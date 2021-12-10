using DomainLayer.PageContent.Entites;
using DomainLayer.PageContent.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.PageContent
{
    public class PageContentService: IPageContentService
    {
        private readonly IPageContentRepository _pageContentRepository;
        public PageContentService(IPageContentRepository pageContentRepository)
        {
            _pageContentRepository = pageContentRepository;
        }
        public string GetInsuranceFormPageEntityAsync()
        {
            /*THIS WAS GOING TO BE USED TO RETRIEVE PAGE CONTENT BUT F0R THE SAKE OF TIME I DID NOT FULLY IMPLEMENT IT
             * 
             */

            return "hello";
        }
    }
}
