using System.ComponentModel.DataAnnotations;

namespace CarShareBlazor.Models.ViewModels
{
    public class AddCarViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Name")]
        public string? Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Licenseplate")]
        public string? Licenseplate { get; set; }
    }
}
