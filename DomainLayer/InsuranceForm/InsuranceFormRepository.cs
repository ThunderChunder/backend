using Datalayer.InsuranceForm;
using Datalayer.PageContent;
using DomainLayer.InsuranceForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.InsuranceForm
{
    public class InsuranceFormRepository: IInsuranceFormRepository
    {
        private readonly IPageContentDao _pageContentDao;
        private readonly IInsuranceFormDao _insuranceFormDao;
        public InsuranceFormRepository(IInsuranceFormDao insuranceFormDao, IPageContentDao pageContentDao)
        {
            _insuranceFormDao = insuranceFormDao;
            _pageContentDao = pageContentDao;
        }
        public double GetInsuranceFactorByRating(string rating)
        {
            return _insuranceFormDao.GetInsuranceFactorByRating(rating);
        }

        public string GetRatingByOccupation(string occupation)
        {
            return _pageContentDao.GetRatingByOccupation(occupation);
        }
    }
}
