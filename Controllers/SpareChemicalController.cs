using BIRC.Helper;
using BIRC.Models;
using BIRC.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Text;

namespace BIRC.Controllers
{
    public class SpareChemicalController : Controller
    {
        private readonly Contexto _contexto;
        protected readonly QueryHelper<SpareChemical> _helper;

        public SpareChemicalController(Contexto contexto)
        {
            _contexto = contexto;
            _helper = new QueryHelper<SpareChemical>(contexto);
        }

        // GET: ChemestryController
        public ActionResult Index()
        {          

            var chemicalList = _contexto.SpareChemical.OrderByDescending(X=>X.Id).ToList();
            return View(chemicalList);

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
                var spare = _contexto.SpareChemical.Where(s => s.ProductName.Contains(search)).ToList();
                return View(spare);
            }
            return View();
        }

        // GET: SpareChemical/Create
        public ActionResult Create()
        {                      
            return View();
        }

        // POST: ChemestryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SpareChemical chemicalControl)
        {
            try
            {
                string productNameUpper = chemicalControl.ProductName.ToUpper();
                string descriptionUpper = chemicalControl.DescProduct.ToUpper();

                chemicalControl.ProductName = productNameUpper;
                chemicalControl.DescProduct = descriptionUpper;

                if (ModelState.IsValid)
                {
                    chemicalControl.Id = _helper.GetMaxId();
                    _contexto.SpareChemical.Add(chemicalControl);
                    _contexto.SaveChanges();                   
                    return RedirectToAction("Index");
                }

                return View(chemicalControl);
            }
            catch
            {
                return View();
            }
        }

        // GET: ChemestryController/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                SpareChemical spareChemical = _contexto.SpareChemical.Find(id);
                return View(spareChemical);
            }
            return NotFound();
        }

        // POST: ChemestryController/Edit/5
        [HttpPost]       
        public ActionResult Edit(string id, string dtIn, string dtValidate, string partNumber, string description, string quantity,string minimumQuantity, string location, string value, string po, string typeedtion, string unitMeasure, string typeOperation, string userId,string localused)
        {

            var getlocation = _contexto.SpareChemical.Select(l => l.StorageBin).ToList();
            ViewBag.storageBin = getlocation;

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

            SpareChemical spareChemical = new SpareChemical
            {
                Id = int.Parse(id),                
                ProductName = partNumber.ToUpper(),
                DescProduct = description.ToUpper(),
                Quantity = qtyFormated,
                minimumQuantity = int.Parse(minimumQuantity),
                PurchaseOrder = po,
                StorageBin = location,
                UnitMeasure = unitMeasure,
                TypeOperation = typeOperation.ToUpper(),
                DtIn = DateTime.Parse(dtIn),
                DtValidate = DateTime.Parse(dtValidate),
                UserId = userId.ToUpper(),
                localUsed= localused,              
               
            };

            LogUpdate logUpdate = new LogUpdate
            {
                Id = int.Parse(id),
                Alteration = DateTime.Now,
                Quantity = int.Parse(quantity),
                Product = partNumber.ToUpper(),
                UserId = userId,
                TypeEdtion = typeedtion,
                CurrentBalance = qtyFormated,
                LocalUsed=localused,
                minimumQuantity= int.Parse(minimumQuantity),//implementado 060323
                ModelAlteration = "SpareChemical",
               
            };

            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    _contexto.Update(spareChemical);
                    _contexto.SaveChangesAsync();
                    _contexto.LogUpdate.AddAsync(logUpdate);
                    _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(spareChemical);
            }
            return NotFound();
        }

        public IActionResult Csv()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("PRODUCT NAME;QUANTITY;LOCATION;USUARIO");

            var dataLog = _contexto.SpareChemical.ToList();

            foreach (var user in dataLog)
            {
                //  var typeEdtion = (user.TypeEdtion.ToUpper().Equals("MINUS")) ? "OUT" : "IN";
                builder.AppendLine($"{user.ProductName};{user.Quantity};{user.StorageBin};{user.UserId}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "spare-chemical.csv");
        }
    }
}


//var getlocation = _contexto.SpareChemical.Select(l => l.StorageBin).Distinct().ToList();
//ViewBag.storageBin = getlocation;