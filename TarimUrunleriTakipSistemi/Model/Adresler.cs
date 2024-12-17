using System.ComponentModel.DataAnnotations;

namespace TarimUrunleruTakipSistemi.Models
{
    public class Adresler
    {
        [Key]
        public int AdresID { get; set; }  // Birincil anahtar olarak AdresID

        public string Ulke { get; set; }
        public string Eyalet { get; set; }
        public string Sehir { get; set; }
        public string Mahalle { get; set; }
        public string Sokak { get; set; }
        public int BinaNo { get; set; }
        public int DaireNo { get; set; }

        public ICollection<Sahipler> Sahipler { get; set; }
        public ICollection<Ciftlikler> Ciftlikler { get; set; }
        public ICollection<Musteriler> Musteriler { get; set; }
        public ICollection<Soforler> Soforler { get; set; }
    }
}
