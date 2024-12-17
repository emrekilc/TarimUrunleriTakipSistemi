using System.ComponentModel.DataAnnotations;

public class Urunler
{
    [Key]
    public int Id { get; set; }
    public int KategoriID { get; set; }
    public int BirimID { get; set; }
    public string Ad { get; set; }
    public int StokMiktari { get; set; }
    public decimal BirimFiyati { get; set; }

    public Kategori Kategori { get; set; }
    public Birimler Birim { get; set; }
    public ICollection<Hasatlar> Hasatlar { get; set; }
    public ICollection<Siparisler> Siparisler { get; set; }
}
