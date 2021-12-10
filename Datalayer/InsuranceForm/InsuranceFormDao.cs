using Datalayer.InsuranceForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.InsuranceForm
{        
    public interface IInsuranceFormDao
    {
        double GetInsuranceFactorByRating(string rating);
    }
    public class InsuranceFormDao: IInsuranceFormDao
    {


        private IEnumerable<InsuranceFactorModel> _insuranceFactorModels { get; set; }

        public InsuranceFormDao()
        {
            _insuranceFactorModels = new List<InsuranceFactorModel>()
            {
                new InsuranceFactorModel()
                {
                    Rating = "Light Manual",
                    Factor = 1.70
                },
                new InsuranceFactorModel()
                {
                    Rating = "Professional",
                    Factor = 1.1
                },
                new InsuranceFactorModel()
                {
                    Rating = "White Collar",
                    Factor = 1.45
                },
                new InsuranceFactorModel()
                {
                    Rating = "Heavy Manual",
                    Factor = 2.1
                }
            };
        }

        public double GetInsuranceFactorByRating(string rating)
        {
            return _insuranceFactorModels.FirstOrDefault(x => x.Rating.ToLower() == rating.ToLower()).Factor;
        }
    }
}
