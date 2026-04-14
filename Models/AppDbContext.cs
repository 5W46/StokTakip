using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StokTakip.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string? Barkod { get; set; }
        public string UrunAdi { get; set; } = string.Empty;
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyati { get; set; }
        public int StokMiktari { get; set; }
        public int MinStok { get; set; }
        public string? AlinanYer { get; set; }
        public string? AlinanNumara { get; set; }
        public string? Aciklama { get; set; }
        public string? FotografYolu { get; set; }   // Yeni alan
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<StokHareket> StokHareketleri { get; set; } = new List<StokHareket>();
        public ICollection<SatisDetay> SatisDetaylari { get; set; } = new List<SatisDetay>();
    }

    public class Musteri
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Telefon { get; set; }
        public string? Email { get; set; }
        public string? Adres { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<Satis> Satislar { get; set; } = new List<Satis>();
    }

    public class Satis
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public DateTime SatisTarihi { get; set; }
        public string? KargoTakipNo { get; set; }
        public string? Notlar { get; set; }
        public decimal ToplamTutar { get; set; }
        public string OdemeDurumu { get; set; } = "Bekliyor";
        public decimal? Indirim { get; set; }
        public decimal? KargoUcreti { get; set; }

        public Musteri? Musteri { get; set; }
        public ICollection<SatisDetay> Detaylar { get; set; } = new List<SatisDetay>();
    }

    public class SatisDetay
    {
        public int Id { get; set; }
        public int SatisId { get; set; }
        public int UrunId { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal ToplamFiyat { get; set; }

        public Satis? Satis { get; set; }
        public Urun? Urun { get; set; }
    }

    public class StokHareket
    {
        public int Id { get; set; }
        public int UrunId { get; set; }
        public string HareketTipi { get; set; } = string.Empty;
        public int Miktar { get; set; }
        public int OncekiStok { get; set; }
        public int SonrakiStok { get; set; }
        public string? Aciklama { get; set; }
        public DateTime Tarih { get; set; }

        public string? TedarikciAdi { get; set; }
        public string? TedarikciTelefon { get; set; }
        public string? MusteriAdi { get; set; }
        public string? MusteriTelefon { get; set; }
        public int? CihazId { get; set; }

        public Urun? Urun { get; set; }
    }

    public class Cihaz
    {
        public int Id { get; set; }
        public string MarkaModel { get; set; } = string.Empty;
        public string SeriNo { get; set; } = string.Empty;
        public string Durum { get; set; } = string.Empty;
        public decimal AlisMaliyeti { get; set; }
        public decimal SatisFiyati { get; set; }
        public decimal Kar => SatisFiyati - (AlisMaliyeti + (Harcamalar?.Sum(h => h.Tutar) ?? 0));
        public string? Notlar { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? SatisTarihi { get; set; }

        public string? AlinanKisiAdSoyad { get; set; }
        public string? AlinanKisiTelefon { get; set; }
        public string? SatilanKisiAdSoyad { get; set; }
        public string? SatilanKisiTelefon { get; set; }

        public ICollection<CihazYapilacak> Yapilacaklar { get; set; } = new List<CihazYapilacak>();
        public ICollection<CihazHarcama> Harcamalar { get; set; } = new List<CihazHarcama>();
    }

    public class CihazYapilacak
    {
        public int Id { get; set; }
        public int CihazId { get; set; }
        public string Aciklama { get; set; } = string.Empty;
        public bool Tamamlandi { get; set; }
        public int Sira { get; set; }

        public Cihaz? Cihaz { get; set; }
    }

    public class CihazHarcama
    {
        public int Id { get; set; }
        public int CihazId { get; set; }
        public string HarcamaAdi { get; set; } = string.Empty;
        public decimal Tutar { get; set; }
        public string? Aciklama { get; set; }
        public int? UrunId { get; set; }
        public int Miktar { get; set; }
        public DateTime Tarih { get; set; }

        public Cihaz? Cihaz { get; set; }
        public Urun? Urun { get; set; }
    }

    public class CihazDisParca
    {
        public int Id { get; set; }
        public int CihazId { get; set; }
        public string ParcaAdi { get; set; } = string.Empty;
        public int Miktar { get; set; }
        public decimal BirimMaliyet { get; set; }
        public decimal ToplamMaliyet { get; set; }
        public DateTime Tarih { get; set; }

        public Cihaz? Cihaz { get; set; }
    }

    // Batarya modülleri
    public class PilLot
    {
        public int Id { get; set; }
        public string LotAdi { get; set; } = string.Empty;
        public string? HucreModel { get; set; }
        public string? TedarikciAdi { get; set; }
        public string? TedarikciTelefon { get; set; }
        public decimal BirimMaliyet { get; set; }
        public int Adet { get; set; }
        public bool SifirPilMi { get; set; }
        public DateTime GirisTarihi { get; set; }
        public string? Notlar { get; set; }

        public ICollection<PilHucresi> Hucres { get; set; } = new List<PilHucresi>();
    }

    public class PilHucresi
    {
        public int Id { get; set; }
        public int LotId { get; set; }
        public int SeriNo { get; set; }
        public decimal Kapasite { get; set; }
        public decimal IcDirenc { get; set; }
        public string Durum { get; set; } = "Stokta";
        public DateTime? TestTarihi { get; set; }
        public string? Notlar { get; set; }

        public PilLot? Lot { get; set; }
        public ICollection<PilBataryaHucresi> BataryaHucres { get; set; } = new List<PilBataryaHucresi>();
    }

    public class PilBatarya
    {
        public int Id { get; set; }
        public string BataryaAdi { get; set; } = string.Empty;
        public int SeriSayisi { get; set; }
        public int ParalelSayisi { get; set; }
        public decimal ToplamKapasite { get; set; }
        public decimal OrtalamaKapasite { get; set; }
        public decimal ToplamIcDirenc { get; set; }
        public decimal OrtalamaIcDirenc { get; set; }
        public string? BMSMarka { get; set; }
        public string? BMSModel { get; set; }
        public decimal PilMaliyeti { get; set; }
        public decimal SarfMalzemeler { get; set; }
        public decimal Isçilik { get; set; }
        public decimal ToplamMaliyet => PilMaliyeti + SarfMalzemeler + Isçilik;
        public decimal SatisFiyati { get; set; }
        public decimal Kar => SatisFiyati - ToplamMaliyet;
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? SatisTarihi { get; set; }
        public string Durum { get; set; } = "Üretim Aşamasında";
        public string? Notlar { get; set; }
        public string? SatilanKisiAdSoyad { get; set; }
        public string? SatilanKisiTelefon { get; set; }

        public ICollection<PilBataryaHucresi> BataryaHucres { get; set; } = new List<PilBataryaHucresi>();
    }

    public class PilBataryaHucresi
    {
        public int Id { get; set; }
        public int BataryaId { get; set; }
        public int HucresId { get; set; }

        public PilBatarya? Batarya { get; set; }
        public PilHucresi? Hucres { get; set; }
    }

    public class PilHareket
    {
        public int Id { get; set; }
        public int HucresId { get; set; }
        public string HareketTipi { get; set; } = string.Empty;
        public int Miktar { get; set; }
        public DateTime Tarih { get; set; }
        public string? Aciklama { get; set; }

        public PilHucresi? Hucres { get; set; }
    }

    public class Gider
    {
        public int Id { get; set; }
        public DateTime GiderTarihi { get; set; }
        public string Kategori { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
        public decimal Tutar { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<SatisDetay> SatisDetaylari { get; set; }
        public DbSet<StokHareket> StokHareketleri { get; set; }
        public DbSet<Cihaz> Cihazlar { get; set; }
        public DbSet<CihazYapilacak> CihazYapilacaklar { get; set; }
        public DbSet<CihazHarcama> CihazHarcamalar { get; set; }
        public DbSet<CihazDisParca> CihazDisParcalar { get; set; }
        public DbSet<PilLot> PilLotlari { get; set; }
        public DbSet<PilHucresi> PilHucres { get; set; }
        public DbSet<PilBatarya> PilBataryalar { get; set; }
        public DbSet<PilBataryaHucresi> PilBataryaHucres { get; set; }
        public DbSet<PilHareket> PilHareketleri { get; set; }
        public DbSet<Gider> Giderler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=stoktakip.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Urun>()
                .HasIndex(u => u.Barkod)
                .IsUnique();

            modelBuilder.Entity<Cihaz>()
                .HasIndex(c => c.SeriNo)
                .IsUnique();

            modelBuilder.Entity<PilLot>()
                .HasIndex(l => l.LotAdi)
                .IsUnique();

            modelBuilder.Entity<PilHucresi>()
                .HasIndex(h => new { h.LotId, h.SeriNo })
                .IsUnique();

            modelBuilder.Entity<CihazYapilacak>()
                .HasIndex(cy => new { cy.CihazId, cy.Sira })
                .IsUnique();

            modelBuilder.Entity<Cihaz>()
                .Ignore(c => c.Kar);
        }
    }
}