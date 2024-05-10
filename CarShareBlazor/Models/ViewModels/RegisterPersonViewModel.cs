using System.ComponentModel.DataAnnotations;

namespace CarShareBlazor.Models.ViewModels
{
    public class RegisterPersonViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Name")]
        public string? FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide LastName")]
        public string? LastName { get; set; }
        public int UserID { get; set; }
    }
}
