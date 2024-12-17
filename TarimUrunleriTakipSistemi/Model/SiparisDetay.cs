using System.ComponentModel.DataAnnotations;

public class SiparisDetay
{
    [Key]
    public int Id { get; set; }
    public int Miktar { get; set; }
    public decimal BirimFiyat { get; set; }

    // İlişkiler
    public int SiparisId { get; set; }
    public Siparisler? Siparis { get; set; } // Navigation Property

    public int UrunId { get; set; }
    public Urunler? Urun { get; set; } // Navigation Property
}
