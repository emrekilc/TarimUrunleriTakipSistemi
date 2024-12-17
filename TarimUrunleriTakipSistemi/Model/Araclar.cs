using System.ComponentModel.DataAnnotations;

public class Araclar
{
    [Key]
    public int AracID { get; set; }
    public string Plaka { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public decimal Kapasite { get; set; }

    public ICollection<Lojistik> Lojistik { get; set; }
}
