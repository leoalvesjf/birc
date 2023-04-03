using System;
using System.ComponentModel.DataAnnotations;

namespace BIRC.Models.Entities
{
    public class SpareChemicalBase
    {
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Description")]
        public string DescProduct { get; set; }
        public int Quantity { get; set; }

        [Display(Name = "Location")]
        public string StorageBin { get; set; }

        [Display(Name = "Incoming")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime DtIn { get; set; }

        [Display(Name = "Validate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime DtValidate { get; set; }

        [Display(Name = "Purchase O.")]
        [StringLength(20)]
        public string PurchaseOrder { get; set; }

        [Display(Name = "U.Measure")]
        public string UnitMeasure { get; set; }

        [Display(Name = "Type O.")]
        public string TypeOperation { get; set; }

        public string UserId { get; set; }
    }
}