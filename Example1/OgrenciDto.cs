using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
  public  class OgrenciDto
    {
        public List<Ogrenci> TumListe()
        {
            List<Ogrenci> ogrenci = new List<Ogrenci>();
            ogrenci.Add(new Ogrenci() { OgrenciNo = 1, Adi = "Ahmet", soyadi = "Işık" });
            ogrenci.Add(new Ogrenci() { OgrenciNo = 2, Adi = "Mehmet", soyadi = "Duran" });
            ogrenci.Add(new Ogrenci() { OgrenciNo = 3, Adi = "Ayşe", soyadi = "Kelebek" });
            ogrenci.Add(new Ogrenci() { OgrenciNo = 4, Adi = "Ali", soyadi = "Nehir" });
            ogrenci.Add(new Ogrenci() { OgrenciNo = 5, Adi = "Meryem", soyadi = "Gül" });
            ogrenci.Add(new Ogrenci() { OgrenciNo = 6, Adi = "Tunç", soyadi = "Dağ" });
            ogrenci.Add(new Ogrenci() { OgrenciNo = 7, Adi = "Ece", soyadi = "Uslu" });
            ogrenci.Add(new Ogrenci() { OgrenciNo = 8, Adi = "Berk", soyadi = "Ak" });
            ogrenci.Add(new Ogrenci() { OgrenciNo = 9, Adi = "Güneş", soyadi = "Su" });

            return ogrenci;
        }
    }
}
