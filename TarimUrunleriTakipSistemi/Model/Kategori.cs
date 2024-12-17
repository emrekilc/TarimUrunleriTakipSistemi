using System.ComponentModel.DataAnnotations;

public class Kategori
{
    [Key]
    public int Id { get; set; }
    public string Ad { get; set; } = string.Empty;
    public string? Aciklama { get; set; }
    public DateTime OlusturmaTarihi { get; set; }

    // İlişkiler
    public ICollection<Urunler>? Urunler { get; set; } // Bir kategori birden fazla ürüne sahip olabilir.
}
