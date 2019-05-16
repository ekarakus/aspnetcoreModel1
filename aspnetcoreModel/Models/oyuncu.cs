using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcoreModel.Models
{
    public class Oyuncu
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string cinsiyet { get; set; }
        public DateTime dogumTarih { get; set; }
    }
}
