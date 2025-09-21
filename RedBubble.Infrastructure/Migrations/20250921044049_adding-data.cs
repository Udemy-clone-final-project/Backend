using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RedBubble.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87971704-052e-4435-a615-a307fef2d994", "AQAAAAIAAYagAAAAEJ/3hKZToObTSG8WQqDmn7jq08SPCeQPm6aQIJaYul+XbzOMObDQ6bQ9gvsNoGVePQ==", "1d40871c-fd8a-4cde-aa73-d0ae037171ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ce84dc0-065c-45f5-90bc-5377dc4d07ec", "AQAAAAIAAYagAAAAEJdVt6bIJKVv79b342vkjJaxUDbusPynmZqbr7HXy0UgXbg0zv8DzqP9akzU6URBYg==", "1614f8ad-a20f-4f01-8a58-26c581f87b19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20265d8c-5f39-40f4-acb7-10c80e64952a", "AQAAAAIAAYagAAAAEO43+aDtcuwwSaYJNGGM8YYk7xmS7oUAM0zshfDqs6hJBLNEvCFCp/vStJODhrPb5A==", "fdc85f05-3f05-4568-bcf7-27670129acd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e45d5b14-a1c0-472e-9125-0007292f034a", "AQAAAAIAAYagAAAAEEYeBgh1w0t/WwWfBVWLnB3+VlnAAce6d9siG8pKV7EAtIwUHIBTrNLEiOlM6t7v1Q==", "e5925eec-27f8-44ff-9ffa-ab9ab06da51f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3d2227e-284d-4917-acfc-bcb745348024", "AQAAAAIAAYagAAAAEEOwr2CRA0ukcgs7H3PZWwls4K55Iwy6lsEoAlUkviMqjyvSlJOtU1updhJOHNGTZw==", "3ddfe236-b867-459b-842c-0653b03f3516" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c77e131-410b-4667-85c0-479bfb9b40e0", "AQAAAAIAAYagAAAAENVLwqJAxC+d3r7v7ucHBr9KZOc/u+T3aMuEL1Rm2zSc/Y8wj3E7AHEN/jB0xgQr2g==", "a3d1d357-bdda-43f6-aa91-8eea241d8c72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "946010d8-7d29-4ed3-840f-6f2d237f523a", "AQAAAAIAAYagAAAAECJwTbDupXT0UGXAjGflVC29W7Yo6luEcSOmgXBArrh5YYvf2A/FPwgLH9o4o8zJgg==", "02c24413-41c7-45fe-9cda-33553fecf24d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40c17f02-7567-4859-bd8b-d407c1215972", "AQAAAAIAAYagAAAAEGKTNQ7sjZTEQ5QdCQ3ONcO8PZSKgCt+VNf+x//f4KIhmXFLvrNaB/NCOJqGiJDskw==", "a41c442e-210a-4407-890b-b985a8767442" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "986158fc-f178-4be5-85d3-37607674f643", "AQAAAAIAAYagAAAAEBPZYpLfDafCFG1nO/LFs8PG02stVQhXkUXNTsKRIzbm/+t9l/yl4bVHo/yNeBR/vw==", "bd3e5ce2-c587-45c2-97f3-1632abc0cb62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b06dc0b9-2aba-40fb-b2d3-5c8cf72c1990", "AQAAAAIAAYagAAAAEOGGJwIjGCS6c9O4HxmSOCnzL+iOvmBoo8vrT2HRlKVYpRfc/af2r0KkAANdpArWPg==", "6060d47a-3474-4566-b69f-c1f387b54790" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6500b6d-f46f-4263-b46a-25b337d2a1f9", "AQAAAAIAAYagAAAAEJpzVwJO6NZH2+jBE4SYvaOhej8TU9SZjvMD0112dqxGOhTK4VzWRyK/UdgGjh5fYg==", "d291bc39-1d3c-40fb-a205-471470044ebe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc46b600-4219-4b18-aff5-427324cfbf36", "AQAAAAIAAYagAAAAEIl5/irUPhNhpar8rn7/XbpL5xfH8JY8/2u9h9oh4laJrIMUCWn6X6oG3saDxL3JSg==", "56df057e-4090-4540-98b7-76803df7f186" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9842e223-315e-4bea-a9ac-855db29d62d0", "AQAAAAIAAYagAAAAECnp/pUZGK+kou+uIyKhD+GT8hD5PrTeaiEuPr8M/MT2tb+WLI31/dq8wJdlj4SQ+Q==", "b6d26c39-cc78-4fc9-b201-6a1358141b95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc427780-7b0d-4105-ab93-b2315d0addd7", "AQAAAAIAAYagAAAAEKvnqKJtFXjfoxffNxg/vvTcMtR23j+nE8KCdMu3lsUOVd04KFXCLZRsBvTEfJrGlw==", "445c3661-b31e-4cdb-bccf-644560d9ec3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3311987-0588-44fc-93c2-a60bdd9f06d8", "AQAAAAIAAYagAAAAEEQMdw0VPobsrhyF6BMVpYyVHKOBCZ1+jQHlWBWlfZsypcT4r8tETe26nhUvKvXkVw==", "93cc377a-4d3a-4c4d-8949-f38978e0b97d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ce5ed60-bf33-4e3f-915f-87df4acf899c", "AQAAAAIAAYagAAAAEEa4cv43R7665VmvWG3wXpwbY9cynLACfaA1Y42HthL745VfFIMpF4VIHMdQNyqyXw==", "b47ab268-cf0d-4bb0-a107-44cddb388db1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f78d246-6895-4fc1-b6cd-f4034636b6e5", "AQAAAAIAAYagAAAAECHH5SBk+VqNc86w50+h2ldw1d/w1nDXukY2e/OmsKJnqqUaoJ9PGA4D7Gw5jQcl5w==", "c3ece942-cab3-4ea7-9f8f-5e7f632cac90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc8780d1-bd57-4b39-be80-2d539ec78bb8", "AQAAAAIAAYagAAAAEGyMLOMgF5s+Nt3ZUNorBImjUSICtfQXrj20KC1bckoyBqQTBBuzDe+i8l/1O3BHmQ==", "f55a02d2-7023-434d-8482-dca38b151f29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff8f401b-ad55-4c40-8332-e585eb1fcdf3", "AQAAAAIAAYagAAAAEHVOlnohKYEu8EJouQkRLrgX4cnjjlicytyPdzmnJBTvgKRvTM9F9UPPlg8BsVQhIg==", "ecda95de-5dd4-42a0-bf28-4a9a0b555020" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14bcd385-3f75-40b3-9b79-e657f10a9945", "AQAAAAIAAYagAAAAEK9p5iI/wJqMSmFnu+oNA+MDvF7zlMWRq9OYac1xJqFk/cnimU+xByklxtjcebBuGA==", "cdc9c73e-5105-406b-a801-35028133202b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-020",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d3225bf-1eaa-4ae3-be0c-760ecd2de88a", "AQAAAAIAAYagAAAAEMb3mwEt1qN1f/idB1SpsgUNrKgJPGciACdirZ3Zq/96JokHwZQimCUEQohnN5546w==", "b279a7bb-cff0-4414-b041-4c1c6e749ae3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-021",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d3fc04d-8864-47c7-96dc-c0c3d25b0a80", "AQAAAAIAAYagAAAAEGP3kGxG4PVE7ex6lmn/l4qPgOKNhEwxs53ftndaXpKxGVYvElK805liC10n+g9iBQ==", "de515dfb-5123-40df-bda5-c78612e4c46b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02066489-6796-4ff5-a5f3-c24f6582b266", "AQAAAAIAAYagAAAAEJr7h4U/6Xncb3+js4PI1XhCKOCrIgr9yTkpq48M/umj9fbvYsS0XeYH/kX3Mfk1Zw==", "a0c3440e-8790-4d2c-aa94-dbb18dd01556" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-023",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed1d2531-0403-45d4-8615-fe19f88d7bbb", "AQAAAAIAAYagAAAAEG5jObz4IZNBHp2xBfDv07HcJNmBnk7OFiyfaln97HXjZIGWx0F5I51v6X56WluWjQ==", "c3f37856-1e15-45d2-ab68-c2db12283a30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-024",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b87138f0-5385-452b-aafe-44a9474696cd", "AQAAAAIAAYagAAAAEAAz5CMeK2MNO7r/EOYI0u/iXBMJ+qcQqcUnj8LxX88llmile6ZDie/kSVk4LqMZNA==", "ab872d78-2d5d-48a2-a426-ec6f70d72354" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-025",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4efe4408-1bf3-43eb-8412-b22ecabcb246", "AQAAAAIAAYagAAAAEMLC40CzzP+JoovgA46dm5KFOe0llifCI5gdUibZM1uhH5AfHppTq+OLret//WVFGQ==", "c4707104-b314-482f-8368-fb0d9f93b69c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-026",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a217dfdb-7d10-4261-b801-19fd5063c2a4", "AQAAAAIAAYagAAAAENlflFytpp3r6ItwwuX30UB0cDitxGp+xMaHc5SQ+t/iW7o7DElGppSmM2aNZ15pCQ==", "23c72037-5786-4802-8b75-01b03a1901db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98ec383d-5116-48f7-86f9-2da94c5bd5ac", "AQAAAAIAAYagAAAAEBrmZRuHXuJK433ytCzHixT8pk4WBZC32NPYdciTm0FZ9KBWOv4LrpHMUaplHhUkvw==", "24db03fa-5bbe-4847-910f-27ae930316c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-028",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "392bad7f-27be-4084-ba9a-0429210033c3", "AQAAAAIAAYagAAAAEIYaD102uaZBDaRBQFkdR/hMYOxZDDbKBelu5Z+2vNj3N+y4zV5tz5DEMeh1U+jLXw==", "45e8d367-1a1a-4697-ace9-5cee188a8de7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-029",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a049109-d656-40f4-836a-d0f670a974bf", "AQAAAAIAAYagAAAAEBdbalw0jdPBmwHPw4l5L318dw3aztAAHkTpLzAXubzdT+0uQwDtUKUkEIB/vUu2cg==", "1277ac48-0543-45a7-9901-514f491c3540" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-030",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "533cefeb-c01e-4e86-af5c-9cb7eca5b45c", "AQAAAAIAAYagAAAAEJwyWz6Scx13h7hAxZcL0d83ed7XvdiLNKzbnMzFxf7aZA9LEknkaJ6+ZL6blZFBNQ==", "94bc7d4c-a241-4a15-b600-e19b8375cfb8" });

            migrationBuilder.InsertData(
                table: "BaseProducts",
                columns: new[] { "Id", "BasePrice", "CategoryId", "CreatedBy", "CreatedOn", "Description", "HasColors", "HasSizes", "IsActive", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, 19.99m, 9, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comfortable cotton t-shirt with a relaxed fit", true, true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic T-Shirt" },
                    { 2, 24.99m, 9, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-quality cotton t-shirt with a modern fit", true, true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Premium T-Shirt" },
                    { 3, 22.99m, 9, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soft vintage-style t-shirt with a worn-in feel", true, true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vintage T-Shirt" },
                    { 4, 39.99m, 10, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warm and comfortable hoodie for casual wear", true, true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic Hoodie" },
                    { 5, 49.99m, 10, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-quality hoodie with premium materials", true, true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Premium Hoodie" },
                    { 6, 16.99m, 11, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lightweight tank top perfect for summer", true, true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic Tank Top" },
                    { 7, 19.99m, 11, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moisture-wicking tank top for active wear", true, true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Athletic Tank Top" }
                });

            migrationBuilder.InsertData(
                table: "BaseProducts",
                columns: new[] { "Id", "BasePrice", "CategoryId", "CreatedBy", "CreatedOn", "Description", "HasColors", "IsActive", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 8, 11.99m, 22, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-quality ceramic mug for beverages", true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic Ceramic Mug" },
                    { 9, 16.99m, 22, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insulated travel mug for on-the-go", true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Travel Mug" }
                });

            migrationBuilder.InsertData(
                table: "BaseProducts",
                columns: new[] { "Id", "BasePrice", "CategoryId", "CreatedBy", "CreatedOn", "Description", "HasSizes", "IsActive", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 10, 8.99m, 5, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-quality poster print for wall decoration", true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Standard Poster" },
                    { 11, 12.99m, 5, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Premium quality poster with enhanced colors", true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Premium Poster" }
                });

            migrationBuilder.InsertData(
                table: "BaseProducts",
                columns: new[] { "Id", "BasePrice", "CategoryId", "CreatedBy", "CreatedOn", "Description", "HasColors", "IsActive", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 12, 15.99m, 30, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Protective case for iPhone models", true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone Case" },
                    { 13, 15.99m, 30, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Protective case for Samsung Galaxy", true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Case" }
                });

            migrationBuilder.InsertData(
                table: "DeliveryMethods",
                columns: new[] { "Id", "Cost", "DeliveryTime", "Description", "ShortName" },
                values: new object[,]
                {
                    { 1, 5.99m, "1-2 days", "Fastest delivery: 1-2 days", "UPS1" },
                    { 2, 12.99m, "2-5 days", "Get it within 5 days", "UPS2" },
                    { 3, 24.99m, "5-10 days", "Slower but cheap", "UPS3" },
                    { 4, 0m, "1-2 weeks", "Free! You get what you pay for", "FREE" }
                });

            migrationBuilder.InsertData(
                table: "Designs",
                columns: new[] { "Id", "AdminId", "AltText", "CreatedBy", "CreatedOn", "Description", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "admin-001", "Cosmic Stars design artwork", "admin-001", new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twinkling stars in deep space", "design_1.jpg", "https://picsum.photos/seed/design1/800/600", true, "admin-001", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.00m, "Cosmic Stars #1" },
                    { 2, "admin-001", "Geometric Mandala design artwork", "admin-001", new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intricate geometric mandala pattern", "design_2.jpg", "https://picsum.photos/seed/design2/800/600", true, "admin-001", new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.80m, "Geometric Mandala #2" },
                    { 3, "admin-001", "Colorful Spiral design artwork", "admin-001", new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vibrant spiral design with flowing colors", "design_3.jpg", "https://picsum.photos/seed/design3/800/600", true, "admin-001", new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.88m, "Colorful Spiral #3" },
                    { 4, "admin-001", "Tropical Fish design artwork", "admin-001", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorful tropical fish in coral reef", "design_4.jpg", "https://picsum.photos/seed/design4/800/600", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.05m, "Tropical Fish #4" },
                    { 5, "admin-001", "Forest Wolf design artwork", "admin-001", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mysterious wolf in moonlit forest", "design_5.jpg", "https://picsum.photos/seed/design5/800/600", true, "admin-001", new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.51m, "Forest Wolf #5" },
                    { 6, "admin-001", "Hand Lettering design artwork", "admin-001", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beautiful hand-drawn lettering art", "design_6.jpg", "https://picsum.photos/seed/design6/800/600", true, "admin-001", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.72m, "Hand Lettering #6" },
                    { 7, "admin-001", "Vintage Camera design artwork", "admin-001", new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic vintage camera illustration", "design_7.jpg", "https://picsum.photos/seed/design7/800/600", true, "admin-001", new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.35m, "Vintage Camera #7" },
                    { 8, "admin-001", "Geometric Mandala design artwork", "admin-001", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intricate geometric mandala pattern", "design_8.jpg", "https://picsum.photos/seed/design8/800/600", true, "admin-001", new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.54m, "Geometric Mandala #8" },
                    { 9, "admin-001", "Colorful Spiral design artwork", "admin-001", new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vibrant spiral design with flowing colors", "design_9.jpg", "https://picsum.photos/seed/design9/800/600", true, "admin-001", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.47m, "Colorful Spiral #9" },
                    { 10, "admin-001", "Vintage Camera design artwork", "admin-001", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic vintage camera illustration", "design_10.jpg", "https://picsum.photos/seed/design10/800/600", true, "admin-001", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.29m, "Vintage Camera #10" },
                    { 11, "admin-001", "Coffee Lover design artwork", "admin-001", new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee-themed design for caffeine enthusiasts", "design_11.jpg", "https://picsum.photos/seed/design11/800/600", true, "admin-001", new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.19m, "Coffee Lover #11" },
                    { 12, "admin-001", "Forest Path design artwork", "admin-001", new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peaceful forest trail through tall trees", "design_12.jpg", "https://picsum.photos/seed/design12/800/600", true, "admin-001", new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.01m, "Forest Path #12" },
                    { 13, "admin-001", "Abstract Watercolor design artwork", "admin-001", new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flowing watercolor abstract composition", "design_13.jpg", "https://picsum.photos/seed/design13/800/600", true, "admin-001", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.32m, "Abstract Watercolor #13" },
                    { 14, "admin-001", "Geometric Mandala design artwork", "admin-001", new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intricate geometric mandala pattern", "design_14.jpg", "https://picsum.photos/seed/design14/800/600", true, "admin-001", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.84m, "Geometric Mandala #14" },
                    { 15, "admin-001", "Forest Path design artwork", "admin-001", new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peaceful forest trail through tall trees", "design_15.jpg", "https://picsum.photos/seed/design15/800/600", true, "admin-001", new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.65m, "Forest Path #15" },
                    { 16, "admin-001", "Minimalist Lines design artwork", "admin-001", new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean minimalist line art design", "design_16.jpg", "https://picsum.photos/seed/design16/800/600", true, "admin-001", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.92m, "Minimalist Lines #16" },
                    { 17, "admin-001", "Ocean Waves design artwork", "admin-001", new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful ocean waves crashing on shore", "design_17.jpg", "https://picsum.photos/seed/design17/800/600", true, "admin-001", new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.57m, "Ocean Waves #17" },
                    { 18, "admin-001", "Mountain Sunset design artwork", "admin-001", new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathtaking mountain landscape at sunset", "design_18.jpg", "https://picsum.photos/seed/design18/800/600", true, "admin-001", new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.51m, "Mountain Sunset #18" },
                    { 19, "admin-001", "Tropical Fish design artwork", "admin-001", new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorful tropical fish in coral reef", "design_19.jpg", "https://picsum.photos/seed/design19/800/600", true, "admin-001", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.63m, "Tropical Fish #19" },
                    { 20, "admin-001", "Mountain Sunset design artwork", "admin-001", new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathtaking mountain landscape at sunset", "design_20.jpg", "https://picsum.photos/seed/design20/800/600", true, "admin-001", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.23m, "Mountain Sunset #20" },
                    { 21, "admin-001", "Sketch Portrait design artwork", "admin-001", new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hand-drawn portrait sketch", "design_21.jpg", "https://picsum.photos/seed/design21/800/600", true, "admin-001", new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.69m, "Sketch Portrait #21" },
                    { 22, "admin-001", "Rocket Launch design artwork", "admin-001", new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocket launching into space", "design_22.jpg", "https://picsum.photos/seed/design22/800/600", true, "admin-001", new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.98m, "Rocket Launch #22" },
                    { 23, "admin-001", "Majestic Eagle design artwork", "admin-001", new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful eagle in flight", "design_23.jpg", "https://picsum.photos/seed/design23/800/600", true, "admin-001", new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.26m, "Majestic Eagle #23" },
                    { 24, "admin-001", "Motivational Quote design artwork", "admin-001", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inspirational typography design", "design_24.jpg", "https://picsum.photos/seed/design24/800/600", true, "admin-001", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.69m, "Motivational Quote #24" },
                    { 25, "admin-001", "Mountain Sunset design artwork", "admin-001", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathtaking mountain landscape at sunset", "design_25.jpg", "https://picsum.photos/seed/design25/800/600", true, "admin-001", new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.66m, "Mountain Sunset #25" },
                    { 26, "admin-001", "Space Station design artwork", "admin-001", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Futuristic space station in orbit", "design_26.jpg", "https://picsum.photos/seed/design26/800/600", true, "admin-001", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.83m, "Space Station #26" },
                    { 27, "admin-001", "Vintage Script design artwork", "admin-001", new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elegant vintage script typography", "design_27.jpg", "https://picsum.photos/seed/design27/800/600", true, "admin-001", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.19m, "Vintage Script #27" },
                    { 28, "admin-001", "Minimalist Lines design artwork", "admin-001", new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean minimalist line art design", "design_28.jpg", "https://picsum.photos/seed/design28/800/600", true, "admin-001", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.10m, "Minimalist Lines #28" },
                    { 29, "admin-001", "Coffee Lover design artwork", "admin-001", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee-themed design for caffeine enthusiasts", "design_29.jpg", "https://picsum.photos/seed/design29/800/600", true, "admin-001", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.72m, "Coffee Lover #29" },
                    { 30, "admin-001", "Butterfly Garden design artwork", "admin-001", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorful butterflies in blooming garden", "design_30.jpg", "https://picsum.photos/seed/design30/800/600", true, "admin-001", new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.21m, "Butterfly Garden #30" },
                    { 31, "admin-001", "Modern Sans Serif design artwork", "admin-001", new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean modern sans serif typography", "design_31.jpg", "https://picsum.photos/seed/design31/800/600", true, "admin-001", new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.22m, "Modern Sans Serif #31" },
                    { 32, "admin-001", "Geometric Triangles design artwork", "admin-001", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modern geometric triangle pattern", "design_32.jpg", "https://picsum.photos/seed/design32/800/600", true, "admin-001", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.73m, "Geometric Triangles #32" },
                    { 33, "admin-001", "Bold Typography design artwork", "admin-001", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Strong and impactful typography design", "design_33.jpg", "https://picsum.photos/seed/design33/800/600", true, "admin-001", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.95m, "Bold Typography #33" },
                    { 34, "admin-001", "Desert Cactus design artwork", "admin-001", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Majestic saguaro cactus in desert landscape", "design_34.jpg", "https://picsum.photos/seed/design34/800/600", true, "admin-001", new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.59m, "Desert Cactus #34" },
                    { 35, "admin-001", "Vintage Camera design artwork", "admin-001", new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic vintage camera illustration", "design_35.jpg", "https://picsum.photos/seed/design35/800/600", true, "admin-001", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.34m, "Vintage Camera #35" },
                    { 36, "admin-001", "Sketch Portrait design artwork", "admin-001", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hand-drawn portrait sketch", "design_36.jpg", "https://picsum.photos/seed/design36/800/600", true, "admin-001", new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.41m, "Sketch Portrait #36" },
                    { 37, "admin-001", "Geometric Triangles design artwork", "admin-001", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modern geometric triangle pattern", "design_37.jpg", "https://picsum.photos/seed/design37/800/600", true, "admin-001", new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.08m, "Geometric Triangles #37" },
                    { 38, "admin-001", "Colorful Spiral design artwork", "admin-001", new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vibrant spiral design with flowing colors", "design_38.jpg", "https://picsum.photos/seed/design38/800/600", true, "admin-001", new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.46m, "Colorful Spiral #38" },
                    { 39, "admin-001", "Abstract Watercolor design artwork", "admin-001", new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flowing watercolor abstract composition", "design_39.jpg", "https://picsum.photos/seed/design39/800/600", true, "admin-001", new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.90m, "Abstract Watercolor #39" },
                    { 40, "admin-001", "Autumn Leaves design artwork", "admin-001", new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorful autumn leaves falling gracefully", "design_40.jpg", "https://picsum.photos/seed/design40/800/600", true, "admin-001", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.49m, "Autumn Leaves #40" },
                    { 41, "admin-001", "Butterfly Garden design artwork", "admin-001", new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorful butterflies in blooming garden", "design_41.jpg", "https://picsum.photos/seed/design41/800/600", true, "admin-001", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.70m, "Butterfly Garden #41" },
                    { 42, "admin-001", "Galaxy Nebula design artwork", "admin-001", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stunning galaxy nebula in deep space", "design_42.jpg", "https://picsum.photos/seed/design42/800/600", true, "admin-001", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.05m, "Galaxy Nebula #42" },
                    { 43, "admin-001", "Modern Sans Serif design artwork", "admin-001", new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean modern sans serif typography", "design_43.jpg", "https://picsum.photos/seed/design43/800/600", true, "admin-001", new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.71m, "Modern Sans Serif #43" },
                    { 44, "admin-001", "Zen Circle design artwork", "admin-001", new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minimalist zen circle meditation", "design_44.jpg", "https://picsum.photos/seed/design44/800/600", true, "admin-001", new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.03m, "Zen Circle #44" },
                    { 45, "admin-001", "Mountain Sunset design artwork", "admin-001", new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathtaking mountain landscape at sunset", "design_45.jpg", "https://picsum.photos/seed/design45/800/600", true, "admin-001", new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.52m, "Mountain Sunset #45" },
                    { 46, "admin-001", "Bold Typography design artwork", "admin-001", new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Strong and impactful typography design", "design_46.jpg", "https://picsum.photos/seed/design46/800/600", true, "admin-001", new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.20m, "Bold Typography #46" },
                    { 47, "admin-001", "Sketch Portrait design artwork", "admin-001", new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hand-drawn portrait sketch", "design_47.jpg", "https://picsum.photos/seed/design47/800/600", true, "admin-001", new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.12m, "Sketch Portrait #47" },
                    { 48, "admin-001", "Vintage Script design artwork", "admin-001", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elegant vintage script typography", "design_48.jpg", "https://picsum.photos/seed/design48/800/600", true, "admin-001", new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.93m, "Vintage Script #48" },
                    { 49, "admin-001", "Vintage Camera design artwork", "admin-001", new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic vintage camera illustration", "design_49.jpg", "https://picsum.photos/seed/design49/800/600", true, "admin-001", new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.24m, "Vintage Camera #49" },
                    { 50, "admin-001", "Forest Wolf design artwork", "admin-001", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mysterious wolf in moonlit forest", "design_50.jpg", "https://picsum.photos/seed/design50/800/600", true, "admin-001", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.98m, "Forest Wolf #50" }
                });

            migrationBuilder.InsertData(
                table: "BaseProductColors",
                columns: new[] { "Id", "BaseProductId", "ColorId", "ColorSpecificMockupUrl", "IsActive" },
                values: new object[,]
                {
                    { 1, 1, 1, null, true },
                    { 2, 1, 2, null, true },
                    { 3, 1, 3, null, true },
                    { 4, 1, 4, null, true },
                    { 5, 1, 5, null, true },
                    { 6, 1, 6, null, true },
                    { 7, 1, 7, null, true },
                    { 8, 1, 8, null, true },
                    { 9, 2, 1, null, true },
                    { 10, 2, 2, null, true },
                    { 11, 2, 3, null, true },
                    { 12, 2, 4, null, true },
                    { 13, 2, 5, null, true },
                    { 14, 2, 6, null, true },
                    { 15, 2, 7, null, true },
                    { 16, 2, 8, null, true },
                    { 17, 3, 1, null, true },
                    { 18, 3, 2, null, true },
                    { 19, 3, 3, null, true },
                    { 20, 3, 4, null, true },
                    { 21, 3, 5, null, true },
                    { 22, 3, 6, null, true },
                    { 23, 3, 7, null, true },
                    { 24, 3, 8, null, true },
                    { 25, 4, 1, null, true },
                    { 26, 4, 2, null, true },
                    { 27, 4, 3, null, true },
                    { 28, 4, 4, null, true },
                    { 29, 4, 5, null, true },
                    { 30, 4, 6, null, true },
                    { 31, 5, 1, null, true },
                    { 32, 5, 2, null, true },
                    { 33, 5, 3, null, true },
                    { 34, 5, 4, null, true },
                    { 35, 5, 5, null, true },
                    { 36, 5, 6, null, true },
                    { 37, 6, 1, null, true },
                    { 38, 6, 2, null, true },
                    { 39, 6, 3, null, true },
                    { 40, 6, 4, null, true },
                    { 41, 6, 5, null, true },
                    { 42, 6, 6, null, true },
                    { 43, 6, 7, null, true },
                    { 44, 6, 8, null, true },
                    { 45, 7, 1, null, true },
                    { 46, 7, 2, null, true },
                    { 47, 7, 3, null, true },
                    { 48, 7, 4, null, true },
                    { 49, 7, 5, null, true },
                    { 50, 7, 6, null, true },
                    { 51, 7, 7, null, true },
                    { 52, 7, 8, null, true },
                    { 53, 8, 1, null, true },
                    { 54, 8, 2, null, true },
                    { 55, 8, 3, null, true },
                    { 56, 8, 4, null, true },
                    { 57, 8, 5, null, true },
                    { 58, 8, 6, null, true },
                    { 59, 9, 1, null, true },
                    { 60, 9, 2, null, true },
                    { 61, 9, 3, null, true },
                    { 62, 9, 4, null, true },
                    { 63, 9, 5, null, true },
                    { 64, 9, 6, null, true },
                    { 65, 12, 1, null, true },
                    { 66, 12, 2, null, true },
                    { 67, 12, 3, null, true },
                    { 68, 12, 4, null, true },
                    { 69, 12, 5, null, true },
                    { 70, 12, 6, null, true },
                    { 71, 12, 7, null, true },
                    { 72, 12, 8, null, true },
                    { 73, 13, 1, null, true },
                    { 74, 13, 2, null, true },
                    { 75, 13, 3, null, true },
                    { 76, 13, 4, null, true },
                    { 77, 13, 5, null, true },
                    { 78, 13, 6, null, true },
                    { 79, 13, 7, null, true },
                    { 80, 13, 8, null, true }
                });

            migrationBuilder.InsertData(
                table: "BaseProductPrintAreas",
                columns: new[] { "Id", "AreaName", "BaseProductId", "DisplayOrder", "Height", "IsActive", "MinDPI", "PositionX", "PositionY", "Width" },
                values: new object[,]
                {
                    { 1, "Front", 1, 1, 16.0m, true, 300, 100, 150, 12.0m },
                    { 2, "Back", 1, 2, 16.0m, true, 300, 100, 150, 12.0m },
                    { 3, "Front", 2, 1, 16.0m, true, 300, 100, 150, 12.0m },
                    { 4, "Back", 2, 2, 16.0m, true, 300, 100, 150, 12.0m },
                    { 5, "Front", 3, 1, 16.0m, true, 300, 100, 150, 12.0m },
                    { 6, "Back", 3, 2, 16.0m, true, 300, 100, 150, 12.0m },
                    { 7, "Front", 4, 1, 16.0m, true, 300, 100, 150, 12.0m },
                    { 8, "Back", 4, 2, 16.0m, true, 300, 100, 150, 12.0m },
                    { 9, "Front", 5, 1, 16.0m, true, 300, 100, 150, 12.0m },
                    { 10, "Back", 5, 2, 16.0m, true, 300, 100, 150, 12.0m },
                    { 11, "Front", 6, 1, 12.0m, true, 300, 100, 120, 10.0m },
                    { 12, "Back", 6, 2, 12.0m, true, 300, 100, 120, 10.0m },
                    { 13, "Front", 7, 1, 12.0m, true, 300, 100, 120, 10.0m },
                    { 14, "Back", 7, 2, 12.0m, true, 300, 100, 120, 10.0m },
                    { 15, "Front", 8, 1, 3.5m, true, 300, 50, 100, 8.0m },
                    { 16, "Front", 9, 1, 3.5m, true, 300, 50, 100, 8.0m }
                });

            migrationBuilder.InsertData(
                table: "BaseProductPrintAreas",
                columns: new[] { "Id", "AreaName", "BaseProductId", "DisplayOrder", "Height", "IsActive", "MinDPI", "Width" },
                values: new object[,]
                {
                    { 17, "Full", 10, 1, 24.0m, true, 300, 18.0m },
                    { 18, "Full", 11, 1, 24.0m, true, 300, 18.0m }
                });

            migrationBuilder.InsertData(
                table: "BaseProductPrintAreas",
                columns: new[] { "Id", "AreaName", "BaseProductId", "DisplayOrder", "Height", "IsActive", "MinDPI", "PositionX", "PositionY", "Width" },
                values: new object[,]
                {
                    { 19, "Back", 12, 1, 5.5m, true, 300, 25, 50, 3.0m },
                    { 20, "Back", 13, 1, 5.5m, true, 300, 25, 50, 3.0m }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "SizeId" },
                values: new object[,]
                {
                    { 1, 1, true, 1 },
                    { 2, 1, true, 2 },
                    { 3, 1, true, 3 },
                    { 4, 1, true, 4 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "PriceModifier", "SizeId" },
                values: new object[,]
                {
                    { 5, 1, true, 2.0m, 5 },
                    { 6, 1, true, 4.0m, 6 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "SizeId" },
                values: new object[,]
                {
                    { 7, 2, true, 1 },
                    { 8, 2, true, 2 },
                    { 9, 2, true, 3 },
                    { 10, 2, true, 4 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "PriceModifier", "SizeId" },
                values: new object[,]
                {
                    { 11, 2, true, 2.0m, 5 },
                    { 12, 2, true, 4.0m, 6 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "SizeId" },
                values: new object[,]
                {
                    { 13, 3, true, 1 },
                    { 14, 3, true, 2 },
                    { 15, 3, true, 3 },
                    { 16, 3, true, 4 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "PriceModifier", "SizeId" },
                values: new object[,]
                {
                    { 17, 3, true, 2.0m, 5 },
                    { 18, 3, true, 4.0m, 6 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "SizeId" },
                values: new object[,]
                {
                    { 19, 4, true, 1 },
                    { 20, 4, true, 2 },
                    { 21, 4, true, 3 },
                    { 22, 4, true, 4 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "PriceModifier", "SizeId" },
                values: new object[,]
                {
                    { 23, 4, true, 3.0m, 5 },
                    { 24, 4, true, 6.0m, 6 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "SizeId" },
                values: new object[,]
                {
                    { 25, 5, true, 1 },
                    { 26, 5, true, 2 },
                    { 27, 5, true, 3 },
                    { 28, 5, true, 4 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "PriceModifier", "SizeId" },
                values: new object[,]
                {
                    { 29, 5, true, 3.0m, 5 },
                    { 30, 5, true, 6.0m, 6 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "SizeId" },
                values: new object[,]
                {
                    { 31, 6, true, 1 },
                    { 32, 6, true, 2 },
                    { 33, 6, true, 3 },
                    { 34, 6, true, 4 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "PriceModifier", "SizeId" },
                values: new object[,]
                {
                    { 35, 6, true, 1.5m, 5 },
                    { 36, 6, true, 3.0m, 6 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "SizeId" },
                values: new object[,]
                {
                    { 37, 7, true, 1 },
                    { 38, 7, true, 2 },
                    { 39, 7, true, 3 },
                    { 40, 7, true, 4 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "PriceModifier", "SizeId" },
                values: new object[,]
                {
                    { 41, 7, true, 1.5m, 5 },
                    { 42, 7, true, 3.0m, 6 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "SizeId" },
                values: new object[] { 43, 10, true, 1 });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "PriceModifier", "SizeId" },
                values: new object[,]
                {
                    { 44, 10, true, 2.0m, 2 },
                    { 45, 10, true, 4.0m, 3 },
                    { 46, 10, true, 6.0m, 4 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "SizeId" },
                values: new object[] { 47, 11, true, 1 });

            migrationBuilder.InsertData(
                table: "BaseProductSizes",
                columns: new[] { "Id", "BaseProductId", "IsActive", "PriceModifier", "SizeId" },
                values: new object[,]
                {
                    { 48, 11, true, 2.0m, 2 },
                    { 49, 11, true, 4.0m, 3 },
                    { 50, 11, true, 6.0m, 4 }
                });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "IsPrimary", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[] { 1, 1, 1, "/mockups/tshirt-front-flat.jpg", true, true, "/mockups/tshirt-front-mockup.jpg", 1000, "/templates/tshirt-front-template.png", 800, "Front" });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[,]
                {
                    { 2, 1, 2, null, true, "/mockups/tshirt-back-mockup.jpg", 1000, "/templates/tshirt-back-template.png", 800, "Back" },
                    { 3, 1, 3, null, true, "/mockups/tshirt-side-mockup.jpg", 800, "/templates/tshirt-side-template.png", 600, "Side" }
                });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "IsPrimary", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[] { 4, 2, 1, "/mockups/tshirt-front-flat.jpg", true, true, "/mockups/tshirt-front-mockup.jpg", 1000, "/templates/tshirt-front-template.png", 800, "Front" });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[,]
                {
                    { 5, 2, 2, null, true, "/mockups/tshirt-back-mockup.jpg", 1000, "/templates/tshirt-back-template.png", 800, "Back" },
                    { 6, 2, 3, null, true, "/mockups/tshirt-side-mockup.jpg", 800, "/templates/tshirt-side-template.png", 600, "Side" }
                });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "IsPrimary", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[] { 7, 3, 1, "/mockups/tshirt-front-flat.jpg", true, true, "/mockups/tshirt-front-mockup.jpg", 1000, "/templates/tshirt-front-template.png", 800, "Front" });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[,]
                {
                    { 8, 3, 2, null, true, "/mockups/tshirt-back-mockup.jpg", 1000, "/templates/tshirt-back-template.png", 800, "Back" },
                    { 9, 3, 3, null, true, "/mockups/tshirt-side-mockup.jpg", 800, "/templates/tshirt-side-template.png", 600, "Side" }
                });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "IsPrimary", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[] { 10, 4, 1, null, true, true, "/mockups/hoodie-front-mockup.jpg", 1000, "/templates/hoodie-front-template.png", 800, "Front" });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[] { 11, 4, 2, null, true, "/mockups/hoodie-back-mockup.jpg", 1000, "/templates/hoodie-back-template.png", 800, "Back" });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "IsPrimary", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[] { 12, 5, 1, null, true, true, "/mockups/hoodie-front-mockup.jpg", 1000, "/templates/hoodie-front-template.png", 800, "Front" });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[] { 13, 5, 2, null, true, "/mockups/hoodie-back-mockup.jpg", 1000, "/templates/hoodie-back-template.png", 800, "Back" });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "IsPrimary", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[] { 14, 6, 1, null, true, true, "/mockups/tank-front-mockup.jpg", 800, "/templates/tank-front-template.png", 600, "Front" });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[] { 15, 6, 2, null, true, "/mockups/tank-back-mockup.jpg", 800, "/templates/tank-back-template.png", 600, "Back" });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "IsPrimary", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[] { 16, 7, 1, null, true, true, "/mockups/tank-front-mockup.jpg", 800, "/templates/tank-front-template.png", 600, "Front" });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[] { 17, 7, 2, null, true, "/mockups/tank-back-mockup.jpg", 800, "/templates/tank-back-template.png", 600, "Back" });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "IsPrimary", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[] { 18, 8, 1, null, true, true, "/mockups/mug-front-mockup.jpg", 500, "/templates/mug-front-template.png", 400, "Front" });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[] { 19, 8, 2, null, true, "/mockups/mug-side-mockup.jpg", 400, "/templates/mug-side-template.png", 300, "Side" });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "IsPrimary", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[] { 20, 9, 1, null, true, true, "/mockups/mug-front-mockup.jpg", 500, "/templates/mug-front-template.png", 400, "Front" });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[] { 21, 9, 2, null, true, "/mockups/mug-side-mockup.jpg", 400, "/templates/mug-side-template.png", 300, "Side" });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "IsPrimary", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[,]
                {
                    { 22, 10, 1, null, true, true, "/mockups/poster-mockup.jpg", 1600, "/templates/poster-template.png", 1200, "Front" },
                    { 23, 11, 1, null, true, true, "/mockups/poster-mockup.jpg", 1600, "/templates/poster-template.png", 1200, "Front" },
                    { 24, 12, 1, null, true, true, "/mockups/phone-case-mockup.jpg", 600, "/templates/phone-case-template.png", 300, "Back" },
                    { 25, 13, 1, null, true, true, "/mockups/phone-case-mockup.jpg", 600, "/templates/phone-case-template.png", 300, "Back" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "BaseProductId", "ColorId", "DesignId", "IsActive", "Price", "SizeId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, true, 27.70m, 1 },
                    { 2, 1, 1, 1, true, 25.69m, 2 },
                    { 3, 1, 1, 1, true, 25.03m, 3 },
                    { 4, 1, 1, 1, true, 27.32m, 4 },
                    { 5, 1, 1, 1, true, 22.49m, 5 },
                    { 6, 1, 1, 1, true, 22.33m, 6 },
                    { 7, 1, 2, 1, true, 23.31m, 1 },
                    { 8, 1, 2, 1, true, 23.25m, 2 },
                    { 9, 1, 2, 1, true, 24.34m, 3 },
                    { 10, 1, 2, 1, true, 24.54m, 4 },
                    { 11, 1, 2, 1, true, 23.44m, 5 },
                    { 12, 1, 2, 1, true, 24.83m, 6 },
                    { 13, 1, 3, 1, true, 22.65m, 1 },
                    { 14, 1, 3, 1, true, 26.23m, 2 },
                    { 15, 1, 3, 1, true, 23.01m, 3 },
                    { 16, 1, 3, 1, true, 26.86m, 4 },
                    { 17, 1, 3, 1, true, 25.27m, 5 },
                    { 18, 1, 3, 1, true, 26.28m, 6 },
                    { 19, 1, 4, 1, true, 22.12m, 1 },
                    { 20, 1, 4, 1, true, 27.27m, 2 },
                    { 21, 1, 4, 1, true, 24.43m, 3 },
                    { 22, 1, 4, 1, true, 26.32m, 4 },
                    { 23, 1, 4, 1, true, 22.34m, 5 },
                    { 24, 1, 4, 1, true, 24.00m, 6 },
                    { 25, 1, 5, 1, true, 24.33m, 1 },
                    { 26, 1, 5, 1, true, 26.90m, 2 },
                    { 27, 1, 5, 1, true, 27.91m, 3 },
                    { 28, 1, 5, 1, true, 23.36m, 4 },
                    { 29, 1, 5, 1, true, 24.99m, 5 },
                    { 30, 1, 5, 1, true, 23.94m, 6 },
                    { 31, 1, 6, 1, true, 25.18m, 1 },
                    { 32, 1, 6, 1, true, 25.39m, 2 },
                    { 33, 1, 6, 1, true, 25.98m, 3 },
                    { 34, 1, 6, 1, true, 24.51m, 4 },
                    { 35, 1, 6, 1, true, 27.20m, 5 },
                    { 36, 1, 6, 1, true, 25.14m, 6 },
                    { 37, 1, 7, 1, true, 26.54m, 1 },
                    { 38, 1, 7, 1, true, 22.86m, 2 },
                    { 39, 1, 7, 1, true, 24.59m, 3 },
                    { 40, 1, 7, 1, true, 27.24m, 4 },
                    { 41, 1, 7, 1, true, 25.44m, 5 },
                    { 42, 1, 7, 1, true, 24.41m, 6 },
                    { 43, 1, 8, 1, true, 22.10m, 1 },
                    { 44, 1, 8, 1, true, 27.25m, 2 },
                    { 45, 1, 8, 1, true, 23.95m, 3 },
                    { 46, 1, 8, 1, true, 24.19m, 4 },
                    { 47, 1, 8, 1, true, 24.86m, 5 },
                    { 48, 1, 8, 1, true, 25.60m, 6 },
                    { 49, 1, 1, 2, true, 26.16m, 1 },
                    { 50, 1, 1, 2, true, 24.93m, 2 },
                    { 51, 1, 1, 2, true, 24.32m, 3 },
                    { 52, 1, 1, 2, true, 23.42m, 4 },
                    { 53, 1, 1, 2, true, 22.12m, 5 },
                    { 54, 1, 1, 2, true, 24.31m, 6 },
                    { 55, 1, 2, 2, true, 24.99m, 1 },
                    { 56, 1, 2, 2, true, 23.37m, 2 },
                    { 57, 1, 2, 2, true, 25.34m, 3 },
                    { 58, 1, 2, 2, true, 23.02m, 4 },
                    { 59, 1, 2, 2, true, 24.98m, 5 },
                    { 60, 1, 2, 2, true, 23.58m, 6 },
                    { 61, 1, 3, 2, true, 22.41m, 1 },
                    { 62, 1, 3, 2, true, 27.94m, 2 },
                    { 63, 1, 3, 2, true, 26.25m, 3 },
                    { 64, 1, 3, 2, true, 22.39m, 4 },
                    { 65, 1, 3, 2, true, 27.34m, 5 },
                    { 66, 1, 3, 2, true, 26.04m, 6 },
                    { 67, 1, 4, 2, true, 26.83m, 1 },
                    { 68, 1, 4, 2, true, 26.13m, 2 },
                    { 69, 1, 4, 2, true, 27.02m, 3 },
                    { 70, 1, 4, 2, true, 25.86m, 4 },
                    { 71, 1, 4, 2, true, 22.32m, 5 },
                    { 72, 1, 4, 2, true, 24.40m, 6 },
                    { 73, 1, 5, 2, true, 23.68m, 1 },
                    { 74, 1, 5, 2, true, 22.86m, 2 },
                    { 75, 1, 5, 2, true, 23.82m, 3 },
                    { 76, 1, 5, 2, true, 22.00m, 4 },
                    { 77, 1, 5, 2, true, 26.21m, 5 },
                    { 78, 1, 5, 2, true, 23.08m, 6 },
                    { 79, 1, 6, 2, true, 22.04m, 1 },
                    { 80, 1, 6, 2, true, 22.13m, 2 },
                    { 81, 1, 6, 2, true, 24.03m, 3 },
                    { 82, 1, 6, 2, true, 24.31m, 4 },
                    { 83, 1, 6, 2, true, 25.19m, 5 },
                    { 84, 1, 6, 2, true, 22.05m, 6 },
                    { 85, 1, 7, 2, true, 27.61m, 1 },
                    { 86, 1, 7, 2, true, 23.75m, 2 },
                    { 87, 1, 7, 2, true, 25.26m, 3 },
                    { 88, 1, 7, 2, true, 23.66m, 4 },
                    { 89, 1, 7, 2, true, 27.52m, 5 },
                    { 90, 1, 7, 2, true, 25.82m, 6 },
                    { 91, 1, 8, 2, true, 27.79m, 1 },
                    { 92, 1, 8, 2, true, 25.50m, 2 },
                    { 93, 1, 8, 2, true, 25.87m, 3 },
                    { 94, 1, 8, 2, true, 23.00m, 4 },
                    { 95, 1, 8, 2, true, 26.83m, 5 },
                    { 96, 1, 8, 2, true, 25.49m, 6 },
                    { 97, 1, 1, 3, true, 26.15m, 1 },
                    { 98, 1, 1, 3, true, 27.69m, 2 },
                    { 99, 1, 1, 3, true, 27.90m, 3 },
                    { 100, 1, 1, 3, true, 25.91m, 4 },
                    { 101, 1, 1, 3, true, 25.35m, 5 },
                    { 102, 1, 1, 3, true, 26.72m, 6 },
                    { 103, 1, 2, 3, true, 26.57m, 1 },
                    { 104, 1, 2, 3, true, 22.30m, 2 },
                    { 105, 1, 2, 3, true, 24.61m, 3 },
                    { 106, 1, 2, 3, true, 27.91m, 4 },
                    { 107, 1, 2, 3, true, 27.73m, 5 },
                    { 108, 1, 2, 3, true, 27.24m, 6 },
                    { 109, 1, 3, 3, true, 22.48m, 1 },
                    { 110, 1, 3, 3, true, 24.97m, 2 },
                    { 111, 1, 3, 3, true, 25.15m, 3 },
                    { 112, 1, 3, 3, true, 24.25m, 4 },
                    { 113, 1, 3, 3, true, 22.98m, 5 },
                    { 114, 1, 3, 3, true, 24.83m, 6 },
                    { 115, 1, 4, 3, true, 27.55m, 1 },
                    { 116, 1, 4, 3, true, 26.09m, 2 },
                    { 117, 1, 4, 3, true, 24.73m, 3 },
                    { 118, 1, 4, 3, true, 26.20m, 4 },
                    { 119, 1, 4, 3, true, 22.77m, 5 },
                    { 120, 1, 4, 3, true, 25.58m, 6 },
                    { 121, 1, 5, 3, true, 22.76m, 1 },
                    { 122, 1, 5, 3, true, 25.16m, 2 },
                    { 123, 1, 5, 3, true, 26.60m, 3 },
                    { 124, 1, 5, 3, true, 23.19m, 4 },
                    { 125, 1, 5, 3, true, 26.05m, 5 },
                    { 126, 1, 5, 3, true, 24.80m, 6 },
                    { 127, 1, 6, 3, true, 26.52m, 1 },
                    { 128, 1, 6, 3, true, 22.67m, 2 },
                    { 129, 1, 6, 3, true, 24.03m, 3 },
                    { 130, 1, 6, 3, true, 26.32m, 4 },
                    { 131, 1, 6, 3, true, 23.84m, 5 },
                    { 132, 1, 6, 3, true, 26.51m, 6 },
                    { 133, 1, 7, 3, true, 23.18m, 1 },
                    { 134, 1, 7, 3, true, 24.12m, 2 },
                    { 135, 1, 7, 3, true, 24.78m, 3 },
                    { 136, 1, 7, 3, true, 25.30m, 4 },
                    { 137, 1, 7, 3, true, 25.73m, 5 },
                    { 138, 1, 7, 3, true, 24.89m, 6 },
                    { 139, 1, 8, 3, true, 25.43m, 1 },
                    { 140, 1, 8, 3, true, 27.70m, 2 },
                    { 141, 1, 8, 3, true, 24.01m, 3 },
                    { 142, 1, 8, 3, true, 26.01m, 4 },
                    { 143, 1, 8, 3, true, 23.17m, 5 },
                    { 144, 1, 8, 3, true, 24.53m, 6 },
                    { 145, 1, 1, 4, true, 22.65m, 1 },
                    { 146, 1, 1, 4, true, 25.54m, 2 },
                    { 147, 1, 1, 4, true, 24.52m, 3 },
                    { 148, 1, 1, 4, true, 23.03m, 4 },
                    { 149, 1, 1, 4, true, 23.44m, 5 },
                    { 150, 1, 1, 4, true, 22.73m, 6 },
                    { 151, 1, 2, 4, true, 22.75m, 1 },
                    { 152, 1, 2, 4, true, 27.94m, 2 },
                    { 153, 1, 2, 4, true, 26.91m, 3 },
                    { 154, 1, 2, 4, true, 24.31m, 4 },
                    { 155, 1, 2, 4, true, 25.13m, 5 },
                    { 156, 1, 2, 4, true, 22.17m, 6 },
                    { 157, 1, 3, 4, true, 22.11m, 1 },
                    { 158, 1, 3, 4, true, 25.37m, 2 },
                    { 159, 1, 3, 4, true, 24.23m, 3 },
                    { 160, 1, 3, 4, true, 27.80m, 4 },
                    { 161, 1, 3, 4, true, 23.38m, 5 },
                    { 162, 1, 3, 4, true, 27.06m, 6 },
                    { 163, 1, 4, 4, true, 25.21m, 1 },
                    { 164, 1, 4, 4, true, 24.15m, 2 },
                    { 165, 1, 4, 4, true, 23.12m, 3 },
                    { 166, 1, 4, 4, true, 26.63m, 4 },
                    { 167, 1, 4, 4, true, 23.06m, 5 },
                    { 168, 1, 4, 4, true, 26.85m, 6 },
                    { 169, 1, 5, 4, true, 22.04m, 1 },
                    { 170, 1, 5, 4, true, 24.24m, 2 },
                    { 171, 1, 5, 4, true, 22.35m, 3 },
                    { 172, 1, 5, 4, true, 27.84m, 4 },
                    { 173, 1, 5, 4, true, 22.76m, 5 },
                    { 174, 1, 5, 4, true, 23.06m, 6 },
                    { 175, 1, 6, 4, true, 23.56m, 1 },
                    { 176, 1, 6, 4, true, 24.74m, 2 },
                    { 177, 1, 6, 4, true, 23.99m, 3 },
                    { 178, 1, 6, 4, true, 24.06m, 4 },
                    { 179, 1, 6, 4, true, 22.53m, 5 },
                    { 180, 1, 6, 4, true, 22.51m, 6 },
                    { 181, 1, 7, 4, true, 22.28m, 1 },
                    { 182, 1, 7, 4, true, 25.48m, 2 },
                    { 183, 1, 7, 4, true, 27.21m, 3 },
                    { 184, 1, 7, 4, true, 23.29m, 4 },
                    { 185, 1, 7, 4, true, 25.57m, 5 },
                    { 186, 1, 7, 4, true, 23.89m, 6 },
                    { 187, 1, 8, 4, true, 27.59m, 1 },
                    { 188, 1, 8, 4, true, 26.86m, 2 },
                    { 189, 1, 8, 4, true, 26.98m, 3 },
                    { 190, 1, 8, 4, true, 24.60m, 4 },
                    { 191, 1, 8, 4, true, 25.18m, 5 },
                    { 192, 1, 8, 4, true, 22.35m, 6 },
                    { 193, 1, 1, 5, true, 22.64m, 1 },
                    { 194, 1, 1, 5, true, 25.62m, 2 },
                    { 195, 1, 1, 5, true, 26.31m, 3 },
                    { 196, 1, 1, 5, true, 24.95m, 4 },
                    { 197, 1, 1, 5, true, 22.79m, 5 },
                    { 198, 1, 1, 5, true, 27.01m, 6 },
                    { 199, 1, 2, 5, true, 23.40m, 1 },
                    { 200, 1, 2, 5, true, 24.01m, 2 },
                    { 201, 1, 2, 5, true, 24.47m, 3 },
                    { 202, 1, 2, 5, true, 25.66m, 4 },
                    { 203, 1, 2, 5, true, 22.98m, 5 },
                    { 204, 1, 2, 5, true, 27.19m, 6 },
                    { 205, 1, 3, 5, true, 22.36m, 1 },
                    { 206, 1, 3, 5, true, 22.90m, 2 },
                    { 207, 1, 3, 5, true, 27.18m, 3 },
                    { 208, 1, 3, 5, true, 25.84m, 4 },
                    { 209, 1, 3, 5, true, 22.74m, 5 },
                    { 210, 1, 3, 5, true, 22.38m, 6 },
                    { 211, 1, 4, 5, true, 26.17m, 1 },
                    { 212, 1, 4, 5, true, 26.04m, 2 },
                    { 213, 1, 4, 5, true, 24.83m, 3 },
                    { 214, 1, 4, 5, true, 23.72m, 4 },
                    { 215, 1, 4, 5, true, 27.51m, 5 },
                    { 216, 1, 4, 5, true, 25.89m, 6 },
                    { 217, 1, 5, 5, true, 27.83m, 1 },
                    { 218, 1, 5, 5, true, 23.91m, 2 },
                    { 219, 1, 5, 5, true, 26.57m, 3 },
                    { 220, 1, 5, 5, true, 27.22m, 4 },
                    { 221, 1, 5, 5, true, 27.04m, 5 },
                    { 222, 1, 5, 5, true, 24.19m, 6 },
                    { 223, 1, 6, 5, true, 27.86m, 1 },
                    { 224, 1, 6, 5, true, 25.43m, 2 },
                    { 225, 1, 6, 5, true, 27.05m, 3 },
                    { 226, 1, 6, 5, true, 21.99m, 4 },
                    { 227, 1, 6, 5, true, 27.18m, 5 },
                    { 228, 1, 6, 5, true, 25.12m, 6 },
                    { 229, 1, 7, 5, true, 24.75m, 1 },
                    { 230, 1, 7, 5, true, 26.60m, 2 },
                    { 231, 1, 7, 5, true, 23.94m, 3 },
                    { 232, 1, 7, 5, true, 24.97m, 4 },
                    { 233, 1, 7, 5, true, 22.65m, 5 },
                    { 234, 1, 7, 5, true, 26.51m, 6 },
                    { 235, 1, 8, 5, true, 26.03m, 1 },
                    { 236, 1, 8, 5, true, 24.61m, 2 },
                    { 237, 1, 8, 5, true, 24.49m, 3 },
                    { 238, 1, 8, 5, true, 22.01m, 4 },
                    { 239, 1, 8, 5, true, 22.92m, 5 },
                    { 240, 1, 8, 5, true, 24.66m, 6 },
                    { 241, 1, 1, 6, true, 24.70m, 1 },
                    { 242, 1, 1, 6, true, 23.74m, 2 },
                    { 243, 1, 1, 6, true, 26.11m, 3 },
                    { 244, 1, 1, 6, true, 26.59m, 4 },
                    { 245, 1, 1, 6, true, 26.42m, 5 },
                    { 246, 1, 1, 6, true, 27.13m, 6 },
                    { 247, 1, 2, 6, true, 25.51m, 1 },
                    { 248, 1, 2, 6, true, 26.92m, 2 },
                    { 249, 1, 2, 6, true, 26.10m, 3 },
                    { 250, 1, 2, 6, true, 22.41m, 4 },
                    { 251, 1, 2, 6, true, 25.10m, 5 },
                    { 252, 1, 2, 6, true, 26.87m, 6 },
                    { 253, 1, 3, 6, true, 22.43m, 1 },
                    { 254, 1, 3, 6, true, 24.17m, 2 },
                    { 255, 1, 3, 6, true, 24.97m, 3 },
                    { 256, 1, 3, 6, true, 22.27m, 4 },
                    { 257, 1, 3, 6, true, 25.79m, 5 },
                    { 258, 1, 3, 6, true, 25.53m, 6 },
                    { 259, 1, 4, 6, true, 22.13m, 1 },
                    { 260, 1, 4, 6, true, 22.36m, 2 },
                    { 261, 1, 4, 6, true, 23.71m, 3 },
                    { 262, 1, 4, 6, true, 24.04m, 4 },
                    { 263, 1, 4, 6, true, 23.08m, 5 },
                    { 264, 1, 4, 6, true, 24.13m, 6 },
                    { 265, 1, 5, 6, true, 26.43m, 1 },
                    { 266, 1, 5, 6, true, 23.20m, 2 },
                    { 267, 1, 5, 6, true, 25.38m, 3 },
                    { 268, 1, 5, 6, true, 26.31m, 4 },
                    { 269, 1, 5, 6, true, 25.67m, 5 },
                    { 270, 1, 5, 6, true, 24.89m, 6 },
                    { 271, 1, 6, 6, true, 23.39m, 1 },
                    { 272, 1, 6, 6, true, 27.81m, 2 },
                    { 273, 1, 6, 6, true, 22.98m, 3 },
                    { 274, 1, 6, 6, true, 23.91m, 4 },
                    { 275, 1, 6, 6, true, 24.51m, 5 },
                    { 276, 1, 6, 6, true, 25.29m, 6 },
                    { 277, 1, 7, 6, true, 26.07m, 1 },
                    { 278, 1, 7, 6, true, 23.26m, 2 },
                    { 279, 1, 7, 6, true, 27.01m, 3 },
                    { 280, 1, 7, 6, true, 27.92m, 4 },
                    { 281, 1, 7, 6, true, 24.47m, 5 },
                    { 282, 1, 7, 6, true, 22.26m, 6 },
                    { 283, 1, 8, 6, true, 27.01m, 1 },
                    { 284, 1, 8, 6, true, 24.33m, 2 },
                    { 285, 1, 8, 6, true, 23.49m, 3 },
                    { 286, 1, 8, 6, true, 25.06m, 4 },
                    { 287, 1, 8, 6, true, 24.53m, 5 },
                    { 288, 1, 8, 6, true, 26.47m, 6 },
                    { 289, 1, 1, 7, true, 23.53m, 1 },
                    { 290, 1, 1, 7, true, 25.76m, 2 },
                    { 291, 1, 1, 7, true, 26.81m, 3 },
                    { 292, 1, 1, 7, true, 26.95m, 4 },
                    { 293, 1, 1, 7, true, 27.87m, 5 },
                    { 294, 1, 1, 7, true, 22.55m, 6 },
                    { 295, 1, 2, 7, true, 22.94m, 1 },
                    { 296, 1, 2, 7, true, 22.65m, 2 },
                    { 297, 1, 2, 7, true, 22.65m, 3 },
                    { 298, 1, 2, 7, true, 23.97m, 4 },
                    { 299, 1, 2, 7, true, 22.14m, 5 },
                    { 300, 1, 2, 7, true, 25.21m, 6 },
                    { 301, 1, 3, 7, true, 23.73m, 1 },
                    { 302, 1, 3, 7, true, 27.19m, 2 },
                    { 303, 1, 3, 7, true, 23.23m, 3 },
                    { 304, 1, 3, 7, true, 23.20m, 4 },
                    { 305, 1, 3, 7, true, 27.01m, 5 },
                    { 306, 1, 3, 7, true, 25.29m, 6 },
                    { 307, 1, 4, 7, true, 25.88m, 1 },
                    { 308, 1, 4, 7, true, 26.51m, 2 },
                    { 309, 1, 4, 7, true, 27.65m, 3 },
                    { 310, 1, 4, 7, true, 27.67m, 4 },
                    { 311, 1, 4, 7, true, 24.18m, 5 },
                    { 312, 1, 4, 7, true, 24.52m, 6 },
                    { 313, 1, 5, 7, true, 26.51m, 1 },
                    { 314, 1, 5, 7, true, 22.20m, 2 },
                    { 315, 1, 5, 7, true, 25.88m, 3 },
                    { 316, 1, 5, 7, true, 23.44m, 4 },
                    { 317, 1, 5, 7, true, 25.02m, 5 },
                    { 318, 1, 5, 7, true, 26.74m, 6 },
                    { 319, 1, 6, 7, true, 22.63m, 1 },
                    { 320, 1, 6, 7, true, 23.37m, 2 },
                    { 321, 1, 6, 7, true, 26.65m, 3 },
                    { 322, 1, 6, 7, true, 26.91m, 4 },
                    { 323, 1, 6, 7, true, 24.77m, 5 },
                    { 324, 1, 6, 7, true, 27.91m, 6 },
                    { 325, 1, 7, 7, true, 26.07m, 1 },
                    { 326, 1, 7, 7, true, 24.43m, 2 },
                    { 327, 1, 7, 7, true, 27.93m, 3 },
                    { 328, 1, 7, 7, true, 22.42m, 4 },
                    { 329, 1, 7, 7, true, 22.96m, 5 },
                    { 330, 1, 7, 7, true, 23.85m, 6 },
                    { 331, 1, 8, 7, true, 24.63m, 1 },
                    { 332, 1, 8, 7, true, 24.09m, 2 },
                    { 333, 1, 8, 7, true, 23.11m, 3 },
                    { 334, 1, 8, 7, true, 23.79m, 4 },
                    { 335, 1, 8, 7, true, 26.18m, 5 },
                    { 336, 1, 8, 7, true, 25.28m, 6 },
                    { 337, 1, 1, 8, true, 27.01m, 1 },
                    { 338, 1, 1, 8, true, 25.80m, 2 },
                    { 339, 1, 1, 8, true, 25.31m, 3 },
                    { 340, 1, 1, 8, true, 26.19m, 4 },
                    { 341, 1, 1, 8, true, 27.16m, 5 },
                    { 342, 1, 1, 8, true, 26.01m, 6 },
                    { 343, 1, 2, 8, true, 26.81m, 1 },
                    { 344, 1, 2, 8, true, 23.85m, 2 },
                    { 345, 1, 2, 8, true, 23.56m, 3 },
                    { 346, 1, 2, 8, true, 24.28m, 4 },
                    { 347, 1, 2, 8, true, 22.43m, 5 },
                    { 348, 1, 2, 8, true, 27.66m, 6 },
                    { 349, 1, 3, 8, true, 24.66m, 1 },
                    { 350, 1, 3, 8, true, 27.49m, 2 },
                    { 351, 1, 3, 8, true, 25.62m, 3 },
                    { 352, 1, 3, 8, true, 23.89m, 4 },
                    { 353, 1, 3, 8, true, 23.32m, 5 },
                    { 354, 1, 3, 8, true, 26.77m, 6 },
                    { 355, 1, 4, 8, true, 26.54m, 1 },
                    { 356, 1, 4, 8, true, 24.82m, 2 },
                    { 357, 1, 4, 8, true, 24.40m, 3 },
                    { 358, 1, 4, 8, true, 23.31m, 4 },
                    { 359, 1, 4, 8, true, 25.12m, 5 },
                    { 360, 1, 4, 8, true, 24.57m, 6 },
                    { 361, 1, 5, 8, true, 25.35m, 1 },
                    { 362, 1, 5, 8, true, 25.45m, 2 },
                    { 363, 1, 5, 8, true, 25.54m, 3 },
                    { 364, 1, 5, 8, true, 25.79m, 4 },
                    { 365, 1, 5, 8, true, 25.02m, 5 },
                    { 366, 1, 5, 8, true, 22.08m, 6 },
                    { 367, 1, 6, 8, true, 23.40m, 1 },
                    { 368, 1, 6, 8, true, 24.71m, 2 },
                    { 369, 1, 6, 8, true, 24.02m, 3 },
                    { 370, 1, 6, 8, true, 22.59m, 4 },
                    { 371, 1, 6, 8, true, 24.42m, 5 },
                    { 372, 1, 6, 8, true, 27.22m, 6 },
                    { 373, 1, 7, 8, true, 23.42m, 1 },
                    { 374, 1, 7, 8, true, 24.43m, 2 },
                    { 375, 1, 7, 8, true, 24.19m, 3 },
                    { 376, 1, 7, 8, true, 22.63m, 4 },
                    { 377, 1, 7, 8, true, 22.09m, 5 },
                    { 378, 1, 7, 8, true, 22.91m, 6 },
                    { 379, 1, 8, 8, true, 26.34m, 1 },
                    { 380, 1, 8, 8, true, 23.78m, 2 },
                    { 381, 1, 8, 8, true, 23.99m, 3 },
                    { 382, 1, 8, 8, true, 22.26m, 4 },
                    { 383, 1, 8, 8, true, 25.75m, 5 },
                    { 384, 1, 8, 8, true, 23.45m, 6 },
                    { 385, 1, 1, 9, true, 26.22m, 1 },
                    { 386, 1, 1, 9, true, 22.73m, 2 },
                    { 387, 1, 1, 9, true, 22.76m, 3 },
                    { 388, 1, 1, 9, true, 24.33m, 4 },
                    { 389, 1, 1, 9, true, 25.24m, 5 },
                    { 390, 1, 1, 9, true, 23.35m, 6 },
                    { 391, 1, 2, 9, true, 22.87m, 1 },
                    { 392, 1, 2, 9, true, 25.69m, 2 },
                    { 393, 1, 2, 9, true, 22.67m, 3 },
                    { 394, 1, 2, 9, true, 22.73m, 4 },
                    { 395, 1, 2, 9, true, 22.83m, 5 },
                    { 396, 1, 2, 9, true, 23.70m, 6 },
                    { 397, 1, 3, 9, true, 22.46m, 1 },
                    { 398, 1, 3, 9, true, 23.01m, 2 },
                    { 399, 1, 3, 9, true, 26.82m, 3 },
                    { 400, 1, 3, 9, true, 23.48m, 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1, "Product variant 1 mockup view 1", "variant_1_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 1 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 2, "Product variant 1 mockup view 2", "variant_1_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 1 },
                    { 3, "Product variant 1 mockup view 3", "variant_1_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 4, "Product variant 2 mockup view 1", "variant_2_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 2 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 5, "Product variant 2 mockup view 2", "variant_2_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 2 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 7, "Product variant 3 mockup view 1", "variant_3_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 3 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 8, "Product variant 3 mockup view 2", "variant_3_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 3 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 10, "Product variant 4 mockup view 1", "variant_4_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 4 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 11, "Product variant 4 mockup view 2", "variant_4_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 4 },
                    { 12, "Product variant 4 mockup view 3", "variant_4_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 13, "Product variant 5 mockup view 1", "variant_5_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 5 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 14, "Product variant 5 mockup view 2", "variant_5_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 5 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 16, "Product variant 6 mockup view 1", "variant_6_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 6 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 17, "Product variant 6 mockup view 2", "variant_6_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 6 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 19, "Product variant 7 mockup view 1", "variant_7_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 7 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 20, "Product variant 7 mockup view 2", "variant_7_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 7 },
                    { 21, "Product variant 7 mockup view 3", "variant_7_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 7 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 22, "Product variant 8 mockup view 1", "variant_8_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 8 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 23, "Product variant 8 mockup view 2", "variant_8_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 8 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 25, "Product variant 9 mockup view 1", "variant_9_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 9 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 26, "Product variant 9 mockup view 2", "variant_9_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 9 },
                    { 27, "Product variant 9 mockup view 3", "variant_9_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 9 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 28, "Product variant 10 mockup view 1", "variant_10_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 10 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 29, "Product variant 10 mockup view 2", "variant_10_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 10 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 31, "Product variant 11 mockup view 1", "variant_11_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 11 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 32, "Product variant 11 mockup view 2", "variant_11_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 11 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 34, "Product variant 12 mockup view 1", "variant_12_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 12 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 35, "Product variant 12 mockup view 2", "variant_12_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 12 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 37, "Product variant 13 mockup view 1", "variant_13_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 13 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 38, "Product variant 13 mockup view 2", "variant_13_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 13 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 40, "Product variant 14 mockup view 1", "variant_14_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 14 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 41, "Product variant 14 mockup view 2", "variant_14_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 14 },
                    { 42, "Product variant 14 mockup view 3", "variant_14_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 14 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 43, "Product variant 15 mockup view 1", "variant_15_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 15 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 44, "Product variant 15 mockup view 2", "variant_15_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 15 },
                    { 45, "Product variant 15 mockup view 3", "variant_15_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 15 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 46, "Product variant 16 mockup view 1", "variant_16_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 16 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 47, "Product variant 16 mockup view 2", "variant_16_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 16 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 49, "Product variant 17 mockup view 1", "variant_17_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 17 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 50, "Product variant 17 mockup view 2", "variant_17_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 17 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 52, "Product variant 18 mockup view 1", "variant_18_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 18 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 53, "Product variant 18 mockup view 2", "variant_18_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 18 },
                    { 54, "Product variant 18 mockup view 3", "variant_18_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 18 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 55, "Product variant 19 mockup view 1", "variant_19_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 19 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 56, "Product variant 19 mockup view 2", "variant_19_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 19 },
                    { 57, "Product variant 19 mockup view 3", "variant_19_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 19 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 58, "Product variant 20 mockup view 1", "variant_20_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 20 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 59, "Product variant 20 mockup view 2", "variant_20_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 20 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 61, "Product variant 21 mockup view 1", "variant_21_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 21 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 62, "Product variant 21 mockup view 2", "variant_21_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 21 },
                    { 63, "Product variant 21 mockup view 3", "variant_21_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 21 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 64, "Product variant 22 mockup view 1", "variant_22_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 22 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 65, "Product variant 22 mockup view 2", "variant_22_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 22 },
                    { 66, "Product variant 22 mockup view 3", "variant_22_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 22 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 67, "Product variant 23 mockup view 1", "variant_23_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 23 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 68, "Product variant 23 mockup view 2", "variant_23_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 23 },
                    { 69, "Product variant 23 mockup view 3", "variant_23_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 23 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 70, "Product variant 24 mockup view 1", "variant_24_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 24 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 71, "Product variant 24 mockup view 2", "variant_24_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 24 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 73, "Product variant 25 mockup view 1", "variant_25_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 25 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 74, "Product variant 25 mockup view 2", "variant_25_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 25 },
                    { 75, "Product variant 25 mockup view 3", "variant_25_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 25 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 76, "Product variant 26 mockup view 1", "variant_26_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 26 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 77, "Product variant 26 mockup view 2", "variant_26_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 26 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 79, "Product variant 27 mockup view 1", "variant_27_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 27 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 80, "Product variant 27 mockup view 2", "variant_27_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 27 },
                    { 81, "Product variant 27 mockup view 3", "variant_27_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 27 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 82, "Product variant 28 mockup view 1", "variant_28_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 28 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 83, "Product variant 28 mockup view 2", "variant_28_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 28 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 85, "Product variant 29 mockup view 1", "variant_29_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 29 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 86, "Product variant 29 mockup view 2", "variant_29_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 29 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 88, "Product variant 30 mockup view 1", "variant_30_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 30 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 89, "Product variant 30 mockup view 2", "variant_30_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 30 },
                    { 90, "Product variant 30 mockup view 3", "variant_30_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 30 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 91, "Product variant 31 mockup view 1", "variant_31_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 31 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 92, "Product variant 31 mockup view 2", "variant_31_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 31 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 94, "Product variant 32 mockup view 1", "variant_32_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 32 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 95, "Product variant 32 mockup view 2", "variant_32_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 32 },
                    { 96, "Product variant 32 mockup view 3", "variant_32_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 32 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 97, "Product variant 33 mockup view 1", "variant_33_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 33 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 98, "Product variant 33 mockup view 2", "variant_33_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 33 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 100, "Product variant 34 mockup view 1", "variant_34_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 34 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 101, "Product variant 34 mockup view 2", "variant_34_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 34 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 103, "Product variant 35 mockup view 1", "variant_35_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 35 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 104, "Product variant 35 mockup view 2", "variant_35_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 35 },
                    { 105, "Product variant 35 mockup view 3", "variant_35_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 35 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 106, "Product variant 36 mockup view 1", "variant_36_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 36 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 107, "Product variant 36 mockup view 2", "variant_36_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 36 },
                    { 108, "Product variant 36 mockup view 3", "variant_36_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 36 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 109, "Product variant 37 mockup view 1", "variant_37_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 37 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 110, "Product variant 37 mockup view 2", "variant_37_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 37 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 112, "Product variant 38 mockup view 1", "variant_38_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 38 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 113, "Product variant 38 mockup view 2", "variant_38_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 38 },
                    { 114, "Product variant 38 mockup view 3", "variant_38_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 38 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 115, "Product variant 39 mockup view 1", "variant_39_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 39 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 116, "Product variant 39 mockup view 2", "variant_39_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 39 },
                    { 117, "Product variant 39 mockup view 3", "variant_39_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 39 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 118, "Product variant 40 mockup view 1", "variant_40_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 40 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 119, "Product variant 40 mockup view 2", "variant_40_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 40 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 121, "Product variant 41 mockup view 1", "variant_41_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 41 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 122, "Product variant 41 mockup view 2", "variant_41_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 41 },
                    { 123, "Product variant 41 mockup view 3", "variant_41_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 41 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 124, "Product variant 42 mockup view 1", "variant_42_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 42 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 125, "Product variant 42 mockup view 2", "variant_42_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 42 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 127, "Product variant 43 mockup view 1", "variant_43_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 43 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 128, "Product variant 43 mockup view 2", "variant_43_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 43 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 130, "Product variant 44 mockup view 1", "variant_44_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 44 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 131, "Product variant 44 mockup view 2", "variant_44_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 44 },
                    { 132, "Product variant 44 mockup view 3", "variant_44_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 44 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 133, "Product variant 45 mockup view 1", "variant_45_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 45 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 134, "Product variant 45 mockup view 2", "variant_45_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 45 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 136, "Product variant 46 mockup view 1", "variant_46_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 46 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 137, "Product variant 46 mockup view 2", "variant_46_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 46 },
                    { 138, "Product variant 46 mockup view 3", "variant_46_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 46 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 139, "Product variant 47 mockup view 1", "variant_47_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 47 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 140, "Product variant 47 mockup view 2", "variant_47_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 47 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 142, "Product variant 48 mockup view 1", "variant_48_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 48 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 143, "Product variant 48 mockup view 2", "variant_48_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 48 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 145, "Product variant 49 mockup view 1", "variant_49_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 49 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 146, "Product variant 49 mockup view 2", "variant_49_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 49 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 148, "Product variant 50 mockup view 1", "variant_50_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 50 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 149, "Product variant 50 mockup view 2", "variant_50_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 50 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 151, "Product variant 51 mockup view 1", "variant_51_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 51 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 152, "Product variant 51 mockup view 2", "variant_51_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 51 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 154, "Product variant 52 mockup view 1", "variant_52_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 52 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 155, "Product variant 52 mockup view 2", "variant_52_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 52 },
                    { 156, "Product variant 52 mockup view 3", "variant_52_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 52 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 157, "Product variant 53 mockup view 1", "variant_53_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 53 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 158, "Product variant 53 mockup view 2", "variant_53_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 53 },
                    { 159, "Product variant 53 mockup view 3", "variant_53_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 53 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 160, "Product variant 54 mockup view 1", "variant_54_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 54 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 161, "Product variant 54 mockup view 2", "variant_54_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 54 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 163, "Product variant 55 mockup view 1", "variant_55_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 55 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 164, "Product variant 55 mockup view 2", "variant_55_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 55 },
                    { 165, "Product variant 55 mockup view 3", "variant_55_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 55 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 166, "Product variant 56 mockup view 1", "variant_56_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 56 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 167, "Product variant 56 mockup view 2", "variant_56_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 56 },
                    { 168, "Product variant 56 mockup view 3", "variant_56_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 56 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 169, "Product variant 57 mockup view 1", "variant_57_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 57 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 170, "Product variant 57 mockup view 2", "variant_57_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 57 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 172, "Product variant 58 mockup view 1", "variant_58_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 58 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 173, "Product variant 58 mockup view 2", "variant_58_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 58 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 175, "Product variant 59 mockup view 1", "variant_59_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 59 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 176, "Product variant 59 mockup view 2", "variant_59_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 59 },
                    { 177, "Product variant 59 mockup view 3", "variant_59_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 59 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 178, "Product variant 60 mockup view 1", "variant_60_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 60 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 179, "Product variant 60 mockup view 2", "variant_60_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 60 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 181, "Product variant 61 mockup view 1", "variant_61_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 61 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 182, "Product variant 61 mockup view 2", "variant_61_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 61 },
                    { 183, "Product variant 61 mockup view 3", "variant_61_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 61 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 184, "Product variant 62 mockup view 1", "variant_62_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 62 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 185, "Product variant 62 mockup view 2", "variant_62_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 62 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 187, "Product variant 63 mockup view 1", "variant_63_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 63 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 188, "Product variant 63 mockup view 2", "variant_63_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 63 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 190, "Product variant 64 mockup view 1", "variant_64_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 64 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 191, "Product variant 64 mockup view 2", "variant_64_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 64 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 193, "Product variant 65 mockup view 1", "variant_65_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 65 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 194, "Product variant 65 mockup view 2", "variant_65_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 65 },
                    { 195, "Product variant 65 mockup view 3", "variant_65_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 65 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 196, "Product variant 66 mockup view 1", "variant_66_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 66 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 197, "Product variant 66 mockup view 2", "variant_66_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 66 },
                    { 198, "Product variant 66 mockup view 3", "variant_66_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 66 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 199, "Product variant 67 mockup view 1", "variant_67_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 67 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 200, "Product variant 67 mockup view 2", "variant_67_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 67 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 202, "Product variant 68 mockup view 1", "variant_68_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 68 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 203, "Product variant 68 mockup view 2", "variant_68_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 68 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 205, "Product variant 69 mockup view 1", "variant_69_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 69 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 206, "Product variant 69 mockup view 2", "variant_69_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 69 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 208, "Product variant 70 mockup view 1", "variant_70_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 70 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 209, "Product variant 70 mockup view 2", "variant_70_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 70 },
                    { 210, "Product variant 70 mockup view 3", "variant_70_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 70 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 211, "Product variant 71 mockup view 1", "variant_71_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 71 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 212, "Product variant 71 mockup view 2", "variant_71_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 71 },
                    { 213, "Product variant 71 mockup view 3", "variant_71_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 71 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 214, "Product variant 72 mockup view 1", "variant_72_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 72 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 215, "Product variant 72 mockup view 2", "variant_72_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 72 },
                    { 216, "Product variant 72 mockup view 3", "variant_72_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 72 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 217, "Product variant 73 mockup view 1", "variant_73_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 73 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 218, "Product variant 73 mockup view 2", "variant_73_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 73 },
                    { 219, "Product variant 73 mockup view 3", "variant_73_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 73 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 220, "Product variant 74 mockup view 1", "variant_74_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 74 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 221, "Product variant 74 mockup view 2", "variant_74_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 74 },
                    { 222, "Product variant 74 mockup view 3", "variant_74_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 74 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 223, "Product variant 75 mockup view 1", "variant_75_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 75 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 224, "Product variant 75 mockup view 2", "variant_75_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 75 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 226, "Product variant 76 mockup view 1", "variant_76_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 76 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 227, "Product variant 76 mockup view 2", "variant_76_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 76 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 229, "Product variant 77 mockup view 1", "variant_77_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 77 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 230, "Product variant 77 mockup view 2", "variant_77_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 77 },
                    { 231, "Product variant 77 mockup view 3", "variant_77_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 77 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 232, "Product variant 78 mockup view 1", "variant_78_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 78 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 233, "Product variant 78 mockup view 2", "variant_78_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 78 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 235, "Product variant 79 mockup view 1", "variant_79_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 79 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 236, "Product variant 79 mockup view 2", "variant_79_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 79 },
                    { 237, "Product variant 79 mockup view 3", "variant_79_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 79 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 238, "Product variant 80 mockup view 1", "variant_80_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 80 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 239, "Product variant 80 mockup view 2", "variant_80_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 80 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 241, "Product variant 81 mockup view 1", "variant_81_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 81 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 242, "Product variant 81 mockup view 2", "variant_81_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 81 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 244, "Product variant 82 mockup view 1", "variant_82_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 82 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 245, "Product variant 82 mockup view 2", "variant_82_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 82 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 247, "Product variant 83 mockup view 1", "variant_83_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 83 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 248, "Product variant 83 mockup view 2", "variant_83_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 83 },
                    { 249, "Product variant 83 mockup view 3", "variant_83_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 83 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 250, "Product variant 84 mockup view 1", "variant_84_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 84 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 251, "Product variant 84 mockup view 2", "variant_84_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 84 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 253, "Product variant 85 mockup view 1", "variant_85_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 85 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 254, "Product variant 85 mockup view 2", "variant_85_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 85 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 256, "Product variant 86 mockup view 1", "variant_86_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 86 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 257, "Product variant 86 mockup view 2", "variant_86_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 86 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 259, "Product variant 87 mockup view 1", "variant_87_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 87 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 260, "Product variant 87 mockup view 2", "variant_87_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 87 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 262, "Product variant 88 mockup view 1", "variant_88_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 88 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 263, "Product variant 88 mockup view 2", "variant_88_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 88 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 265, "Product variant 89 mockup view 1", "variant_89_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 89 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 266, "Product variant 89 mockup view 2", "variant_89_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 89 },
                    { 267, "Product variant 89 mockup view 3", "variant_89_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 89 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 268, "Product variant 90 mockup view 1", "variant_90_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 90 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 269, "Product variant 90 mockup view 2", "variant_90_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 90 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 271, "Product variant 91 mockup view 1", "variant_91_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 91 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 272, "Product variant 91 mockup view 2", "variant_91_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 91 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 274, "Product variant 92 mockup view 1", "variant_92_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 92 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 275, "Product variant 92 mockup view 2", "variant_92_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 92 },
                    { 276, "Product variant 92 mockup view 3", "variant_92_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 92 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 277, "Product variant 93 mockup view 1", "variant_93_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 93 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 278, "Product variant 93 mockup view 2", "variant_93_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 93 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 280, "Product variant 94 mockup view 1", "variant_94_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 94 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 281, "Product variant 94 mockup view 2", "variant_94_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 94 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 283, "Product variant 95 mockup view 1", "variant_95_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 95 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 284, "Product variant 95 mockup view 2", "variant_95_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 95 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 286, "Product variant 96 mockup view 1", "variant_96_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 96 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 287, "Product variant 96 mockup view 2", "variant_96_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 96 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 289, "Product variant 97 mockup view 1", "variant_97_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 97 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 290, "Product variant 97 mockup view 2", "variant_97_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 97 },
                    { 291, "Product variant 97 mockup view 3", "variant_97_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 97 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 292, "Product variant 98 mockup view 1", "variant_98_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 98 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 293, "Product variant 98 mockup view 2", "variant_98_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 98 },
                    { 294, "Product variant 98 mockup view 3", "variant_98_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 98 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 295, "Product variant 99 mockup view 1", "variant_99_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 99 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 296, "Product variant 99 mockup view 2", "variant_99_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 99 },
                    { 297, "Product variant 99 mockup view 3", "variant_99_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 99 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 298, "Product variant 100 mockup view 1", "variant_100_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 100 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 299, "Product variant 100 mockup view 2", "variant_100_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 100 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 301, "Product variant 101 mockup view 1", "variant_101_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 101 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 302, "Product variant 101 mockup view 2", "variant_101_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 101 },
                    { 303, "Product variant 101 mockup view 3", "variant_101_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 101 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 304, "Product variant 102 mockup view 1", "variant_102_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 102 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 305, "Product variant 102 mockup view 2", "variant_102_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 102 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 307, "Product variant 103 mockup view 1", "variant_103_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 103 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 308, "Product variant 103 mockup view 2", "variant_103_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 103 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 310, "Product variant 104 mockup view 1", "variant_104_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 104 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 311, "Product variant 104 mockup view 2", "variant_104_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 104 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 313, "Product variant 105 mockup view 1", "variant_105_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 105 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 314, "Product variant 105 mockup view 2", "variant_105_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 105 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 316, "Product variant 106 mockup view 1", "variant_106_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 106 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 317, "Product variant 106 mockup view 2", "variant_106_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 106 },
                    { 318, "Product variant 106 mockup view 3", "variant_106_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 106 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 319, "Product variant 107 mockup view 1", "variant_107_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 107 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 320, "Product variant 107 mockup view 2", "variant_107_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 107 },
                    { 321, "Product variant 107 mockup view 3", "variant_107_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 107 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 322, "Product variant 108 mockup view 1", "variant_108_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 108 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 323, "Product variant 108 mockup view 2", "variant_108_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 108 },
                    { 324, "Product variant 108 mockup view 3", "variant_108_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 108 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 325, "Product variant 109 mockup view 1", "variant_109_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 109 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 326, "Product variant 109 mockup view 2", "variant_109_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 109 },
                    { 327, "Product variant 109 mockup view 3", "variant_109_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 109 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 328, "Product variant 110 mockup view 1", "variant_110_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 110 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 329, "Product variant 110 mockup view 2", "variant_110_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 110 },
                    { 330, "Product variant 110 mockup view 3", "variant_110_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 110 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 331, "Product variant 111 mockup view 1", "variant_111_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 111 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 332, "Product variant 111 mockup view 2", "variant_111_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 111 },
                    { 333, "Product variant 111 mockup view 3", "variant_111_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 111 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 334, "Product variant 112 mockup view 1", "variant_112_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 112 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 335, "Product variant 112 mockup view 2", "variant_112_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 112 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 337, "Product variant 113 mockup view 1", "variant_113_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 113 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 338, "Product variant 113 mockup view 2", "variant_113_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 113 },
                    { 339, "Product variant 113 mockup view 3", "variant_113_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 113 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 340, "Product variant 114 mockup view 1", "variant_114_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 114 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 341, "Product variant 114 mockup view 2", "variant_114_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 114 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 343, "Product variant 115 mockup view 1", "variant_115_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 115 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 344, "Product variant 115 mockup view 2", "variant_115_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 115 },
                    { 345, "Product variant 115 mockup view 3", "variant_115_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 115 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 346, "Product variant 116 mockup view 1", "variant_116_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 116 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 347, "Product variant 116 mockup view 2", "variant_116_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 116 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 349, "Product variant 117 mockup view 1", "variant_117_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 117 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 350, "Product variant 117 mockup view 2", "variant_117_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 117 },
                    { 351, "Product variant 117 mockup view 3", "variant_117_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 117 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 352, "Product variant 118 mockup view 1", "variant_118_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 118 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 353, "Product variant 118 mockup view 2", "variant_118_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 118 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 355, "Product variant 119 mockup view 1", "variant_119_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 119 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 356, "Product variant 119 mockup view 2", "variant_119_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 119 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 358, "Product variant 120 mockup view 1", "variant_120_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 120 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 359, "Product variant 120 mockup view 2", "variant_120_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 120 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 361, "Product variant 121 mockup view 1", "variant_121_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 121 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 362, "Product variant 121 mockup view 2", "variant_121_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 121 },
                    { 363, "Product variant 121 mockup view 3", "variant_121_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 121 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 364, "Product variant 122 mockup view 1", "variant_122_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 122 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 365, "Product variant 122 mockup view 2", "variant_122_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 122 },
                    { 366, "Product variant 122 mockup view 3", "variant_122_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 122 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 367, "Product variant 123 mockup view 1", "variant_123_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 123 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 368, "Product variant 123 mockup view 2", "variant_123_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 123 },
                    { 369, "Product variant 123 mockup view 3", "variant_123_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 123 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 370, "Product variant 124 mockup view 1", "variant_124_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 124 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 371, "Product variant 124 mockup view 2", "variant_124_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 124 },
                    { 372, "Product variant 124 mockup view 3", "variant_124_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 124 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 373, "Product variant 125 mockup view 1", "variant_125_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 125 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 374, "Product variant 125 mockup view 2", "variant_125_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 125 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 376, "Product variant 126 mockup view 1", "variant_126_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 126 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 377, "Product variant 126 mockup view 2", "variant_126_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 126 },
                    { 378, "Product variant 126 mockup view 3", "variant_126_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 126 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 379, "Product variant 127 mockup view 1", "variant_127_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 127 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 380, "Product variant 127 mockup view 2", "variant_127_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 127 },
                    { 381, "Product variant 127 mockup view 3", "variant_127_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 127 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 382, "Product variant 128 mockup view 1", "variant_128_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 128 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 383, "Product variant 128 mockup view 2", "variant_128_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 128 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 385, "Product variant 129 mockup view 1", "variant_129_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 129 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 386, "Product variant 129 mockup view 2", "variant_129_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 129 },
                    { 387, "Product variant 129 mockup view 3", "variant_129_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 129 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 388, "Product variant 130 mockup view 1", "variant_130_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 130 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 389, "Product variant 130 mockup view 2", "variant_130_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 130 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 391, "Product variant 131 mockup view 1", "variant_131_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 131 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 392, "Product variant 131 mockup view 2", "variant_131_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 131 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 394, "Product variant 132 mockup view 1", "variant_132_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 132 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 395, "Product variant 132 mockup view 2", "variant_132_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 132 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 397, "Product variant 133 mockup view 1", "variant_133_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 133 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 398, "Product variant 133 mockup view 2", "variant_133_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 133 },
                    { 399, "Product variant 133 mockup view 3", "variant_133_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 133 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 400, "Product variant 134 mockup view 1", "variant_134_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 134 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 401, "Product variant 134 mockup view 2", "variant_134_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 134 },
                    { 402, "Product variant 134 mockup view 3", "variant_134_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 134 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 403, "Product variant 135 mockup view 1", "variant_135_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 135 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 404, "Product variant 135 mockup view 2", "variant_135_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 135 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 406, "Product variant 136 mockup view 1", "variant_136_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 136 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 407, "Product variant 136 mockup view 2", "variant_136_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 136 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 409, "Product variant 137 mockup view 1", "variant_137_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 137 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 410, "Product variant 137 mockup view 2", "variant_137_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 137 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 412, "Product variant 138 mockup view 1", "variant_138_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 138 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 413, "Product variant 138 mockup view 2", "variant_138_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 138 },
                    { 414, "Product variant 138 mockup view 3", "variant_138_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 138 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 415, "Product variant 139 mockup view 1", "variant_139_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 139 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 416, "Product variant 139 mockup view 2", "variant_139_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 139 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 418, "Product variant 140 mockup view 1", "variant_140_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 140 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 419, "Product variant 140 mockup view 2", "variant_140_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 140 },
                    { 420, "Product variant 140 mockup view 3", "variant_140_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 140 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 421, "Product variant 141 mockup view 1", "variant_141_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 141 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 422, "Product variant 141 mockup view 2", "variant_141_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 141 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 424, "Product variant 142 mockup view 1", "variant_142_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 142 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 425, "Product variant 142 mockup view 2", "variant_142_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 142 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 427, "Product variant 143 mockup view 1", "variant_143_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 143 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 428, "Product variant 143 mockup view 2", "variant_143_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 143 },
                    { 429, "Product variant 143 mockup view 3", "variant_143_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 143 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 430, "Product variant 144 mockup view 1", "variant_144_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 144 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 431, "Product variant 144 mockup view 2", "variant_144_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 144 },
                    { 432, "Product variant 144 mockup view 3", "variant_144_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 144 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 433, "Product variant 145 mockup view 1", "variant_145_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 145 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 434, "Product variant 145 mockup view 2", "variant_145_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 145 },
                    { 435, "Product variant 145 mockup view 3", "variant_145_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 145 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 436, "Product variant 146 mockup view 1", "variant_146_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 146 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 437, "Product variant 146 mockup view 2", "variant_146_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 146 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 439, "Product variant 147 mockup view 1", "variant_147_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 147 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 440, "Product variant 147 mockup view 2", "variant_147_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 147 },
                    { 441, "Product variant 147 mockup view 3", "variant_147_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 147 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 442, "Product variant 148 mockup view 1", "variant_148_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 148 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 443, "Product variant 148 mockup view 2", "variant_148_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 148 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 445, "Product variant 149 mockup view 1", "variant_149_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 149 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 446, "Product variant 149 mockup view 2", "variant_149_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 149 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 448, "Product variant 150 mockup view 1", "variant_150_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 150 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 449, "Product variant 150 mockup view 2", "variant_150_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 150 },
                    { 450, "Product variant 150 mockup view 3", "variant_150_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 150 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 451, "Product variant 151 mockup view 1", "variant_151_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 151 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 452, "Product variant 151 mockup view 2", "variant_151_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 151 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 454, "Product variant 152 mockup view 1", "variant_152_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 152 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 455, "Product variant 152 mockup view 2", "variant_152_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 152 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 457, "Product variant 153 mockup view 1", "variant_153_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 153 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 458, "Product variant 153 mockup view 2", "variant_153_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 153 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 460, "Product variant 154 mockup view 1", "variant_154_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 154 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 461, "Product variant 154 mockup view 2", "variant_154_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 154 },
                    { 462, "Product variant 154 mockup view 3", "variant_154_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 154 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 463, "Product variant 155 mockup view 1", "variant_155_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 155 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 464, "Product variant 155 mockup view 2", "variant_155_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 155 },
                    { 465, "Product variant 155 mockup view 3", "variant_155_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 155 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 466, "Product variant 156 mockup view 1", "variant_156_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 156 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 467, "Product variant 156 mockup view 2", "variant_156_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 156 },
                    { 468, "Product variant 156 mockup view 3", "variant_156_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 156 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 469, "Product variant 157 mockup view 1", "variant_157_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 157 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 470, "Product variant 157 mockup view 2", "variant_157_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 157 },
                    { 471, "Product variant 157 mockup view 3", "variant_157_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 157 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 472, "Product variant 158 mockup view 1", "variant_158_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 158 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 473, "Product variant 158 mockup view 2", "variant_158_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 158 },
                    { 474, "Product variant 158 mockup view 3", "variant_158_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 158 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 475, "Product variant 159 mockup view 1", "variant_159_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 159 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 476, "Product variant 159 mockup view 2", "variant_159_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 159 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 478, "Product variant 160 mockup view 1", "variant_160_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 160 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 479, "Product variant 160 mockup view 2", "variant_160_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 160 },
                    { 480, "Product variant 160 mockup view 3", "variant_160_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 160 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 481, "Product variant 161 mockup view 1", "variant_161_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 161 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 482, "Product variant 161 mockup view 2", "variant_161_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 161 },
                    { 483, "Product variant 161 mockup view 3", "variant_161_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 161 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 484, "Product variant 162 mockup view 1", "variant_162_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 162 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 485, "Product variant 162 mockup view 2", "variant_162_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 162 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 487, "Product variant 163 mockup view 1", "variant_163_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 163 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 488, "Product variant 163 mockup view 2", "variant_163_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 163 },
                    { 489, "Product variant 163 mockup view 3", "variant_163_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 163 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 490, "Product variant 164 mockup view 1", "variant_164_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 164 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 491, "Product variant 164 mockup view 2", "variant_164_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 164 },
                    { 492, "Product variant 164 mockup view 3", "variant_164_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 164 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 493, "Product variant 165 mockup view 1", "variant_165_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 165 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 494, "Product variant 165 mockup view 2", "variant_165_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 165 },
                    { 495, "Product variant 165 mockup view 3", "variant_165_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 165 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 496, "Product variant 166 mockup view 1", "variant_166_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 166 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 497, "Product variant 166 mockup view 2", "variant_166_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 166 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 499, "Product variant 167 mockup view 1", "variant_167_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 167 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 500, "Product variant 167 mockup view 2", "variant_167_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 167 },
                    { 501, "Product variant 167 mockup view 3", "variant_167_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 167 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 502, "Product variant 168 mockup view 1", "variant_168_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 168 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 503, "Product variant 168 mockup view 2", "variant_168_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 168 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 505, "Product variant 169 mockup view 1", "variant_169_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 169 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 506, "Product variant 169 mockup view 2", "variant_169_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 169 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 508, "Product variant 170 mockup view 1", "variant_170_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 170 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 509, "Product variant 170 mockup view 2", "variant_170_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 170 },
                    { 510, "Product variant 170 mockup view 3", "variant_170_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 170 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 511, "Product variant 171 mockup view 1", "variant_171_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 171 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 512, "Product variant 171 mockup view 2", "variant_171_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 171 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 514, "Product variant 172 mockup view 1", "variant_172_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 172 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 515, "Product variant 172 mockup view 2", "variant_172_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 172 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 517, "Product variant 173 mockup view 1", "variant_173_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 173 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 518, "Product variant 173 mockup view 2", "variant_173_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 173 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 520, "Product variant 174 mockup view 1", "variant_174_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 174 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 521, "Product variant 174 mockup view 2", "variant_174_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 174 },
                    { 522, "Product variant 174 mockup view 3", "variant_174_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 174 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 523, "Product variant 175 mockup view 1", "variant_175_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 175 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 524, "Product variant 175 mockup view 2", "variant_175_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 175 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 526, "Product variant 176 mockup view 1", "variant_176_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 176 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 527, "Product variant 176 mockup view 2", "variant_176_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 176 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 529, "Product variant 177 mockup view 1", "variant_177_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 177 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 530, "Product variant 177 mockup view 2", "variant_177_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 177 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 532, "Product variant 178 mockup view 1", "variant_178_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 178 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 533, "Product variant 178 mockup view 2", "variant_178_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 178 },
                    { 534, "Product variant 178 mockup view 3", "variant_178_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 178 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 535, "Product variant 179 mockup view 1", "variant_179_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 179 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 536, "Product variant 179 mockup view 2", "variant_179_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 179 },
                    { 537, "Product variant 179 mockup view 3", "variant_179_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 179 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 538, "Product variant 180 mockup view 1", "variant_180_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 180 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 539, "Product variant 180 mockup view 2", "variant_180_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 180 },
                    { 540, "Product variant 180 mockup view 3", "variant_180_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 180 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 541, "Product variant 181 mockup view 1", "variant_181_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 181 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 542, "Product variant 181 mockup view 2", "variant_181_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 181 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 544, "Product variant 182 mockup view 1", "variant_182_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 182 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 545, "Product variant 182 mockup view 2", "variant_182_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 182 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 547, "Product variant 183 mockup view 1", "variant_183_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 183 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 548, "Product variant 183 mockup view 2", "variant_183_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 183 },
                    { 549, "Product variant 183 mockup view 3", "variant_183_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 183 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 550, "Product variant 184 mockup view 1", "variant_184_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 184 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 551, "Product variant 184 mockup view 2", "variant_184_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 184 },
                    { 552, "Product variant 184 mockup view 3", "variant_184_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 184 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 553, "Product variant 185 mockup view 1", "variant_185_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 185 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 554, "Product variant 185 mockup view 2", "variant_185_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 185 },
                    { 555, "Product variant 185 mockup view 3", "variant_185_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 185 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 556, "Product variant 186 mockup view 1", "variant_186_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 186 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 557, "Product variant 186 mockup view 2", "variant_186_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 186 },
                    { 558, "Product variant 186 mockup view 3", "variant_186_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 186 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 559, "Product variant 187 mockup view 1", "variant_187_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 187 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 560, "Product variant 187 mockup view 2", "variant_187_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 187 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 562, "Product variant 188 mockup view 1", "variant_188_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 188 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 563, "Product variant 188 mockup view 2", "variant_188_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 188 },
                    { 564, "Product variant 188 mockup view 3", "variant_188_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 188 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 565, "Product variant 189 mockup view 1", "variant_189_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 189 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 566, "Product variant 189 mockup view 2", "variant_189_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 189 },
                    { 567, "Product variant 189 mockup view 3", "variant_189_mockup_3.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 189 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 568, "Product variant 190 mockup view 1", "variant_190_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 190 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 569, "Product variant 190 mockup view 2", "variant_190_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 190 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 571, "Product variant 191 mockup view 1", "variant_191_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 191 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 572, "Product variant 191 mockup view 2", "variant_191_mockup_2.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, 191 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 574, "Product variant 192 mockup view 1", "variant_192_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 192 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 575, "Product variant 192 mockup view 2", "variant_192_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 192 },
                    { 576, "Product variant 192 mockup view 3", "variant_192_mockup_3.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 192 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 577, "Product variant 193 mockup view 1", "variant_193_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 193 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 578, "Product variant 193 mockup view 2", "variant_193_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 193 },
                    { 579, "Product variant 193 mockup view 3", "variant_193_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 193 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 580, "Product variant 194 mockup view 1", "variant_194_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 194 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 581, "Product variant 194 mockup view 2", "variant_194_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 194 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 583, "Product variant 195 mockup view 1", "variant_195_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 195 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 584, "Product variant 195 mockup view 2", "variant_195_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 195 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 586, "Product variant 196 mockup view 1", "variant_196_mockup_1.jpg", "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", true, true, 196 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 587, "Product variant 196 mockup view 2", "variant_196_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 196 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 589, "Product variant 197 mockup view 1", "variant_197_mockup_1.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, true, 197 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 590, "Product variant 197 mockup view 2", "variant_197_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 197 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 592, "Product variant 198 mockup view 1", "variant_198_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 198 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 593, "Product variant 198 mockup view 2", "variant_198_mockup_2.jpg", "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop", true, 198 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 595, "Product variant 199 mockup view 1", "variant_199_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 199 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 596, "Product variant 199 mockup view 2", "variant_199_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 199 },
                    { 597, "Product variant 199 mockup view 3", "variant_199_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 199 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 598, "Product variant 200 mockup view 1", "variant_200_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 200 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 599, "Product variant 200 mockup view 2", "variant_200_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 200 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 601, "Product variant 201 mockup view 1", "variant_201_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 201 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 602, "Product variant 201 mockup view 2", "variant_201_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 201 },
                    { 603, "Product variant 201 mockup view 3", "variant_201_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 201 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 604, "Product variant 202 mockup view 1", "variant_202_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 202 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 605, "Product variant 202 mockup view 2", "variant_202_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 202 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 607, "Product variant 203 mockup view 1", "variant_203_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 203 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 608, "Product variant 203 mockup view 2", "variant_203_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 203 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 610, "Product variant 204 mockup view 1", "variant_204_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 204 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 611, "Product variant 204 mockup view 2", "variant_204_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 204 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 613, "Product variant 205 mockup view 1", "variant_205_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 205 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 614, "Product variant 205 mockup view 2", "variant_205_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 205 },
                    { 615, "Product variant 205 mockup view 3", "variant_205_mockup_3.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 205 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 616, "Product variant 206 mockup view 1", "variant_206_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 206 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 617, "Product variant 206 mockup view 2", "variant_206_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 206 },
                    { 618, "Product variant 206 mockup view 3", "variant_206_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 206 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 619, "Product variant 207 mockup view 1", "variant_207_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 207 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 620, "Product variant 207 mockup view 2", "variant_207_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 207 },
                    { 621, "Product variant 207 mockup view 3", "variant_207_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 207 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 622, "Product variant 208 mockup view 1", "variant_208_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 208 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 623, "Product variant 208 mockup view 2", "variant_208_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 208 },
                    { 624, "Product variant 208 mockup view 3", "variant_208_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 208 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 625, "Product variant 209 mockup view 1", "variant_209_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 209 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 626, "Product variant 209 mockup view 2", "variant_209_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 209 },
                    { 627, "Product variant 209 mockup view 3", "variant_209_mockup_3.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 209 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 628, "Product variant 210 mockup view 1", "variant_210_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 210 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 629, "Product variant 210 mockup view 2", "variant_210_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 210 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 631, "Product variant 211 mockup view 1", "variant_211_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 211 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 632, "Product variant 211 mockup view 2", "variant_211_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 211 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 634, "Product variant 212 mockup view 1", "variant_212_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 212 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 635, "Product variant 212 mockup view 2", "variant_212_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 212 },
                    { 636, "Product variant 212 mockup view 3", "variant_212_mockup_3.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 212 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 637, "Product variant 213 mockup view 1", "variant_213_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 213 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 638, "Product variant 213 mockup view 2", "variant_213_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 213 },
                    { 639, "Product variant 213 mockup view 3", "variant_213_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 213 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 640, "Product variant 214 mockup view 1", "variant_214_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 214 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 641, "Product variant 214 mockup view 2", "variant_214_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 214 },
                    { 642, "Product variant 214 mockup view 3", "variant_214_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 214 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 643, "Product variant 215 mockup view 1", "variant_215_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 215 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 644, "Product variant 215 mockup view 2", "variant_215_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 215 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 646, "Product variant 216 mockup view 1", "variant_216_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 216 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 647, "Product variant 216 mockup view 2", "variant_216_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 216 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 649, "Product variant 217 mockup view 1", "variant_217_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 217 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 650, "Product variant 217 mockup view 2", "variant_217_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 217 },
                    { 651, "Product variant 217 mockup view 3", "variant_217_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 217 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 652, "Product variant 218 mockup view 1", "variant_218_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 218 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 653, "Product variant 218 mockup view 2", "variant_218_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 218 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 655, "Product variant 219 mockup view 1", "variant_219_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 219 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 656, "Product variant 219 mockup view 2", "variant_219_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 219 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 658, "Product variant 220 mockup view 1", "variant_220_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 220 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 659, "Product variant 220 mockup view 2", "variant_220_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 220 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 661, "Product variant 221 mockup view 1", "variant_221_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 221 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 662, "Product variant 221 mockup view 2", "variant_221_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 221 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 664, "Product variant 222 mockup view 1", "variant_222_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 222 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 665, "Product variant 222 mockup view 2", "variant_222_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 222 },
                    { 666, "Product variant 222 mockup view 3", "variant_222_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 222 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 667, "Product variant 223 mockup view 1", "variant_223_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 223 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 668, "Product variant 223 mockup view 2", "variant_223_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 223 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 670, "Product variant 224 mockup view 1", "variant_224_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 224 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 671, "Product variant 224 mockup view 2", "variant_224_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 224 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 673, "Product variant 225 mockup view 1", "variant_225_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 225 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 674, "Product variant 225 mockup view 2", "variant_225_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 225 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 676, "Product variant 226 mockup view 1", "variant_226_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 226 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 677, "Product variant 226 mockup view 2", "variant_226_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 226 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 679, "Product variant 227 mockup view 1", "variant_227_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 227 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 680, "Product variant 227 mockup view 2", "variant_227_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 227 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 682, "Product variant 228 mockup view 1", "variant_228_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 228 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 683, "Product variant 228 mockup view 2", "variant_228_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 228 },
                    { 684, "Product variant 228 mockup view 3", "variant_228_mockup_3.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 228 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 685, "Product variant 229 mockup view 1", "variant_229_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 229 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 686, "Product variant 229 mockup view 2", "variant_229_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 229 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 688, "Product variant 230 mockup view 1", "variant_230_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 230 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 689, "Product variant 230 mockup view 2", "variant_230_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 230 },
                    { 690, "Product variant 230 mockup view 3", "variant_230_mockup_3.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 230 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 691, "Product variant 231 mockup view 1", "variant_231_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 231 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 692, "Product variant 231 mockup view 2", "variant_231_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 231 },
                    { 693, "Product variant 231 mockup view 3", "variant_231_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 231 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 694, "Product variant 232 mockup view 1", "variant_232_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 232 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 695, "Product variant 232 mockup view 2", "variant_232_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 232 },
                    { 696, "Product variant 232 mockup view 3", "variant_232_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 232 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 697, "Product variant 233 mockup view 1", "variant_233_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 233 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 698, "Product variant 233 mockup view 2", "variant_233_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 233 },
                    { 699, "Product variant 233 mockup view 3", "variant_233_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 233 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 700, "Product variant 234 mockup view 1", "variant_234_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 234 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 701, "Product variant 234 mockup view 2", "variant_234_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 234 },
                    { 702, "Product variant 234 mockup view 3", "variant_234_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 234 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 703, "Product variant 235 mockup view 1", "variant_235_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 235 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 704, "Product variant 235 mockup view 2", "variant_235_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 235 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 706, "Product variant 236 mockup view 1", "variant_236_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 236 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 707, "Product variant 236 mockup view 2", "variant_236_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 236 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 709, "Product variant 237 mockup view 1", "variant_237_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 237 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 710, "Product variant 237 mockup view 2", "variant_237_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 237 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 712, "Product variant 238 mockup view 1", "variant_238_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 238 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 713, "Product variant 238 mockup view 2", "variant_238_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 238 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 715, "Product variant 239 mockup view 1", "variant_239_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 239 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 716, "Product variant 239 mockup view 2", "variant_239_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 239 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 718, "Product variant 240 mockup view 1", "variant_240_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 240 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 719, "Product variant 240 mockup view 2", "variant_240_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 240 },
                    { 720, "Product variant 240 mockup view 3", "variant_240_mockup_3.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 240 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 721, "Product variant 241 mockup view 1", "variant_241_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 241 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 722, "Product variant 241 mockup view 2", "variant_241_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 241 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 724, "Product variant 242 mockup view 1", "variant_242_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 242 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 725, "Product variant 242 mockup view 2", "variant_242_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 242 },
                    { 726, "Product variant 242 mockup view 3", "variant_242_mockup_3.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 242 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 727, "Product variant 243 mockup view 1", "variant_243_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 243 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 728, "Product variant 243 mockup view 2", "variant_243_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 243 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 730, "Product variant 244 mockup view 1", "variant_244_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 244 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 731, "Product variant 244 mockup view 2", "variant_244_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 244 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 733, "Product variant 245 mockup view 1", "variant_245_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 245 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 734, "Product variant 245 mockup view 2", "variant_245_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 245 },
                    { 735, "Product variant 245 mockup view 3", "variant_245_mockup_3.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 245 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 736, "Product variant 246 mockup view 1", "variant_246_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 246 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 737, "Product variant 246 mockup view 2", "variant_246_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 246 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 739, "Product variant 247 mockup view 1", "variant_247_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 247 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 740, "Product variant 247 mockup view 2", "variant_247_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 247 },
                    { 741, "Product variant 247 mockup view 3", "variant_247_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 247 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 742, "Product variant 248 mockup view 1", "variant_248_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 248 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 743, "Product variant 248 mockup view 2", "variant_248_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 248 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 745, "Product variant 249 mockup view 1", "variant_249_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 249 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 746, "Product variant 249 mockup view 2", "variant_249_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 249 },
                    { 747, "Product variant 249 mockup view 3", "variant_249_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 249 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 748, "Product variant 250 mockup view 1", "variant_250_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 250 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 749, "Product variant 250 mockup view 2", "variant_250_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 250 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 751, "Product variant 251 mockup view 1", "variant_251_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 251 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 752, "Product variant 251 mockup view 2", "variant_251_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 251 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 754, "Product variant 252 mockup view 1", "variant_252_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 252 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 755, "Product variant 252 mockup view 2", "variant_252_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 252 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 757, "Product variant 253 mockup view 1", "variant_253_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 253 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 758, "Product variant 253 mockup view 2", "variant_253_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 253 },
                    { 759, "Product variant 253 mockup view 3", "variant_253_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 253 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 760, "Product variant 254 mockup view 1", "variant_254_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 254 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 761, "Product variant 254 mockup view 2", "variant_254_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 254 },
                    { 762, "Product variant 254 mockup view 3", "variant_254_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 254 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 763, "Product variant 255 mockup view 1", "variant_255_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 255 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 764, "Product variant 255 mockup view 2", "variant_255_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 255 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 766, "Product variant 256 mockup view 1", "variant_256_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 256 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 767, "Product variant 256 mockup view 2", "variant_256_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 256 },
                    { 768, "Product variant 256 mockup view 3", "variant_256_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 256 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 769, "Product variant 257 mockup view 1", "variant_257_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 257 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 770, "Product variant 257 mockup view 2", "variant_257_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 257 },
                    { 771, "Product variant 257 mockup view 3", "variant_257_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 257 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 772, "Product variant 258 mockup view 1", "variant_258_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 258 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 773, "Product variant 258 mockup view 2", "variant_258_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 258 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 775, "Product variant 259 mockup view 1", "variant_259_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 259 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 776, "Product variant 259 mockup view 2", "variant_259_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 259 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 778, "Product variant 260 mockup view 1", "variant_260_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 260 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 779, "Product variant 260 mockup view 2", "variant_260_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 260 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 781, "Product variant 261 mockup view 1", "variant_261_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 261 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 782, "Product variant 261 mockup view 2", "variant_261_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 261 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 784, "Product variant 262 mockup view 1", "variant_262_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 262 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 785, "Product variant 262 mockup view 2", "variant_262_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 262 },
                    { 786, "Product variant 262 mockup view 3", "variant_262_mockup_3.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 262 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 787, "Product variant 263 mockup view 1", "variant_263_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 263 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 788, "Product variant 263 mockup view 2", "variant_263_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 263 },
                    { 789, "Product variant 263 mockup view 3", "variant_263_mockup_3.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 263 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 790, "Product variant 264 mockup view 1", "variant_264_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 264 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 791, "Product variant 264 mockup view 2", "variant_264_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 264 },
                    { 792, "Product variant 264 mockup view 3", "variant_264_mockup_3.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 264 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 793, "Product variant 265 mockup view 1", "variant_265_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 265 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 794, "Product variant 265 mockup view 2", "variant_265_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 265 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 796, "Product variant 266 mockup view 1", "variant_266_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 266 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 797, "Product variant 266 mockup view 2", "variant_266_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 266 },
                    { 798, "Product variant 266 mockup view 3", "variant_266_mockup_3.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 266 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 799, "Product variant 267 mockup view 1", "variant_267_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 267 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 800, "Product variant 267 mockup view 2", "variant_267_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 267 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 802, "Product variant 268 mockup view 1", "variant_268_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 268 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 803, "Product variant 268 mockup view 2", "variant_268_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 268 },
                    { 804, "Product variant 268 mockup view 3", "variant_268_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 268 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 805, "Product variant 269 mockup view 1", "variant_269_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 269 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 806, "Product variant 269 mockup view 2", "variant_269_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 269 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 808, "Product variant 270 mockup view 1", "variant_270_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 270 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 809, "Product variant 270 mockup view 2", "variant_270_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 270 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 811, "Product variant 271 mockup view 1", "variant_271_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 271 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 812, "Product variant 271 mockup view 2", "variant_271_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 271 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 814, "Product variant 272 mockup view 1", "variant_272_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 272 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 815, "Product variant 272 mockup view 2", "variant_272_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 272 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 817, "Product variant 273 mockup view 1", "variant_273_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 273 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 818, "Product variant 273 mockup view 2", "variant_273_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 273 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 820, "Product variant 274 mockup view 1", "variant_274_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 274 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 821, "Product variant 274 mockup view 2", "variant_274_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 274 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 823, "Product variant 275 mockup view 1", "variant_275_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 275 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 824, "Product variant 275 mockup view 2", "variant_275_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 275 },
                    { 825, "Product variant 275 mockup view 3", "variant_275_mockup_3.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 275 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 826, "Product variant 276 mockup view 1", "variant_276_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 276 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 827, "Product variant 276 mockup view 2", "variant_276_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 276 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 829, "Product variant 277 mockup view 1", "variant_277_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 277 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 830, "Product variant 277 mockup view 2", "variant_277_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 277 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 832, "Product variant 278 mockup view 1", "variant_278_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 278 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 833, "Product variant 278 mockup view 2", "variant_278_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 278 },
                    { 834, "Product variant 278 mockup view 3", "variant_278_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 278 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 835, "Product variant 279 mockup view 1", "variant_279_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 279 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 836, "Product variant 279 mockup view 2", "variant_279_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 279 },
                    { 837, "Product variant 279 mockup view 3", "variant_279_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 279 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 838, "Product variant 280 mockup view 1", "variant_280_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 280 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 839, "Product variant 280 mockup view 2", "variant_280_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 280 },
                    { 840, "Product variant 280 mockup view 3", "variant_280_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 280 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 841, "Product variant 281 mockup view 1", "variant_281_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 281 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 842, "Product variant 281 mockup view 2", "variant_281_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 281 },
                    { 843, "Product variant 281 mockup view 3", "variant_281_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 281 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 844, "Product variant 282 mockup view 1", "variant_282_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 282 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 845, "Product variant 282 mockup view 2", "variant_282_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 282 },
                    { 846, "Product variant 282 mockup view 3", "variant_282_mockup_3.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 282 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 847, "Product variant 283 mockup view 1", "variant_283_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 283 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 848, "Product variant 283 mockup view 2", "variant_283_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 283 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 850, "Product variant 284 mockup view 1", "variant_284_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 284 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 851, "Product variant 284 mockup view 2", "variant_284_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 284 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 853, "Product variant 285 mockup view 1", "variant_285_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 285 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 854, "Product variant 285 mockup view 2", "variant_285_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 285 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 856, "Product variant 286 mockup view 1", "variant_286_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 286 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 857, "Product variant 286 mockup view 2", "variant_286_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 286 },
                    { 858, "Product variant 286 mockup view 3", "variant_286_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 286 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 859, "Product variant 287 mockup view 1", "variant_287_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 287 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 860, "Product variant 287 mockup view 2", "variant_287_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 287 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 862, "Product variant 288 mockup view 1", "variant_288_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 288 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 863, "Product variant 288 mockup view 2", "variant_288_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 288 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 865, "Product variant 289 mockup view 1", "variant_289_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 289 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 866, "Product variant 289 mockup view 2", "variant_289_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 289 },
                    { 867, "Product variant 289 mockup view 3", "variant_289_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 289 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 868, "Product variant 290 mockup view 1", "variant_290_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 290 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 869, "Product variant 290 mockup view 2", "variant_290_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 290 },
                    { 870, "Product variant 290 mockup view 3", "variant_290_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 290 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 871, "Product variant 291 mockup view 1", "variant_291_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 291 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 872, "Product variant 291 mockup view 2", "variant_291_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 291 },
                    { 873, "Product variant 291 mockup view 3", "variant_291_mockup_3.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 291 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 874, "Product variant 292 mockup view 1", "variant_292_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 292 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 875, "Product variant 292 mockup view 2", "variant_292_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 292 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 877, "Product variant 293 mockup view 1", "variant_293_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 293 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 878, "Product variant 293 mockup view 2", "variant_293_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 293 },
                    { 879, "Product variant 293 mockup view 3", "variant_293_mockup_3.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 293 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 880, "Product variant 294 mockup view 1", "variant_294_mockup_1.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, true, 294 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 881, "Product variant 294 mockup view 2", "variant_294_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 294 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 883, "Product variant 295 mockup view 1", "variant_295_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 295 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 884, "Product variant 295 mockup view 2", "variant_295_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 295 },
                    { 885, "Product variant 295 mockup view 3", "variant_295_mockup_3.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 295 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 886, "Product variant 296 mockup view 1", "variant_296_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 296 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 887, "Product variant 296 mockup view 2", "variant_296_mockup_2.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, 296 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 889, "Product variant 297 mockup view 1", "variant_297_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 297 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 890, "Product variant 297 mockup view 2", "variant_297_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 297 },
                    { 891, "Product variant 297 mockup view 3", "variant_297_mockup_3.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 297 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 892, "Product variant 298 mockup view 1", "variant_298_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 298 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 893, "Product variant 298 mockup view 2", "variant_298_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 298 },
                    { 894, "Product variant 298 mockup view 3", "variant_298_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 298 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 895, "Product variant 299 mockup view 1", "variant_299_mockup_1.jpg", "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", true, true, 299 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 896, "Product variant 299 mockup view 2", "variant_299_mockup_2.jpg", "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop", true, 299 },
                    { 897, "Product variant 299 mockup view 3", "variant_299_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 299 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 898, "Product variant 300 mockup view 1", "variant_300_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 300 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 899, "Product variant 300 mockup view 2", "variant_300_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 300 },
                    { 900, "Product variant 300 mockup view 3", "variant_300_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 300 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 901, "Product variant 301 mockup view 1", "variant_301_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 301 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 902, "Product variant 301 mockup view 2", "variant_301_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 301 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 904, "Product variant 302 mockup view 1", "variant_302_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 302 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 905, "Product variant 302 mockup view 2", "variant_302_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 302 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 907, "Product variant 303 mockup view 1", "variant_303_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 303 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 908, "Product variant 303 mockup view 2", "variant_303_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 303 },
                    { 909, "Product variant 303 mockup view 3", "variant_303_mockup_3.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 303 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 910, "Product variant 304 mockup view 1", "variant_304_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 304 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 911, "Product variant 304 mockup view 2", "variant_304_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 304 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 913, "Product variant 305 mockup view 1", "variant_305_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 305 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 914, "Product variant 305 mockup view 2", "variant_305_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 305 },
                    { 915, "Product variant 305 mockup view 3", "variant_305_mockup_3.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 305 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 916, "Product variant 306 mockup view 1", "variant_306_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 306 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 917, "Product variant 306 mockup view 2", "variant_306_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 306 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 919, "Product variant 307 mockup view 1", "variant_307_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 307 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 920, "Product variant 307 mockup view 2", "variant_307_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 307 },
                    { 921, "Product variant 307 mockup view 3", "variant_307_mockup_3.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 307 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 922, "Product variant 308 mockup view 1", "variant_308_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 308 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 923, "Product variant 308 mockup view 2", "variant_308_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 308 },
                    { 924, "Product variant 308 mockup view 3", "variant_308_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 308 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 925, "Product variant 309 mockup view 1", "variant_309_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 309 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 926, "Product variant 309 mockup view 2", "variant_309_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 309 },
                    { 927, "Product variant 309 mockup view 3", "variant_309_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 309 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 928, "Product variant 310 mockup view 1", "variant_310_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 310 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 929, "Product variant 310 mockup view 2", "variant_310_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 310 },
                    { 930, "Product variant 310 mockup view 3", "variant_310_mockup_3.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 310 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 931, "Product variant 311 mockup view 1", "variant_311_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 311 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 932, "Product variant 311 mockup view 2", "variant_311_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 311 },
                    { 933, "Product variant 311 mockup view 3", "variant_311_mockup_3.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 311 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 934, "Product variant 312 mockup view 1", "variant_312_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 312 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 935, "Product variant 312 mockup view 2", "variant_312_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 312 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 937, "Product variant 313 mockup view 1", "variant_313_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 313 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 938, "Product variant 313 mockup view 2", "variant_313_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 313 },
                    { 939, "Product variant 313 mockup view 3", "variant_313_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 313 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 940, "Product variant 314 mockup view 1", "variant_314_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 314 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 941, "Product variant 314 mockup view 2", "variant_314_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 314 },
                    { 942, "Product variant 314 mockup view 3", "variant_314_mockup_3.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 314 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 943, "Product variant 315 mockup view 1", "variant_315_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 315 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 944, "Product variant 315 mockup view 2", "variant_315_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 315 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 946, "Product variant 316 mockup view 1", "variant_316_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 316 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 947, "Product variant 316 mockup view 2", "variant_316_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 316 },
                    { 948, "Product variant 316 mockup view 3", "variant_316_mockup_3.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 316 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 949, "Product variant 317 mockup view 1", "variant_317_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 317 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 950, "Product variant 317 mockup view 2", "variant_317_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 317 },
                    { 951, "Product variant 317 mockup view 3", "variant_317_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 317 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 952, "Product variant 318 mockup view 1", "variant_318_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 318 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 953, "Product variant 318 mockup view 2", "variant_318_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 318 },
                    { 954, "Product variant 318 mockup view 3", "variant_318_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 318 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 955, "Product variant 319 mockup view 1", "variant_319_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 319 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 956, "Product variant 319 mockup view 2", "variant_319_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 319 },
                    { 957, "Product variant 319 mockup view 3", "variant_319_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 319 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 958, "Product variant 320 mockup view 1", "variant_320_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 320 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 959, "Product variant 320 mockup view 2", "variant_320_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 320 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 961, "Product variant 321 mockup view 1", "variant_321_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 321 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 962, "Product variant 321 mockup view 2", "variant_321_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 321 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 964, "Product variant 322 mockup view 1", "variant_322_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 322 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 965, "Product variant 322 mockup view 2", "variant_322_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 322 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 967, "Product variant 323 mockup view 1", "variant_323_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 323 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 968, "Product variant 323 mockup view 2", "variant_323_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 323 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 970, "Product variant 324 mockup view 1", "variant_324_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 324 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 971, "Product variant 324 mockup view 2", "variant_324_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 324 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 973, "Product variant 325 mockup view 1", "variant_325_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 325 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 974, "Product variant 325 mockup view 2", "variant_325_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 325 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 976, "Product variant 326 mockup view 1", "variant_326_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 326 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 977, "Product variant 326 mockup view 2", "variant_326_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 326 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 979, "Product variant 327 mockup view 1", "variant_327_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 327 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 980, "Product variant 327 mockup view 2", "variant_327_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 327 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 982, "Product variant 328 mockup view 1", "variant_328_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 328 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 983, "Product variant 328 mockup view 2", "variant_328_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 328 },
                    { 984, "Product variant 328 mockup view 3", "variant_328_mockup_3.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 328 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 985, "Product variant 329 mockup view 1", "variant_329_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 329 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 986, "Product variant 329 mockup view 2", "variant_329_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 329 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 988, "Product variant 330 mockup view 1", "variant_330_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 330 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 989, "Product variant 330 mockup view 2", "variant_330_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 330 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 991, "Product variant 331 mockup view 1", "variant_331_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 331 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 992, "Product variant 331 mockup view 2", "variant_331_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 331 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 994, "Product variant 332 mockup view 1", "variant_332_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 332 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 995, "Product variant 332 mockup view 2", "variant_332_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 332 },
                    { 996, "Product variant 332 mockup view 3", "variant_332_mockup_3.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 332 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 997, "Product variant 333 mockup view 1", "variant_333_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 333 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 998, "Product variant 333 mockup view 2", "variant_333_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 333 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1000, "Product variant 334 mockup view 1", "variant_334_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 334 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1001, "Product variant 334 mockup view 2", "variant_334_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 334 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1003, "Product variant 335 mockup view 1", "variant_335_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 335 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1004, "Product variant 335 mockup view 2", "variant_335_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 335 },
                    { 1005, "Product variant 335 mockup view 3", "variant_335_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 335 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1006, "Product variant 336 mockup view 1", "variant_336_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 336 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1007, "Product variant 336 mockup view 2", "variant_336_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 336 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1009, "Product variant 337 mockup view 1", "variant_337_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 337 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1010, "Product variant 337 mockup view 2", "variant_337_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 337 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1012, "Product variant 338 mockup view 1", "variant_338_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 338 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1013, "Product variant 338 mockup view 2", "variant_338_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 338 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1015, "Product variant 339 mockup view 1", "variant_339_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 339 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1016, "Product variant 339 mockup view 2", "variant_339_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 339 },
                    { 1017, "Product variant 339 mockup view 3", "variant_339_mockup_3.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 339 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1018, "Product variant 340 mockup view 1", "variant_340_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 340 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1019, "Product variant 340 mockup view 2", "variant_340_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 340 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1021, "Product variant 341 mockup view 1", "variant_341_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 341 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1022, "Product variant 341 mockup view 2", "variant_341_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 341 },
                    { 1023, "Product variant 341 mockup view 3", "variant_341_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 341 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1024, "Product variant 342 mockup view 1", "variant_342_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 342 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1025, "Product variant 342 mockup view 2", "variant_342_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 342 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1027, "Product variant 343 mockup view 1", "variant_343_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 343 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1028, "Product variant 343 mockup view 2", "variant_343_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 343 },
                    { 1029, "Product variant 343 mockup view 3", "variant_343_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 343 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1030, "Product variant 344 mockup view 1", "variant_344_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 344 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1031, "Product variant 344 mockup view 2", "variant_344_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 344 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1033, "Product variant 345 mockup view 1", "variant_345_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 345 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1034, "Product variant 345 mockup view 2", "variant_345_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 345 },
                    { 1035, "Product variant 345 mockup view 3", "variant_345_mockup_3.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 345 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1036, "Product variant 346 mockup view 1", "variant_346_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 346 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1037, "Product variant 346 mockup view 2", "variant_346_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 346 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1039, "Product variant 347 mockup view 1", "variant_347_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 347 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1040, "Product variant 347 mockup view 2", "variant_347_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 347 },
                    { 1041, "Product variant 347 mockup view 3", "variant_347_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 347 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1042, "Product variant 348 mockup view 1", "variant_348_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 348 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1043, "Product variant 348 mockup view 2", "variant_348_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 348 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1045, "Product variant 349 mockup view 1", "variant_349_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 349 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1046, "Product variant 349 mockup view 2", "variant_349_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 349 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1048, "Product variant 350 mockup view 1", "variant_350_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 350 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1049, "Product variant 350 mockup view 2", "variant_350_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 350 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1051, "Product variant 351 mockup view 1", "variant_351_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 351 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1052, "Product variant 351 mockup view 2", "variant_351_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 351 },
                    { 1053, "Product variant 351 mockup view 3", "variant_351_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 351 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1054, "Product variant 352 mockup view 1", "variant_352_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 352 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1055, "Product variant 352 mockup view 2", "variant_352_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 352 },
                    { 1056, "Product variant 352 mockup view 3", "variant_352_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 352 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1057, "Product variant 353 mockup view 1", "variant_353_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 353 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1058, "Product variant 353 mockup view 2", "variant_353_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 353 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1060, "Product variant 354 mockup view 1", "variant_354_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 354 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1061, "Product variant 354 mockup view 2", "variant_354_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 354 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1063, "Product variant 355 mockup view 1", "variant_355_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 355 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1064, "Product variant 355 mockup view 2", "variant_355_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 355 },
                    { 1065, "Product variant 355 mockup view 3", "variant_355_mockup_3.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 355 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1066, "Product variant 356 mockup view 1", "variant_356_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 356 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1067, "Product variant 356 mockup view 2", "variant_356_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 356 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1069, "Product variant 357 mockup view 1", "variant_357_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 357 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1070, "Product variant 357 mockup view 2", "variant_357_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 357 },
                    { 1071, "Product variant 357 mockup view 3", "variant_357_mockup_3.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 357 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1072, "Product variant 358 mockup view 1", "variant_358_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 358 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1073, "Product variant 358 mockup view 2", "variant_358_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 358 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1075, "Product variant 359 mockup view 1", "variant_359_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 359 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1076, "Product variant 359 mockup view 2", "variant_359_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 359 },
                    { 1077, "Product variant 359 mockup view 3", "variant_359_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 359 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1078, "Product variant 360 mockup view 1", "variant_360_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 360 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1079, "Product variant 360 mockup view 2", "variant_360_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 360 },
                    { 1080, "Product variant 360 mockup view 3", "variant_360_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 360 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1081, "Product variant 361 mockup view 1", "variant_361_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 361 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1082, "Product variant 361 mockup view 2", "variant_361_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 361 },
                    { 1083, "Product variant 361 mockup view 3", "variant_361_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 361 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1084, "Product variant 362 mockup view 1", "variant_362_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 362 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1085, "Product variant 362 mockup view 2", "variant_362_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 362 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1087, "Product variant 363 mockup view 1", "variant_363_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 363 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1088, "Product variant 363 mockup view 2", "variant_363_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 363 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1090, "Product variant 364 mockup view 1", "variant_364_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 364 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1091, "Product variant 364 mockup view 2", "variant_364_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 364 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1093, "Product variant 365 mockup view 1", "variant_365_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 365 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1094, "Product variant 365 mockup view 2", "variant_365_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 365 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1096, "Product variant 366 mockup view 1", "variant_366_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 366 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1097, "Product variant 366 mockup view 2", "variant_366_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 366 },
                    { 1098, "Product variant 366 mockup view 3", "variant_366_mockup_3.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 366 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1099, "Product variant 367 mockup view 1", "variant_367_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 367 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1100, "Product variant 367 mockup view 2", "variant_367_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 367 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1102, "Product variant 368 mockup view 1", "variant_368_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 368 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1103, "Product variant 368 mockup view 2", "variant_368_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 368 },
                    { 1104, "Product variant 368 mockup view 3", "variant_368_mockup_3.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 368 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1105, "Product variant 369 mockup view 1", "variant_369_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 369 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1106, "Product variant 369 mockup view 2", "variant_369_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 369 },
                    { 1107, "Product variant 369 mockup view 3", "variant_369_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 369 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1108, "Product variant 370 mockup view 1", "variant_370_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 370 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1109, "Product variant 370 mockup view 2", "variant_370_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 370 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1111, "Product variant 371 mockup view 1", "variant_371_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 371 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1112, "Product variant 371 mockup view 2", "variant_371_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 371 },
                    { 1113, "Product variant 371 mockup view 3", "variant_371_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 371 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1114, "Product variant 372 mockup view 1", "variant_372_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 372 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1115, "Product variant 372 mockup view 2", "variant_372_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 372 },
                    { 1116, "Product variant 372 mockup view 3", "variant_372_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 372 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1117, "Product variant 373 mockup view 1", "variant_373_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 373 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1118, "Product variant 373 mockup view 2", "variant_373_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 373 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1120, "Product variant 374 mockup view 1", "variant_374_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 374 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1121, "Product variant 374 mockup view 2", "variant_374_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 374 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1123, "Product variant 375 mockup view 1", "variant_375_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 375 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1124, "Product variant 375 mockup view 2", "variant_375_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 375 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1126, "Product variant 376 mockup view 1", "variant_376_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 376 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1127, "Product variant 376 mockup view 2", "variant_376_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 376 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1129, "Product variant 377 mockup view 1", "variant_377_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 377 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1130, "Product variant 377 mockup view 2", "variant_377_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 377 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1132, "Product variant 378 mockup view 1", "variant_378_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 378 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1133, "Product variant 378 mockup view 2", "variant_378_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 378 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1135, "Product variant 379 mockup view 1", "variant_379_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 379 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1136, "Product variant 379 mockup view 2", "variant_379_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 379 },
                    { 1137, "Product variant 379 mockup view 3", "variant_379_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 379 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1138, "Product variant 380 mockup view 1", "variant_380_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 380 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1139, "Product variant 380 mockup view 2", "variant_380_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 380 },
                    { 1140, "Product variant 380 mockup view 3", "variant_380_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 380 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1141, "Product variant 381 mockup view 1", "variant_381_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 381 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1142, "Product variant 381 mockup view 2", "variant_381_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 381 },
                    { 1143, "Product variant 381 mockup view 3", "variant_381_mockup_3.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 381 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1144, "Product variant 382 mockup view 1", "variant_382_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 382 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1145, "Product variant 382 mockup view 2", "variant_382_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 382 },
                    { 1146, "Product variant 382 mockup view 3", "variant_382_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 382 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1147, "Product variant 383 mockup view 1", "variant_383_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 383 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1148, "Product variant 383 mockup view 2", "variant_383_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 383 },
                    { 1149, "Product variant 383 mockup view 3", "variant_383_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 383 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1150, "Product variant 384 mockup view 1", "variant_384_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 384 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1151, "Product variant 384 mockup view 2", "variant_384_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 384 },
                    { 1152, "Product variant 384 mockup view 3", "variant_384_mockup_3.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 384 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1153, "Product variant 385 mockup view 1", "variant_385_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 385 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1154, "Product variant 385 mockup view 2", "variant_385_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 385 },
                    { 1155, "Product variant 385 mockup view 3", "variant_385_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 385 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1156, "Product variant 386 mockup view 1", "variant_386_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 386 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1157, "Product variant 386 mockup view 2", "variant_386_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 386 },
                    { 1158, "Product variant 386 mockup view 3", "variant_386_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 386 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1159, "Product variant 387 mockup view 1", "variant_387_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 387 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1160, "Product variant 387 mockup view 2", "variant_387_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 387 },
                    { 1161, "Product variant 387 mockup view 3", "variant_387_mockup_3.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 387 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1162, "Product variant 388 mockup view 1", "variant_388_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 388 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1163, "Product variant 388 mockup view 2", "variant_388_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 388 },
                    { 1164, "Product variant 388 mockup view 3", "variant_388_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 388 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1165, "Product variant 389 mockup view 1", "variant_389_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 389 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1166, "Product variant 389 mockup view 2", "variant_389_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 389 },
                    { 1167, "Product variant 389 mockup view 3", "variant_389_mockup_3.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 389 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1168, "Product variant 390 mockup view 1", "variant_390_mockup_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, 390 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1169, "Product variant 390 mockup view 2", "variant_390_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 390 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1171, "Product variant 391 mockup view 1", "variant_391_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 391 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1172, "Product variant 391 mockup view 2", "variant_391_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 391 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1174, "Product variant 392 mockup view 1", "variant_392_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 392 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1175, "Product variant 392 mockup view 2", "variant_392_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 392 },
                    { 1176, "Product variant 392 mockup view 3", "variant_392_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 392 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1177, "Product variant 393 mockup view 1", "variant_393_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 393 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1178, "Product variant 393 mockup view 2", "variant_393_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 393 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1180, "Product variant 394 mockup view 1", "variant_394_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 394 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1181, "Product variant 394 mockup view 2", "variant_394_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 394 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1183, "Product variant 395 mockup view 1", "variant_395_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 395 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1184, "Product variant 395 mockup view 2", "variant_395_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 395 },
                    { 1185, "Product variant 395 mockup view 3", "variant_395_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 395 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1186, "Product variant 396 mockup view 1", "variant_396_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 396 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1187, "Product variant 396 mockup view 2", "variant_396_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 396 },
                    { 1188, "Product variant 396 mockup view 3", "variant_396_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 396 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1189, "Product variant 397 mockup view 1", "variant_397_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 397 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1190, "Product variant 397 mockup view 2", "variant_397_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 397 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1192, "Product variant 398 mockup view 1", "variant_398_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 398 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1193, "Product variant 398 mockup view 2", "variant_398_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 398 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1195, "Product variant 399 mockup view 1", "variant_399_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 399 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1196, "Product variant 399 mockup view 2", "variant_399_mockup_2.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 399 },
                    { 1197, "Product variant 399 mockup view 3", "variant_399_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 399 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1198, "Product variant 400 mockup view 1", "variant_400_mockup_1.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, true, 400 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1199, "Product variant 400 mockup view 2", "variant_400_mockup_2.jpg", "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop", true, 400 },
                    { 1200, "Product variant 400 mockup view 3", "variant_400_mockup_3.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, 400 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "BaseProductSizes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DeliveryMethods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeliveryMethods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DeliveryMethods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DeliveryMethods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d89cfd48-0b4e-4ac3-962d-357e6327790d", "AQAAAAIAAYagAAAAENEHrxq2WfsHwWfw1l6I9h1C13uTC+uVDNVRUiXtr0b+vYtXT2kqGJY1SNX6JxAKuw==", "0d6ff3b4-edd5-4491-95c0-cb9c0b2d6d77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f93e5acc-8313-42d6-8120-925f14669ea6", "AQAAAAIAAYagAAAAEG3IS5wkeOOHxJ9fdjjnsBp7bUhCRmnFwDxCgGAeRqxusRVmzHhrZEHinUGofcFrOg==", "e251c6c4-6d48-4dc2-882a-8f5849b4b415" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "008bf57d-3452-430a-ab71-17f87a9a50e4", "AQAAAAIAAYagAAAAEG8hBkHrvWE/9OKQ+4El+11Qd4/ppgK95N6AWcr5WABaMtg6AXP0nqRsS0q8goQrYQ==", "7ca57249-b173-4b74-857c-4786c5603758" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50d8528f-f4da-4534-9ddf-986239cca897", "AQAAAAIAAYagAAAAED9ZW6hO3H11Q+SYDwF6308YaqXXhiqBkVNWjjwEaAGdukJDQxvf8D/m6sG7HYleNw==", "fbb7ef33-b1d9-4ff3-b47b-838d40a90a84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2cc5179-1f97-4697-b2a3-b3759fd482b5", "AQAAAAIAAYagAAAAEJtZLRS+lJ0sPpPyNMWpCDMIH7968Ynhh82jmLEQ7IufLXm5mhcE4/rtKeDoh7/qJQ==", "585b8a4c-cf34-44e1-81b3-8ffd01db6a56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07ab89ac-7dba-4230-b7ff-738f7344c6ed", "AQAAAAIAAYagAAAAEBWOJA1n3iua6U5Gn/cugw+KU6GYYjGa7/UGOZmIq02AVGO5RSGXlFZ5llBzf+B1Fw==", "0b2e6ee0-2e28-45c5-b9b9-020571e345f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adff1d58-100f-440a-ba90-f5ff1f5372fc", "AQAAAAIAAYagAAAAEJaDxQCNDPc3zL6KuQgqWdUb1Lr5iadH0Wt7LRkKig/4veksLtQZ+wA9uGx9hhAEBQ==", "0b248334-a970-4508-9580-3235b0f9d339" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7768c4c5-2d72-45c3-bbb1-69b5148665dd", "AQAAAAIAAYagAAAAEIokplx3fQwrY4XzGqN0qshgj9LWlR+C2Gd/rrZnzSf7esO4BKndECv1BL8aO2ibeQ==", "34eade0f-b8e6-418c-aded-efdeca591959" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a408f4a3-41dd-465b-83c0-124cc10582a1", "AQAAAAIAAYagAAAAEJXK4InDLd6XTsap25KUvXlpdDi7L3KRvugp+qIEwSIZLZZuBNxmQ7UoLZ99rWHLbA==", "f4fd1553-5f22-4b61-9d4c-8851ae43c7d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f90bb67b-63ec-447b-a79c-b06155b8aae1", "AQAAAAIAAYagAAAAEOthq+16pY6oZeRXMsIbdOob/J6an2cWZRfWfw4VSZOgCrWpIjs36eIeAtTDiwSlhA==", "d725176a-70f7-4871-955d-55a7d624aa7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8ed22c5-2f0b-48c8-b360-65ab3df263a6", "AQAAAAIAAYagAAAAEJlXHV7PjUBh42ML82x+SDzSV+Ra/vuZMs+xovaL0+/mUqLtzMd72DiVgjNbb0LgTA==", "1086e8c4-afbc-4428-b2d2-81d6f83471bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cfa1131-1467-4075-b789-a87823709ff2", "AQAAAAIAAYagAAAAEJMRt4om/U8jQtaYNxkXLDppUzm1HHFn5Bgussf+JPYVTvlbYfbEOZI8Ts9xX7hjIQ==", "5404727f-7f5f-4887-a439-b89ba575812f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94ca2782-697c-4c90-9c73-c9e8f4530651", "AQAAAAIAAYagAAAAEH8DFmclOT4eQa35Tu73HRM6P1NLgqyu4THg1AY55gYWw6CAEpXRmClKFiE6U4xxwg==", "4c14b5ee-97bc-4c3e-8a55-729a3a8f21b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f43c1da-38b3-445b-b58d-f390cd9335a4", "AQAAAAIAAYagAAAAEBBKSP8hZ2fzsTEMa/+JZNVBXGAfl+lolUm80ta+M/A87vZiOTh1gteAS/dNVlVkzw==", "56cd0f47-d7f1-4544-9d1c-ed49d04ac19a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecfecb09-8eed-4692-a93d-9517aa1d18e2", "AQAAAAIAAYagAAAAEClsuAArctdtLIysyfKOKeR4dDlRMBS++V+HgC6zvSRs3Uw07GhFFq2Qum6lam6+jQ==", "231e71a0-89ae-4388-b371-bdf982ffc671" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f31928b5-d939-448c-83f8-78a1b98a2372", "AQAAAAIAAYagAAAAEM2A/ouAfwto6u9vfd/pOjrKK3VbBST7gvNNN1Q0qgqh5oPITvcDu2jXB8aSyqe1WQ==", "f65a400b-1c9a-4de6-8376-e1def8d1eb13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b7aef7d-ada7-49d0-aae0-9a56fda79a77", "AQAAAAIAAYagAAAAEG4EzjRyY0/G3QCX27SkmryWMQsfPOAhxPmijGhvMNkgyZWvL/O9mM8ifysDCoBWiQ==", "bf52bc87-8c32-4332-b6bf-9f56f5f1a72b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a301036e-fc3c-41a1-92d6-ed23f69e87f4", "AQAAAAIAAYagAAAAEILWEslcy1wlvoCSmWATPrMy0uqHhLQqqAmbjfZ8ibRLPy887Nz29e0MrzWCbqliYw==", "26106778-06f2-497a-a06c-6bc73fe755f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "def01534-e439-407e-b07e-e3367081d20a", "AQAAAAIAAYagAAAAEMIKpWvq0/02XezYUKPgsFsASY9HX35LkXGysPZ+KV7vLOuxyoODVBEJDxClVW1hAQ==", "74201c63-d1e8-49aa-ba0d-f4851878c40e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc800a07-ec18-4571-883f-52f274aa7c5e", "AQAAAAIAAYagAAAAEA/p0u1YKdfnz4Vepnwb/EasXK8SWK2xCCPjk7dQCxIpGrOLm/qLzgCP3K47kKwSTg==", "433abf9a-a601-4532-89e7-cc478cf29b07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-020",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67765cb7-3e17-486e-8cb0-0441f2135d41", "AQAAAAIAAYagAAAAEP0pV+dKw6ItPjdJEMgN6DLM4XQCOYnMzFvkYCtfR4v3PYUO2TmfJOQ2Rf0jBObE0g==", "e7d9477e-acd4-4bc9-9afc-e8c3b660d1d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-021",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cd27e28-0203-4292-ad94-f30276c6ae34", "AQAAAAIAAYagAAAAEMAJvpNY6Z57k9gk76KEd59qFxyEk8WdDURNGUNAznj3+rCbraG8I/tVzTvv0d9SOA==", "57f74f69-d982-4339-927a-b2ccb2a73f1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11e0252a-60c2-4804-a234-aa5b329b5c2a", "AQAAAAIAAYagAAAAEOoCg1A/pj+dA3mReiJZTeKsWizUFtdiY/LgSflcPW3DcFjyqo5znYn2HSB8DfO5Ow==", "7a70d589-c90d-47c4-81ee-4c2edd7399d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-023",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc330585-0634-4d6d-ad71-cd07cc33726c", "AQAAAAIAAYagAAAAEG/aZteFXlpKB5kM6VjHTCXewU+mmenJthbqN6LHwnNgM+B42IP/XKlb5O2ypbWC7w==", "6ab4cd96-13ec-4089-a157-fc0e2b1f8259" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-024",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a288cf77-2bcd-4db8-bed3-ecae43253742", "AQAAAAIAAYagAAAAECXZKio9HHPkm6RfpSvT2Z89Yg+STofLc0XbaAfb2l0S0uKrEuuUXe+1NCKtyvIViA==", "56948ffb-9dfd-4927-828b-bd7ec0515316" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-025",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae7d5bd3-5c54-4f05-986f-7c9b2841a48a", "AQAAAAIAAYagAAAAEMV2ErgOBFhibtuiI0uN7/1l76bCzBdq/mOxwiY9BGcalMdN79ozKVETGSMMTHDGgw==", "d97a7e2d-eef8-4bfd-9994-ce8347a6a312" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-026",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02fb1f90-44cf-4b0d-a209-c4d6e20c4425", "AQAAAAIAAYagAAAAEKJp1rF9c1qxZT+LoK4xBPkeg+jMOhcJxLsmeP5MINcFjIIu9SrgBVUBh5hfFf5UTQ==", "d48ce552-911a-44ae-acd5-305e745af1c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "492fc25a-957d-45a8-b012-acad6c666995", "AQAAAAIAAYagAAAAEGYoPvnF1/FKOMDNSxey+liWd3EnjrMV0tIahWURkgig46JNa0ptw/TNVGm2fe7vFg==", "9d4152fd-6035-4ade-b40b-3a5ebd3d86ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-028",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e03b4932-325e-47b7-865b-16600452be90", "AQAAAAIAAYagAAAAEFxkVAe/0EcQDa05b1OwRpZnftAGk9ReEcwKUQySqw4NbvbA8Dqrea6MSjtcW02Ccg==", "198e9799-aecd-4312-99ab-590e1797b2aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-029",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f157346-3ead-433f-a074-6b9733955e52", "AQAAAAIAAYagAAAAEM6uE3HBgv+FAoTTWIm9LSqcQh6pF67or0XFm+h7rLDWi0VpYZpXRpj5U+YW15snJA==", "5232a21e-cfd7-410b-a632-b9ccf2dc9f9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-030",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4bdae27-e275-4599-8765-fb55cadc5719", "AQAAAAIAAYagAAAAEBco2jQH0X9iTa7IroQl2qOvCvKCIUhseNw8FMAhPLt1w7Qu6k6Rl2c/PhbQUcSsuQ==", "20dc775b-8b5f-40c7-b3d7-f8db5f20ba25" });
        }
    }
}
