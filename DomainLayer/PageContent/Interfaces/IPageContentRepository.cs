using DomainLayer.PageContent.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.PageContent.Interfaces
{
    public interface IPageContentRepository
    {
        //Task<InsuranceFormPageEntity> GetInsuranceFormPageEntityAsync();
        void GetInsuranceFormPageEntityAsync();
    }
}
