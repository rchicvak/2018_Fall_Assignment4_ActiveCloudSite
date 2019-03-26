using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEXTrading.Models.ViewModel
{
    public class CompaniesTops
    {
        public List<Top> Tops { get; set; }
        public List<string> Sectors { get; set; }

        public CompaniesTops(List<Top> tops, List<string> sectors)
        {
            Tops = tops;
            Sectors = sectors;
        }
    }
}
