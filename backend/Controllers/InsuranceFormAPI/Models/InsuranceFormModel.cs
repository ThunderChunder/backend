using System.ComponentModel.DataAnnotations;

namespace Webservice.Controllers.InsuranceFormAPI.Models
{
    public class InsuranceFormModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Range(18, 105)]
        public int Age { get; set; }
        [Required]
        public string DOB { get; set; }
        [Required]
        public string Occupation { get; set; }
        [Required]
        [Range(1000, 1000000)]
        public int SumInsured { get; set; }
        [Required]
        public int MonthlyExpenses { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        [RegularExpression(@"[0-9][0-9][0-9][0-9]")]
        public string PostCode { get; set; }
    }
}
