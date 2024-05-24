using System.ComponentModel.DataAnnotations;

namespace L56P_DevWorkflow.Models;

public record MyFileModel
{
    public Guid? Id { get; set; }

    [Required]
    [MaxLength(500)]
    public string? FileName { get; set; }

    public string? Url { get; set; }

    [Required]
    [MaxLength(50)]
    public string? MimeType { get; set; }

    [MaxLength(5000)]
    public byte[]? Data { get; set; }
}
