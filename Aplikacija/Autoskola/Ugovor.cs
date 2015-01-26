using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoskola
{
    class Ugovor
    {
        public string tablica = "ugovor";
        public int ugovorID { get; set; }
        public string stavke { get; set; }
        public DateTime datumUpisa { get; set; }
        public int OIBP { get; set; }
        public int OIBI { get; set; }
        public string kategorijaID { get; set; }
    }
}
