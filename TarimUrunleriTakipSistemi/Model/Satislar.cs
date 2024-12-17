using System.ComponentModel.DataAnnotations;

public class Satislar

{
    [Key]
    public int SatisID { get; set; }
    public int SiparisID { get; set; }

    public Siparisler Siparis { get; set; }
}
