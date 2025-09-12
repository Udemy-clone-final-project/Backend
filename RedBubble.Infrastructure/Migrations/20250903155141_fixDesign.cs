using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedBubble.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Designs_AspNetUsers_ApplicationUserId",
                table: "Designs");

            migrationBuilder.DropForeignKey(
                name: "FK_Designs_AspNetUsers_ApplicationUserId1",
                table: "Designs");

            migrationBuilder.DropIndex(
                name: "IX_Designs_ApplicationUserId",
                table: "Designs");

            migrationBuilder.DropIndex(
                name: "IX_Designs_ApplicationUserId1",
                table: "Designs");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Designs");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Designs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2025, 9, 3, 15, 51, 33, 648, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedAt",
                value: new DateTime(2025, 9, 3, 15, 51, 33, 648, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-001",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cc6c46bd-3511-44b6-9fe9-5c8718cf0f4b", new DateTime(2025, 9, 3, 15, 51, 33, 797, DateTimeKind.Utc).AddTicks(2039), "AQAAAAIAAYagAAAAEBOy5xB7tQrcJnRrmn7rtc1xk6KydZoNb7g4m4/vHzAk9FindyMWcbu+FhO9x8umDQ==", "b4a34db5-3e4b-4ce7-956a-f485bac57b89", new DateTime(2025, 9, 3, 15, 51, 33, 797, DateTimeKind.Utc).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-001",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9dd30f5a-d099-4b69-bd41-bfac183746d4", new DateTime(2024, 12, 12, 15, 51, 33, 936, DateTimeKind.Utc).AddTicks(6005), "AQAAAAIAAYagAAAAEGbQRM8aD0H5yw2bzK+N2DoH1jFdjvAyKUBm0fGri6vGWFeIOf6IrqV6o5pXpksoLg==", "d8ecf498-ec49-4e41-9e81-b57e4e14ae25", new DateTime(2025, 8, 12, 15, 51, 33, 936, DateTimeKind.Utc).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-002",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dec1801a-fee1-4f76-a65e-59d86ad966d1", new DateTime(2025, 6, 4, 15, 51, 34, 72, DateTimeKind.Utc).AddTicks(9004), "AQAAAAIAAYagAAAAEM/MiNRHPjggiMRynGQ2ugFyarmpALdZeyWLqoAJQqweveXLOy85yJ0ArelT3MWg9g==", "9b9f9ba7-64f3-46ae-ac22-d4e685c23ad9", new DateTime(2025, 8, 26, 15, 51, 34, 72, DateTimeKind.Utc).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-003",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a96820de-d0b7-4121-82bc-abd84b857f54", new DateTime(2024, 11, 26, 15, 51, 34, 216, DateTimeKind.Utc).AddTicks(4894), "AQAAAAIAAYagAAAAEHXt/ReNwOxOMbmJGlL1zkMwCYSaUTvfiECIf8DVgYnFnQ7Nydexd5CSZaFWm6C3fA==", "6777c3e2-f119-4e81-97f8-9f4756eaf3c3", new DateTime(2025, 8, 11, 15, 51, 34, 216, DateTimeKind.Utc).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-004",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a7c661ff-938c-4a54-8eab-8a3f915a8e2d", new DateTime(2025, 5, 19, 15, 51, 34, 352, DateTimeKind.Utc).AddTicks(9140), "AQAAAAIAAYagAAAAEOluXKKmP1TV6iGnL7mbZS8JpT49lqVsiR2mI5SyKp6n5wTE6/G5lV2qJ0TFeWEUJQ==", "127023f4-69c5-470b-b7f8-511265f36245", new DateTime(2025, 8, 25, 15, 51, 34, 352, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-005",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dd84222b-29ab-4c70-90bf-ac79b3e11f18", new DateTime(2024, 11, 9, 15, 51, 34, 504, DateTimeKind.Utc).AddTicks(2499), "AQAAAAIAAYagAAAAEJntqqdQfJz2hyK5my51Z/xhAZXxa57YfguNdjjjnXI+FlwFFqaW4wG7jPMZo68hww==", "b3c1a86b-f866-4d25-9c24-bdd14af54309", new DateTime(2025, 8, 10, 15, 51, 34, 504, DateTimeKind.Utc).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-006",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "035dd276-2a31-4531-8ad9-87b9e1bb465e", new DateTime(2025, 5, 2, 15, 51, 34, 652, DateTimeKind.Utc).AddTicks(691), "AQAAAAIAAYagAAAAEFN38T5+eKZSsMsrW/m5WqdukJlm/Tp2q6wFFfuvXhGPRziA/hz9C34FdNAum5G2bQ==", "85942653-e200-4061-91cd-2596cff245e9", new DateTime(2025, 8, 24, 15, 51, 34, 652, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-007",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "62944773-8a5d-4bc0-bac1-76990c06fd33", new DateTime(2024, 10, 24, 15, 51, 34, 797, DateTimeKind.Utc).AddTicks(7521), "AQAAAAIAAYagAAAAEAwfyv10Rbfq4ISg2B2KKoQ6xjbrhq0O8zAs1YQF4NloHib+Hx4q4ZZCNcQlyrAFRg==", "e0e0096c-8c6b-4928-959b-b25e473877d6", new DateTime(2025, 8, 9, 15, 51, 34, 797, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-008",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ed98598c-a7ad-4594-ac82-d77a16a464dd", new DateTime(2025, 4, 16, 15, 51, 34, 932, DateTimeKind.Utc).AddTicks(8351), "AQAAAAIAAYagAAAAEN52APZcHPIBUbheQXDYXFXiPrBlW88tZXNdnjgn9KCaC4HkszCgdEr9qk3HYjBjXQ==", "e61c4490-b64e-41fc-9156-f233ec93427d", new DateTime(2025, 8, 22, 15, 51, 34, 932, DateTimeKind.Utc).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-009",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5e0eb222-e991-4230-a4d3-236778758551", new DateTime(2024, 10, 8, 15, 51, 35, 73, DateTimeKind.Utc).AddTicks(6125), "AQAAAAIAAYagAAAAEPld8CKc1JIO6r8nE1Iqd7Y2OL48MrQGmT/6x9kLIcvUPD/F8tdKLuMKTWeKQ66YtQ==", "ee80884b-daea-4020-8721-7859bae97025", new DateTime(2025, 8, 7, 15, 51, 35, 73, DateTimeKind.Utc).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-010",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e07a9f78-1ebf-4d7b-9ad1-49a1c53186d0", new DateTime(2025, 3, 31, 15, 51, 35, 211, DateTimeKind.Utc).AddTicks(4408), "AQAAAAIAAYagAAAAEDulwnQaS1y/IJ0+hnMSZvaj/5+DX1vZ9IazTNa4PF/KR3qOcUrHsfh9/C22eJpEBg==", "d9158470-e579-4e87-955b-3e70ab1808e5", new DateTime(2025, 8, 21, 15, 51, 35, 211, DateTimeKind.Utc).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-011",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cf8b8437-2086-4708-a2ad-aa265483672d", new DateTime(2024, 9, 22, 15, 51, 35, 345, DateTimeKind.Utc).AddTicks(643), "AQAAAAIAAYagAAAAEBKRY3B6F7AvkyOTE6qGg21iVReOS7epQhGhgS54E8eTaev3xUOzEJ31QbfdyXL5rg==", "ed58a0f8-0bd0-4888-86ec-1c5553eb21d9", new DateTime(2025, 8, 6, 15, 51, 35, 345, DateTimeKind.Utc).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-012",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "65e8dd28-22b5-459a-9a2f-1a3df7f017ee", new DateTime(2025, 3, 14, 15, 51, 35, 480, DateTimeKind.Utc).AddTicks(3866), "AQAAAAIAAYagAAAAEH64ul6fayL7kVxOHYxYZ55K7MGY9dRw+iwTky/yt0sy9s05woPg6FU1kYmK41PRMQ==", "36ec503e-a1b6-430a-b062-64c582deb1f8", new DateTime(2025, 8, 20, 15, 51, 35, 480, DateTimeKind.Utc).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-013",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d145644a-82a0-4ca0-ba20-7ccad1123b62", new DateTime(2024, 9, 5, 15, 51, 35, 605, DateTimeKind.Utc).AddTicks(4101), "AQAAAAIAAYagAAAAEFTVUURWu123seTrjUxnnFLicAEVoAz+4mx/6hxBffAJCT/TAe2bSQ/Yt4WNWKNGPw==", "ef443d68-2177-44e0-9494-b63ab58c350b", new DateTime(2025, 8, 5, 15, 51, 35, 605, DateTimeKind.Utc).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-014",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a5bda1c5-4009-4a7b-9443-2ee86bb9627a", new DateTime(2025, 2, 26, 15, 51, 35, 719, DateTimeKind.Utc).AddTicks(5252), "AQAAAAIAAYagAAAAECMT/bs02SLY9gEXfz4FLqPSKFNwehiKbq2zLJtrY3LCxtbRsvp85p1GeRz0Drftig==", "95ac078a-6dd4-469f-a7af-90c0adf4dc65", new DateTime(2025, 8, 18, 15, 51, 35, 719, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-015",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c3dd43d9-f291-4b23-9ceb-bd4b92537fd8", new DateTime(2025, 8, 19, 15, 51, 35, 834, DateTimeKind.Utc).AddTicks(265), "AQAAAAIAAYagAAAAEHCurw1afrp+rd59XbFGwuGavq5EkmoV2CbTgQwa1f709EcXlUwRmlVGkPNQa1zqKQ==", "a8391006-b413-481a-bad4-85b89c37c759", new DateTime(2025, 9, 1, 15, 51, 35, 834, DateTimeKind.Utc).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-016",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0aabf61e-ae3c-40ea-ac89-b82b2f6b75b8", new DateTime(2025, 2, 10, 15, 51, 35, 936, DateTimeKind.Utc).AddTicks(3928), "AQAAAAIAAYagAAAAEEKAFbGnXcUZPWXgLLFsnUhMh5WBDWISdZQXW5VKZneRYrMAE0xim/CoagZaByz0Yw==", "bb1ca9e7-17fd-4e2b-8ce1-0dc47b1d9cfb", new DateTime(2025, 8, 17, 15, 51, 35, 936, DateTimeKind.Utc).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-017",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "24c4a76e-7b80-49d2-ad62-a1d5b6920883", new DateTime(2025, 8, 3, 15, 51, 36, 38, DateTimeKind.Utc).AddTicks(2035), "AQAAAAIAAYagAAAAENfshQLdK0M3cHDfk6i1dSoHZMfZHSWwEK/0WYiErPvEM7WIyiQum2RnfDlsoOj6cw==", "3f3ecf51-f4af-43d2-bebb-42fbf1e54b9e", new DateTime(2025, 8, 31, 15, 51, 36, 38, DateTimeKind.Utc).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-018",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0fd352bc-a288-4ad5-ae78-7538a5247713", new DateTime(2025, 1, 24, 15, 51, 36, 140, DateTimeKind.Utc).AddTicks(8537), "AQAAAAIAAYagAAAAEF3U/vnW0hU7FqnSzFL5oV7OOJNJ/dLkIvrwqB4DfdsH/HGtF3RfWhglwGSZAPTl0A==", "e25bf8ae-2a37-4482-b8b8-fd1656caa5f6", new DateTime(2025, 8, 16, 15, 51, 36, 140, DateTimeKind.Utc).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-019",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e946ff9b-a7eb-4b62-af7a-ea8301f009ba", new DateTime(2025, 7, 17, 15, 51, 36, 243, DateTimeKind.Utc).AddTicks(9146), "AQAAAAIAAYagAAAAEDuU4F1GyUUHAJ9xTpS2eP9GKU715JVjLvUge1hNlb25u7MOs6V30EZKEeBCT/sb8w==", "e1dd6baa-9e6f-4b88-96c1-8b95af025755", new DateTime(2025, 8, 30, 15, 51, 36, 243, DateTimeKind.Utc).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-020",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dbf86e06-dcf7-4634-82f3-eecae1f44985", new DateTime(2025, 1, 8, 15, 51, 36, 346, DateTimeKind.Utc).AddTicks(9488), "AQAAAAIAAYagAAAAEBqNJSioPVsh+u9x1AB5NS1L66snIhB/1P013ZjMYMMwROzQPeHp0kfscL0uoOFVSw==", "4596766c-b4d6-4e68-94a4-12545e560152", new DateTime(2025, 8, 15, 15, 51, 36, 346, DateTimeKind.Utc).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-021",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ae4f8c63-c644-43c2-9673-bc94b7f64ff1", new DateTime(2025, 7, 1, 15, 51, 36, 450, DateTimeKind.Utc).AddTicks(6829), "AQAAAAIAAYagAAAAENEUOnuJbHC6ILr/YaMa3fPizggbBCtEMA0oCKoRLlb60EPXblLQIX/w34cKoaIc2Q==", "4da97e94-4062-41e2-9d14-0741edfb9b9d", new DateTime(2025, 8, 28, 15, 51, 36, 450, DateTimeKind.Utc).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-022",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "acb02d9b-71f1-45b1-ae77-bb4082281aaf", new DateTime(2024, 12, 23, 15, 51, 36, 557, DateTimeKind.Utc).AddTicks(9250), "AQAAAAIAAYagAAAAEOGiFpDZQMvYHywOtbq/orubQBIXcrJP6R/uH2k2Oet9uavzsoezr57x6g5HZ9BRBw==", "fa35229c-6623-4a7e-ae30-de798b14174c", new DateTime(2025, 8, 13, 15, 51, 36, 557, DateTimeKind.Utc).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-023",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7fdeeee7-0dd2-443a-bea3-738febb980b2", new DateTime(2025, 6, 15, 15, 51, 36, 662, DateTimeKind.Utc).AddTicks(6775), "AQAAAAIAAYagAAAAEPN7KewEI53mI5bsaGJTCSqzukFT8z62EXhVOcwCmWUKLySdZbri3TNC5mfV8K7WOw==", "1bff83da-331f-4d06-b5d2-91285c48c20c", new DateTime(2025, 8, 27, 15, 51, 36, 662, DateTimeKind.Utc).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-024",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2517eff5-2f88-4f51-84f1-aaa711c26123", new DateTime(2024, 12, 6, 15, 51, 36, 767, DateTimeKind.Utc).AddTicks(9466), "AQAAAAIAAYagAAAAEBvaqpZt++8e1IHk9yauexv9LfUML6IfyC+QqYIxcNpPyWdWROjV+ofSx8gn07hzfg==", "f09e6eb7-784f-4afc-9b5a-6e596ee8a892", new DateTime(2025, 8, 12, 15, 51, 36, 767, DateTimeKind.Utc).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-025",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d49fb59a-dff4-4d6c-bb02-ad45b36252f4", new DateTime(2025, 5, 29, 15, 51, 36, 870, DateTimeKind.Utc).AddTicks(5886), "AQAAAAIAAYagAAAAEDuCkBFiuTIKK47j6OTTsxka7jYykX+GZ8RNkbFFimZra4U9lRVYnKGcIIQ7qIZNJw==", "0c098ebe-6ff1-43c3-b638-4e1e7181c80b", new DateTime(2025, 8, 26, 15, 51, 36, 870, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-026",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "10bdeda9-893f-4785-8cc0-6494e89b236a", new DateTime(2024, 11, 20, 15, 51, 36, 972, DateTimeKind.Utc).AddTicks(253), "AQAAAAIAAYagAAAAEChmzMzLUr3zlBzaOGqesU1RHhGoessmPPoLVrUwqmG4597AhJxg0EJwZMXoFtHKew==", "db283458-0b9a-495d-8c8f-0b3ff678e8d2", new DateTime(2025, 8, 11, 15, 51, 36, 972, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-027",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e1c9261d-5959-4866-bc58-b8ff38bb3dbe", new DateTime(2025, 5, 13, 15, 51, 37, 74, DateTimeKind.Utc).AddTicks(3891), "AQAAAAIAAYagAAAAELQfVyTtRpz2KGwxk6EPwwAa3QakMpPYcQoCAs97RnXMOOoMIxvWF+LqYd5G00umGA==", "9741f74d-a82e-4e96-94a8-b9f4921c91af", new DateTime(2025, 8, 25, 15, 51, 37, 74, DateTimeKind.Utc).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-028",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d8f6ec60-9945-4cb5-9a23-364796c27f82", new DateTime(2024, 11, 4, 15, 51, 37, 177, DateTimeKind.Utc).AddTicks(7537), "AQAAAAIAAYagAAAAEFPauKYi6geGx5H9i/L3g0nUlfxpBMp/4NfHGaRX6R/tHYgZlLfLVUdBis0sNHiC5Q==", "b3d671f3-1110-4030-90de-041feed8c96d", new DateTime(2025, 8, 9, 15, 51, 37, 177, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-029",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "fd60a9d2-a614-4b08-85f8-5894a0034dc2", new DateTime(2025, 4, 27, 15, 51, 37, 290, DateTimeKind.Utc).AddTicks(5687), "AQAAAAIAAYagAAAAEMdmJLjzV4bR0df6gAoKZEJ/AIp5F/9QlRBYK2Q1XzVuzXVnr0me35cDwT69clEXTg==", "c52c599f-46b9-4e83-9c1f-03fb3d972ae9", new DateTime(2025, 8, 23, 15, 51, 37, 290, DateTimeKind.Utc).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-030",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4985a48b-65a6-4a25-acd7-a28912bfb01d", new DateTime(2024, 10, 18, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(2714), "AQAAAAIAAYagAAAAEBSuXd+srQqafnQc8wFJ7ZiaSb61PnfZeenVjcftEiNPDsMmhoDzH6R4R5iSep93qw==", "ae2317d4-4ad5-4507-b034-96d220f06a81", new DateTime(2025, 8, 8, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 7, 10, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 7, 8, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 7, 6, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 25, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 7, 7, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 27, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 7, 9, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 7, 6, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 7, 5, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 15, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 7, 3, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 10, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 6, 30, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 5, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 7, 2, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 13, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 7, 4, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 7, 6, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 21, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 7, 7, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 31, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 6, 27, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 26, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 6, 29, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 5, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7558), new DateTime(2025, 8, 4, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 5, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7583), new DateTime(2025, 8, 4, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 5, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7587), new DateTime(2025, 8, 4, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 5, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7591), new DateTime(2025, 8, 4, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 5, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7594), new DateTime(2025, 8, 4, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 5, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7599), new DateTime(2025, 8, 4, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 5, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7602), new DateTime(2025, 8, 4, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 5, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7606), new DateTime(2025, 8, 4, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 10, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7618), new DateTime(2025, 8, 9, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 10, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7623), new DateTime(2025, 8, 9, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 10, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7626), new DateTime(2025, 8, 9, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 10, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7630), new DateTime(2025, 8, 9, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 10, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7633), new DateTime(2025, 8, 9, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 10, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7637), new DateTime(2025, 8, 9, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 10, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7640), new DateTime(2025, 8, 9, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 10, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7644), new DateTime(2025, 8, 9, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 15, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7656), new DateTime(2025, 8, 14, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 15, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7661), new DateTime(2025, 8, 14, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 15, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7665), new DateTime(2025, 8, 14, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 15, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7669), new DateTime(2025, 8, 14, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 15, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7672), new DateTime(2025, 8, 14, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7683), new DateTime(2025, 8, 19, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7687), new DateTime(2025, 8, 19, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7691), new DateTime(2025, 8, 19, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7899), new DateTime(2025, 8, 19, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7903), new DateTime(2025, 8, 19, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7906), new DateTime(2025, 8, 19, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7910), new DateTime(2025, 8, 19, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7913), new DateTime(2025, 8, 19, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 25, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7925), new DateTime(2025, 8, 24, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 25, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7929), new DateTime(2025, 8, 24, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 25, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7932), new DateTime(2025, 8, 24, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 25, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7936), new DateTime(2025, 8, 24, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 25, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7941), new DateTime(2025, 8, 24, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9540), new DateTime(2025, 8, 24, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 17, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9651), new DateTime(2025, 8, 1, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 19, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9669), new DateTime(2025, 4, 27, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 7, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9681), new DateTime(2025, 7, 15, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9748), new DateTime(2025, 9, 13, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9767), new DateTime(2025, 8, 27, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 29, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9780), new DateTime(2025, 6, 19, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 24, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9792), new DateTime(2025, 4, 8, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9802), new DateTime(2025, 9, 12, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9813), new DateTime(2025, 9, 26, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9824), new DateTime(2025, 6, 27, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 16, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9836), new DateTime(2025, 4, 20, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 17, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9845), new DateTime(2025, 5, 6, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9857), new DateTime(2025, 9, 10, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9866), new DateTime(2025, 7, 8, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9876), new DateTime(2025, 9, 8, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 27, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9940), new DateTime(2025, 5, 11, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 13, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9952), new DateTime(2025, 4, 28, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9963), new DateTime(2025, 9, 2, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9973), new DateTime(2025, 8, 24, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 20, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9983), new DateTime(2025, 3, 31, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9992), new DateTime(2025, 8, 31, 15, 51, 37, 412, DateTimeKind.Utc).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3), new DateTime(2025, 4, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(13), new DateTime(2025, 4, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(24), new DateTime(2025, 4, 8, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(33), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(44), new DateTime(2025, 4, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(103), new DateTime(2025, 6, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 5, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(114), new DateTime(2025, 5, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 9, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(123), new DateTime(2025, 3, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(212), new DateTime(2025, 3, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(223), new DateTime(2025, 9, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(233), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 7, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(244), new DateTime(2025, 7, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(254), new DateTime(2025, 9, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(264), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(274), new DateTime(2025, 6, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 11, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(283), new DateTime(2025, 7, 12, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(344), new DateTime(2025, 4, 11, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(660), new DateTime(2025, 4, 6, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(674), new DateTime(2025, 5, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(688), new DateTime(2025, 7, 7, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(700), new DateTime(2025, 3, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(713), new DateTime(2025, 4, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(728), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(741), new DateTime(2025, 5, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(753), new DateTime(2025, 3, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(767), new DateTime(2025, 6, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(780), new DateTime(2025, 5, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(794), new DateTime(2025, 5, 8, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(979), new DateTime(2025, 8, 7, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 11, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(994), new DateTime(2025, 5, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1007), new DateTime(2025, 4, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 11, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1022), new DateTime(2025, 7, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1036), new DateTime(2025, 6, 8, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1051), new DateTime(2025, 5, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1065), new DateTime(2025, 6, 7, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1078), new DateTime(2025, 4, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1092), new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1105), new DateTime(2025, 8, 11, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1119), new DateTime(2025, 6, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 7, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1133), new DateTime(2025, 5, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 9, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1195), new DateTime(2025, 8, 6, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1211), new DateTime(2025, 6, 13, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1226), new DateTime(2025, 6, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1242), new DateTime(2025, 3, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1258), new DateTime(2025, 6, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 4, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1272), new DateTime(2025, 6, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1285), new DateTime(2025, 3, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 8, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1299), new DateTime(2025, 5, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1314), new DateTime(2025, 7, 6, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1327), new DateTime(2025, 5, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1489), new DateTime(2025, 9, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1505), new DateTime(2025, 3, 12, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1519), new DateTime(2025, 7, 8, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1533), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1548), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1561), new DateTime(2025, 7, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1574), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 5, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1588), new DateTime(2025, 5, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1601), new DateTime(2025, 5, 11, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1615), new DateTime(2025, 4, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1628), new DateTime(2025, 5, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1726), new DateTime(2025, 4, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1745), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1759), new DateTime(2025, 3, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1772), new DateTime(2025, 5, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 13, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1786), new DateTime(2025, 5, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 5, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1800), new DateTime(2025, 7, 3, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 12, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1814), new DateTime(2025, 6, 6, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 6, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1827), new DateTime(2025, 7, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1842), new DateTime(2025, 5, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1856), new DateTime(2025, 7, 8, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1870), new DateTime(2025, 9, 3, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1883), new DateTime(2025, 4, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1969), new DateTime(2025, 6, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1984), new DateTime(2025, 5, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1997), new DateTime(2025, 9, 9, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2011), new DateTime(2025, 5, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2028), new DateTime(2025, 7, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(295), new DateTime(2024, 9, 26, 8, 51, 37, 415, DateTimeKind.Utc).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 22, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(377), new DateTime(2025, 5, 25, 2, 51, 37, 415, DateTimeKind.Utc).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 1, 24, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(401), new DateTime(2025, 1, 26, 10, 51, 37, 415, DateTimeKind.Utc).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(416), new DateTime(2025, 8, 22, 22, 51, 37, 415, DateTimeKind.Utc).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 12, 24, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(429), new DateTime(2024, 12, 25, 10, 51, 37, 415, DateTimeKind.Utc).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 15, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(446), new DateTime(2024, 9, 16, 4, 51, 37, 415, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(459), new DateTime(2024, 12, 7, 17, 51, 37, 415, DateTimeKind.Utc).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(471), new DateTime(2025, 6, 24, 9, 51, 37, 415, DateTimeKind.Utc).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 5, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(483), new DateTime(2025, 4, 5, 17, 51, 37, 415, DateTimeKind.Utc).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(498), new DateTime(2025, 9, 1, 23, 51, 37, 415, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(509), new DateTime(2025, 7, 23, 6, 51, 37, 415, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 10, 21, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(521), new DateTime(2024, 10, 23, 11, 51, 37, 415, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 7, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 5, 8, 18, 51, 37, 415, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(544), new DateTime(2024, 9, 23, 4, 51, 37, 415, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 1, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(556), new DateTime(2024, 11, 2, 12, 51, 37, 415, DateTimeKind.Utc).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 7, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(568), new DateTime(2024, 11, 10, 9, 51, 37, 415, DateTimeKind.Utc).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 12, 26, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(580), new DateTime(2024, 12, 27, 22, 51, 37, 415, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(594), new DateTime(2025, 8, 24, 4, 51, 37, 415, DateTimeKind.Utc).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(613), new DateTime(2025, 3, 14, 10, 51, 37, 415, DateTimeKind.Utc).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(626), new DateTime(2024, 11, 23, 16, 51, 37, 415, DateTimeKind.Utc).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(642), new DateTime(2024, 11, 25, 9, 51, 37, 415, DateTimeKind.Utc).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 3, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(655), new DateTime(2025, 7, 4, 20, 51, 37, 415, DateTimeKind.Utc).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 18, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(813), new DateTime(2024, 11, 19, 22, 51, 37, 415, DateTimeKind.Utc).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 13, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(832), new DateTime(2025, 3, 14, 3, 51, 37, 415, DateTimeKind.Utc).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(846), new DateTime(2025, 6, 27, 21, 51, 37, 415, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 19, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(865), new DateTime(2025, 4, 21, 1, 51, 37, 415, DateTimeKind.Utc).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(883), new DateTime(2024, 10, 2, 23, 51, 37, 415, DateTimeKind.Utc).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 2, 1, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(901), new DateTime(2025, 2, 3, 3, 51, 37, 415, DateTimeKind.Utc).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 16, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(915), new DateTime(2025, 5, 19, 13, 51, 37, 415, DateTimeKind.Utc).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 12, 18, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(929), new DateTime(2024, 12, 20, 1, 51, 37, 415, DateTimeKind.Utc).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 4, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(958), new DateTime(2025, 7, 5, 9, 51, 37, 415, DateTimeKind.Utc).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 8, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(987), new DateTime(2024, 9, 11, 6, 51, 37, 415, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1000), new DateTime(2025, 1, 27, 16, 51, 37, 415, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 5, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1017), new DateTime(2024, 11, 7, 13, 51, 37, 415, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 13, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1028), new DateTime(2025, 6, 16, 6, 51, 37, 415, DateTimeKind.Utc).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1041), new DateTime(2025, 8, 3, 19, 51, 37, 415, DateTimeKind.Utc).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1057), new DateTime(2025, 8, 5, 14, 51, 37, 415, DateTimeKind.Utc).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 20, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1072), new DateTime(2025, 3, 21, 2, 51, 37, 415, DateTimeKind.Utc).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 16, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1087), new DateTime(2024, 9, 18, 14, 51, 37, 415, DateTimeKind.Utc).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1099), new DateTime(2024, 9, 28, 4, 51, 37, 415, DateTimeKind.Utc).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1111), new DateTime(2024, 9, 14, 6, 51, 37, 415, DateTimeKind.Utc).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1127), new DateTime(2025, 2, 6, 11, 51, 37, 415, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1141), new DateTime(2024, 11, 28, 8, 51, 37, 415, DateTimeKind.Utc).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 7, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1153), new DateTime(2025, 4, 8, 2, 51, 37, 415, DateTimeKind.Utc).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 12, 8, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1165), new DateTime(2024, 12, 10, 5, 51, 37, 415, DateTimeKind.Utc).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 12, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1263), new DateTime(2025, 7, 15, 5, 51, 37, 415, DateTimeKind.Utc).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1277), new DateTime(2025, 9, 2, 14, 51, 37, 415, DateTimeKind.Utc).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 1, 11, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1289), new DateTime(2025, 1, 12, 21, 51, 37, 415, DateTimeKind.Utc).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1303), new DateTime(2025, 8, 19, 3, 51, 37, 415, DateTimeKind.Utc).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 5, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1315), new DateTime(2025, 5, 7, 8, 51, 37, 415, DateTimeKind.Utc).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1327), new DateTime(2025, 6, 11, 4, 51, 37, 415, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1339), new DateTime(2025, 8, 9, 9, 51, 37, 415, DateTimeKind.Utc).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1350), new DateTime(2025, 7, 7, 8, 51, 37, 415, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 12, 9, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1362), new DateTime(2024, 12, 11, 14, 51, 37, 415, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1374), new DateTime(2025, 8, 31, 7, 51, 37, 415, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1385), new DateTime(2024, 10, 28, 17, 51, 37, 415, DateTimeKind.Utc).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 1, 24, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1398), new DateTime(2025, 1, 24, 20, 51, 37, 415, DateTimeKind.Utc).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 18, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1412), new DateTime(2025, 5, 20, 19, 51, 37, 415, DateTimeKind.Utc).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 5, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1427), new DateTime(2025, 4, 6, 14, 51, 37, 415, DateTimeKind.Utc).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 25, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1441), new DateTime(2024, 11, 27, 0, 51, 37, 415, DateTimeKind.Utc).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1453), new DateTime(2025, 7, 1, 17, 51, 37, 415, DateTimeKind.Utc).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 24, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1465), new DateTime(2025, 4, 25, 19, 51, 37, 415, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1479), new DateTime(2025, 1, 18, 12, 51, 37, 415, DateTimeKind.Utc).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 19, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1492), new DateTime(2024, 9, 22, 3, 51, 37, 415, DateTimeKind.Utc).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 17, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1506), new DateTime(2025, 4, 19, 16, 51, 37, 415, DateTimeKind.Utc).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 19, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 11, 21, 6, 51, 37, 415, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1607), new DateTime(2025, 6, 19, 8, 51, 37, 415, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 10, 29, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1623), new DateTime(2024, 10, 30, 5, 51, 37, 415, DateTimeKind.Utc).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 1, 5, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1638), new DateTime(2025, 1, 6, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 2, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1650), new DateTime(2025, 7, 3, 0, 51, 37, 415, DateTimeKind.Utc).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 26, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1661), new DateTime(2025, 3, 28, 1, 51, 37, 415, DateTimeKind.Utc).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 15, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1673), new DateTime(2025, 3, 17, 2, 51, 37, 415, DateTimeKind.Utc).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 2, 27, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1688), new DateTime(2025, 2, 28, 10, 51, 37, 415, DateTimeKind.Utc).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 14, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1700), new DateTime(2025, 7, 14, 18, 51, 37, 415, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 21, 15, 51, 37, 415, DateTimeKind.Utc).AddTicks(1711), new DateTime(2025, 4, 24, 0, 51, 37, 415, DateTimeKind.Utc).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(862), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1012), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1099), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1111), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1122), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1137), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1147), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1156), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1167), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1178), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1188), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1197), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1208), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1217), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1227), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1236), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1246), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1257), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1268), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1278), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1288), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1298), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1307), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1317), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1453), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1464), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1475), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1486), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1496), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1506), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1517), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1526), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1537), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1549), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1559), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1569), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1579), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1590), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1599), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1609), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1619), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1629), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1639), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1648), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1658), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1783), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1794), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1804), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1814), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1824), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1834), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1843), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1852), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1861), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1871), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1880), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1890), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1900), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1910), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1919), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1929), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1938), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1948), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1957), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1967), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2115), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2128), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2137), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2147), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2157), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2167), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2177), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2300), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2312), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2324), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2334), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2346), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2358), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2369), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2378), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2389), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2398), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2407), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2416), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2426), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2436), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2445), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2455), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2464), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2550), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2560), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2569), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2579), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2588), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2598), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2608), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2617), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2627), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2636), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2646), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2656), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2665), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2675), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2684), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2694), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2703), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2712), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2722), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2731), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2741), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2751), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2760), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2837), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2847), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2857), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2867), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2876), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2886), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2895), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2904), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2914), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2923), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2932), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2942), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2952), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2961), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2971), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2981), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2990), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3154), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3167), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3176), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3185), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3194), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3204), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3213), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3223), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3232), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3242), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3252), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3261), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3271), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3280), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3290), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3299), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3309), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3319), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3328), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3337), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3347), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3356), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3366), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3375), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3459), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3469), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3480), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3490), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3499), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3509), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3518), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3527), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3536), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3546), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3555), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3566), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3575), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3585), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3594), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3603), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3612), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3622), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3631), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3640), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3649), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3659), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3668), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3747), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3757), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3766), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3776), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3785), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3794), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3804), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3813), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3823), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3833), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3842), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3852), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3861), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3871), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3881), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3890), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3899), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3909), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3918), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3927), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3936), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3946), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3955), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4035), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4045), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4055), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4064), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4074), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4083), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4093), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4102), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4111), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4121), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4130), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4140), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4150), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4159), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4168), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4178), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4187), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4197), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4206), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4215), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4225), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4236), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4245), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4319), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4330), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4340), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4349), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4359), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4368), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4377), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4387), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4396), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4406), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4415), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4425), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4435), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4444), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4454), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4463), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4473), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4482), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4491), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4501), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4502) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4510), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4519), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4529), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4538), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4594), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4604), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4614), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4623), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4632), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4642), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4651), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4660), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4669), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4678), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4688), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4861), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4871), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4881), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4890), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4899), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4908), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4917), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4926), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4936), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4945), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4954), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4964), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4973), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4982), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4991), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5000), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5009), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5018), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5026), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5035), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5044), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5053), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5062), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5157), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5501), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5507), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5514), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5520), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5527), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5534), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5541), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5547), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5554), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5560), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5567), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5573), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5581), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5582) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5587), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5594), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5600), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5607), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5614), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5620), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5627), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5634), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5640), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5701), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5708), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5714), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5721), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5728), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5735), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5741), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5748), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5755), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5761), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5768), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5775), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5781), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5788), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5794), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5801), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5807), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5813), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5820), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5826), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5839), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5846), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5903), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5911), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5917), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5924), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5931), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5937), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5944), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5951), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5957), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5964), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5971), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5977), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5984), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5990), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5997), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6004), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6010), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6017), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6024), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6030), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6037), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6043), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6050), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6057), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6117), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6124), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6131), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6137), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6144), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6150), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6157), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6164), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6171), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6178), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6184), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6191), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6197), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6204), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6211), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6217), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6224), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6230), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6237), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6243), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6250), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6256), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6263), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6326), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6333), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6340), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6346), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6353), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6360), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6367), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6374), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6380), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6387), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6393), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6400), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6407), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6413), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6420), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6427), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6434), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6440), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6447), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6453), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6460), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6467), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6473), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6531), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6538), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6544), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6551), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6557), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6564), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6571), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6577), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6584), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6591), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6598), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6605), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6612), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6618), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6625), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6631), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6638), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6645), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6651), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6658), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6665), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6671), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6678), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6685), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6728), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6735), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6742), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6749), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6756), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6762), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6769), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6776), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6783), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6790), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6796), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6803), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6810), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6816), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6823), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6829), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6835), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6842), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6848), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6855), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6861), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6867), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6943), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6951), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6958), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6965), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6971), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6978), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6985), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6992), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(6999), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7005), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7013), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7019), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7026), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7033), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7040), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7047), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7053), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7060), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7067), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7074), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7080), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7087), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7094), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7101), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7212), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7220), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7227), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7234), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7240), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7247), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7253), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7260), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7266), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7273), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7280), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7286), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7292), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7299), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7306), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7312), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7318), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7325), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7331), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7338), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7345), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7352), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7358), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7420), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7427), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7433), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7440), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7447), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7454), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7791), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7800), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7809), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7819), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7828), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7837), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7855), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7864), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7873), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7882), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7892), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7902), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7910), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7920), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7930), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7940), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8127), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8212), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8222), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8232), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8242), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8252), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8262), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8272), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8282), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8291), new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8301), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8311), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8321), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8330), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8340), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8349), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8359), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8368), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8377), new DateTime(2025, 8, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8387), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8397), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8407), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8416), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8575), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8585), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8594), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8604), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8613), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8623), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8632), new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8642), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8652), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8672), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8682), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8692), new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8701), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8711), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8720), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8731), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8740), new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8750), new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8760), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8770), new DateTime(2025, 8, 17, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8779), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8789), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8798), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8877), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8887), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8897), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8907), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8916), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8926), new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8936), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8946), new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8956), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8966), new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8976), new DateTime(2025, 8, 20, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8986), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8996), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9005), new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9015), new DateTime(2025, 8, 21, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9024), new DateTime(2025, 9, 2, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9034), new DateTime(2025, 9, 1, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9044), new DateTime(2025, 8, 23, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9053), new DateTime(2025, 8, 31, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9063), new DateTime(2025, 8, 24, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9073), new DateTime(2025, 8, 25, 15, 51, 37, 414, DateTimeKind.Utc).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2672), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2697), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2704), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2711), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2796), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2806), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2821), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2829), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2835), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2843), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2849), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2855), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2869), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2875), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2881), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2888), new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2894), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2902), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2914), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2920), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2926), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2932), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2939), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2945), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2957), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2963), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2969), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2975), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2982), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3085), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3100), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3107), new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3113), new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3122), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3128), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3134), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3146), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3152), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3158), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3164), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3171), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3177), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3195), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3202), new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3208), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3214), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3220), new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3246), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3252), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3259), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3265), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3271), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3345), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3359), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3366), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3372), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3378), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3384), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3390), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3402), new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3408), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3414), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3420), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3427), new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3435), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3446), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3453), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3459), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3465), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3471), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3477), new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3489), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3495), new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3501), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3507), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3581), new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3588), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3601), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3607), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3613), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3619), new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3626), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3633), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3644), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3650), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3656), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3662), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3668), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3675), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3686), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3692), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3698), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3705), new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3711), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3717), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3738), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3744), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3751), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3757), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3763), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3769), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3825), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3832), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3838), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3844), new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3851), new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3857), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3870), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3876), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3883), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3889), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3895), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3901), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3913), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3919), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3925), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3931), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3938), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3944), new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3955), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3961), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3968), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3974), new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3980), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3986), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3997), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4003), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4108), new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4120), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4126), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4132), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4147), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4153), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4160), new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4166), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4172), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4178), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4190), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4196), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4202), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4208), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4214), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4220), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4243), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4250), new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4256), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4262), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4359), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4366), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4380), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4386), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4392), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4398), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4404), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4410), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4422), new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4429), new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4435), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4441), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4448), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4454), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4465), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4471), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4477), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4483), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4489), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4496), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4507), new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4513), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4520), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4526), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4532), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4538), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4550), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4630), new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4637), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4643), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4649), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4655), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4667), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4674), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4680), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4686), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4692), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4699), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4710), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4716), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4723), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4729), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4735), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4741), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4764), new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4770), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4777), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4783), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4789), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4795), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4807), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4813), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4819), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4891), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4897), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4903), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4916), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4922), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4927), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4934), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4939), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4945), new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4956), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4963), new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4968), new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4974), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4980), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4987), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4997), new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5003), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5009), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5015), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5021), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5027), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5037), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5043), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5049), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5055), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5061), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5067), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5143), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5150), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5156), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5162), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5168), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5508), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5517), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5521), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5525), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5531), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5536), new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5540), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5555), new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5559), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5564), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5568), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5572), new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5576), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5585), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5589), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5593), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5597), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5602), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5607), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5615), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5619), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5674), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5679), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5683), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5690), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5700), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5704), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5708), new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5712), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5717), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5721), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5730), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5734), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5738), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5796), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5801), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5805), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5814), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5818), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5823), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5827), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5831), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5835), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5843), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5848), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5852), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5857), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5861), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5865), new DateTime(2025, 8, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5873), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5877), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5881), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5886), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5890), new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5894), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5909), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5913), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5917), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5922), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5926), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5930), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5973), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5978), new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5982), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5986), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5991), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5995), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6003), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6007), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6012), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6016), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6021), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6025), new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6033), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6037), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6042), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6046), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6050), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6054), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6062), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6067), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6071), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6075), new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6080), new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6084), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6092), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6168), new DateTime(2025, 9, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6178), new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6182), new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6186), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6195), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6200), new DateTime(2025, 8, 31, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6204), new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6208), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6212), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6217), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6224), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6229), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6233), new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6237), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6242), new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6246), new DateTime(2025, 8, 25, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6260), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6265), new DateTime(2025, 8, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6269), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6273), new DateTime(2025, 8, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6277), new DateTime(2025, 8, 30, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6281), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6290), new DateTime(2025, 8, 15, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6294), new DateTime(2025, 8, 28, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6298), new DateTime(2025, 9, 2, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6302), new DateTime(2025, 8, 26, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6442), new DateTime(2025, 8, 21, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6447), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6457), new DateTime(2025, 8, 19, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6461), new DateTime(2025, 8, 18, 15, 51, 37, 413, DateTimeKind.Utc).AddTicks(6462) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Designs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Designs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2025, 9, 2, 19, 39, 21, 24, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedAt",
                value: new DateTime(2025, 9, 2, 19, 39, 21, 24, DateTimeKind.Utc).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-001",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "06bf3e1b-aa38-4e6a-8eeb-e53f737c6e26", new DateTime(2025, 9, 2, 19, 39, 21, 192, DateTimeKind.Utc).AddTicks(7322), "AQAAAAIAAYagAAAAELKNY/vzwGFGBckeaQuPGxIhH94NJDn8B7dL14NImAo83jGSPZNBOImfuXo4z63PPQ==", "0802df45-ec27-435c-b8dc-787991f54c76", new DateTime(2025, 9, 2, 19, 39, 21, 192, DateTimeKind.Utc).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-001",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "10320a7d-046b-4c1a-960d-c50e1bb7a2b4", new DateTime(2024, 12, 11, 19, 39, 21, 361, DateTimeKind.Utc).AddTicks(3656), "AQAAAAIAAYagAAAAEBM2EDBYTdohYi9SYYpZOUHe0UpaqWtpI+dmufGW4ykXyNFD/GT0WplhQOW4le5fuA==", "4fc8ecb5-daf3-41e3-9e32-9627ed60dbc6", new DateTime(2025, 8, 11, 19, 39, 21, 361, DateTimeKind.Utc).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-002",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5c491b98-f490-4154-89cb-61a063ca97a8", new DateTime(2025, 6, 3, 19, 39, 21, 539, DateTimeKind.Utc).AddTicks(1081), "AQAAAAIAAYagAAAAEHELv/Y9HL+MbRxqYk0vejHHD9XdC8ycg6PrjCoyN5yeHSnhR8Ea/PskWbqiq3CPaQ==", "d5e4f296-93f9-4eee-be0d-bc58e3276eae", new DateTime(2025, 8, 25, 19, 39, 21, 539, DateTimeKind.Utc).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-003",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "37902b5a-8bff-4b2b-87b0-34d4f110be95", new DateTime(2024, 11, 25, 19, 39, 21, 715, DateTimeKind.Utc).AddTicks(5234), "AQAAAAIAAYagAAAAEAFvIABEpQKtJWbmotFwsCM0OIYtAmTHRegV+KA3YzXL+Lf72za5r4naxPbX+5nv0w==", "85318b2f-07a6-46bd-87ae-5d9e04809290", new DateTime(2025, 8, 10, 19, 39, 21, 715, DateTimeKind.Utc).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-004",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e924fe0b-bcc3-4c7d-b884-b6e43baa6e46", new DateTime(2025, 5, 18, 19, 39, 21, 929, DateTimeKind.Utc).AddTicks(8869), "AQAAAAIAAYagAAAAECUCK6gOeLDn3R6Irm0TYvLyb72Yh39RNOi/YhhBm5MprRRX/vSy+Elru1ZY1lc/qg==", "9fef9706-d723-449e-8a5e-31cd73b038ff", new DateTime(2025, 8, 24, 19, 39, 21, 929, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-005",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3af8945f-ea7a-46be-8831-77ee44161b59", new DateTime(2024, 11, 8, 19, 39, 22, 316, DateTimeKind.Utc).AddTicks(6655), "AQAAAAIAAYagAAAAEBys3guL4ZSo8vFd+iuMnc1l203dghiSukep4+iPbaWoc8ovsHE/C5rSVsru8QK3kw==", "22fc32c2-d389-4da6-b590-113a92c2137e", new DateTime(2025, 8, 9, 19, 39, 22, 316, DateTimeKind.Utc).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-006",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3207593d-575a-43af-85a0-68e32365b972", new DateTime(2025, 5, 1, 19, 39, 22, 575, DateTimeKind.Utc).AddTicks(7603), "AQAAAAIAAYagAAAAEGE75o9qPp2+DqU2LhHNwKKv//sBhIzkDvcSzKUJZh2VizPKwX/l1wp7QZLBhtjBSA==", "21b69db6-6a12-467f-b7ad-2d6c89cf693e", new DateTime(2025, 8, 23, 19, 39, 22, 575, DateTimeKind.Utc).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-007",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ba9d92f0-c09b-4366-94d4-92375030143f", new DateTime(2024, 10, 23, 19, 39, 22, 837, DateTimeKind.Utc).AddTicks(8260), "AQAAAAIAAYagAAAAEFI8X7CjKNLpi4F/xH2WNAi6+KMhykIRYvEICulLJ0f5yP9yfoDENEGROh8lfhIo/g==", "54927c3b-a082-4ce7-b91a-aebd61c58998", new DateTime(2025, 8, 8, 19, 39, 22, 837, DateTimeKind.Utc).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-008",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "19f3ffa5-7873-4db2-8021-17197a0c6bef", new DateTime(2025, 4, 15, 19, 39, 23, 98, DateTimeKind.Utc).AddTicks(6972), "AQAAAAIAAYagAAAAEKfvG5TmxPmaiqCxkiW1seFopdQCo8Ls/8r1HOx579Dcw45yrwupDMSod8NaIVbwOg==", "ac41a45a-d470-4d8c-89a1-946d368fe8b4", new DateTime(2025, 8, 21, 19, 39, 23, 98, DateTimeKind.Utc).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-009",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "202a7e32-e9a7-4d03-8012-aff5779b145c", new DateTime(2024, 10, 7, 19, 39, 23, 365, DateTimeKind.Utc).AddTicks(5866), "AQAAAAIAAYagAAAAEHMprXrrHxaXvuWcNGWudlnsDQwt/RKvOzjAgQRZHIGccoj2JcxRDL7Q8JKgtzIjSA==", "f70e1ae1-de9c-4043-a025-9193a4d08345", new DateTime(2025, 8, 6, 19, 39, 23, 365, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-010",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5cf4fed3-3cba-4dfa-82dd-766f075593e4", new DateTime(2025, 3, 30, 19, 39, 23, 549, DateTimeKind.Utc).AddTicks(834), "AQAAAAIAAYagAAAAEOOOZKMqew6rTznN4p2pIfL4wCKk4sgrsrMrgSkPYC/VNurqgrOtl9vJTbJf/d5TCw==", "e3a1335a-9e23-4ade-be96-ac5c45b8cf70", new DateTime(2025, 8, 20, 19, 39, 23, 549, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-011",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5a259d28-2a52-4f4d-aadd-cdd4dede2137", new DateTime(2024, 9, 21, 19, 39, 23, 764, DateTimeKind.Utc).AddTicks(7701), "AQAAAAIAAYagAAAAEJIfPANmGsZ5lfBxEdNxITNxY9bQMPpLnwIDC1k+lIbHFm2pgYGLdsQ//r8LopYZFg==", "fbda607d-74ac-4a04-8e17-e59c58d1abaf", new DateTime(2025, 8, 5, 19, 39, 23, 764, DateTimeKind.Utc).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-012",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2352949d-135d-4e9f-99ad-db7e7142cc62", new DateTime(2025, 3, 13, 19, 39, 23, 995, DateTimeKind.Utc).AddTicks(175), "AQAAAAIAAYagAAAAEEWBOCB1R9MAoiEE8erp981ycmEiCsNRAUxCp5/SutxLiGrcyv69LiA69BOu1rfA/Q==", "0bd17640-8d97-48cb-b075-a4a9bb0fde16", new DateTime(2025, 8, 19, 19, 39, 23, 995, DateTimeKind.Utc).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-013",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2a24ea84-4bad-426f-9600-4ce6915915f3", new DateTime(2024, 9, 4, 19, 39, 24, 210, DateTimeKind.Utc).AddTicks(1787), "AQAAAAIAAYagAAAAEAWfUKeB/HCtW/SZua2QXjs7kUAjnXzCpO23HZoXSUPenIF6VQMc+QwHBYq90VeepQ==", "071adf2e-2802-4635-a629-19e79a191507", new DateTime(2025, 8, 4, 19, 39, 24, 210, DateTimeKind.Utc).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-014",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2b80d37e-c221-4540-85fa-e0cadd33caae", new DateTime(2025, 2, 25, 19, 39, 24, 387, DateTimeKind.Utc).AddTicks(5430), "AQAAAAIAAYagAAAAEGNBfkpcQSTxpDYBhWzZrJ3K0kWfCg2/TvMBtXhacd74QFY1pP+5HXs83Vyl2CMajA==", "e7f5d6c8-6328-4e6b-b158-f84ab905ec9c", new DateTime(2025, 8, 17, 19, 39, 24, 387, DateTimeKind.Utc).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-015",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a17f717d-b829-401c-8396-5da5cb744da1", new DateTime(2025, 8, 18, 19, 39, 24, 568, DateTimeKind.Utc).AddTicks(5662), "AQAAAAIAAYagAAAAEELeSHz+GlZVS5iplGn2gX9yeaBaXHylX4sX9LWctzHlqp4VZUCdPQ77XP63TTukgg==", "2cd97a07-fda0-4051-a0a6-c2e993756c24", new DateTime(2025, 8, 31, 19, 39, 24, 568, DateTimeKind.Utc).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-016",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ad9049b3-34f1-4ef0-a84d-d2c414bcd1ba", new DateTime(2025, 2, 9, 19, 39, 24, 731, DateTimeKind.Utc).AddTicks(7623), "AQAAAAIAAYagAAAAEE9906M1NS0pW7nicyWqYfAqcM4bX6yAT1+Ax2ItaCwvbSZwd2WMsZs0BOJ+7c6dfQ==", "79ee0abc-4766-49e4-ad72-be916958e390", new DateTime(2025, 8, 16, 19, 39, 24, 731, DateTimeKind.Utc).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-017",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "fdd7aa0f-1d80-4bac-98bb-fe33f0948499", new DateTime(2025, 8, 2, 19, 39, 24, 923, DateTimeKind.Utc).AddTicks(4005), "AQAAAAIAAYagAAAAEL8XtfwkWuQOA8B1srZMfgG4v68qBo6+S+043EJtPdBqDfVpiSv41z4Cz63FeHWoaA==", "ede5849a-dc4a-43e8-8c81-c838fbfdb223", new DateTime(2025, 8, 30, 19, 39, 24, 923, DateTimeKind.Utc).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-018",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "71ba39cd-c959-4d2b-8925-97f2aa093e81", new DateTime(2025, 1, 23, 19, 39, 25, 97, DateTimeKind.Utc).AddTicks(5947), "AQAAAAIAAYagAAAAECve1jhopsMKvOTaibkASSrsi35/y7Jt6kwhRCnsZXe+vEzR2HxHYac6AXMKSLhTvw==", "8c55a5e4-ccd8-496b-b5d1-cabd52374c8c", new DateTime(2025, 8, 15, 19, 39, 25, 97, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-019",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8b22e07c-aa48-48f4-8416-6943dc843a76", new DateTime(2025, 7, 16, 19, 39, 25, 243, DateTimeKind.Utc).AddTicks(4642), "AQAAAAIAAYagAAAAEEjjyBP4y4QsgCD4hbai5x87HpflMICqJFtAaGnCV+XVyk+vxSY7uKDfm1i4kVoq+Q==", "ac22619e-309f-41d2-be98-8aea4cdbca3d", new DateTime(2025, 8, 29, 19, 39, 25, 243, DateTimeKind.Utc).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-020",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "37b25123-decc-42b0-aa67-23c7c87789e0", new DateTime(2025, 1, 7, 19, 39, 25, 392, DateTimeKind.Utc).AddTicks(2564), "AQAAAAIAAYagAAAAEDXe/3vv73EZEqEsV38eqNAjkUVqsYjUUgiTpwKntC33vXtd3HypT+Am++IJry7ylQ==", "d71d530d-c6eb-44b5-9940-85e924972a63", new DateTime(2025, 8, 14, 19, 39, 25, 392, DateTimeKind.Utc).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-021",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3e6e3d56-f1a9-4c17-8665-383c7e44d5b0", new DateTime(2025, 6, 30, 19, 39, 25, 532, DateTimeKind.Utc).AddTicks(7715), "AQAAAAIAAYagAAAAEP+8XhOXN+9ZIRbKEGteiWsKcOYYxr8C1catcmfbCZJb/s1fH+hR6njmrLsoYK1GWA==", "9e0c8ea6-b47e-4497-abeb-c8010ef0c4ec", new DateTime(2025, 8, 27, 19, 39, 25, 532, DateTimeKind.Utc).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-022",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "68b5df19-30b0-46e8-bfec-8683fd468673", new DateTime(2024, 12, 22, 19, 39, 25, 677, DateTimeKind.Utc).AddTicks(6785), "AQAAAAIAAYagAAAAEOQ6+pxfsUU4QNqiAmKghruyy7yiGWCTLG4Kf1clvr6hrxC4jhsRXR8XHf+7LsNMFQ==", "33434a91-441d-488d-b251-3473f9d504a4", new DateTime(2025, 8, 12, 19, 39, 25, 677, DateTimeKind.Utc).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-023",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "23106810-22a2-4e13-b3e6-dcd9baa40c51", new DateTime(2025, 6, 14, 19, 39, 25, 829, DateTimeKind.Utc).AddTicks(6799), "AQAAAAIAAYagAAAAEPwHb8eXNvK+4XxlNdmlrj5bC3D0azR1mKHe3y1eC+SHl5v72mx4E09WRimL7APIcg==", "0ce4aa66-b0f8-4846-9169-4cc08a28a729", new DateTime(2025, 8, 26, 19, 39, 25, 829, DateTimeKind.Utc).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-024",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "31bab74f-4590-44ea-96bd-0ba5f11efbec", new DateTime(2024, 12, 5, 19, 39, 25, 980, DateTimeKind.Utc).AddTicks(1422), "AQAAAAIAAYagAAAAEGQzvznmHaglQsNk6vrTpLFpRkrEjft+wti5DEC3dMI5HhqGqPv/2ZQmPsFkiFvZLg==", "d9b2189c-a404-476d-837b-26c5b86de77b", new DateTime(2025, 8, 11, 19, 39, 25, 980, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-025",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ba4b41bf-bea1-409e-9ea9-ead02fb3f3e4", new DateTime(2025, 5, 28, 19, 39, 26, 135, DateTimeKind.Utc).AddTicks(5631), "AQAAAAIAAYagAAAAEISvtWvraTWQpOhzf7oCTbvQb2JZ2OqaNtlSqU4zun6ye8Fy1n1RRpMFpim5Ke7OWQ==", "95a4df77-585d-4960-b9aa-1b50ce95e754", new DateTime(2025, 8, 25, 19, 39, 26, 135, DateTimeKind.Utc).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-026",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "82ea7004-a7c1-4fa9-a54d-9e3c13fb88de", new DateTime(2024, 11, 19, 19, 39, 26, 301, DateTimeKind.Utc).AddTicks(4750), "AQAAAAIAAYagAAAAELW1xRGiKCNPN8jZ+6QwnxpcP/7GGdHXRz5qRKnRrvfJPcdktBJZn4cIFDQBM8f+cg==", "cd26f51d-fe21-45a8-80cd-eb2bc0d8d4c1", new DateTime(2025, 8, 10, 19, 39, 26, 301, DateTimeKind.Utc).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-027",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b4ecddff-7299-4028-bb00-71b4f5374aa0", new DateTime(2025, 5, 12, 19, 39, 26, 469, DateTimeKind.Utc).AddTicks(4580), "AQAAAAIAAYagAAAAEO4dVMyVner4/zdvJ0UWYMDx8yAweUSaIy2C5V0CbwOQZh1tpGz3M8L1KAk09JWJLQ==", "2279341a-d1a2-4bf2-9511-a6c199b393dd", new DateTime(2025, 8, 24, 19, 39, 26, 469, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-028",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "be3dcef2-91c9-41c5-97b9-7b33274ad20f", new DateTime(2024, 11, 3, 19, 39, 26, 633, DateTimeKind.Utc).AddTicks(598), "AQAAAAIAAYagAAAAEPIgCkitMnnV7HldXPI8hVx9Zjb4nCJM3u0td4nqGrnwX1FNHD7TAagflzO1tBQtPw==", "17f4502f-cb19-4b50-8777-78adb7b97784", new DateTime(2025, 8, 8, 19, 39, 26, 633, DateTimeKind.Utc).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-029",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bcefe828-3daa-4fe3-b3a6-594c49ab7fc1", new DateTime(2025, 4, 26, 19, 39, 26, 780, DateTimeKind.Utc).AddTicks(4676), "AQAAAAIAAYagAAAAEAV55YD6EqrG1uej+VHbi7PW3veOgrBrn9JClAcgehmu9RjgYMbvBszIiWdkbBjqRA==", "0a96e0ee-9072-4065-a0cd-41d10fd4efd0", new DateTime(2025, 8, 22, 19, 39, 26, 780, DateTimeKind.Utc).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-030",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8fdf4a55-bb12-4361-9e1d-cb851980aa50", new DateTime(2024, 10, 17, 19, 39, 26, 941, DateTimeKind.Utc).AddTicks(5893), "AQAAAAIAAYagAAAAEL2sFMy5d6w7gBE7pGJaJkoHNIL4vKPATFlHnTlFbRmkz6hQ1HQKSMxKi/58XTSkqA==", "81c453ca-c62d-4fc1-b9a0-163ae4be50ea", new DateTime(2025, 8, 7, 19, 39, 26, 941, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 7, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 7, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 7, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 7, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 7, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 7, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 7, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 7, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 6, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 7, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 7, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 7, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 7, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 6, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 6, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2292), new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2304), new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2307), new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2312), new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2315), new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2321), new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2324), new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2328), new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2343), new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2349), new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2353), new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2357), new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2361), new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2365), new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2369), new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2372), new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2383), new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2388), new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2392), new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2396), new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2400), new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2524), new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2527), new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2531), new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2535), new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2539), new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2543), new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2547), new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2557), new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2562), new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2566), new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2570), new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2575), new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4303), new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 7, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4420), new DateTime(2025, 7, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4444), new DateTime(2025, 4, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 7, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4460), new DateTime(2025, 7, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4587), new DateTime(2025, 9, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4606), new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4623), new DateTime(2025, 6, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4639), new DateTime(2025, 4, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4653), new DateTime(2025, 9, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4668), new DateTime(2025, 9, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 6, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4685), new DateTime(2025, 6, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4700), new DateTime(2025, 4, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4714), new DateTime(2025, 5, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4730), new DateTime(2025, 9, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 6, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4744), new DateTime(2025, 7, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4851), new DateTime(2025, 9, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4868), new DateTime(2025, 5, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4884), new DateTime(2025, 4, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4901), new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4915), new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4929), new DateTime(2025, 3, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4943), new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4958), new DateTime(2025, 4, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4973), new DateTime(2025, 4, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4988), new DateTime(2025, 4, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5001), new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5064), new DateTime(2025, 4, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5081), new DateTime(2025, 6, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5095), new DateTime(2025, 5, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5109), new DateTime(2025, 3, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5277), new DateTime(2025, 3, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5294), new DateTime(2025, 9, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5310), new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 7, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5328), new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5342), new DateTime(2025, 9, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 7, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5356), new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5371), new DateTime(2025, 6, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 7, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5569), new DateTime(2025, 7, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5588), new DateTime(2025, 4, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5603), new DateTime(2025, 4, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5618), new DateTime(2025, 5, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 6, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5633), new DateTime(2025, 7, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5647), new DateTime(2025, 3, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5661), new DateTime(2025, 4, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 7, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5675), new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5689), new DateTime(2025, 5, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5703), new DateTime(2025, 3, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5719), new DateTime(2025, 6, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5831), new DateTime(2025, 5, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5852), new DateTime(2025, 5, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 7, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5866), new DateTime(2025, 8, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5881), new DateTime(2025, 5, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5895), new DateTime(2025, 4, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 6, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5909), new DateTime(2025, 7, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5924), new DateTime(2025, 6, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5937), new DateTime(2025, 5, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5952), new DateTime(2025, 6, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5966), new DateTime(2025, 4, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5980), new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5994), new DateTime(2025, 8, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6083), new DateTime(2025, 6, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6098), new DateTime(2025, 5, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 7, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6114), new DateTime(2025, 8, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6128), new DateTime(2025, 6, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6142), new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6160), new DateTime(2025, 3, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6174), new DateTime(2025, 6, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6187), new DateTime(2025, 6, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6202), new DateTime(2025, 3, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6215), new DateTime(2025, 5, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 6, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6229), new DateTime(2025, 7, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6319), new DateTime(2025, 5, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6335), new DateTime(2025, 9, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6349), new DateTime(2025, 3, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 7, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6363), new DateTime(2025, 7, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6376), new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6391), new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 6, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6404), new DateTime(2025, 7, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 7, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6418), new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6433), new DateTime(2025, 5, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6446), new DateTime(2025, 5, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6460), new DateTime(2025, 4, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6547), new DateTime(2025, 5, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6573), new DateTime(2025, 4, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6589), new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6589) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6604), new DateTime(2025, 3, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6623), new DateTime(2025, 4, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6640), new DateTime(2025, 5, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6655), new DateTime(2025, 7, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6672), new DateTime(2025, 6, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 7, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6688), new DateTime(2025, 7, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6704), new DateTime(2025, 5, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 6, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6719), new DateTime(2025, 7, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6734), new DateTime(2025, 9, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 3, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6835), new DateTime(2025, 4, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6856), new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 5, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6873), new DateTime(2025, 5, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6887), new DateTime(2025, 9, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 4, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6903), new DateTime(2025, 5, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ApplicationUserId", "ApplicationUserId1", "CreatedOn", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(2025, 6, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6919), new DateTime(2025, 7, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 23, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(816), new DateTime(2024, 9, 25, 12, 39, 26, 945, DateTimeKind.Utc).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 21, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(894), new DateTime(2025, 5, 24, 6, 39, 26, 945, DateTimeKind.Utc).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(923), new DateTime(2025, 1, 25, 14, 39, 26, 945, DateTimeKind.Utc).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(941), new DateTime(2025, 8, 22, 2, 39, 26, 945, DateTimeKind.Utc).AddTicks(941) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 12, 23, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(956), new DateTime(2024, 12, 24, 14, 39, 26, 945, DateTimeKind.Utc).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(973), new DateTime(2024, 9, 15, 8, 39, 26, 945, DateTimeKind.Utc).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 12, 5, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(987), new DateTime(2024, 12, 6, 21, 39, 26, 945, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1001), new DateTime(2025, 6, 23, 13, 39, 26, 945, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 4, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1013), new DateTime(2025, 4, 4, 21, 39, 26, 945, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1102), new DateTime(2025, 9, 1, 3, 39, 26, 945, DateTimeKind.Utc).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 20, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1117), new DateTime(2025, 7, 22, 10, 39, 26, 945, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 10, 20, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1130), new DateTime(2024, 10, 22, 15, 39, 26, 945, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 6, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1143), new DateTime(2025, 5, 7, 22, 39, 26, 945, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 21, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1158), new DateTime(2024, 9, 22, 8, 39, 26, 945, DateTimeKind.Utc).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 10, 31, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1171), new DateTime(2024, 11, 1, 16, 39, 26, 945, DateTimeKind.Utc).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 6, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1186), new DateTime(2024, 11, 9, 13, 39, 26, 945, DateTimeKind.Utc).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 12, 25, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1200), new DateTime(2024, 12, 27, 2, 39, 26, 945, DateTimeKind.Utc).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 8, 23, 8, 39, 26, 945, DateTimeKind.Utc).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 10, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1231), new DateTime(2025, 3, 13, 14, 39, 26, 945, DateTimeKind.Utc).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 22, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1245), new DateTime(2024, 11, 22, 20, 39, 26, 945, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 22, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1261), new DateTime(2024, 11, 24, 13, 39, 26, 945, DateTimeKind.Utc).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 2, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1273), new DateTime(2025, 7, 4, 0, 39, 26, 945, DateTimeKind.Utc).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 17, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1289), new DateTime(2024, 11, 19, 2, 39, 26, 945, DateTimeKind.Utc).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 12, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1302), new DateTime(2025, 3, 13, 7, 39, 26, 945, DateTimeKind.Utc).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1314), new DateTime(2025, 6, 27, 1, 39, 26, 945, DateTimeKind.Utc).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 18, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1329), new DateTime(2025, 4, 20, 5, 39, 26, 945, DateTimeKind.Utc).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 29, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1344), new DateTime(2024, 10, 2, 3, 39, 26, 945, DateTimeKind.Utc).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 1, 31, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1360), new DateTime(2025, 2, 2, 7, 39, 26, 945, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 15, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1372), new DateTime(2025, 5, 18, 17, 39, 26, 945, DateTimeKind.Utc).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 12, 17, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1387), new DateTime(2024, 12, 19, 5, 39, 26, 945, DateTimeKind.Utc).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 3, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1452), new DateTime(2025, 7, 4, 13, 39, 26, 945, DateTimeKind.Utc).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 7, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1490), new DateTime(2024, 9, 10, 10, 39, 26, 945, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 1, 25, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1504), new DateTime(2025, 1, 26, 20, 39, 26, 945, DateTimeKind.Utc).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 4, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1578), new DateTime(2024, 11, 6, 17, 39, 26, 945, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1592), new DateTime(2025, 6, 15, 10, 39, 26, 945, DateTimeKind.Utc).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1606), new DateTime(2025, 8, 2, 23, 39, 26, 945, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1622), new DateTime(2025, 8, 4, 18, 39, 26, 945, DateTimeKind.Utc).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 19, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1638), new DateTime(2025, 3, 20, 6, 39, 26, 945, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 15, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1653), new DateTime(2024, 9, 17, 18, 39, 26, 945, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1668), new DateTime(2024, 9, 27, 8, 39, 26, 945, DateTimeKind.Utc).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 12, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1680), new DateTime(2024, 9, 13, 10, 39, 26, 945, DateTimeKind.Utc).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 2, 4, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1695), new DateTime(2025, 2, 5, 15, 39, 26, 945, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 25, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1709), new DateTime(2024, 11, 27, 12, 39, 26, 945, DateTimeKind.Utc).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 6, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1721), new DateTime(2025, 4, 7, 6, 39, 26, 945, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 12, 7, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1733), new DateTime(2024, 12, 9, 9, 39, 26, 945, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 11, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1747), new DateTime(2025, 7, 14, 9, 39, 26, 945, DateTimeKind.Utc).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1759), new DateTime(2025, 9, 1, 18, 39, 26, 945, DateTimeKind.Utc).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 1, 10, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1771), new DateTime(2025, 1, 12, 1, 39, 26, 945, DateTimeKind.Utc).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1784), new DateTime(2025, 8, 18, 7, 39, 26, 945, DateTimeKind.Utc).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 4, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1796), new DateTime(2025, 5, 6, 12, 39, 26, 945, DateTimeKind.Utc).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 7, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1808), new DateTime(2025, 6, 10, 8, 39, 26, 945, DateTimeKind.Utc).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1820), new DateTime(2025, 8, 8, 13, 39, 26, 945, DateTimeKind.Utc).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 4, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1831), new DateTime(2025, 7, 6, 12, 39, 26, 945, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 12, 8, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1844), new DateTime(2024, 12, 10, 18, 39, 26, 945, DateTimeKind.Utc).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1856), new DateTime(2025, 8, 30, 11, 39, 26, 945, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 10, 27, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1868), new DateTime(2024, 10, 27, 21, 39, 26, 945, DateTimeKind.Utc).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2032), new DateTime(2025, 1, 24, 0, 39, 26, 945, DateTimeKind.Utc).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 5, 17, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2048), new DateTime(2025, 5, 19, 23, 39, 26, 945, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 4, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2063), new DateTime(2025, 4, 5, 18, 39, 26, 945, DateTimeKind.Utc).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 24, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2079), new DateTime(2024, 11, 26, 4, 39, 26, 945, DateTimeKind.Utc).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2092), new DateTime(2025, 6, 30, 21, 39, 26, 945, DateTimeKind.Utc).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2104), new DateTime(2025, 4, 24, 23, 39, 26, 945, DateTimeKind.Utc).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 1, 14, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2120), new DateTime(2025, 1, 17, 16, 39, 26, 945, DateTimeKind.Utc).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2135), new DateTime(2024, 9, 21, 7, 39, 26, 945, DateTimeKind.Utc).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 16, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2152), new DateTime(2025, 4, 18, 20, 39, 26, 945, DateTimeKind.Utc).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 11, 18, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2169), new DateTime(2024, 11, 20, 10, 39, 26, 945, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 15, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2187), new DateTime(2025, 6, 18, 12, 39, 26, 945, DateTimeKind.Utc).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 10, 28, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2202), new DateTime(2024, 10, 29, 9, 39, 26, 945, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 1, 4, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2220), new DateTime(2025, 1, 5, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 1, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2235), new DateTime(2025, 7, 2, 4, 39, 26, 945, DateTimeKind.Utc).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 25, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2247), new DateTime(2025, 3, 27, 5, 39, 26, 945, DateTimeKind.Utc).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 14, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2259), new DateTime(2025, 3, 16, 6, 39, 26, 945, DateTimeKind.Utc).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 2, 26, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2276), new DateTime(2025, 2, 27, 14, 39, 26, 945, DateTimeKind.Utc).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 13, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2289), new DateTime(2025, 7, 13, 22, 39, 26, 945, DateTimeKind.Utc).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 20, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2302), new DateTime(2025, 4, 23, 4, 39, 26, 945, DateTimeKind.Utc).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9190), new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9220), new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9230), new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9240), new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9250), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9262), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9271), new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9282), new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9292), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9303), new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9313), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9322), new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9332), new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9340), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9350), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9359), new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9368), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9379), new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9389), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9398), new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9408), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9519), new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9532), new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9544), new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9556), new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9564), new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9573), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9583), new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9592), new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9601), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9615), new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9625), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9634), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9648), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9658), new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9668), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9679), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9688), new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9697), new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9706), new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9716), new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9726), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9735), new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9846), new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9867), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9877), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9886), new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9896), new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9905), new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9915), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9924), new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9933), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9942), new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9951), new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9960), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9970), new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9979), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9989), new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9998), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(16), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(26), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(39), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(49), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(373), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(384), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(394), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(404), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(414), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(424), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(443), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(453), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(463), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(472), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(481), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(490), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(499), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(508), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(517), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(527), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(536), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(545), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(554), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(563), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(573), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(692), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(704), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(712), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(722), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(731), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(740), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(750), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(760), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(770), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(780), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(789), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(798), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(808), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(817), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(826), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(835), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(845), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(854), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(863), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(872), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(882), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(892), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(902), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1020), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1033), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1042), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1052), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1061), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1071), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1079), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1090), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1099), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1108), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1118), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1128), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1137), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1147), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1156), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1168), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1177), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1188), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1197), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1273), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1283), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1293), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1301), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1311), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1320), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1329), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1339), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1348), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1357), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1367), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1377), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1386), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1395), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1404), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1415), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1424), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1434), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1443), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1452), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1461), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1616), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1628), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1638), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1648), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1658), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1667), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1678), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1688), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1698), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1707), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1716), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1725), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1735), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1744), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1754), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1763), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1772), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1781), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1791), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1801), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1811), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1820), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1830), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1974), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1987), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1996), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2005), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2017), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2027), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2036), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2046), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2056), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2065), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2075), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2084), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2094), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2103), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2112), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2123), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2132), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2142), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2152), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2162), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2171), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2181), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2190), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2200), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2309), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2319), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2329), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2338), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2347), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2357), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2366), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2376), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2386), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2396), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2405), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2415), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2424), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2434), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2444), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2453), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2462), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2471), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2481), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2490), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2499), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2511), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2520), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2632), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2643), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2653), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2663), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2673), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2681), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2691), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2700), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2710), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2719), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2728), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2738), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2747), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2756), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2767), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2776), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2786), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2795), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2805), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2815), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2825), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2835), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2844), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2951), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2961), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2971), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2980), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2990), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3000), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3009), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3018), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3027), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3037), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3046), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3056), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3065), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3074), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3199), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3209), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3219), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3230), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3239), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3249), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3259), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3268), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3278), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3288), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3298), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3309), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3318), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3336), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3345), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3354), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3364), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3373), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3383), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3392), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3567), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3582), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3592), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3601), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3611), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3620), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3631), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3640), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3649), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3658), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3667), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3677), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3687), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3696), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3705), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3715), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3725), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3726) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3735), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3736) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3745), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3764), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3774), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3783), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3806), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3817), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3828), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3839), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3850), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3860), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3869), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3878), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3888), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3897), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3907), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4219), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4232), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4242), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4252), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4263), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4272), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4281), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4291), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4300), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4308), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4317), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4326), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4504), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4517), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4526), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4536), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4547), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4557), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4567), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4580), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4590), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4599), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4609), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4620), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4630), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4640), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4650), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4660), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4669), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4680), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4690), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4700), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4710), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4720), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4730), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4877), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4887), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4897), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4907), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4917), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4928), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4937), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4948), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4957), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4967), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4976), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4986), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4998), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5008), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5017), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5027), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5036), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5046), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5056), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5065), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5076), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5085), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5095), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5185), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5197), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5206), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5217), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5228), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5239), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5249), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5261), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5273), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5283), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5293), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5303), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5312), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5321), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5331), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5340), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5351), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5360), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5371), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5380), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5390), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5399), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5409), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5509), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5522), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5532), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5542), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5551), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5560), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5570), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5579), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5589), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5607), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5618), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5627), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5637), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5646), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5655), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5664), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5674), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5683), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5692), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5702), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5711), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5721), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5731), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5829), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5839), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5848), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5857), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5867), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5876), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5886), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5895), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5904), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5913), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5923), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5932), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5941), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5951), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5960), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5970), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5979), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5989), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6001), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6014), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6023), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6034), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6043), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6152), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6154) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6163), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6182), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6192), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6201), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6211), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6221), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6231), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6240), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6250), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6259), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6269), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6279), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6288), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6298), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6307), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6317), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6327), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6336), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6345), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6355), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6364), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6464), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6477), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6487), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6496), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6506), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6516), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6526), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6536), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6545), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6555), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6565), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6575), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6584), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6594), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6604), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6613), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6622), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6633), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6642), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6651), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6661), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6670), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6680), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6690), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6762), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6772), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6782), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6791), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6802), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6811), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6820), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6830), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6840), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6849), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6859), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6869), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6879), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6889), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6898), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6908), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6918), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6928), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6937), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6946), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6957), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6967), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7108), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7120), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7131), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7142), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7295), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7305), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7315), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7325), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7334), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7345), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7354), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7365), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7375), new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7385), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7394), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7404), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7414), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7423), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7433), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7443), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7452), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7462), new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7472), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7591), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7604), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7614), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7624), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7634), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7643), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7653), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7662), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7672), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7681), new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7691), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7700), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7711), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7720), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7729), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7738), new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7748), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7757), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7767), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7776), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7786), new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7795), new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7805), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7815), new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7925), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7937), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7946), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7958), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7967), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7978), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7987), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7996), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8006), new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8016), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8026), new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8036), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8046), new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8055), new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8064), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8073), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8083), new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8448), new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8459), new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8469), new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8480), new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8490), new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8499), new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8648), new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7549), new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7669), new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7686), new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7693), new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7702), new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7713), new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7735), new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7743), new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7749), new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7759), new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7766), new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7773), new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7789), new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7797), new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7805), new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7812), new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7818), new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7828), new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7844), new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7851), new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7857), new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7864), new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7872), new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7878), new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7892), new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7899), new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7953), new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7962), new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7969), new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8008), new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8026), new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8034), new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8041), new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8051), new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8059), new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8066), new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8083), new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8090), new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8096), new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8102), new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8109), new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8115), new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8132), new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8139), new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8147), new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8153), new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8160), new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8166), new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8198), new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8206), new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8329), new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8341), new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8348), new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8354), new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8372), new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8379), new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8387), new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8393), new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8400), new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8406), new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8421), new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8428), new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8435), new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8441), new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8448), new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8457), new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8471), new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8479), new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8486), new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8492), new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8498), new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8505), new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8520), new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8619), new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8628), new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8636), new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8643), new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8649), new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8665), new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8672), new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8685), new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8692), new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8699), new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8713), new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8720), new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8727), new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8734), new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8740), new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8747), new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8764), new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8770), new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8777), new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8784), new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8791), new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8798), new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8828), new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8836), new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8842), new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8849), new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8928), new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8937), new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8955), new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8962), new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8969), new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8976), new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8983), new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9004), new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9012), new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9020), new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9026), new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9032), new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9039), new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9053), new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9060), new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9066), new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9072), new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9079), new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9086), new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9098), new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9106), new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9112), new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9119), new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9127), new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9133), new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9218), new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9229), new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9237), new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9247), new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9254), new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9260), new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9278), new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9286), new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9292), new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9298), new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9306), new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9312), new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9326), new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9333), new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9340), new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9347), new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9354), new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9360), new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9389), new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9396), new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9491), new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9501), new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9508), new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9515), new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9533), new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9540), new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9547), new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9561), new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9567), new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9582), new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9589), new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9596), new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9603), new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9610), new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9617), new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9632), new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9638), new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9645), new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9652), new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9658), new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9665), new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9683), new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9690), new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9697), new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9704), new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9711), new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9808), new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9829), new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9837), new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9844), new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9851), new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9864), new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9877), new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9885), new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9891), new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9898), new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9905), new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9912), new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9926), new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9940), new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9948), new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9955), new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9962), new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9969), new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(128), new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(135), new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(142), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(148), new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(155), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(162), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(177), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(335), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(346), new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(352), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(359), new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(366), new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(383), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(391), new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(397), new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(405), new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(412), new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(419), new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(440), new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(447), new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(453), new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(460), new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(467), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(481), new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(487), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(495), new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(502), new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(509), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(516), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(531), new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(538), new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(545), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(641), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(650), new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(657), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(674), new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(682), new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(689), new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(696), new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(703), new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(710), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(724), new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(733), new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(740), new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(749), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(756), new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(762), new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(795), new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(802), new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(810), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(818), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(825), new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(831), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(847), new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(853), new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(860), new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(867), new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(874), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(882), new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(994), new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1001), new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1007), new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1014), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1021), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1035), new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1052), new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1060), new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1066), new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1073), new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1079), new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1086), new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1166), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1177), new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1184), new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1191), new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1198), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1216), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1217) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1222), new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1229), new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1235), new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1242), new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1248), new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1261), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1268), new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1274), new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1281), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1288), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1295), new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1307), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1314), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1321), new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1328), new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1334), new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1341), new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1370), new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1377), new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1516), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1525), new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1531), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1538), new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1557), new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1563), new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1569), new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1576), new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1582), new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1589), new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1602), new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1608), new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1615), new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1622), new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1628), new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1635), new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 10, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1647), new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1654), new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1661), new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 8, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1668), new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1674), new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1680), new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1693), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 5, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1699), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1706), new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1713), new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1719), new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 6, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1837), new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1865), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1872), new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1879), new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1885), new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1892), new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1900), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 4, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1914), new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1920), new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1927), new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1933), new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 7, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1940), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1947), new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1960), new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1967), new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1975), new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1982), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1989), new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1995), new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2025), new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2032), new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 13, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2039), new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2046), new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2052), new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 3, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2059), new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2073), new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 2, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2191), new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2201), new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2208), new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 7, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2215), new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 12, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2221), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 9, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2240), new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2025, 8, 11, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2247), new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2249) });

            migrationBuilder.CreateIndex(
                name: "IX_Designs_ApplicationUserId",
                table: "Designs",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Designs_ApplicationUserId1",
                table: "Designs",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Designs_AspNetUsers_ApplicationUserId",
                table: "Designs",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Designs_AspNetUsers_ApplicationUserId1",
                table: "Designs",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
