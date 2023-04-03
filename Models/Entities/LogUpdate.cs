using BIRC.Models.Repositories;
using Microsoft.VisualBasic;
using System;

namespace BIRC.Models.Entities
{
    public class LogUpdate : BaseModel
    {            
        public string Product { get; set; }
        public DateTime Alteration  { get; set; }
        public int Quantity { get; set; }
        public string TypeEdtion { get; set; }
        public int CurrentBalance { get; set; }//referente a SaldoAtual
        public string UserId { get; set; }
        public string ModelAlteration { get; set; }
        public string LocalUsed { get; set; }
        public int minimumQuantity { get; set; }//implementado 060323
    }
}
