using BIRC.Helper;
using BIRC.Models;
using BIRC.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Text;

namespace BIRC.Controllers
{
    public class SpareOfficeController : Controller
    {
        private readonly Contexto _contexto;
        protected readonly QueryHelper<SpareOffice> _helper;

        public SpareOfficeController(Contexto contexto)
        {
            _contexto = contexto;
            _helper = new QueryHelper<SpareOffice>(contexto);
        }
        // GET: SpareOfficeController ( Ordenado Descending )
        public ActionResult Index()
        {
            
                var officeSpare = _contexto.SpareOffice.OrderByDescending(x => x.Id).ToList();
                return View(officeSpare); // exibir os itens na tabela         

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
                var spare = _contexto.SpareOffice.Where(s => s.ProductName.Contains(search)).ToList();
                
                return View(spare);
            }

            return View();

        }

        // GET: SpareOfficeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SpareOfficeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SpareOfficeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SpareOffice spareoffice)
        {
            try
            {
                string productNameUpper = spareoffice.ProductName.ToUpper();
                string descriptionUpper = spareoffice.DescProduct.ToUpper();

                spareoffice.ProductName = productNameUpper;
                spareoffice.DescProduct = descriptionUpper;
                if (ModelState.IsValid)
                {
                    spareoffice.Id = _helper.GetMaxId();
                    _contexto.SpareOffice.Add(spareoffice);
                    _contexto.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(spareoffice);
            }
            catch
            {
                return View();
            }
        }

        // GET: SpareOfficeController/Edit/5
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                SpareOffice spareOffice = _contexto.SpareOffice.Find(id);
                return View(spareOffice);
            }
            return NotFound();
        }

        // POST: SpareOfficeController/Edit/5
        [HttpPost]      
        public ActionResult Edit(string id, string partNumber, string description,  string quantity,string minimumQuantity,string dtIn, string location, string value, string po, string typeedtion, string unitMeasure, string typeOperation, string localUsed,string userId )
        {
            var getlocation = _contexto.SpareOffice.Select(l => l.ProductName).ToList();
            ViewBag.ProductName = getlocation;

            int qtyFormated = 0;
            
            if (typeedtion.Equals("minus"))
            {
                qtyFormated = int.Parse(value) - int.Parse(quantity);
            }
            else
            {
                qtyFormated = int.Parse(value) + int.Parse(quantity);
            }



            SpareOffice spareOffice = new SpareOffice
            {
                Id = int.Parse(id),
                ProductName = partNumber.ToUpper(),
                DescProduct = description.ToUpper(),
                Quantity = qtyFormated,
                minimumQuantity = int.Parse(minimumQuantity),//implementado 060323
                PurchaseOrder = po,
                StorageBin = location,
                UnitMeasure = unitMeasure,
                TypeOperation = typeOperation.ToUpper(),
                DtIn = DateTime.Parse(dtIn),
                UserId = userId.ToUpper(),
                LocalUsed= localUsed,
            };

            LogUpdate logUpdate = new LogUpdate
            {
                Id = int.Parse(id),
                Alteration = DateTime.Now,
                Quantity = int.Parse(quantity),
                Product = partNumber,
                TypeEdtion = typeedtion,
                UserId = userId,
                CurrentBalance = qtyFormated,
                LocalUsed= localUsed,
                minimumQuantity = int.Parse(minimumQuantity),//implementado 060323
                ModelAlteration = "SpareOffice"

            };

            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    _contexto.Update(spareOffice);
                    _contexto.SaveChangesAsync();
                    _contexto.LogUpdate.AddAsync(logUpdate);
                    _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

                else return View(spareOffice);

            }

            return NotFound();

        }

        public IActionResult Csv()
        {
            var builder = new StringBuilder();

            builder.AppendLine("PRODUCT NAME;QUANTITY;LOCATION;USUARIO");

            var dataLog = _contexto.SpareOffice.ToList();

            foreach (var user in dataLog)
            {
                //  var typeEdtion = (user.TypeEdtion.ToUpper().Equals("MINUS")) ? "OUT" : "IN";
                builder.AppendLine($"{user.ProductName};{user.Quantity};{user.StorageBin};{user.UserId}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "spare-office.csv");
        }        
    }
}
