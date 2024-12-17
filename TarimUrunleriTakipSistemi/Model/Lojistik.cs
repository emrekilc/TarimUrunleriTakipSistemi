using System.ComponentModel.DataAnnotations;

public class Lojistik
{
    [Key]
    public int LojistikID { get; set; }
    public int SoforID { get; set; }
    public int SatisID { get; set; }
    public int AracID { get; set; }
    public int DurumID { get; set; }
    public DateTime? TahiminiTeslimTarihi { get; set; }
    public DateTime? TeslimTarihi { get; set; }

    public Soforler Sofor { get; set; }
    public Satislar Satis { get; set; }
    public Araclar Arac { get; set; }
    public LojistikDurumlari Durum { get; set; }
}
