using DomainLayer.InsuranceForm.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Webservice.Controllers.InsuranceFormAPI.Models;

namespace Webservice.Controllers.InsuranceFormAPI
{
    [ApiController]
    [Route("api/v1/insuranceform")]
    public class InsuranceFormController : Controller
    {
        private readonly IInsuranceFormService _insuranceFormService;

        public InsuranceFormController(IInsuranceFormService insuranceFormService)
        {
            _insuranceFormService = insuranceFormService;
        }

        [HttpPost("calculate")]
        public IActionResult Index(InsuranceFormModel insuranceFormRequest)
        {
            return Ok(
                _insuranceFormService.CalculateInsurancePremium(
                    insuranceFormRequest.SumInsured, 
                    insuranceFormRequest.Age,
                    insuranceFormRequest.Occupation
                    )
                );           
        }
    }
}
