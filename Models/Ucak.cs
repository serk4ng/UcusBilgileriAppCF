using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Ucak
    {
        [Key]
        public string Id_Havayolu { get; set; }
        public string Id_Ucak { get; set; }
        public int Adet { get; set; }
        public Havayolu Havayolu { get; set; }
       // public ICollection<Havayolu> HavayolunaAitUcaklar { get; set; }
    }
}
