using System.ComponentModel.DataAnnotations;
using TarimUrunleruTakipSistemi.Models;

public class Ciftlikler
{
    [Key]
    public int CiftlikID { get; set; }
    public int SahipID { get; set; }
    public int AraziTuruID { get; set; }
    public int AdresID { get; set; }
    public string Ad { get; set; }
    public decimal Buyukluk { get; set; }

    public Sahipler Sahip { get; set; }
    public AraziTurleri AraziTuru { get; set; }
    public Adresler Adres { get; set; }
    public ICollection<Hasatlar> Hasatlar { get; set; }
}
