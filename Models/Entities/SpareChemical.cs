using BIRC.Models.Repositories;
using System;
using System.ComponentModel.DataAnnotations;

namespace BIRC.Models.Entities
{
    public class SpareChemical : BaseModel
    {
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Description")]
        public string DescProduct { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        [Required]
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
        public string localUsed { get; set; }

        [Display(Name = "Type O.")]
        public string TypeOperation { get; set; } 
        
        public string UserId { get; set; }

        public int? minimumQuantity { get; set; }

       
    }
}
