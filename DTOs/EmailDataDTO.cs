using System.ComponentModel.DataAnnotations;

namespace CHECKPOINT2_DOTNET.DTOs
{
    public class EmailDataDTO
    {

        [Required]
        [EmailAddress]
        public string UserEmail { get; set; } = string.Empty;
    }
}
