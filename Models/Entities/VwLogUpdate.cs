using BIRC.Models.Repositories;
using System;

namespace BIRC.Models.Entities
{
    public class VwLogUpdate : BaseModel
    {
     
        public int CodProduto { get; set; }
        public string NomeProduto { get; set; }
        public string MovimentacaoSaldo { get; set; }
        public string CategoriaProduto { get; set; }
        public string SaldoAtual { get; set; }
        public string NomeUsuario { get; set; }
        public string DataMovimentacao { get; set; }
        public string LocalUsed { get; set; }
        public  int minimumQuantity { get; set; }
    }
}
