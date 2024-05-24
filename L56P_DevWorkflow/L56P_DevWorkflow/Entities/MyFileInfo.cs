using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace L56P_DevWorkflow.Entities;

public class MyFileInfo
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [StringLength(500)]
    public required string FileName { get; set; }

    [StringLength(50)]
    public required string MimeType { get; set; }

    public DateTime UploadedOn { get; set; } = DateTime.Now;

    public required MyFileData FileData { get; set; }
}
