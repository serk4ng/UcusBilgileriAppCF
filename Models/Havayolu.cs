using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Havayolu
    {
        [Key]
        public string Id_Havayolu { get; set; }
        public string Havayolu_Adi { get; set; }      
        public string Id_Ucak { get; set; }
        public ICollection<Ucak> UcagaAitHavayolu { get; set; }
        //public Ucak Ucagi { get; set; }

    }
}
