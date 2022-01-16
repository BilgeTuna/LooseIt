using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseIt.Models
{
    [Table("Yemekler")]
    public class  Yemek
    {
#pragma warning disable IDE0079 // Remove unnecessary suppression
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
#pragma warning restore IDE0079 // Remove unnecessary suppression

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int YemekId { get; set; }

        [Required, MaxLength(500)]
        public string YemekAdi { get; set; }
       
        public string Kategori { get; set; }
        
        public decimal Kalori { get; set; }
        public int Miktar { get; set; }
        public string YemekResim { get; set; }

#pragma warning disable IDE0079 // Remove unnecessary suppression
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
#pragma warning restore IDE0079 // Remove unnecessary suppression

        public int YemekKategoriId { get; set; }
        public virtual YemekKategori YemekKategori { get; set; }
        public virtual ICollection<Ogun> Ogunler { get; set; }
    }
}
