using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nesneOtelrezervasyonu
{
    class rezervasyonbilgisi:Müsteribilgileri
    {
        
        public string kisisayisi { get; set; }
        
        public DateTime rezervebaslangıc { get; set; }
        public DateTime rezervebitis { get; set; }
        public string gunsayisi { get; set; }
        public string odasec { get; set; }
        public List<rezervasyonbilgisi> rezervasyon { get; set; }







        public string timebaslangic { get; set; }

        public string timebitis { get; set; }
    }
}
