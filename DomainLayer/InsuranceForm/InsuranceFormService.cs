using DomainLayer.InsuranceForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.InsuranceForm
{
    public class InsuranceFormService: IInsuranceFormService
    {
        private readonly IInsuranceFormRepository _insuranceFormRepository;
        public InsuranceFormService(IInsuranceFormRepository insuranceFormRepository)
        {
            _insuranceFormRepository = insuranceFormRepository;
        }
        public double CalculateInsurancePremium(int sumInsured, int age, string occupation)
        {
            var rating = _insuranceFormRepository.GetRatingByOccupation(occupation);
            var factor = _insuranceFormRepository.GetInsuranceFactorByRating(rating);
            var result = (Convert.ToDouble(sumInsured) * factor) / (100.0 * 12.0 * Convert.ToDouble(age));

            return Math.Round(result, 2);
        }
    }
}
