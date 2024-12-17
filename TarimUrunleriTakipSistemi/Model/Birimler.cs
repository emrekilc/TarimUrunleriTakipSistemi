using System.ComponentModel.DataAnnotations;

public class Birimler
{
    [Key]
    public int BirimID { get; set; }
    public string Birim { get; set; }

    public ICollection<Urunler> Urunler { get; set; }
    public ICollection<Hasatlar> Hasatlar { get; set; }
}
