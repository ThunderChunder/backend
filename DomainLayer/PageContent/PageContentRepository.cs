using Datalayer.PageContent;
using DomainLayer.PageContent.Entites;
using DomainLayer.PageContent.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.PageContent
{
    public class PageContentRepository: IPageContentRepository
    {
        private readonly IPageContentDao _pageContentDao;
        public PageContentRepository(IPageContentDao pageContentDao)
        {
            _pageContentDao = pageContentDao;
        }

        public void GetInsuranceFormPageEntityAsync()
        {

        }
    }
}
