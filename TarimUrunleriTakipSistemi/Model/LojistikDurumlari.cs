using System.ComponentModel.DataAnnotations;

public class LojistikDurumlari
{
    [Key]
    public int DurumID { get; set; }
    public string Durum { get; set; }

    public ICollection<Lojistik> Lojistik { get; set; }
}
