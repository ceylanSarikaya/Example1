using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class OgrenciListesi : IOgrenciListesi
    {
        public List<Ogrenci> Listele()
        {
            OgrenciDto list = new OgrenciDto();
            return list.TumListe();
        }

        public List<Ogrenci> OgrenciNoListele(int OgrenciNo)
        {
            OgrenciDto dto = new OgrenciDto();

            var list = from o in dto.TumListe() where o.OgrenciNo == OgrenciNo select o;
            return list.ToList();

        }
    }
}
