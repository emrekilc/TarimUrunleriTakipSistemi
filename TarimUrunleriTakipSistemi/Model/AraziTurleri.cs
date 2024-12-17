using System.ComponentModel.DataAnnotations;

public class AraziTurleri
{
    [Key]
    public int AraziTuruID { get; set; }
    public string Turu { get; set; }

    public ICollection<Ciftlikler> Ciftlikler { get; set; }
}
