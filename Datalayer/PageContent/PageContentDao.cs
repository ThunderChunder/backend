using Datalayer.PageContent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.PageContent
{
    public interface IPageContentDao
    {
        void GetInsuranceFormPageModelAsync();
        string GetRatingByOccupation(string occupation);
    }
    public class PageContentDao: IPageContentDao
    {
        private IEnumerable<InsuranceFormPageModel> _insuranceFormModels { get; set; }

        public PageContentDao()
        {
            _insuranceFormModels = new List<InsuranceFormPageModel>()
            {
                new InsuranceFormPageModel()
                {
                    Occupation = "Cleaner",
                    Rating = "Light Manual"
                },
                new InsuranceFormPageModel()
                {
                    Occupation = "Doctor",
                    Rating = "Professional"
                },
                new InsuranceFormPageModel()
                {
                    Occupation = "Author",
                    Rating = "White Collar"
                },
                new InsuranceFormPageModel()
                {
                    Occupation = "Farmer",
                    Rating = "Heavy Manual"
                },
                new InsuranceFormPageModel()
                {
                    Occupation = "Mechanic",
                    Rating = "Heavy Manual"
                },
                new InsuranceFormPageModel()
                {
                    Occupation = "Florist",
                    Rating = "Light Manual"
                }
            };
        }

        public void GetInsuranceFormPageModelAsync()
        {

        }

        public string GetRatingByOccupation(string occupation)
        {
            return _insuranceFormModels.FirstOrDefault(x => x.Occupation.ToLower() == occupation.ToLower()).Rating;
        }
    }
}
