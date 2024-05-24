using L56P_DevWorkflow.Data;
using L56P_DevWorkflow.Entities;
using L56P_DevWorkflow.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace L56P_DevWorkflow.Services;

public class MyFileService(AppDbContext dbContext)
{
    public async Task<Guid> UploadFileAsync(MyFileModel fileModel)
    {
        var file = new MyFileInfo
        {
            FileName = fileModel.FileName!,
            MimeType = fileModel.MimeType!,
            FileData = new() { BinaryData = fileModel.Data! },
        };

        dbContext.Add(file);

        await dbContext.SaveChangesAsync();

        return file.Id;
    }

    public async Task<MyFileModel> DownloadFileAsync(Guid id)
    {
        TypeAdapterConfig<MyFileInfo, MyFileModel>.NewConfig()
            .Map(dest => dest.Data, src => src.FileData.BinaryData);

        var file = await dbContext.Files
            .Include(f => f.FileData)
            .FirstOrDefaultAsync(f => f.Id == id)
            ?? throw new FileNotFoundException("Specified file was not found.");

        var model = file.Adapt<MyFileModel>();

        return model;
    }

    public Task<bool> FileExistsAsync(Guid id)
    {
        return dbContext.Files.AnyAsync(f => f.Id == id);
    }

    internal async Task<List<MyFileModel>> GetRecentAsync()
    {
        TypeAdapterConfig<MyFileInfo, MyFileModel>.NewConfig()
            .Map(dest => dest.Data, src => src.FileData.BinaryData);

        var date = DateTime.Now.AddDays(-7);

        var files = await dbContext.Files
            .Where(f => date < f.UploadedOn)
            .ToListAsync();

        return files.Adapt<List<MyFileModel>>();
    }
}
