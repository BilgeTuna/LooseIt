using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseIt.Models
{
    [Table("Kullanicilar")]

    public class Kullanici
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KullaniciId { get; set; }

        [Required(ErrorMessage = "Kullanıcı maili girilmesi zorunludur."), MaxLength(500)]
        public string KullaniciMail { get; set; }

        [Required(ErrorMessage = "Şifre girilmesi zorunludur."), MaxLength(500)]
        public string Sifre { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public decimal Boy { get; set; }

        public decimal Kilogram { get; set; }

        public int Yas { get; set; }

        public string Cinsiyet { get; set; }

        public string EgzersizDurum { get; set; }
        public virtual ICollection<Ogun> Ogunler { get; set; }
    }
}
