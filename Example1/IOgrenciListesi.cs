using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
   
   public interface IOgrenciListesi
    {
        List<Ogrenci> Listele();

        List<Ogrenci> OgrenciNoListele(int OgrenciNo);
    }
}
