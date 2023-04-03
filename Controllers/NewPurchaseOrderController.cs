using BIRC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BIRC.Controllers
{
    public class NewPurchaseOrderController : Controller
    {
        private readonly Contexto _context;

        public NewPurchaseOrderController(Contexto context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            return View();
        }


        //criar Regra de Negocio







    }
}
