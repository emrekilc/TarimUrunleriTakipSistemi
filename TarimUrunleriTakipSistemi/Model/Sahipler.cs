using System.ComponentModel.DataAnnotations;
using TarimUrunleruTakipSistemi.Models;

public class Sahipler
{
    [Key]
    public int SahipID { get; set; }
    public int AdresID { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Telefon { get; set; }

    public Adresler Adres { get; set; }
    public ICollection<Ciftlikler> Ciftlikler { get; set; }
}
