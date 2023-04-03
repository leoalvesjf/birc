using BIRC.Helper;
using BIRC.Models.Entities;
using BIRC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BIRC.Controllers
{
    public class PessoaController : Controller
    {
        public readonly Contexto _contexto;
        public readonly QueryHelper<Pessoa> _helper;

        public PessoaController(Contexto contexto)
        {
            _contexto = contexto;
            _helper = new QueryHelper<Pessoa>(contexto);
        }


        public IActionResult Index()
        {
            var pessoa = _contexto.Pessoa.OrderByDescending(X => X.Id).ToList();
            return View(pessoa);

        }

    }
}
