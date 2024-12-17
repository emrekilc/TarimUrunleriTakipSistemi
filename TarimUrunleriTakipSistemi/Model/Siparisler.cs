using System.ComponentModel.DataAnnotations;

public class Siparisler
{
    [Key]
    public int SiparisID { get; set; }
    public int MusteriID { get; set; }
    public int UrunID { get; set; }
    public int Miktar { get; set; }
    public DateTime SiparisTarihi { get; set; }
    public DateTime? TeslimTarihi { get; set; }
    public decimal Fiyat { get; set; }

    public Musteriler Musteri { get; set; }
    public Urunler Urun { get; set; }
}
