using BIRC.Models.Repositories;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BIRC.Models.Entities
{
    public class Pessoa :BaseModel
    {        
        public string Nome { get; set; }        
        public int Idade { get; set; }
        
    }
}
