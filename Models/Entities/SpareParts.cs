using BIRC.Models.Repositories;
using System;
using System.ComponentModel.DataAnnotations;


namespace BIRC.Models.Entities
{
    public class SpareParts : BaseModel
    {
        [Display(Name = "Product Number")]
        public string PartNumber { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Quantity { get; set; }

        [Display(Name = "Incoming")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime DtIn { get; set; }
              
        [Display(Name = "Storage Bin")]
        public string Location { get; set; }

        [StringLength(20)]
        [Display(Name = "Purchase Order")]
        public string PurchaseOrder { get; set; }
        public string LocalUsed { get; set; }
        public int minimumQuantity { get; set; }
        public string UserId { get; set; }

    }
}
