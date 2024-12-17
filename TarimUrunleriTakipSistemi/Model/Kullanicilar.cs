using System.ComponentModel.DataAnnotations;

public class Kullanicilar
{
    [Key]
    public int KullaniciID { get; set; }
    public int RolID { get; set; }
    public string KullaniciAdi { get; set; }
    public string Sifre { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public Roller Rol { get; set; }
}
