using Microsoft.EntityFrameworkCore;
using System;
 // DbContext sınıfının olduğu namespace
using TarimUrunleriTakipSistemi.Models;
using TarimUrunleriTakipSistemi.Data; // Urunler modelinin olduğu namespace

namespace YourProject.Services
{
	public class ProductService
	{
		private readonly DbContext _context;

		public ProductService(DbContext context)
		{
			_context = context;
		}

		// Tüm ürünleri SQL ile getirme
		public List<Urunler> GetAllProducts()
		{
			var sql = "SELECT * FROM Urunler";
			return _context.Urunler
				.FromSqlRaw(sql)
				.ToList();
		}

		// ID'ye göre ürünü SQL ile getirme
		public Urunler GetProductById(int id)
		{
			var sql = $"SELECT * FROM Urunler WHERE Id = {id}";
			return _context.Urunler
				.FromSqlInterpolated($"SELECT * FROM Urunler WHERE Id = {id}")
				.FirstOrDefault();
		}

		// Yeni ürün ekleme (SQL komut ile)
		public void AddProduct(Urunler product)
		{
			var sql = $"INSERT INTO Urunler (KategoriID, BirimID, Ad, StokMiktari, BirimFiyati) " +
					  $"VALUES ({product.KategoriID}, {product.BirimID}, {product.Ad}, {product.StokMiktari}, {product.BirimFiyati})";

			_context.Database.ExecuteSqlInterpolated($"INSERT INTO Urunler (KategoriID, BirimID, Ad, StokMiktari, BirimFiyati) "
				+ $"VALUES ({product.KategoriID}, {product.BirimID}, {product.Ad}, {product.StokMiktari}, {product.BirimFiyati})");
		}

		// Ürün güncelleme (SQL komut ile)
		public void UpdateProduct(Urunler product)
		{
			var sql = $"UPDATE Urunler " +
					  $"SET Ad = {product.Ad}, KategoriID = {product.KategoriID}, BirimID = {product.BirimID}, " +
					  $"StokMiktari = {product.StokMiktari}, BirimFiyati = {product.BirimFiyati} " +
					  $"WHERE Id = {product.Id}";

			_context.Database.ExecuteSqlInterpolated($"UPDATE Urunler " +
													 $"SET Ad = {product.Ad}, KategoriID = {product.KategoriID}, BirimID = {product.BirimID}, " +
													 $"StokMiktari = {product.StokMiktari}, BirimFiyati = {product.BirimFiyati} " +
													 $"WHERE Id = {product.Id}");
		}

		// Ürün silme (SQL komut ile)
		public void DeleteProduct(int id)
		{
			_context.Database.ExecuteSqlInterpolated($"DELETE FROM Urunler WHERE Id = {id}");
		}

		// Belirli stok miktarından büyük ürünleri SQL ile getirme
		public List<Urunler> GetProductsWithStockAbove(int minStock)
		{
			return _context.Urunler
				.FromSqlInterpolated($"SELECT * FROM Urunler WHERE StokMiktari > {minStock}")
				.ToList();
		}
	}
}
