using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseIt.Models
{
    [Table("Ogunler")]
    public class Ogun
    {
        public Ogun()
        {
            Yemekler = new List<Yemek>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int OgunId { get; set; }

        public string OgunAdi { get; set; }

        public DateTime OgunTarih { get; set; }

        public virtual List<Yemek> Yemekler { get; set; }
        public virtual ICollection<Kullanici> Kullanicilar { get; set; }
        public double ToplamKalori { get; set; }


    }
}
