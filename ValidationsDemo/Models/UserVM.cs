using System.ComponentModel.DataAnnotations;

namespace ServiceModels.ViewModels
{
    public class UserVM
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Email { get; set; }
    }
}