using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.InsuranceForm.Interfaces
{
    public interface IInsuranceFormService
    {
        double CalculateInsurancePremium(int sumInsured, int age, string occupation);
    }
}
