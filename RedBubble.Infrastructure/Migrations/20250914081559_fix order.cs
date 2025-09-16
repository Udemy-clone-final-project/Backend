using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedBubble.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_State",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShippingAddress_State",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cce25402-2a20-462d-b62b-e3b864f8e0a4", "AQAAAAIAAYagAAAAEMU+sQ4dViBhvRKJyGkoVW4k4Pny/NNhXGlUqIDitULG6LuhIS+t7srk7dwXkhz41g==", "25799bf2-1ef5-456a-8e71-d02964b8a8ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fae275d9-eb2f-4f0b-87e4-249a97dee0d6", "AQAAAAIAAYagAAAAEHduRokpQbGMLEqcZhi0SVOOl0+PZ6qjqi7x+tsSXPhYYtebQXFUM3tXRrhVfDxo0Q==", "2a4be60c-1831-4c5a-8dc3-f6acebaa1c79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51469a92-9083-41ad-ac6f-c80dda39a722", "AQAAAAIAAYagAAAAENPN7i32/rneU0L7B0la3VP1He+mQznG22CmaWnjszSsFGXJv1M6/3k61nccJseM/A==", "39ea7643-71d6-469b-a298-02202b7e6bbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "953b3b41-c1be-47d9-9a7d-f4c2af87b0a0", "AQAAAAIAAYagAAAAEKpc03i/qV17lK52+MXLyOzzeiiqRKLy8kvgGRGzTAt4nzX5TeaaNTsuy1DjI95JXA==", "cb288dda-bb32-4b83-b03c-1272b1d8c15c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfd4af53-6de1-4bc7-8377-04eb7020c750", "AQAAAAIAAYagAAAAECwEAqo2+iNGvw5QYGMWCRql8AWwQh3v6nS65qyW/K1z0cvrfvYEzsrbyJF3t6CQGQ==", "7dd1ccce-2695-4c11-bf7c-7732acd56a29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f79a6d98-ef2c-4e1a-adb8-99c89e4f96eb", "AQAAAAIAAYagAAAAEE+XJSX3lltfbr14/hRPHQ93WkubiJ4tGHLkV1gZzspEoEOOdiq8G2xPv0Qssxw2sQ==", "6c0ce492-6a4b-4160-97a6-bf230ccab1e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fda32a6e-90d8-49dc-911f-e50ad1911be2", "AQAAAAIAAYagAAAAEBb8VLRNyzp52Pe+NUkZ4LfZImknd9B52msTZlrDsj2hGRR2JIJZUkft3ZUIwse78w==", "3440d4b7-7f63-47ce-bfe1-487fabe1b718" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "365a26fc-2ecd-41e5-9bc0-8c58a6c80c50", "AQAAAAIAAYagAAAAELBUplU2dQiAK856XWZ6Mgn2zOiYhDQ8AGIVxtgwCjOhCeOQVbuA1Zh3suhx5456aQ==", "df74796f-b417-4eb6-91f2-9f8c00c79dd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba41c4fb-5417-4114-8a84-9ce0fbf49caf", "AQAAAAIAAYagAAAAEMI8hj1HaWISCz/nByo2Jw5b/lshVjzuqI6NeG0VBd1t+cVsKbL8Oz9lLq2xexo6/w==", "fb716eff-2f48-491c-8f03-67ab8aa44296" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41b6b00d-dfb7-4577-a1f4-c61d4b1ed8bc", "AQAAAAIAAYagAAAAEBxm5pxqNQhTXLinJzDRb3GkoOJ1tNc4zNM1PH6QuZLtjCn7Z9dTy634LW3edOBkvA==", "10282506-74b7-4611-a9f2-8bf86ce16f12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dd11065-a37f-4aca-aa5b-ae553c91bc69", "AQAAAAIAAYagAAAAECCCxh/EPUHVoIqGdR2Ufh7DEQe2TIF5JrD02bFZRM1npklcKi3F3y8Iy5xve8QahA==", "afdd5c94-4020-4d23-9e11-532e24a8c65a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96e7a48e-375e-4f65-8913-d1e2725d5828", "AQAAAAIAAYagAAAAEI1Zf1kffXmPRY7znRpKrnSbawPyEWir5bhlLaG8FFmq3dg9vXxNspof9eL8m0NGtg==", "789260c3-0103-4f4e-8976-a72ba407d1aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59920de3-31c7-4725-9e21-5085de0051c2", "AQAAAAIAAYagAAAAEICxQFOuba2i4sZw+4w+psXKnb853dhW9AMviERfEQWMO3U+ke1NnbXQWQMHb6hVcg==", "a631b919-5b5d-418b-a3a1-e6d2ab6cf78e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ca26860-50ff-42f8-b085-48c55027c9bc", "AQAAAAIAAYagAAAAEEtZ/9wsSas95Vw2/H5oW26FPTKfF/Nezo4eS5vwugX9ObPBCDB/heIFOC0zJYF9iw==", "2480b71e-2181-4b44-98c0-daf762e7f3a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc6fe411-c465-4748-80a2-2b535b39caa1", "AQAAAAIAAYagAAAAEI2CjE90loP5SIN8ruEr2TvGJFD/gQL9Kudps71bUoVv4JC82jiWm7SuHaLdDsYQ+A==", "b4606865-45f9-4828-be85-c2f9cae46976" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "955b7815-43f3-42b0-9841-53ba759afd58", "AQAAAAIAAYagAAAAEGuRn55Rx8oJ+dDlJF/1F1R/00gqKR0e32vfJCNpiHAzBFw1basnkP8e/a2uW/JFUg==", "98bb17f5-86cb-4232-af8f-8fac9e4eb3bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0d22936-ac98-44a9-93a3-3473dada2073", "AQAAAAIAAYagAAAAEFUp2QNXBWo23c84sKXqHFIAzH0mC1taF/T0QMYhrEmMjQpU53oNBh2C9tF83Uraiw==", "1b9022db-fd0a-4132-a163-ea9c3df54128" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d667240b-638f-436c-9c9c-1f2414da6686", "AQAAAAIAAYagAAAAEB1BZ/aDwP1x8jeq5tEQ2bwEuotsLmpxbG7ENqNDpHeVECLyPTjQnBK+YxWZpFoIAw==", "8dffac9c-f34b-430f-8cc2-6cd52162b4bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ef7bc4c-5797-406a-9743-1683fa40bce5", "AQAAAAIAAYagAAAAEEZrPvKszSkoPFMFH391LjPZuMsRXHvmpei/THs4tyAD7/YrcZGZExrbhzaObiybRg==", "b3b0bcc9-e9d3-4a11-9d7c-a69a1d4e6b37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e030f4a1-5cf4-4896-b2bd-83b5509b0ab7", "AQAAAAIAAYagAAAAEI2HG8TOQktzU07WJrxkntq0TbGCE5Abp+RPvGiV0FrbJAPrQH5u/bopi0JQBTq3PA==", "85fc6ee5-08ef-4795-b0ad-c39d7594c47c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-020",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb743fbb-d21f-4bb2-a08c-fbcd9b03ae89", "AQAAAAIAAYagAAAAEJkDT4ZxLRcK+rkUiX9DkjXmF5TtLzq4oGQLX06oUy1tkdbbJIK1XK0uIxZQryuXEA==", "8748dd9d-0387-4b2f-9d49-7e69fcd008ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-021",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8939b5d-c2bd-44a5-84c6-fd1b67c0f9bd", "AQAAAAIAAYagAAAAEDkvTL/TY9wJ/KHUROd/XnVw3nDdbDE/7mmT6twhrai5Q2CKFDikcTxPw/tZ5dYiOw==", "e00d3f72-e4bf-4d3c-ad5b-888164b04f60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "137e02f7-3e02-44b2-b540-e0959ea37828", "AQAAAAIAAYagAAAAEAT3FJhb6IVVcNGOGBKjV7ZSYo/PlAnM0reb8pyVGLZGDPlOk+Ozdk3ObhR5wHSedA==", "57ff1658-eb00-46aa-ae7b-21599976443a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-023",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "797365cd-7d52-4f3d-acc4-1befe2dfcd91", "AQAAAAIAAYagAAAAEHPSIwBaaUU4E0jH5lkL4xkmhTz3Bxu1bXj2Pzq/cyuuPbEv69TjS/gxI5owyccYig==", "25ea953a-a6ca-4bea-bb1e-4f0302af27f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-024",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "854aa4da-9fe0-4c5c-ba59-1c4a29d83b66", "AQAAAAIAAYagAAAAECOb+wKnUeL3gGymgr0ss/eBJ+J/7Y5YWcUA72TsQdUKomDX2TeIMvte6iTfzlaR8g==", "1e276ca8-d131-42c2-9f04-bd7fffe67885" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-025",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "673e0bed-982e-48a1-a99c-4534e6a18207", "AQAAAAIAAYagAAAAEM9b1W7Gz99IELS4WONksXeq6/T0gmEKoyF7vj7Q0x+FDofuCAvxTA9OQo5gMexuVA==", "1d91f47b-83ad-4df6-b851-9b09c23a7895" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-026",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42b445be-de14-48c7-93e0-bc1bd283d8bd", "AQAAAAIAAYagAAAAELGgIaqw7bkVgt4R2iRqP7WN66wD4PrTSq1BXO28lethiZ719K5THLs0HHcm0QSrzQ==", "64c7a495-57e9-4c53-b03d-d32e8fa0e270" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "baf3ba2e-3dba-47c0-9b3d-df70d5b0f38a", "AQAAAAIAAYagAAAAEBpb/YicR/J9Wisy6WlD+cgo1RC4WdxeXDahCuI6Mp/IbEMtN3p+6XAN6IbUR1YMaQ==", "3045107d-d628-4def-8df0-630d4f6551ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-028",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46a96969-7afa-482c-9840-29a0581aa38e", "AQAAAAIAAYagAAAAEC7FQPnnwSJa261RYF7e6Jip6U8C93X+JZWiOW0B4MV+JHJcI0dbowW6PnaNVN0xIQ==", "df26faf6-fcd8-4bbd-9cff-93f85051e7de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-029",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deb8c274-d1df-4f5e-b7b7-0635b7c70efa", "AQAAAAIAAYagAAAAEOMkHedU2CqnziXec811LjkfxzOJoRHDDYxspgTRRYL4rfNhiFnsgsXyzUIz9+79tg==", "ce1433c4-faaf-4365-bdee-c6dfb3387951" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-030",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e381b2e-e783-48d6-9be1-73b4e16ef32d", "AQAAAAIAAYagAAAAEGxHpYg1nEJzKpzI53OlbH4czQzd1sek0Bhr3dWgAbB9eMQEXwvNFuWI64tyHJ8KGg==", "bd3c799d-19b4-475b-aa28-f49f80b6d7d9" });
        }
    }
}
