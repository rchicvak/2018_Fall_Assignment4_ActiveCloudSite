using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEXTrading.Models.ViewModel
{
    public class CompaniesFinancials
    {
        public List<Company> Companies { get; set; }
        public List<Financial> SelectedFinancial { get; set; }

        public CompaniesFinancials(List<Company> companies, List<Financial> selectedFinancial)
        {
            Companies = companies;
            SelectedFinancial = selectedFinancial;
        }
    }
}
