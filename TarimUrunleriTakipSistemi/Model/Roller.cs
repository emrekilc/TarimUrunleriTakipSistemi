using System.ComponentModel.DataAnnotations;

public class Roller
{
    [Key]
    public int RolID { get; set; }
    public string Rol { get; set; }

    public ICollection<Kullanicilar> Kullanicilar { get; set; }
}
