using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedBubble.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixorderr2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductVariantOrdered_ColorName",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductVariantOrdered_SizeName",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e7a9a92-0d60-46bc-812d-cd8af46c30d3", "AQAAAAIAAYagAAAAEFxW1gr0mOCKkjHAAtf67qjhdwwFwTnxlzexF0ITbbxB+LnK2feg4OUwoy0yb2arxQ==", "4eb538bb-3713-4780-a69b-4bc504523941" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e2f90f1-aaab-42b0-91b7-f891374afaf2", "AQAAAAIAAYagAAAAEKqj0yTD9dIi4l7NcaGbkKwgPmiwsC8/EBpvC55GyFE8CW5tpXyRzXi2VZjM54IZpg==", "7fb1e85f-c4f4-4cd9-9737-4f9014bacaaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e72b001-01f6-47de-8569-8fa3dd560a0b", "AQAAAAIAAYagAAAAELKyqwwGZuvRiwscwCTeATofHp5T6KtC4VVwkk0tLdRekk69iNbEkITpGYnxw1dtQQ==", "795559d2-b98f-4369-b6dc-38fcb59cab3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e5b1a58-6382-47ec-806e-79742eab7d06", "AQAAAAIAAYagAAAAEPnEw7ML0Z2+3pgLvSwwyI4F4BuSe9XaQuokpjVdy2cqQq5NS+CKxKx30lgF/uCdRA==", "9bf25eaa-633c-4584-92f6-bb18b22bd4ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96cf7612-8787-4302-99f6-f0a275779a1a", "AQAAAAIAAYagAAAAEPtcR5EWfPLxSq5oSwSLSHe0DnOKBekN01rmKt+bgBCVTOZKOwpYH0j6aCosaYdRFw==", "1ed25165-6395-4209-b332-de525e88d987" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "608dc889-10f5-4d90-a61d-d6db89155a21", "AQAAAAIAAYagAAAAEL81VeesxO4sv5Q4OwdXhJecXRNCHo4gZnfT6fs30zgtKSc5VIxsyktc+EIGvMOG5g==", "1fada43b-122b-4a5a-afbd-61ed2d29c2cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3655e525-2d0f-49e6-be43-bc998d216a56", "AQAAAAIAAYagAAAAEJezU5ebX5ZjcIhKveSyCCcm2vprd7BqmwfdMQkRldnV8eKzSyu+iaqlOyZj3PRd6A==", "b87b49dc-288f-49fa-af95-64af5a0260f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16527142-c44a-4c94-b674-934d415aca6f", "AQAAAAIAAYagAAAAEJW2e2jKPSTw0TnfYXpQayX1mVBj+b5MYLZkeifA3bQkWkJVytbvN42kIWu6IVis7A==", "67bced03-1557-4142-b88e-ede8d80176a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "323a9a1b-1d50-4420-9cf6-9af3b93cd019", "AQAAAAIAAYagAAAAEFaICPHevuivdQSO5DSJDrbVHSnXO3cWD8+5LeSUeEfPvgxnzYX76KX8zZc8DYhQ5g==", "8b5045f3-5508-4bf6-a8a8-2fb392406c82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df83eb72-f46d-484c-99fc-41872b03abd9", "AQAAAAIAAYagAAAAELnP5m1c3p0AHO6kF2xcq9BE1Sl1H1XpBv7xGB0b08txIC7OXS5z9HkeOeGTgXwlCw==", "a9923bda-687c-4458-86e8-93e635a1f29e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fff00865-f4f8-4a33-b961-84c04bc9187f", "AQAAAAIAAYagAAAAELTTdAqdho9plC+5WzbXdE94eqJTEd+rIzBXksrXZSz05ZsCnClnf8Ck0OjECAArbw==", "52565c41-cb8f-4223-aaad-2725b991ca17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6be8fa30-6f09-46f0-a15f-add1c84f6e50", "AQAAAAIAAYagAAAAEKNrNNsZZuU3FzZQj6R2Lp3sxIvgFUQlGPzmhdD94RG0EoVmz94y3u8z8kXcZQ0m8g==", "26feab87-d8fa-49df-add1-2c397af70ebf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0b8703d-6912-40aa-9257-a3209043f44d", "AQAAAAIAAYagAAAAEHIeTIVQ1qWvuVnW+TirHUpNLpFupquuyJKer1+b5Bx/su7bWaerGOaSC1KukTX2aw==", "d2811d04-ae5b-4c9a-9e27-27aff78acf36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2a00ceb-a061-4cae-ba71-c7464cbb2a86", "AQAAAAIAAYagAAAAELU1NL59oVsitxApbidMJUz49bMVqz8I1p+sk7pFjItF6YHHquBVe2aYRJQopiNmMA==", "21bb0e4f-a727-4478-90e0-e5123cce646a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2399e77f-15d9-42c3-89ec-0df0ba08614e", "AQAAAAIAAYagAAAAEFUUUCBGHT8vQRlswwiOdCmDig/X+AhnXiNfEcEDvxcV4jC4+t1miLnePJCBb7sWkQ==", "36bddcfa-10fc-4cbc-a16e-0c85cca62467" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e813f795-0371-4272-ba8c-952e8ccf44cd", "AQAAAAIAAYagAAAAEKUvSmZox7lAwbAKH1TuuuzDm0ofDdmlHUbCLmcYqGea2a1FsJ21S3rcV6eIFFh1Gw==", "3ea64dff-fe10-4e89-b670-d3b1c089ccff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "327c9913-3a67-4224-a750-20301194a198", "AQAAAAIAAYagAAAAEPZGdRPJzpUikc27mfHxAL+9qeAAoohBgcKyC88ayBFkUgWYW9jIZndc7FoV1ommjw==", "40674c1c-f1e8-4c64-b1b7-3b7a7624ff8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7d4b462-5f78-404f-8d8a-71f34fe0a20e", "AQAAAAIAAYagAAAAEHSJ9IS46ZYDoDRzMaYmtf4dz/ko/OX3ewozyoBna4EcN9/yuAx44iM1G5VbAJArag==", "cbd8a504-4642-4732-8dd7-546e577dc8a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01c4837f-3c75-4e59-921f-d0f593a60946", "AQAAAAIAAYagAAAAEDHGPPo8heFTW9jKRWLaLbHQdznfH4/mt6sELzv2N8gn2ZKf2qKF82Ku4k2fa+rR9g==", "2fa4671f-71c5-494d-9a01-9944d2378cfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47816bf1-8dfb-46e2-9c5d-52fc3a23a3ae", "AQAAAAIAAYagAAAAEGruXQ8F5dSJ2BoVKhz45LiEh2NFtDhRDyGoL3p+NXpPN74tN9CqYsR0SCWW2Uvovw==", "474cdbd7-36fe-4f34-9fea-e921e53ba416" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-020",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4d718fd-15ce-4c0e-a0db-d9804abf8d03", "AQAAAAIAAYagAAAAEBk1upsBSsRWm4DEpm8rfLAVufc/5Lv580pwGmnop8qDqvyMHA7SRyZhXuXSR64Rgw==", "5252db1d-710f-46b4-a73d-83d5dc7a287b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-021",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf7a217f-3b31-48a6-ad73-08a503546491", "AQAAAAIAAYagAAAAEEniP4p8w/Yxuv3oQ4Ucso4IOQTpR5OQ7dEiBCHedw7af2hpWkR8hIjCAKhh80LdNQ==", "4e4d9fa7-9c5b-4c31-88c0-80d519f547f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03f7dff6-a066-4756-90c0-74341d0ac5d6", "AQAAAAIAAYagAAAAEDkfRd8tnH26k52MqPi2MqNbMvEYkM7cQNpgQ4QQg8CxyIECMIfi31VMvOoWcTyLzA==", "703cb585-eabf-4f10-9c52-8f6f91391b0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-023",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ea30fad-f4ca-43b2-b1c1-96fe546dccfc", "AQAAAAIAAYagAAAAEMtf+Pnl/nyCyO5WQsIYxNF1kpHVXhXzBtwRSLANhOEj/JbusfGFGVlTorTU6CavAw==", "27bd96a0-79a3-4fe4-ae36-acc4501d6af3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-024",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b8ddee4-ce90-47c7-ae0d-79e0eb6a1208", "AQAAAAIAAYagAAAAED+US1L/lig6fMmeEwdQoKqO/UwrbXR1J1YJjc4V/X1zcUGXO0Cx8O6HbIn+4n+HOQ==", "c139aabb-a86a-4f03-8b05-4f2ff29ca560" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-025",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c18cc09c-e276-4cf8-9419-8f4e4b30914e", "AQAAAAIAAYagAAAAEPgvVPrbTI+SmdbIXcHyzGhZ7yCGv+De/+bPVC02Ik9cPz/Hk9TbVZ8BBe4+hUzkuw==", "d2f6d979-3ad0-4ebd-ba8c-878f29afeaea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-026",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88a1eadf-185d-4bc5-abf2-42d7b18c30aa", "AQAAAAIAAYagAAAAELCGO2vRU6qmVxL/FlN8DBQ5Cgj+cGsD1kfNcPmKtXCJjFKWlwI7YHtjGRpeZBPp8A==", "e76fc267-77f0-455c-826b-62bc403bc8f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "108216e1-cea6-4598-a8fb-779c330d4738", "AQAAAAIAAYagAAAAEHZL0Y1AMGvv7cFfTKGFVFI6nloKbnTCMpeCjkf0wkyAmJmhrbHQ/MvW7RtWW6HcOg==", "8045ecbf-6815-4894-900d-f0535a32ff07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-028",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9ca71b1-9699-49b5-8370-e4703a1124d4", "AQAAAAIAAYagAAAAECUDz7hNOpeagwq7GVk0tfyRRCxJiMIjRSv+bcS6Wa7fXahuoa8URPmrj8WAngj/XQ==", "a7c3fff8-2381-4252-956a-043f05b9e37d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-029",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6f13fb2-b248-42b7-98aa-1d6cf75f82cd", "AQAAAAIAAYagAAAAEJTZWjXlppegQ8y26dSpLXJW125zjwr6WRWSArzcPBOB4wwsUkZCfjyWWIcVqQGCMQ==", "5def890b-6d61-45f7-9b1b-b4b0472673f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-030",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "980306c2-1af5-436b-a183-7f5b902d2652", "AQAAAAIAAYagAAAAEKm4R3FOen3d0LK6VPUO0EP5w2FLemeRyIQi0pfM9fFkUynoYiWyYpqcZdnhdphq0g==", "ffa1e2b3-411e-425a-88e1-36dda2aaf063" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductVariantOrdered_ColorName",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ProductVariantOrdered_SizeName",
                table: "OrderItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0ec1bc9-9652-4447-b61d-a68aa7730b55", "AQAAAAIAAYagAAAAEFj/ujDPLeEaT+AzgW/vH+nUeIrgDp9w9HxI+k2Uj6STX4lv+vOZuUQLU3bsNURLNA==", "cdd793c4-e008-41cf-9f18-76f2a0805fea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20596bc1-3747-42a2-88b8-e226e8736e45", "AQAAAAIAAYagAAAAECt4cxl/2fGLkaEanlaPavYfuZOo9pvEnBGgMnzDJA5pu2sCTGSWvbF/fEQn0+Y2kQ==", "58baedb7-1dd3-4b0e-aee8-ba0684aa2673" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e259e81-80e9-4025-a2de-3bdf0461da47", "AQAAAAIAAYagAAAAEHiO8Z/onRwC5l3DZDkq2NOIHUDjrSM4LEJwXIFdwqPMEjnKii9IlhMFlIbN2XlM1w==", "8c5f0885-9fbf-42d5-868d-71090d58cea3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e844823f-cc73-421a-be17-45034e74adc5", "AQAAAAIAAYagAAAAEGsgIrU5SMy9touqwA8Kr6MxOIyAkt244uUBTuVQxdE6z1Jy8/p9HdqYZOBbzGamKg==", "8078f990-95b3-49bf-af71-f0f9aa2cbd6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cceb270b-c4fb-4272-87c9-1ddf435dab7c", "AQAAAAIAAYagAAAAEIO8RZ6i+oRZ350JBhGglCmbdxOsB/E8I/bwzyC/Xk1RqhyxnqzndAxY4Dix9MyfvQ==", "fb3fcab9-ca5b-46fd-bc90-285fe4fc16c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e033fb51-1d33-4c7f-af45-e3451e90a8f9", "AQAAAAIAAYagAAAAEJ0MQrLnc7upiE+U9KahRNFoegGRALX8E+cvWow7mohvYTnkyAaRUR+H6Ch+zO8fRw==", "a2caabe9-c387-4b8e-ba62-6ee51ee0ca22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4b2cdcf-e6ca-479d-9ce9-b980b024c09b", "AQAAAAIAAYagAAAAEErr9jCfEQaoSg0HMG8yGTD898oFCqQ9lYFr80/UUYPKWQwYTdEmjsrX7SQ+vcuF7w==", "6f9dd34c-027d-48ed-a80d-cd83f88d1a1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bdcde44-d751-4147-a1d6-08c79e2d5e6c", "AQAAAAIAAYagAAAAEJXy/89R6nNIZrKuxpHoi8Pgag/HmlPJv7fRzxpIuJNnvsorx7IhITYyG3dNr9InBw==", "05bb472a-b582-4604-9239-948b8b0cf89c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b8fb572-d5fb-4eba-9e3f-e9a2cd96c52a", "AQAAAAIAAYagAAAAEHb3f4jeCf5+ZTUB7M0rx0Bi9X0jF9enMdWA1ZJatWJXR4FKG4QIkqUOdpr9l/eT4g==", "7e0b45ec-9b38-4bf7-b682-15f85a508540" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1da5bc5-0765-424d-ab95-e6bdc133491b", "AQAAAAIAAYagAAAAEH+5IMj/0muNGyxfsZpMbeuU7pVmd9ttwNtDu/O5EipoSjHtkqNBDrUyefRewRI5mQ==", "c825767d-5faa-401c-a75a-de19cceb3bd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb26260f-9df6-4c60-9223-bf6274b09424", "AQAAAAIAAYagAAAAEDOqKZeoHCeU8P9fsIVAPIlSDNvC6kU5AheLDOgJdmpSNC9/i4BrPHsRmfAiSF7K8Q==", "1410c0b2-3ebc-4e30-9621-187455cbcb0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf9cf85f-cef3-4a41-9ed9-ebf2c4a20c1b", "AQAAAAIAAYagAAAAEEWaVI9zULuInuPPrIJNyAnez+/7UwZBxMXP1hsIDdiVGtmYT7cXGoGnRGXEmWJKbA==", "7e33973b-7a1e-437f-a64a-daa1d4b294e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "378901dd-16d6-4791-8c36-4c120ac87d4b", "AQAAAAIAAYagAAAAENR138BnvZvKokUhlWWOrm1D3pNWqswY3IBooN76riZ1GZW4OYpG5CSQyNd4rIlmIg==", "baaa0257-8964-4f5b-b933-e6806e6e527a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d47edcae-071e-4d80-9ca6-16f15b9f8fde", "AQAAAAIAAYagAAAAENqRaUcsAqaZ0n1Gug0Y1081R+LkZ2cpQ93YSpi80syLoO69u9vQVZ/QT1T83QlnpQ==", "7e712df0-0d21-4e73-a06f-d4384da18dae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba1557fa-3add-4d14-b082-e954fadd4827", "AQAAAAIAAYagAAAAEJxLSmPhHlNYRrm6glXgybopkian7ApwtKTPngYD/S4YZsm+Z7tSIrhOfAIUkrjbhQ==", "cef02bfc-a1fe-4ccd-a0f7-ac46017e65be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0821346-5eb8-4e1d-8a1d-e0f96af2c08a", "AQAAAAIAAYagAAAAEEDfl+W8ZLlPL7Bj1ogIxt30Q3AiS5+7J6Sph3BTCurqbWjacWMDsbFPA2XqI4V6SQ==", "76e25830-48d8-44f0-8e99-302c47000286" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57ffba3a-59d6-4ea9-8a87-b90376612721", "AQAAAAIAAYagAAAAED/xmjXbwyWRjRTQvc32v/IJkki+NtK4lkSWtS7WMNKS8bDpBjf2jhzGvrN9MQP19w==", "bd0c66bc-1bc9-4071-9784-05f6f773c7d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "479c88e0-7ceb-43a2-bcd0-976feec11e00", "AQAAAAIAAYagAAAAEP5XNT73IIwaNqEAmaAMHsuNu6a+hXra00JDy4GvWrCQNn78JtsgrcI9iZ9bAml5kQ==", "962a21d6-e828-4472-9ec3-0c0badd6d591" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e338e364-9791-4915-8716-acda977e9a51", "AQAAAAIAAYagAAAAEIvLUcpNwmgusVI0rV0BWF8yPeUOQfgfHUa7cjh/I5wSySMZA0De6ofTt/NheTPILA==", "969c8c00-07e9-45dd-9f8e-4280255d51ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a6934f4-a41b-4f00-b29d-e4c58435c209", "AQAAAAIAAYagAAAAELD//Rw8f0sGx9FBzSEvJbjXRQ+ENy3cNCGOmxObUzc87fBfMII5bd7pGTGi7xl1sQ==", "93b7eba2-c72f-47e0-bd1b-339703ad0924" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-020",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddfe654f-1282-4177-a1fb-4399c7c7c5a4", "AQAAAAIAAYagAAAAEDlcQqKXMbIi6972yCeV1SNE9ZOcucyc+WD7YdIvkjm732qFfLbG4MHgFn6r4q0ycQ==", "1f4e9dd9-36b2-4dbf-9681-e44fd90c2b68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-021",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05138f28-27cd-4dee-8d04-fa5008ada229", "AQAAAAIAAYagAAAAEB5IlN2b0OkoS73EwXVZ4TkqD8GhfwrpeTrdWPw/7do6GmhP8hUqu5uhs0tdkHxevg==", "4363614f-6ed5-4b27-80af-17dfaf07050b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c35dec0f-d9ed-4c18-88f3-78b21b21ec03", "AQAAAAIAAYagAAAAEOZgCET7GMmUMnt7OjcuRf8elkq2m0H/oL2ZQxIkOvYHcXxL3DLuU7mMv1oBkWQzeQ==", "b28f3556-213a-49ce-9537-74aa8c4af48d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-023",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02074cf2-516e-42f6-b58b-0d5dea8860a1", "AQAAAAIAAYagAAAAEBQ6+7RE91jbGRnFEfFcw2shrYtPqXF0zIYJBAcI/YAu2G9QExlkllOzwcCcRQCyBA==", "69dcd878-3768-455a-b0b1-683819b44cfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-024",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "172d1425-a2fb-4a49-ac40-42e50a93c6a6", "AQAAAAIAAYagAAAAEPbbFIV7CR/oqJAodKJESKLyEHKBJphbzaFHxvLjacIHkJGw6Y6knZqJJn+48yI0mw==", "6369e90b-5d7c-4290-9a6d-2dd16a25fa88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-025",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5564e283-984d-4a1a-990c-b9ce9e40bb18", "AQAAAAIAAYagAAAAEAPt1t68865HP/Rt4QE50lJ0U57ULRfkI2UG/PLroMghBS4hNPJvWtthuYGioikQog==", "5f57560f-6730-47c2-9e9f-d3daad9d8824" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-026",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c64600b-de5d-47dc-a5c2-8adaf71847d7", "AQAAAAIAAYagAAAAEM5hkwoklSrjg9vJNW5oqSrTR9o0R9KaHbe9WqVh0lBg3K1D5EWVo3kENR65VmUtXg==", "51a6b5c4-f6b6-41fd-bdd8-0a9d23b1c976" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86c39989-8451-4e81-8888-20bd41626f76", "AQAAAAIAAYagAAAAEC/YqZVkNT6CUEGtwc3HbH68gPu/Go4EieVv62LDWgsUkhRTYkqm1Mch3g+hMdvuVQ==", "5c8d8517-004b-42e3-8a0b-a201158ea031" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-028",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b40b993-4310-4ddb-a2e7-17276e3c6552", "AQAAAAIAAYagAAAAEOK4WIFpczSzUrIxlzDZaREsHxqpX5lJVxX+Pjz/LCFd2MGyoz78GJ/dHBu394BzXg==", "8f74f602-e6f3-408d-8eef-37e34fa25a89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-029",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dda983e7-440a-4ac1-b73f-ba6fd74bc0a0", "AQAAAAIAAYagAAAAEPDe2sIj/uaWQs01dQf/8xOvsfblQ+m22JSOnQ0iKt/WOqCQctdsIp0Fv4o8PjzMYA==", "eeac83f9-f81f-46aa-aa16-c16a38902f4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-030",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "427e99b3-e725-4f24-81e5-89a875a2205f", "AQAAAAIAAYagAAAAEFkCaNkOsm2nuwQG7ge3KNsGHlER0IOPsTtAzjtrzOzbnON2VkasbbozyD2epYKgLA==", "0d33d6ea-6ffd-4aaa-9c02-01f3530ef6d8" });
        }
    }
}
