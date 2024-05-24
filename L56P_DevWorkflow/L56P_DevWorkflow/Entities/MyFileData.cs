using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace L56P_DevWorkflow.Entities;

public class MyFileData
{
    [Key]
    [ForeignKey(nameof(FileInfo))]
    public Guid FileInfoId { get; set; }

    public required byte[] BinaryData { get; set; }

    public MyFileInfo? FileInfo { get; set; }
}
