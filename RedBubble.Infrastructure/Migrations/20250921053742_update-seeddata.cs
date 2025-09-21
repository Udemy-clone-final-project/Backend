using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RedBubble.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b02d196-88ff-4ca4-869d-e3f05c3812d0", "AQAAAAIAAYagAAAAEEI1A4H8UdZa8BGv8FpgXmhwPPaUZNW/zxl2D/yE6w0UDZWqdaHXDBtIc1DcB6zh2Q==", "c8cea112-399a-45d9-b803-92a90e72742f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "157231dc-dce8-43de-a497-9ec11f07b18e", "AQAAAAIAAYagAAAAEBtFtr/M14hyr7uwqtzGvoIu/Pa3ORWcFUbOq9j3zZTtnXB9zrpEyvH5anY7rSeqUQ==", "1ebbe3df-1ce9-4775-b966-57796eed9505" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6244e9e8-aa00-4cdf-90e7-9905d164244e", "AQAAAAIAAYagAAAAEAEwj0zvRhKXXZZVtvkBQWspHbkAakTuBN+ZQz7Pap/RSwG+SiSSIz4b0oYjPCAWTw==", "149f7748-d9e0-42ea-9cd2-6d0b474a5e67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "113df8bd-2a31-49fe-ad46-3e2f59c757de", "AQAAAAIAAYagAAAAEElau7BtwGhpbjXCdUMA1lBGeC1OE6KYqoXtsi2z+PiD+fH9yOFuXBppe1NZlj/eqg==", "68ecffd8-5433-4391-996f-81dbec7147e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "206fb63a-b9fb-4661-9210-23964b98c387", "AQAAAAIAAYagAAAAEEFisKHODdTRvRRGJdgmJ4gvXLyg/YiszAHALj33/ew4GaaceIQ8OEecnByW3bgTmg==", "2da372dd-b072-4fbf-b075-1e5b53ce1e13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01973c5f-b041-473e-b62c-337deb8aaf56", "AQAAAAIAAYagAAAAEJv2Q3fGUKzxI+W05vm4B6GHZ1kI0OTHfJ0WNrwly+ptJboRRafcF221ouSVASB/Og==", "5d814fd8-e6a3-4f33-9e5a-fb4fbb2f772d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d6d765d-b83f-4edc-a661-f9769a7cb250", "AQAAAAIAAYagAAAAEPDmWzJeNLlKu+g5eHh8qlCZE2KtYyPSlXUuxpphqDFHmehJSy1dtm5nhAHR4MlvrA==", "8418b429-d150-4d8f-ab54-f622ec1ff4bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89b73d3a-7f8b-49c1-8da8-e934830bc3fe", "AQAAAAIAAYagAAAAENqhCVpnDxqRfsC0QWdRxdX0J8UYJZiA6BcSdohcGOOKyi8dwEEITBrfaURdDkWFDw==", "c654e821-3036-4c6d-9929-f82ab296e179" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43382343-ba2d-41b5-9687-569a15f89d18", "AQAAAAIAAYagAAAAEJunqL/GA5ABe8v2+umbt1HWe1WeAANWRLToOD+dhwT6BMpmZslu8MzWZgXq/7HGIA==", "83a82a86-6de6-4d5b-864e-e4fa52109bc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a4fb01e-b7c5-4d05-bfc4-51094412b4c4", "AQAAAAIAAYagAAAAEKAAbL1PVg4kSDyZIfrO3P+gmbj2YvUuIWIg0gvDI2xbcwcMlHFcPXDOMByiyGeLcQ==", "97eeb1bb-f56a-457c-90eb-87f487198e3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52c4228a-c970-49fa-b45f-83033cf3b59c", "AQAAAAIAAYagAAAAEH9iRAXqO6y3FMAcgnogcCL1cfToAjNhM61NE/PWBJGRtdMfP371kiae5YY2KlkTzg==", "4d2dd286-175b-486d-b0f3-70c994b11fe5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e50ce310-3226-40cd-a2bd-b706e4e22088", "AQAAAAIAAYagAAAAEM0qwwYRjO7hBdpCc2AsHL8V92ALiN72MzNqvG7abxfQSOcQg6AeU8Zie7CGoKFltA==", "6c37acea-640f-4608-a869-5588d8adfd2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76f51a1b-2091-4627-bc10-2a5613a4e85e", "AQAAAAIAAYagAAAAELClwVATqv0SFeZuDAnhtNDBPp7qC04+lRCgo8lshgZbTx7htZCdQB4+jyiYQ7ChLA==", "2f4762cb-b934-473b-bda6-f7ed51729e6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1309b54f-6c80-433f-9372-81829e0df932", "AQAAAAIAAYagAAAAEJvA5AotCriSptbZJWcJjTgb8mxev1tat+3BkdJ3IWA/sVKsLwnECYmzXhoAwpCekg==", "6480210d-e51d-496e-a10c-92f3af69afe9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbc18824-28ee-48e1-8532-29f7572aae98", "AQAAAAIAAYagAAAAEKkfStBW/MXjjNbucvFlJ64RDEF94gTQyoEmJ/UQs9Mb1kEPsfZZothAF1RxIOPjiA==", "0e1d1210-5caa-4e36-9a8c-e77c95e8adcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de2b398f-e0b9-4b19-9c38-2d70c1260578", "AQAAAAIAAYagAAAAEMBLfGcaR9w1RJMslPdGd2Iw0U18aiB3sA5NaCHUOdYgzP/raSxKYGiJYC8WmdeFew==", "c2fb36a8-7ef9-4607-9b25-f44d7d1845e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9be83d2-0797-4fbf-b5c8-11a95f7027a4", "AQAAAAIAAYagAAAAENpIjKQSCX6RkDgyBuFKPgzyL/GTTULhCkxVy434Z5Ph8awSeeSKnRFGYeUhDEYjLA==", "88edb54d-6411-48c9-b19d-dd5389008077" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d1dc8d6-d7a0-4a44-9b41-4ea61d201da2", "AQAAAAIAAYagAAAAEAJb9S3dZke97abZLLWy65E0lT9GNDrEx9N13A7IocW4NiITyDTzkPCI405ToK0JAA==", "84d133ff-cc8e-40f5-93be-147833a0bc69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66e9e007-b721-4e62-8b40-9ef8719eb344", "AQAAAAIAAYagAAAAEHcX2cuGA9DX28Faq/nZ8uGph5BfG6ftbK9JcJjNUTZBBCpSKgAI+P/pxz9k/W568Q==", "beeef559-9f36-4dc6-b41d-65f71efc4d8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "450a6689-c354-4ffa-b51e-5e13c8075f5d", "AQAAAAIAAYagAAAAEI0eF2JHsLCOZ/1swPgjbpetH1tZk4EtCU+92EIXzQy+w9L0hY0oh7FgOv+C7rizNQ==", "676eadbe-b83f-4343-80ac-7e908594d7c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-020",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78be4c26-5f08-4b2a-9c5b-938fb839d7aa", "AQAAAAIAAYagAAAAEO9HKy8jxmZ0fVP2w/NDTTY7qmtJw0vI0WA1nRvo0dsI4dQswcqxzKDTOXuu5oaIpw==", "b1a46fa8-a7fa-4535-8327-6fb9781a9906" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-021",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ec629d3-bfd4-4ee8-b767-e887c20fc767", "AQAAAAIAAYagAAAAEINit1q1EVZEFKDSQbYvazuUVkXJl+7AlftmoWLHhanRxiPHFXDk2jhBISMf0eyskw==", "4ffa6a43-e083-4973-928d-d686b386bf97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc3f2613-7ac8-4c7e-b4fb-960d6b5f0471", "AQAAAAIAAYagAAAAEK5dJjWRjpHYEhEMyjhWep2MiUA+W6kP8mQ5AmIW5cy+ifyNLsc1gyN6JXbH3N1hfw==", "c2256e25-d4d5-458e-a504-e089b66e83bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-023",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dafc1735-2c27-4ea5-81a6-c428610ae88b", "AQAAAAIAAYagAAAAEE71cs/090B0c9QUFrmN1RIrye6KgZCeV9LUEPfL/GKVFWIghE6AUkMUnJKB65/R3A==", "fc50d114-a899-4c1a-abaa-f17406b9c367" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-024",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ba5ec62-ef7a-4d0d-bff0-b3bf19f8bdbf", "AQAAAAIAAYagAAAAEIUISMkT4VISYt11/vP6ZPNijstzhI7ldEmxis/x9RUdamx2IQYnqRAkz36L9KSvNQ==", "73a7b822-5bbc-4a5f-afe2-3c93acc836e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-025",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0cc29c6-1fa5-496f-8c9c-9f5e9dbf1ba9", "AQAAAAIAAYagAAAAECom6tn+YJrRbQyMshjEcXxk0QfdomSQ4d3lpKPc/YGFggpjudPEU3ypgLHSSUNIwg==", "7d8d87de-4bbc-46f2-8ea3-a46a38e19ed0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-026",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a16be54-bd78-473d-8a4a-ecca9c424a3c", "AQAAAAIAAYagAAAAEAOeRVllqXvXhky05uXDevBVEiDJVGd0AXDitgEKhBGjW/GlUDv7SivyjzRh5Nwr5g==", "cb147c34-74ad-4ee2-a04b-27c31083c564" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdc7fe3b-a145-42c5-a332-07caa49bb421", "AQAAAAIAAYagAAAAEPlWc8t3ilmFhWrBOT+BwMjOrATdMA5TBKTa3L4vZE/FuL58hiPTL6z8AoRCR38e+Q==", "08104505-d5a9-4136-95d8-90e0d8b92461" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-028",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e216bab4-8f2d-4e18-97e0-6998897856bd", "AQAAAAIAAYagAAAAENEZtmbATDEkjWB8AvvKJutmNVh87yNM1dK96USMQwbYJ/JvkT0yUm2BwVOApl9XYg==", "3948e923-a0b7-4834-99aa-1595e556563e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-029",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b97bea1d-cc01-4ebb-a237-9faddd7a9c4d", "AQAAAAIAAYagAAAAEA64U0fiBYxL5yBY7cMkDoFnwRM1WJZHrNEaYLqLHUfbWvyGfne50duaaxKKUL47aA==", "cb8295ec-7349-48de-b229-3b28528ed2c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-030",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bdf9b3d-780b-45dd-8537-7ea464db5260", "AQAAAAIAAYagAAAAEMLMC9/GndYJgPvKtJG9dqzHF7xr293jwk32IgUOIdi/SAwzF3sQwhoK9pErC/ws8A==", "4a4c36a9-e4ce-465c-950f-d16572f79e96" });

            migrationBuilder.InsertData(
                table: "BaseProducts",
                columns: new[] { "Id", "BasePrice", "CategoryId", "CreatedBy", "CreatedOn", "Description", "HasColors", "IsActive", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 100, 4.99m, 4, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pack of 3 durable vinyl stickers, weather resistant", true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vinyl Sticker Set" },
                    { 101, 2.99m, 4, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-quality decal sticker for laptops, phones, and more", true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Decal Sticker" },
                    { 102, 3.99m, 4, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Weather-resistant bumper sticker for cars and vehicles", true, true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bumper Sticker" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "ParentCategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "ParentCategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "ParentCategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "ParentCategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "ParentCategoryId",
                value: 8);

            migrationBuilder.InsertData(
                table: "BaseProductColors",
                columns: new[] { "Id", "BaseProductId", "ColorId", "ColorSpecificMockupUrl", "IsActive" },
                values: new object[,]
                {
                    { 81, 100, 1, null, true },
                    { 82, 100, 2, null, true },
                    { 83, 100, 3, null, true },
                    { 84, 100, 4, null, true },
                    { 85, 100, 5, null, true },
                    { 86, 100, 6, null, true },
                    { 87, 100, 7, null, true },
                    { 88, 100, 8, null, true },
                    { 89, 101, 1, null, true },
                    { 90, 101, 2, null, true },
                    { 91, 101, 3, null, true },
                    { 92, 101, 4, null, true },
                    { 93, 101, 5, null, true },
                    { 94, 101, 6, null, true },
                    { 95, 101, 7, null, true },
                    { 96, 101, 8, null, true },
                    { 97, 102, 1, null, true },
                    { 98, 102, 2, null, true },
                    { 99, 102, 3, null, true },
                    { 100, 102, 4, null, true },
                    { 101, 102, 5, null, true },
                    { 102, 102, 6, null, true },
                    { 103, 102, 7, null, true },
                    { 104, 102, 8, null, true }
                });

            migrationBuilder.InsertData(
                table: "BaseProductPrintAreas",
                columns: new[] { "Id", "AreaName", "BaseProductId", "DisplayOrder", "Height", "IsActive", "MinDPI", "Width" },
                values: new object[,]
                {
                    { 21, "Full", 100, 1, 3.0m, true, 300, 3.0m },
                    { 22, "Full", 101, 1, 3.0m, true, 300, 3.0m },
                    { 23, "Full", 102, 1, 3.0m, true, 300, 3.0m }
                });

            migrationBuilder.InsertData(
                table: "BaseProductTemplates",
                columns: new[] { "Id", "BaseProductId", "DisplayOrder", "FlatMockupUrl", "IsActive", "IsPrimary", "MockupUrl", "TemplateHeight", "TemplateUrl", "TemplateWidth", "ViewName" },
                values: new object[,]
                {
                    { 26, 100, 1, null, true, true, "/mockups/sticker-mockup.jpg", 300, "/templates/sticker-template.png", 300, "Front" },
                    { 27, 101, 1, null, true, true, "/mockups/sticker-mockup.jpg", 300, "/templates/sticker-template.png", 300, "Front" },
                    { 28, 102, 1, null, true, true, "/mockups/sticker-mockup.jpg", 300, "/templates/sticker-template.png", 300, "Front" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "BaseProductColors",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BaseProductPrintAreas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BaseProductTemplates",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 102);

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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "ParentCategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "ParentCategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "ParentCategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "ParentCategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "ParentCategoryId",
                value: 4);
        }
    }
}
