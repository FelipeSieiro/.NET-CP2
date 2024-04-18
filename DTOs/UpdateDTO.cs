using System.ComponentModel.DataAnnotations;

namespace CHECKPOINT2_DOTNET.DTOs
{
    public class UpdateDTO
    {
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string UserEmail { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; } = string.Empty;
        public string UserPhone { get; set; } = string.Empty;
    }
}
