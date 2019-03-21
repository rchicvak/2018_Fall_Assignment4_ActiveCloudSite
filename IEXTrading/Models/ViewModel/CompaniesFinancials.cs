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
        public string Dates { get; set; }
        public string RDPercents { get; set; }

        public CompaniesFinancials(List<Company> companies, List<Financial> selectedFinancial, string dates, string rdPercents)
        {
            Companies = companies;
            SelectedFinancial = selectedFinancial;
            Dates = dates;
            RDPercents = rdPercents;
        }
    }
}
