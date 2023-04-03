using BIRC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIRC.Controllers
{
    public class LogUpdateController : Controller
    {
        private readonly Contexto _context;

        public LogUpdateController(Contexto contexto)
        {
            _context = contexto;
        }     

        // GET: LogUpdate
        public IActionResult Index()
        {            
            return View();
        }
                
        public IActionResult Csv()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("REGISTRO;COD PRODUTO;PRODUTO;MOVIMENTACAO;CATEGORIA;SALDO ATUAL;DATA DE MOVIMENTACAO;LOCAL USADO;USUARIO;QUANTIDADE MINIMA") ;


             var dataLog = _context.VwLogUpdate.Distinct().ToList();

            foreach (var user in dataLog)
            {
                
                builder.AppendLine($"{user.Id};{user.CodProduto};{user.NomeProduto};{user.MovimentacaoSaldo};{user.CategoriaProduto};{user.SaldoAtual};{user.DataMovimentacao};{user.LocalUsed};{user.NomeUsuario};{user.minimumQuantity}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "RelatorioGerals.csv");//gera o arquivo csv 
        }                      

    }
}
