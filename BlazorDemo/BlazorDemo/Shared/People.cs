using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Shared
{
    public class People
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
    }
}

