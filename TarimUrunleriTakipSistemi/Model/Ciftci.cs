using System.ComponentModel.DataAnnotations;

public class Ciftci
{
    [Key]
    public int Id { get; set; }
    public string AdSoyad { get; set; } = string.Empty;
    public string Telefon { get; set; } = string.Empty;
    public string Adres { get; set; } = string.Empty;

    // İlişkiler
    public ICollection<Stok>? Stoklar { get; set; } // Bir çiftçi birden fazla stok kaydına sahip olabilir.
}
