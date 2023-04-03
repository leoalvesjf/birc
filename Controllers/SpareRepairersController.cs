using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BIRC.Models;
using BIRC.Models.Entities;
using BIRC.Helper;
using System.Linq;
using System.Text;

namespace BIRC.Controllers
{
    public class SpareRepairersController : Controller
    {
        private readonly Contexto _contexto;
        protected readonly QueryHelper<SpareRepairer> _helper;

        public SpareRepairersController(Contexto context)
        {
            _contexto = context;
            _helper = new QueryHelper<SpareRepairer>(context);
        }

        // GET: SpareRepairers
        public IActionResult Index()
        {
            var sparerepairers = _contexto.SpareRepairer.OrderByDescending(x => x.Id).ToList();
            return View(sparerepairers);          
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
            if (searchString.Equals("ProductName"))
            {
                var spare = _contexto.SpareRepairer.Where(s => s.ProductName.Contains(search)).ToList();
                return View(spare);
            }

            return View();

        }

       /* // GET: SpareRepairers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spareRepairer = await _contexto.SpareRepairer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (spareRepairer == null)
            {
                return NotFound();
            }

            return View(spareRepairer);
        }*/

        // GET: SpareRepairers/Create
        public IActionResult Create()
        {
            return View();
        }

        //POST: SpareRepairer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SpareRepairer spareRepairer)
        {
            try
            {
                string producName= spareRepairer.ProductName.ToUpper();
                string description = spareRepairer.DescProduct.ToUpper();
                
                spareRepairer.ProductName= producName;
                spareRepairer.DescProduct= description;

                if (ModelState.IsValid)
                {
                    spareRepairer.Id = _helper.GetMaxId();
                    _contexto.SpareRepairer.Add(spareRepairer);
                   _contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(spareRepairer);
            }
            catch
            {
                return View();
            }
        }

        // GET: SpareRepairers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spareRepairer = await _contexto.SpareRepairer.FindAsync(id);
            if (spareRepairer == null)
            {
                return NotFound();
            }
            return View(spareRepairer);
        }

        //POST: SpareRepairers/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, string dtIn, string dtValidate, string partNumber, string description,
            string quantity,string minimumQuantity, string location, string value, string po, string typeedtion, string unitMeasure, string typeOperation, string localUsed,string userId)
        {
            int qtyFormated = 0;

            if (typeedtion.Equals("minus"))
            {
                qtyFormated = int.Parse(value) - int.Parse(quantity);
            }
            else
            {
                qtyFormated = int.Parse(value) + int.Parse(quantity);
            }           

            SpareRepairer spareRepairer = new SpareRepairer
            {
                Id = int.Parse(id),
                ProductName = partNumber.ToUpper().ToString(),
                DescProduct = description,
                Quantity = qtyFormated,
                minimumQuantity = int.Parse(minimumQuantity),//implementado 060323
                PurchaseOrder = po,
                StorageBin = location,
                UnitMeasure = unitMeasure,
                TypeOperation = typeOperation,
                DtIn = DateTime.Parse(dtIn),
                DtValidate = DateTime.Parse(dtValidate),
                LocalUsed= localUsed,
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
                LocalUsed= localUsed,
                ModelAlteration = "SpareRepairer"

            };

            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    _contexto.Update(spareRepairer);
                    _contexto.SaveChangesAsync();
                    _contexto.LogUpdate.AddAsync(logUpdate);
                    _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(spareRepairer);
            }
            return NotFound();
        }

        // GET: SpareRepairers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spareRepairer = await _contexto.SpareRepairer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (spareRepairer == null)
            {
                return NotFound();
            }

            return View(spareRepairer);
        }

        // POST: SpareRepairers/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var spareRepairer = await _contexto.SpareRepairer.FindAsync(id);
            _contexto.SpareRepairer.Remove(spareRepairer);
            await _contexto.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
              
        private bool SpareRepairerExists(int id)
        {
            return _contexto.SpareRepairer.Any(e => e.Id == id);
        }

        public IActionResult Csv()
        {
            var builder = new StringBuilder();

            builder.AppendLine("PRODUCT NAME;QUANTITY;LOCATION;USUARIO");

            var dataLog = _contexto.SpareRepairer.ToList();

            foreach (var user in dataLog)
            {
                //  var typeEdtion = (user.TypeEdtion.ToUpper().Equals("MINUS")) ? "OUT" : "IN";
                builder.AppendLine($"{user.ProductName};{user.Quantity};{user.StorageBin};{user.UserId}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "spare-unproductive.csv");
        }
    }
}
