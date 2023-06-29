using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Data.Migrations
{
    public partial class AddingPropertyCreatedOn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("022b5e8a-7996-4e3b-840d-9ba18caa91b4"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("571455fb-f393-4f74-99cb-cbb14cc5965b"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("5c9d59fa-b0e3-449f-ab0e-2b520d4c7554"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Houses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 28, 14, 12, 47, 551, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenderId", "RenterId", "Title" },
                values: new object[] { new Guid("1e0c0d75-f212-4f93-a564-e7665261a930"), "Near the Sea Garden in Burgas, Bulgaria", new Guid("229d8928-2b93-40b3-b60b-82ac8e2452b8"), 2, "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/179489660.jpg?k=2029f6d9589b49c95dcc9503a265e292c2cdfcb5277487a0050397c3f8dd545a&o=&hp=1", 1200.00m, null, null, "Family House Comfort" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenderId", "RenterId", "Title" },
                values: new object[] { new Guid("6ef1a699-6135-45d9-822a-ebceb3bd17b0"), "Boyana Neighbourhood, Sofia, Bulgaria", new Guid("229d8928-2b93-40b3-b60b-82ac8e2452b8"), 2, "This luxurious house is everything you will need. It is just excellent.", "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg", 2000.00m, null, null, "Grand House" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenderId", "RenterId", "Title" },
                values: new object[] { new Guid("8658fa22-a9c7-423d-b7c2-2d49458ce986"), "North London, UK (near the border)", new Guid("229d8928-2b93-40b3-b60b-82ac8e2452b8"), 3, "A big house for your whole family. Don't miss to buy a house with three bedrooms.", "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg", 2100.00m, new Guid("b8315e90-318f-48d1-ae00-a9e566b5339f"), null, "Big House Marina" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("1e0c0d75-f212-4f93-a564-e7665261a930"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("6ef1a699-6135-45d9-822a-ebceb3bd17b0"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("8658fa22-a9c7-423d-b7c2-2d49458ce986"));

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Houses");

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenderId", "RenterId", "Title" },
                values: new object[] { new Guid("022b5e8a-7996-4e3b-840d-9ba18caa91b4"), "Boyana Neighbourhood, Sofia, Bulgaria", new Guid("229d8928-2b93-40b3-b60b-82ac8e2452b8"), 2, "This luxurious house is everything you will need. It is just excellent.", "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg", 2000.00m, null, null, "Grand House" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenderId", "RenterId", "Title" },
                values: new object[] { new Guid("571455fb-f393-4f74-99cb-cbb14cc5965b"), "Near the Sea Garden in Burgas, Bulgaria", new Guid("229d8928-2b93-40b3-b60b-82ac8e2452b8"), 2, "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/179489660.jpg?k=2029f6d9589b49c95dcc9503a265e292c2cdfcb5277487a0050397c3f8dd545a&o=&hp=1", 1200.00m, null, null, "Family House Comfort" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenderId", "RenterId", "Title" },
                values: new object[] { new Guid("5c9d59fa-b0e3-449f-ab0e-2b520d4c7554"), "North London, UK (near the border)", new Guid("229d8928-2b93-40b3-b60b-82ac8e2452b8"), 3, "A big house for your whole family. Don't miss to buy a house with three bedrooms.", "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg", 2100.00m, new Guid("b8315e90-318f-48d1-ae00-a9e566b5339f"), null, "Big House Marina" });
        }
    }
}
