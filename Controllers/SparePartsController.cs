using System;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using BIRC.Models;
using BIRC.Models.Entities;
using BIRC.Helper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIRC.Controllers
{
    public class SparePartsController : Controller
    {
        public readonly Contexto _contexto;
        public readonly QueryHelper<SpareParts> _helper;

        public SparePartsController(Contexto context)
        {
            _contexto = context;
            _helper = new QueryHelper<SpareParts>(context);
        }
        // GET: SpareOfficeController ( Ordenado Descending )
        public IActionResult SpareMenu()
        {
            return View();
        }
        public IActionResult Index()
        {
            var spareparts = _contexto.SpareParts.OrderByDescending(x => x.Id).ToList();
            return View(spareparts);

        }

        [HttpPost]
        public ActionResult Index(string searchString, string search)
        {
            //var spare = from s in _contexto.SpareParts select s;
            var recebeSearch = search;

            if (String.IsNullOrEmpty(searchString))
            {
                return RedirectToAction("Index");
            }
            if (searchString.Equals("Partnumber"))
            {
                var spare = _contexto.SpareParts.Where(s => s.PartNumber.Contains(search)).ToList();
                return View(spare);
            }

            return View();

        }

        // GET: SpareParts/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //POST: SpareRepairer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SpareParts spareparts)
        {
            try
            {

                string productNameUpper = spareparts.PartNumber.ToUpper();
                string descriptionUpper = spareparts.Description.ToUpper();

                spareparts.PartNumber = productNameUpper;
                spareparts.Description = descriptionUpper;

                if (ModelState.IsValid)
                {
                    spareparts.Id = _helper.GetMaxId();
                    _contexto.SpareParts.Add(spareparts);
                    _contexto.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(spareparts);
            }
            catch
            {
                return View();
            }
        }

        // GET: SpareRepairers/Edit/5
        public async Task<IActionResult> EditItem(int? id)
        {
            if (id != null)
            {
                return NotFound();
            }
            var spareParts = await _contexto.SpareParts.FindAsync(id);
            if (spareParts == null)
            {
                return NotFound();
            }
            return View(spareParts);

        }

        // POST: SparePartes/Edit/5
        [HttpPost]
        public ActionResult EditItem(string id, string partNumber, string description, string quantity,string minimumQuantity, string value, string dtIn, string location, string currentBalance, string po, string typeedtion, string localUsed, string userId)
        {

            int qtyFormated = 0;
            //MODELO DE NEGOCIO
            if (typeedtion.Equals("minus"))
            {
                qtyFormated = int.Parse(value) - int.Parse(quantity);
            }
            else
            {
                qtyFormated = int.Parse(value) + int.Parse(quantity);
            }

            SpareParts spareParts = new SpareParts
            {
                Id = int.Parse(id),
                PartNumber = partNumber.ToUpper().ToString(),
                Description = description.ToUpper().ToString(),
                Quantity = qtyFormated,
                minimumQuantity = int.Parse(minimumQuantity),//implementado 060323
                PurchaseOrder = po,
                Location = location,
                DtIn = DateTime.Parse(dtIn),
                LocalUsed = localUsed,
                UserId = userId
            };

            LogUpdate logUpdate = new LogUpdate
            {
                Id = int.Parse(id),
                Alteration = DateTime.Now,
                Quantity = int.Parse(quantity),
                minimumQuantity = int.Parse(minimumQuantity),//implementado 060323
                Product = partNumber,
                TypeEdtion = typeedtion,
                UserId = userId,
                CurrentBalance = qtyFormated,
                LocalUsed = localUsed,
                ModelAlteration = "SpareParts",


            };

            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    _contexto.Update(spareParts);
                    _contexto.SaveChangesAsync();
                    _contexto.LogUpdate.AddAsync(logUpdate);
                    _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(spareParts);
            }
            return NotFound();
        }


        public ActionResult ReportGeral()
        {

            return View();
        }

        public IActionResult Csv()
        {
            var builder = new StringBuilder();

            builder.AppendLine("PRODUCT NAME;QUANTITY;LOCATION;USUARIO");

            var dataLog = _contexto.SpareParts.ToList();

            foreach (var user in dataLog)
            {
                //  var typeEdtion = (user.TypeEdtion.ToUpper().Equals("MINUS")) ? "OUT" : "IN";
                builder.AppendLine($"{user.PartNumber};{user.Quantity};{user.Location};{user.UserId}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "spare-parts.csv");
        }
    }
}

