using ChacourShop.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChacourShop.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0001",
                ProductName = "SAVON GLUTA EXTRA FORT",
                Price = 2500,
                CategoryName = "Pommade",
                Description = "Glutathione Extra Fort White Body Soap Resultat 5jr.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/PI9VKTI027CQK8I.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0002",
                ProductName = "LAIT GLUTATHIONE",
                Price = 12000,
                CategoryName = "Pommade",
                Description = "Concentre Glutathione Extra Fort Actif Intence Eclaircissant Propriete.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/CI3ETKF5869E40Y.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0003",
                ProductName = "LAIT FINAL JAUNE",
                Price = 7000,
                CategoryName = "Pommade",
                Description = "Lait de beaute eclaircissant, Hydratant et nourissant. A base de plantes, d'huiles essentielles et de vitamines.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/BLLEP02KFQY18EY.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0004",
                ProductName = "LAIT KOJIC ACID ROUGE",
                Price = 7000,
                CategoryName = "Pommade",
                Description = "Eclaircissant pour le soin corporel.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/1T5QCV1I1OJ8EG3.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0005",
                ProductName = "CONCENTRE GLUTA BLEU",
                Price = 6000,
                CategoryName = "Pommade",
                Description = "Concentre Glutathione Extra Fort Actif Intence Eclaircissant Propriete.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/JAZO5N2IOXIHGDP.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0006",
                ProductName = "LAIT B LIGHT",
                Price = 9000,
                CategoryName = "Pommade",
                Description = "Light Ultra Soft. Lait super eclaircissant aux bio-vegetaux.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/DF4FAL2M74H0MMO.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0007",
                ProductName = "SAVON AHA",
                Price = 2500,
                CategoryName = "Pommade",
                Description = "X2 AHA White Body Soap Resultat 5jr. Special formula for face & body with Glutathione, Collagen, Alpha-Arbutin, plus Vit. C & E.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/9UGR4D92YF0GH8F.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0008",
                ProductName = "GEL DOUCHE FINAL",
                Price = 6000,
                CategoryName = "Pommade",
                Description = "Whitening Creamy Foam Shower Mousse Sacred Lotus. Lotus Sacre. Whitening Exfolient and Scrubed. Creme douche Eclaircissante a la mousse de coton 750ml.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/RQV2490QW7GHIWJ.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0009",
                ProductName = "LOTION NEW SKIN",
                Price = 5000,
                CategoryName = "Pommade",
                Description = "Nouvelle pommade.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/PAR161XYEHCBWLF.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0010",
                ProductName = "LAIT FINAL GOLD",
                Price = 8000,
                CategoryName = "Pommade",
                Description = "Extra fort lait tonifiant, actif intense eclaircissant. Exclusive strong milk, toning milk, active intense. Advanced lightning fadoul.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/TSZ4QV40BQQ291Q.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0011",
                ProductName = "CREME GLUTA CAROTTE",
                Price = 8500,
                CategoryName = "Pommade",
                Description = "Creme Reparateur Glutathione Carotte.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/DGZEK8K2VUSTR2U.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0012",
                ProductName = "LAIT VIP",
                Price = 9000,
                CategoryName = "Pommade",
                Description = "Elegant collagene.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/70JVRAFAMU0WXZB.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0013",
                ProductName = "CONCENTRE KENACOL",
                Price = 12000,
                CategoryName = "Pommade",
                Description = "Concentre Reparateur Kenacol Nouveau Ultra.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/EG37FXEHO1I8OKB.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0014",
                ProductName = "GLUTATHIONE BLANC",
                Price = 7000,
                CategoryName = "Pommade",
                Description = "Eclaircissant pour le soin corporel.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/CRR4LQH5O2RYINW.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0015",
                ProductName = "LAIT TALANGAI",
                Price = 9000,
                CategoryName = "Pommade",
                Description = "Lait eclaircissant aux extrats de plantes.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/2WEXJJ9C8D97NF8.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0016",
                ProductName = "LAIT BIOCELL KOJIC",
                Price = 7000,
                CategoryName = "Pommade",
                Description = "Eclaircissant pour le soin corporel.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/YWJKO17IBMHUW78.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0017",
                ProductName = "LAIT GLUTA BLEU GRAND",
                Price = 25000,
                CategoryName = "Pommade",
                Description = "Glutathione White Extra Fort Blue Active Intense Exclusive Advanced Lightening Whitening in 10 days.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/50C1FUS1GJINVPW.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0018",
                ProductName = "LAIT RAPIDE CLAIR",
                Price = 3000,
                CategoryName = "Pommade",
                Description = "Rapid clair super eclaircissant.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/VOMGSK9SRJ31LPL.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0019",
                ProductName = "LAIT FINAL MAXITONE",
                Price = 7000,
                CategoryName = "Pommade",
                Description = "Lightening Lotion, lait de beaute eclaircissant, Hydratant et nourissant..",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/A3EH2X3JZZ7IEO0.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                ProductCode = "P0020",
                ProductName = "CONCENTRE GLUTA NOIR",
                Price = 6000,
                CategoryName = "Pommade",
                Description = "Concentre Glutathione Diamant Extra Fort Actif intence Eclaircissant Propriete.",
                ProductImage = "http://chacour.shop/ChacourCosmeticAPI/LogoImg/DL5MEGVKMXV64KN.jpg",
                UserId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                CreateDate = DateTime.Now,
                StockLevel = 100
            });
        }
    }
}
