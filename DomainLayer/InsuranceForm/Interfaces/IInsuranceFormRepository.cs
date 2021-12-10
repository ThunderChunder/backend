using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.InsuranceForm.Interfaces
{
    public interface IInsuranceFormRepository
    {
        double GetInsuranceFactorByRating(string rating);

        string GetRatingByOccupation(string occupation);
    }
}
