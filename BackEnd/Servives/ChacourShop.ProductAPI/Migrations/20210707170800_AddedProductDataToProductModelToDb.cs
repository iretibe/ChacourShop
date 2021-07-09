using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChacourShop.ProductAPI.Migrations
{
    public partial class AddedProductDataToProductModelToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "CreateDate", "Description", "Price", "ProductCode", "ProductImage", "ProductName", "StockLevel", "UserId" },
                values: new object[,]
                {
                    { new Guid("c193627d-a3a3-4da7-b7d9-4df623d176f4"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 325, DateTimeKind.Local).AddTicks(714), "Glutathione Extra Fort White Body Soap Resultat 5jr.", 2500.0, "P0001", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/PI9VKTI027CQK8I.jpg", "SAVON GLUTA EXTRA FORT", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("c6d1875e-fbd3-428f-8282-2763b15a04b3"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8485), "Rapid clair super eclaircissant.", 3000.0, "P0018", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/VOMGSK9SRJ31LPL.jpg", "LAIT RAPIDE CLAIR", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("69b64201-d151-4619-87ed-4dd0c22e191a"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8454), "Glutathione White Extra Fort Blue Active Intense Exclusive Advanced Lightening Whitening in 10 days.", 25000.0, "P0017", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/50C1FUS1GJINVPW.jpg", "LAIT GLUTA BLEU GRAND", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("837e7109-623d-4cb5-b099-69dc1ad4c90d"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8436), "Eclaircissant pour le soin corporel.", 7000.0, "P0016", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/YWJKO17IBMHUW78.jpg", "LAIT BIOCELL KOJIC", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("d53cfc12-3f6c-4952-8a25-1310e440c70d"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8419), "Lait eclaircissant aux extrats de plantes.", 9000.0, "P0015", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/2WEXJJ9C8D97NF8.jpg", "LAIT TALANGAI", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("4ada21dd-e1d4-4c46-9670-76a53765f92a"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8402), "Eclaircissant pour le soin corporel.", 7000.0, "P0014", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/CRR4LQH5O2RYINW.jpg", "GLUTATHIONE BLANC", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("515b3486-70cd-4c7f-932e-111db0a9c577"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8384), "Concentre Reparateur Kenacol Nouveau Ultra.", 12000.0, "P0013", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/EG37FXEHO1I8OKB.jpg", "CONCENTRE KENACOL", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("dfd02892-bce5-45f3-96c2-d9d5b6ff16cf"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8363), "Elegant collagene.", 9000.0, "P0012", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/70JVRAFAMU0WXZB.jpg", "LAIT VIP", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("a3977290-e3ef-4729-a98a-9919f16681d5"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8254), "Creme Reparateur Glutathione Carotte.", 8500.0, "P0011", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/DGZEK8K2VUSTR2U.jpg", "CREME GLUTA CAROTTE", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("a2c43b55-313d-4eb3-a554-e26f510a15f2"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8237), "Extra fort lait tonifiant, actif intense eclaircissant. Exclusive strong milk, toning milk, active intense. Advanced lightning fadoul.", 8000.0, "P0010", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/TSZ4QV40BQQ291Q.jpg", "LAIT FINAL GOLD", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("4efedf0c-27b0-4ff6-8e0e-c0d0eb73bf7f"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8211), "Nouvelle pommade.", 5000.0, "P0009", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/PAR161XYEHCBWLF.jpg", "LOTION NEW SKIN", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("dfbfcb15-dad4-41af-966f-0f55517bfee2"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8194), "Whitening Creamy Foam Shower Mousse Sacred Lotus. Lotus Sacre. Whitening Exfolient and Scrubed. Creme douche Eclaircissante a la mousse de coton 750ml.", 6000.0, "P0008", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/RQV2490QW7GHIWJ.jpg", "GEL DOUCHE FINAL", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("c7cee65a-378b-4057-bfdc-6db0ecadab96"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8176), "X2 AHA White Body Soap Resultat 5jr. Special formula for face & body with Glutathione, Collagen, Alpha-Arbutin, plus Vit. C & E.", 2500.0, "P0007", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/9UGR4D92YF0GH8F.jpg", "SAVON AHA", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("13d7744c-f6b8-4802-8eef-8973713a4a98"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8148), "Light Ultra Soft. Lait super eclaircissant aux bio-vegetaux.", 9000.0, "P0006", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/DF4FAL2M74H0MMO.jpg", "LAIT B LIGHT", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("c9744f4b-435b-4924-8cd4-e8485b1daab3"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8124), "Concentre Glutathione Extra Fort Actif Intence Eclaircissant Propriete.", 6000.0, "P0005", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/JAZO5N2IOXIHGDP.jpg", "CONCENTRE GLUTA BLEU", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("d0f3b59a-a1a1-4ab0-8d17-17c9fe8550e1"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8105), "Eclaircissant pour le soin corporel.", 7000.0, "P0004", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/1T5QCV1I1OJ8EG3.jpg", "LAIT KOJIC ACID ROUGE", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("a580858b-aaad-43d5-ac53-264ef21bea52"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8081), "Lait de beaute eclaircissant, Hydratant et nourissant. A base de plantes, d'huiles essentielles et de vitamines.", 7000.0, "P0003", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/BLLEP02KFQY18EY.jpg", "LAIT FINAL JAUNE", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("cbdea814-f1b1-4a5a-9c95-abe8e22f1577"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(7915), "Concentre Glutathione Extra Fort Actif Intence Eclaircissant Propriete.", 12000.0, "P0002", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/CI3ETKF5869E40Y.jpg", "LAIT GLUTATHIONE", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("cc696134-fca7-445a-9c28-15d9738e1edd"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8502), "Lightening Lotion, lait de beaute eclaircissant, Hydratant et nourissant..", 7000.0, "P0019", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/A3EH2X3JZZ7IEO0.jpg", "LAIT FINAL MAXITONE", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("866e239a-6658-4c0f-9f3b-cf0fec9c055c"), "Pommade", new DateTime(2021, 7, 7, 17, 8, 0, 328, DateTimeKind.Local).AddTicks(8519), "Concentre Glutathione Diamant Extra Fort Actif intence Eclaircissant Propriete.", 6000.0, "P0020", "http://chacour.shop/ChacourCosmeticAPI/LogoImg/DL5MEGVKMXV64KN.jpg", "CONCENTRE GLUTA NOIR", 100, new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("13d7744c-f6b8-4802-8eef-8973713a4a98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4ada21dd-e1d4-4c46-9670-76a53765f92a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4efedf0c-27b0-4ff6-8e0e-c0d0eb73bf7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("515b3486-70cd-4c7f-932e-111db0a9c577"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("69b64201-d151-4619-87ed-4dd0c22e191a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("837e7109-623d-4cb5-b099-69dc1ad4c90d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("866e239a-6658-4c0f-9f3b-cf0fec9c055c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a2c43b55-313d-4eb3-a554-e26f510a15f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a3977290-e3ef-4729-a98a-9919f16681d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a580858b-aaad-43d5-ac53-264ef21bea52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c193627d-a3a3-4da7-b7d9-4df623d176f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c6d1875e-fbd3-428f-8282-2763b15a04b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c7cee65a-378b-4057-bfdc-6db0ecadab96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9744f4b-435b-4924-8cd4-e8485b1daab3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cbdea814-f1b1-4a5a-9c95-abe8e22f1577"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cc696134-fca7-445a-9c28-15d9738e1edd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d0f3b59a-a1a1-4ab0-8d17-17c9fe8550e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d53cfc12-3f6c-4952-8a25-1310e440c70d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dfbfcb15-dad4-41af-966f-0f55517bfee2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dfd02892-bce5-45f3-96c2-d9d5b6ff16cf"));
        }
    }
}
