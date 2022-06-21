using System.ComponentModel.DataAnnotations;

namespace MudBlazorCRUD3.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
    }
}
