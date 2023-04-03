using BIRC.Models.Repositories;
using System;
using System.ComponentModel.DataAnnotations;

namespace BIRC.Models.Entities
{
    public class SpareOffice : BaseModel
    {
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "Description")]
        public string DescProduct { get; set; }
        public int Quantity { get; set; }
        [Display(Name = "Location")]
        public string StorageBin { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Display(Name = "Incoming")]
        public DateTime DtIn { get; set; }        

        [StringLength(20)]
        [Display(Name = "Purchase O.")]
        public string PurchaseOrder { get; set; }
      
        [Display(Name = "Measure")]
        public string UnitMeasure { get; set; }
        [Display(Name = "Type O.")]
        public string TypeOperation { get; set; }
        public string LocalUsed { get; set; }
        public string UserId { get; set; }
        public int? minimumQuantity { get; set; }

    }
}
