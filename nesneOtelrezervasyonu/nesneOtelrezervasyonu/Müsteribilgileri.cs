using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nesneOtelrezervasyonu
{
    class Müsteribilgileri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public string iletisimno { get; set; }
        public string mail { get; set; }
        public string adres { get; set; }




        public List<Müsteribilgileri> müsteri { get; set; }
    }
}
