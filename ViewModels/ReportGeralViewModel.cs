using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BIRC.ViewModels
{
    public class ReportGeralViewModel
    {
        
        public DateTime FromDate { get; set; }
        
        public DateTime ToDate { get; set; }

        public string TypeReport { get; set; }
    }
}
