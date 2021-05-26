using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class Customer
    {
        [Required(ErrorMessage ="Requis.")]
        public string Name { get; set; }
        [Required,RegularExpression("^[0-9]*$")]
        public string Number { get; set; }
        [Required,StringLength(64, MinimumLength =1)]
        public string Street { get; set; }
        [Required, RegularExpression("^[0-9]{5}$")]
        public string ZipCode { get; set; }

    }
}
