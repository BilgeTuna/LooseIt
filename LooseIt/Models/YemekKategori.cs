using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseIt.Models
{
    public class YemekKategori
    {
        public int YemekKategoriId { get; set; }
        public string KategoriAd { get; set; }
        public virtual ICollection<Yemek> Yemekler { get; set; }
    }
}
