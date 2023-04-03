using BIRC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIRC.Helper
{
    public class ReportCsv : Controller
    {
        public void Download(string report, Contexto context, DateTime dateFrom, DateTime dateTo)
        {
            var builder = new StringBuilder();

            switch (report)
            {
                case "SPARE CHEMICAL":
                    builder.AppendLine("DESC_PRODUCT;QUANTITY");
                    var reportChemical = context.LogUpdate.Where (p => (p.Alteration) >= dateFrom &&
                    (p.Alteration) <= dateTo && p.TypeEdtion == "minus" && p.ModelAlteration == "SpareChemical").ToList();
                    foreach (var item in reportChemical)
                        builder.AppendLine($"{item.Product};{item.Quantity}");

                    break;
                case "SPARE PARTS":

                    break;
                case "SPARE UNPRODUCTIVE":

                    break;
                case "SPARE OFFICE":

                    break;
            }

            File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "report-spare.csv");
        }

    }
}
