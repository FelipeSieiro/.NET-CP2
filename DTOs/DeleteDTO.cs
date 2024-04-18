using System.ComponentModel.DataAnnotations;

namespace CHECKPOINT2_DOTNET.DTOs
{
    public class DeleteDTO
    {
        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }
    }
}
