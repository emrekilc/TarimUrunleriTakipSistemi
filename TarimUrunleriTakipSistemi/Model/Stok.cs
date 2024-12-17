using System.ComponentModel.DataAnnotations;

public class Stok
{
    [Key]
    public int Id { get; set; }
    public int Miktar { get; set; }
    public DateTime GirisTarihi { get; set; }

    // İlişkiler
    public int UrunId { get; set; }
    public Urunler? Urun { get; set; } // Navigation Property

    public int CiftciId { get; set; }
    public Ciftci? Ciftci { get; set; } // Navigation Property
}
