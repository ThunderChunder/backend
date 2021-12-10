using DomainLayer.PageContent.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Webservice.Controllers.PageAPIs
{
    [ApiController]
    [Route("content/api/v1")]
    public class InsuranceFormPageController : Controller
    {
        private readonly IPageContentService _pageContentService;      
        public InsuranceFormPageController(IPageContentService pageContentService)
        {
            _pageContentService = pageContentService;
        }

        [HttpGet("insuranceform")]
        public IActionResult GetInsuranceFormViewModel()
        {
            return Ok(_pageContentService.GetInsuranceFormPageEntityAsync());
        }
    }
}
