using System.ComponentModel.DataAnnotations;

public class Hasatlar
{
    [Key]
    public int HasatID { get; set; }
    public int CiftlikID { get; set; }
    public int BirimID { get; set; }
    public int UrunID { get; set; }
    public DateTime Tarih { get; set; }
    public int Miktar { get; set; }

    public Ciftlikler Ciftlik { get; set; }
    public Birimler Birim { get; set; }
    public Urunler Urun { get; set; }
}
