using L56P_DevWorkflow.Models;
using L56P_DevWorkflow.Services;
using Microsoft.AspNetCore.Mvc;

namespace L56P_DevWorkflow.Controllers;

public class FilesController(MyFileService fileService) : Controller
{
	public async Task<IActionResult> Recent()
	{
		var files = await fileService.GetRecentAsync();

		foreach (var file in files)
		{
			file.Url = $"https://{HttpContext.Request.Host.Value}/Files/Download/{file.Id}";
		}

		return View(files);
	}

    public async Task<IActionResult> Download(Guid id)
    {
		try
		{
			var file = await fileService.DownloadFileAsync(id);

			return File(file.Data!, file.MimeType!, file.FileName!);
		}
		catch (FileNotFoundException)
		{
			return RedirectToAction("FileNotFound");
		}
    }

	public IActionResult Upload()
	{
		return View();
	}

	[HttpPost]
	public async Task<IActionResult> Upload(UploadFileModel formFile)
	{
		using var stream = new MemoryStream();

		await formFile.File!.CopyToAsync(stream);

		var fileModel = new MyFileModel
		{
			FileName = formFile.File!.FileName,
			MimeType = formFile.File!.ContentType,
			Data = stream.ToArray()
		};

		var id = await fileService.UploadFileAsync(fileModel);

		return RedirectToAction("FileLink", new { id });
	}

	public async Task<IActionResult> FileLink(Guid id)
	{
		if (await fileService.FileExistsAsync(id))
		{
			var fileLink = $"https://{HttpContext.Request.Host.Value}/Files/Download/{id}";
			return View((object)fileLink);
		}

		return RedirectToAction("FileNotFound");
	}

	public IActionResult FileNotFound()
	{
		return View();
	}
}
