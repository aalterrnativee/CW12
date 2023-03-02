using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CW12.Models.Entity;

namespace CW12.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [MaxLength(6, ErrorMessage = "حداکثر تعداد کاراکتر {1} کاراکتر است.")]
        [Required(ErrorMessage = "فیلد {0} الزامی است.")]
        [DisplayName("نام")]
        public string Name { get; set; }

        public string Color { get; set; }
        public string Model { get; set; }

        [Range(minimum: 1000, maximum: 9999, ErrorMessage = "مقدار ورودی باید بین {1} و {2} باشد.")]
        [Required(ErrorMessage = "فیلد {0} الزامی است.")]
        [DisplayName("کد")]
        public int Code { get; set; }

        public Brand Brand { get; set; }
    }
}
