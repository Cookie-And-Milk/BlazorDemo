using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Shared
{
    public class People
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]{2,}$", ErrorMessage = "Name cannot contain numbers or special characters. ")]
        public string? Name { get; set; }
        public int? Age { get; set; } 
        public string Title { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [MaxLength(14, ErrorMessage = "Exceeding maximum length. ")]
        [RegularExpression(@"^\+?[0-9]+", ErrorMessage = "Phone number cannot contain special characters or letters, apart from +. ")]
        public string? PhoneNum { get; set; }
        public DateTime CreationDateTime { get; set; } 

    }
}

