using System.ComponentModel.DataAnnotations;

namespace L56P_DevWorkflow.Models;

public record UploadFileModel
{
    [Required]
    public IFormFile? File { get; set; }
}
