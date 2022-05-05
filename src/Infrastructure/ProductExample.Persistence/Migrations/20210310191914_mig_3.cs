using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductExample.Persistence.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "Quantity", "Stock" },
                values: new object[] { new Guid("e5f642e4-c8a3-4342-9c29-8dfd76b485e6"), "Product1", 10, 10, 10 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "Quantity", "Stock" },
                values: new object[] { new Guid("cde3e293-90ed-4482-9d07-c0d9501ef1f3"), "Product2", 20, 20, 20 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "Quantity", "Stock" },
                values: new object[] { new Guid("3a90e458-0ac5-4bd3-aa64-980ed85d9c32"), "Product3", 30, 30, 30 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a90e458-0ac5-4bd3-aa64-980ed85d9c32"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cde3e293-90ed-4482-9d07-c0d9501ef1f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5f642e4-c8a3-4342-9c29-8dfd76b485e6"));
        }
    }
}
