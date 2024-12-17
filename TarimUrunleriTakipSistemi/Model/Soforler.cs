using System.ComponentModel.DataAnnotations;
using TarimUrunleruTakipSistemi.Models;

public class Soforler
{
    [Key]
    public int SoforID { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int AdresID { get; set; }
    public string Telefon { get; set; }
    public string EhliyetSinifi { get; set; }

    public Adresler Adres { get; set; }
}
