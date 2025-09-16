using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RedBubble.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FinalDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "Description", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System Administrator with full access to manage products and designs", true, "Admin", "ADMIN" },
                    { "2", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer who can browse and purchase products", true, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DisplayName", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "admin-001", 0, "cce25402-2a20-462d-b62b-e3b864f8e0a4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System Administrator", "admin@redbubble.com", true, true, false, null, "ADMIN@REDBUBBLE.COM", "ADMIN@REDBUBBLE.COM", "AQAAAAIAAYagAAAAEMU+sQ4dViBhvRKJyGkoVW4k4Pny/NNhXGlUqIDitULG6LuhIS+t7srk7dwXkhz41g==", null, false, "25799bf2-1ef5-456a-8e71-d02964b8a8ca", false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@redbubble.com" },
                    { "customer-001", 0, "fae275d9-eb2f-4f0b-87e4-249a97dee0d6", new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", "customer001@example.com", true, true, false, null, "CUSTOMER001@EXAMPLE.COM", "CUSTOMER001@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHduRokpQbGMLEqcZhi0SVOOl0+PZ6qjqi7x+tsSXPhYYtebQXFUM3tXRrhVfDxo0Q==", null, false, "2a4be60c-1831-4c5a-8dc3-f6acebaa1c79", false, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer001@example.com" },
                    { "customer-002", 0, "51469a92-9083-41ad-ac6f-c80dda39a722", new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", "customer002@example.com", true, true, false, null, "CUSTOMER002@EXAMPLE.COM", "CUSTOMER002@EXAMPLE.COM", "AQAAAAIAAYagAAAAENPN7i32/rneU0L7B0la3VP1He+mQznG22CmaWnjszSsFGXJv1M6/3k61nccJseM/A==", null, false, "39ea7643-71d6-469b-a298-02202b7e6bbf", false, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer002@example.com" },
                    { "customer-003", 0, "953b3b41-c1be-47d9-9a7d-f4c2af87b0a0", new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael Johnson", "customer003@example.com", true, true, false, null, "CUSTOMER003@EXAMPLE.COM", "CUSTOMER003@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKpc03i/qV17lK52+MXLyOzzeiiqRKLy8kvgGRGzTAt4nzX5TeaaNTsuy1DjI95JXA==", null, false, "cb288dda-bb32-4b83-b03c-1272b1d8c15c", false, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer003@example.com" },
                    { "customer-004", 0, "bfd4af53-6de1-4bc7-8377-04eb7020c750", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarah Williams", "customer004@example.com", true, true, false, null, "CUSTOMER004@EXAMPLE.COM", "CUSTOMER004@EXAMPLE.COM", "AQAAAAIAAYagAAAAECwEAqo2+iNGvw5QYGMWCRql8AWwQh3v6nS65qyW/K1z0cvrfvYEzsrbyJF3t6CQGQ==", null, false, "7dd1ccce-2695-4c11-bf7c-7732acd56a29", false, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer004@example.com" },
                    { "customer-005", 0, "f79a6d98-ef2c-4e1a-adb8-99c89e4f96eb", new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "David Brown", "customer005@example.com", true, true, false, null, "CUSTOMER005@EXAMPLE.COM", "CUSTOMER005@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE+XJSX3lltfbr14/hRPHQ93WkubiJ4tGHLkV1gZzspEoEOOdiq8G2xPv0Qssxw2sQ==", null, false, "6c0ce492-6a4b-4160-97a6-bf230ccab1e4", false, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer005@example.com" },
                    { "customer-006", 0, "fda32a6e-90d8-49dc-911f-e50ad1911be2", new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily Davis", "customer006@example.com", true, true, false, null, "CUSTOMER006@EXAMPLE.COM", "CUSTOMER006@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBb8VLRNyzp52Pe+NUkZ4LfZImknd9B52msTZlrDsj2hGRR2JIJZUkft3ZUIwse78w==", null, false, "3440d4b7-7f63-47ce-bfe1-487fabe1b718", false, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer006@example.com" },
                    { "customer-007", 0, "365a26fc-2ecd-41e5-9bc0-8c58a6c80c50", new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher Wilson", "customer007@example.com", true, true, false, null, "CUSTOMER007@EXAMPLE.COM", "CUSTOMER007@EXAMPLE.COM", "AQAAAAIAAYagAAAAELBUplU2dQiAK856XWZ6Mgn2zOiYhDQ8AGIVxtgwCjOhCeOQVbuA1Zh3suhx5456aQ==", null, false, "df74796f-b417-4eb6-91f2-9f8c00c79dd5", false, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer007@example.com" },
                    { "customer-008", 0, "ba41c4fb-5417-4114-8a84-9ce0fbf49caf", new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessica Martinez", "customer008@example.com", true, true, false, null, "CUSTOMER008@EXAMPLE.COM", "CUSTOMER008@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMI8hj1HaWISCz/nByo2Jw5b/lshVjzuqI6NeG0VBd1t+cVsKbL8Oz9lLq2xexo6/w==", null, false, "fb716eff-2f48-491c-8f03-67ab8aa44296", false, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer008@example.com" },
                    { "customer-009", 0, "41b6b00d-dfb7-4577-a1f4-c61d4b1ed8bc", new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel Anderson", "customer009@example.com", true, true, false, null, "CUSTOMER009@EXAMPLE.COM", "CUSTOMER009@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBxm5pxqNQhTXLinJzDRb3GkoOJ1tNc4zNM1PH6QuZLtjCn7Z9dTy634LW3edOBkvA==", null, false, "10282506-74b7-4611-a9f2-8bf86ce16f12", false, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer009@example.com" },
                    { "customer-010", 0, "1dd11065-a37f-4aca-aa5b-ae553c91bc69", new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ashley Taylor", "customer010@example.com", true, true, false, null, "CUSTOMER010@EXAMPLE.COM", "CUSTOMER010@EXAMPLE.COM", "AQAAAAIAAYagAAAAECCCxh/EPUHVoIqGdR2Ufh7DEQe2TIF5JrD02bFZRM1npklcKi3F3y8Iy5xve8QahA==", null, false, "afdd5c94-4020-4d23-9e11-532e24a8c65a", false, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer010@example.com" },
                    { "customer-011", 0, "96e7a48e-375e-4f65-8913-d1e2725d5828", new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matthew Thomas", "customer011@example.com", true, true, false, null, "CUSTOMER011@EXAMPLE.COM", "CUSTOMER011@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI1Zf1kffXmPRY7znRpKrnSbawPyEWir5bhlLaG8FFmq3dg9vXxNspof9eL8m0NGtg==", null, false, "789260c3-0103-4f4e-8976-a72ba407d1aa", false, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer011@example.com" },
                    { "customer-012", 0, "59920de3-31c7-4725-9e21-5085de0051c2", new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amanda Jackson", "customer012@example.com", true, true, false, null, "CUSTOMER012@EXAMPLE.COM", "CUSTOMER012@EXAMPLE.COM", "AQAAAAIAAYagAAAAEICxQFOuba2i4sZw+4w+psXKnb853dhW9AMviERfEQWMO3U+ke1NnbXQWQMHb6hVcg==", null, false, "a631b919-5b5d-418b-a3a1-e6d2ab6cf78e", false, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer012@example.com" },
                    { "customer-013", 0, "5ca26860-50ff-42f8-b085-48c55027c9bc", new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshua White", "customer013@example.com", true, true, false, null, "CUSTOMER013@EXAMPLE.COM", "CUSTOMER013@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEtZ/9wsSas95Vw2/H5oW26FPTKfF/Nezo4eS5vwugX9ObPBCDB/heIFOC0zJYF9iw==", null, false, "2480b71e-2181-4b44-98c0-daf762e7f3a1", false, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer013@example.com" },
                    { "customer-014", 0, "dc6fe411-c465-4748-80a2-2b535b39caa1", new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephanie Harris", "customer014@example.com", true, true, false, null, "CUSTOMER014@EXAMPLE.COM", "CUSTOMER014@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI2CjE90loP5SIN8ruEr2TvGJFD/gQL9Kudps71bUoVv4JC82jiWm7SuHaLdDsYQ+A==", null, false, "b4606865-45f9-4828-be85-c2f9cae46976", false, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer014@example.com" },
                    { "customer-015", 0, "955b7815-43f3-42b0-9841-53ba759afd58", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew Martin", "customer015@example.com", true, true, false, null, "CUSTOMER015@EXAMPLE.COM", "CUSTOMER015@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGuRn55Rx8oJ+dDlJF/1F1R/00gqKR0e32vfJCNpiHAzBFw1basnkP8e/a2uW/JFUg==", null, false, "98bb17f5-86cb-4232-af8f-8fac9e4eb3bd", false, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer015@example.com" },
                    { "customer-016", 0, "c0d22936-ac98-44a9-93a3-3473dada2073", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicole Thompson", "customer016@example.com", true, true, false, null, "CUSTOMER016@EXAMPLE.COM", "CUSTOMER016@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFUp2QNXBWo23c84sKXqHFIAzH0mC1taF/T0QMYhrEmMjQpU53oNBh2C9tF83Uraiw==", null, false, "1b9022db-fd0a-4132-a163-ea9c3df54128", false, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer016@example.com" },
                    { "customer-017", 0, "d667240b-638f-436c-9c9c-1f2414da6686", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ryan Garcia", "customer017@example.com", true, true, false, null, "CUSTOMER017@EXAMPLE.COM", "CUSTOMER017@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB1BZ/aDwP1x8jeq5tEQ2bwEuotsLmpxbG7ENqNDpHeVECLyPTjQnBK+YxWZpFoIAw==", null, false, "8dffac9c-f34b-430f-8cc2-6cd52162b4bb", false, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer017@example.com" },
                    { "customer-018", 0, "9ef7bc4c-5797-406a-9743-1683fa40bce5", new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heather Martinez", "customer018@example.com", true, true, false, null, "CUSTOMER018@EXAMPLE.COM", "CUSTOMER018@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEZrPvKszSkoPFMFH391LjPZuMsRXHvmpei/THs4tyAD7/YrcZGZExrbhzaObiybRg==", null, false, "b3b0bcc9-e9d3-4a11-9d7c-a69a1d4e6b37", false, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer018@example.com" },
                    { "customer-019", 0, "e030f4a1-5cf4-4896-b2bd-83b5509b0ab7", new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kevin Robinson", "customer019@example.com", true, true, false, null, "CUSTOMER019@EXAMPLE.COM", "CUSTOMER019@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI2HG8TOQktzU07WJrxkntq0TbGCE5Abp+RPvGiV0FrbJAPrQH5u/bopi0JQBTq3PA==", null, false, "85fc6ee5-08ef-4795-b0ad-c39d7594c47c", false, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer019@example.com" },
                    { "customer-020", 0, "eb743fbb-d21f-4bb2-a08c-fbcd9b03ae89", new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rachel Clark", "customer020@example.com", true, true, false, null, "CUSTOMER020@EXAMPLE.COM", "CUSTOMER020@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJkDT4ZxLRcK+rkUiX9DkjXmF5TtLzq4oGQLX06oUy1tkdbbJIK1XK0uIxZQryuXEA==", null, false, "8748dd9d-0387-4b2f-9d49-7e69fcd008ee", false, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer020@example.com" },
                    { "customer-021", 0, "f8939b5d-c2bd-44a5-84c6-fd1b67c0f9bd", new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brandon Rodriguez", "customer021@example.com", true, true, false, null, "CUSTOMER021@EXAMPLE.COM", "CUSTOMER021@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDkvTL/TY9wJ/KHUROd/XnVw3nDdbDE/7mmT6twhrai5Q2CKFDikcTxPw/tZ5dYiOw==", null, false, "e00d3f72-e4bf-4d3c-ad5b-888164b04f60", false, new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer021@example.com" },
                    { "customer-022", 0, "137e02f7-3e02-44b2-b540-e0959ea37828", new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lauren Lewis", "customer022@example.com", true, true, false, null, "CUSTOMER022@EXAMPLE.COM", "CUSTOMER022@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAT3FJhb6IVVcNGOGBKjV7ZSYo/PlAnM0reb8pyVGLZGDPlOk+Ozdk3ObhR5wHSedA==", null, false, "57ff1658-eb00-46aa-ae7b-21599976443a", false, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer022@example.com" },
                    { "customer-023", 0, "797365cd-7d52-4f3d-acc4-1befe2dfcd91", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler Lee", "customer023@example.com", true, true, false, null, "CUSTOMER023@EXAMPLE.COM", "CUSTOMER023@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHPSIwBaaUU4E0jH5lkL4xkmhTz3Bxu1bXj2Pzq/cyuuPbEv69TjS/gxI5owyccYig==", null, false, "25ea953a-a6ca-4bea-bb1e-4f0302af27f6", false, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer023@example.com" },
                    { "customer-024", 0, "854aa4da-9fe0-4c5c-ba59-1c4a29d83b66", new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samantha Walker", "customer024@example.com", true, true, false, null, "CUSTOMER024@EXAMPLE.COM", "CUSTOMER024@EXAMPLE.COM", "AQAAAAIAAYagAAAAECOb+wKnUeL3gGymgr0ss/eBJ+J/7Y5YWcUA72TsQdUKomDX2TeIMvte6iTfzlaR8g==", null, false, "1e276ca8-d131-42c2-9f04-bd7fffe67885", false, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer024@example.com" },
                    { "customer-025", 0, "673e0bed-982e-48a1-a99c-4534e6a18207", new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justin Hall", "customer025@example.com", true, true, false, null, "CUSTOMER025@EXAMPLE.COM", "CUSTOMER025@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM9b1W7Gz99IELS4WONksXeq6/T0gmEKoyF7vj7Q0x+FDofuCAvxTA9OQo5gMexuVA==", null, false, "1d91f47b-83ad-4df6-b851-9b09c23a7895", false, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer025@example.com" },
                    { "customer-026", 0, "42b445be-de14-48c7-93e0-bc1bd283d8bd", new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Megan Allen", "customer026@example.com", true, true, false, null, "CUSTOMER026@EXAMPLE.COM", "CUSTOMER026@EXAMPLE.COM", "AQAAAAIAAYagAAAAELGgIaqw7bkVgt4R2iRqP7WN66wD4PrTSq1BXO28lethiZ719K5THLs0HHcm0QSrzQ==", null, false, "64c7a495-57e9-4c53-b03d-d32e8fa0e270", false, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer026@example.com" },
                    { "customer-027", 0, "baf3ba2e-3dba-47c0-9b3d-df70d5b0f38a", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jacob Young", "customer027@example.com", true, true, false, null, "CUSTOMER027@EXAMPLE.COM", "CUSTOMER027@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBpb/YicR/J9Wisy6WlD+cgo1RC4WdxeXDahCuI6Mp/IbEMtN3p+6XAN6IbUR1YMaQ==", null, false, "3045107d-d628-4def-8df0-630d4f6551ff", false, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer027@example.com" },
                    { "customer-028", 0, "46a96969-7afa-482c-9840-29a0581aa38e", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kayla King", "customer028@example.com", true, true, false, null, "CUSTOMER028@EXAMPLE.COM", "CUSTOMER028@EXAMPLE.COM", "AQAAAAIAAYagAAAAEC7FQPnnwSJa261RYF7e6Jip6U8C93X+JZWiOW0B4MV+JHJcI0dbowW6PnaNVN0xIQ==", null, false, "df26faf6-fcd8-4bbd-9cff-93f85051e7de", false, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer028@example.com" },
                    { "customer-029", 0, "deb8c274-d1df-4f5e-b7b7-0635b7c70efa", new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan Wright", "customer029@example.com", true, true, false, null, "CUSTOMER029@EXAMPLE.COM", "CUSTOMER029@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOMkHedU2CqnziXec811LjkfxzOJoRHDDYxspgTRRYL4rfNhiFnsgsXyzUIz9+79tg==", null, false, "ce1433c4-faaf-4365-bdee-c6dfb3387951", false, new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer029@example.com" },
                    { "customer-030", 0, "4e381b2e-e783-48d6-9be1-73b4e16ef32d", new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brittany Lopez", "customer030@example.com", true, true, false, null, "CUSTOMER030@EXAMPLE.COM", "CUSTOMER030@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGxHpYg1nEJzKpzI53OlbH4czQzd1sek0Bhr3dWgAbB9eMQEXwvNFuWI64tyHJ8KGg==", null, false, "bd3c799d-19b4-475b-aa28-f49f80b6d7d9", false, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer030@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "CreatedOn", "Description", "IsActive", "LastModifiedBy", "LastModifiedOn", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "Clothing", "admin-001", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel and wearable items for all ages", true, "admin-001", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Accessories", "admin-001", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fashion accessories and personal items", true, "admin-001", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Home & Living", "admin-001", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Home decor and lifestyle products", true, "admin-001", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "Tech Accessories", "admin-001", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Technology-related accessories and gadgets", true, "admin-001", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorCode", "ColorName", "IsActive" },
                values: new object[,]
                {
                    { 1, "#000000", "Black", true },
                    { 2, "#FFFFFF", "White", true },
                    { 3, "#FF0000", "Red", true },
                    { 4, "#0000FF", "Blue", true },
                    { 5, "#008000", "Green", true },
                    { 6, "#FFFF00", "Yellow", true },
                    { 7, "#800080", "Purple", true },
                    { 8, "#FFA500", "Orange", true },
                    { 9, "#FFC0CB", "Pink", true },
                    { 10, "#808080", "Gray", true }
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
                table: "Sizes",
                columns: new[] { "Id", "Description", "IsActive", "SizeName" },
                values: new object[,]
                {
                    { 1, "Extra Small", true, "XS" },
                    { 2, "Small", true, "S" },
                    { 3, "Medium", true, "M" },
                    { 4, "Large", true, "L" },
                    { 5, "Extra Large", true, "XL" },
                    { 6, "Double Extra Large", true, "XXL" },
                    { 7, "Universal Size", true, "One Size" }
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "ApplicationUserId", "City", "Country", "FirstName", "LastName", "Street" },
                values: new object[,]
                {
                    { 1, "customer-001", "San Jose", "Spain", "Customer1", "User", "9846 Main St" },
                    { 2, "customer-002", "San Diego", "USA", "Customer2", "User", "8134 Main St" },
                    { 3, "customer-003", "Los Angeles", "Canada", "Customer3", "User", "268 Main St" },
                    { 4, "customer-004", "San Jose", "Germany", "Customer4", "User", "6337 Main St" },
                    { 5, "customer-005", "Phoenix", "USA", "Customer5", "User", "1972 Main St" },
                    { 6, "customer-006", "Philadelphia", "United Kingdom", "Customer6", "User", "8478 Main St" },
                    { 7, "customer-007", "San Jose", "Canada", "Customer7", "User", "167 Main St" },
                    { 8, "customer-008", "San Diego", "USA", "Customer8", "User", "342 Main St" },
                    { 9, "customer-009", "San Antonio", "Italy", "Customer9", "User", "7570 Main St" },
                    { 10, "customer-010", "Philadelphia", "Canada", "Customer10", "User", "9003 Main St" },
                    { 11, "customer-011", "Dallas", "Spain", "Customer11", "User", "5999 Main St" },
                    { 12, "customer-012", "Philadelphia", "USA", "Customer12", "User", "815 Main St" },
                    { 13, "customer-013", "Chicago", "Germany", "Customer13", "User", "9180 Main St" },
                    { 14, "customer-014", "San Jose", "Netherlands", "Customer14", "User", "7991 Main St" },
                    { 15, "customer-015", "Los Angeles", "Spain", "Customer15", "User", "4980 Main St" },
                    { 16, "customer-016", "Los Angeles", "Australia", "Customer16", "User", "1223 Main St" },
                    { 17, "customer-017", "Phoenix", "Spain", "Customer17", "User", "1715 Main St" },
                    { 18, "customer-018", "New York", "France", "Customer18", "User", "1633 Main St" },
                    { 19, "customer-019", "San Jose", "Canada", "Customer19", "User", "8248 Main St" },
                    { 20, "customer-020", "New York", "Canada", "Customer20", "User", "7438 Main St" },
                    { 21, "customer-021", "Los Angeles", "Italy", "Customer21", "User", "3695 Main St" },
                    { 22, "customer-022", "New York", "USA", "Customer22", "User", "638 Main St" },
                    { 23, "customer-023", "Los Angeles", "Netherlands", "Customer23", "User", "7393 Main St" },
                    { 24, "customer-024", "San Jose", "Australia", "Customer24", "User", "9852 Main St" },
                    { 25, "customer-025", "Chicago", "USA", "Customer25", "User", "8495 Main St" },
                    { 26, "customer-026", "Philadelphia", "France", "Customer26", "User", "2789 Main St" },
                    { 27, "customer-027", "San Antonio", "Germany", "Customer27", "User", "2525 Main St" },
                    { 28, "customer-028", "San Diego", "USA", "Customer28", "User", "3079 Main St" },
                    { 29, "customer-029", "Phoenix", "Netherlands", "Customer29", "User", "4457 Main St" },
                    { 30, "customer-030", "Chicago", "Italy", "Customer30", "User", "2198 Main St" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "admin-001" },
                    { "2", "customer-001" },
                    { "2", "customer-002" },
                    { "2", "customer-003" },
                    { "2", "customer-004" },
                    { "2", "customer-005" },
                    { "2", "customer-006" },
                    { "2", "customer-007" },
                    { "2", "customer-008" },
                    { "2", "customer-009" },
                    { "2", "customer-010" },
                    { "2", "customer-011" },
                    { "2", "customer-012" },
                    { "2", "customer-013" },
                    { "2", "customer-014" },
                    { "2", "customer-015" },
                    { "2", "customer-016" },
                    { "2", "customer-017" },
                    { "2", "customer-018" },
                    { "2", "customer-019" },
                    { "2", "customer-020" },
                    { "2", "customer-021" },
                    { "2", "customer-022" },
                    { "2", "customer-023" },
                    { "2", "customer-024" },
                    { "2", "customer-025" },
                    { "2", "customer-026" },
                    { "2", "customer-027" },
                    { "2", "customer-028" },
                    { "2", "customer-029" },
                    { "2", "customer-030" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "CreatedOn", "Description", "IsActive", "LastModifiedBy", "LastModifiedOn", "ParentCategoryId" },
                values: new object[,]
                {
                    { 5, "T-Shirts", "admin-001", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comfortable cotton t-shirts for everyday wear", true, "admin-001", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, "Hoodies", "admin-001", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warm and cozy hoodies for casual style", true, "admin-001", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, "Tank Tops", "admin-001", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lightweight tank tops for summer", true, "admin-001", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, "Long Sleeve", "admin-001", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long sleeve shirts for cooler weather", true, "admin-001", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, "Bags", "admin-001", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stylish bags and totes", true, "admin-001", new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "Stickers", "admin-001", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Decorative stickers and decals", true, "admin-001", new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "Phone Cases", "admin-001", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Protective cases for smartphones", true, "admin-001", new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "Mugs", "admin-001", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ceramic mugs for beverages", true, "admin-001", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "Posters", "admin-001", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wall posters and prints", true, "admin-001", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "Canvas Prints", "admin-001", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-quality canvas prints", true, "admin-001", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "Laptop Stickers", "admin-001", new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Decorative stickers for laptops", true, "admin-001", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "Mouse Pads", "admin-001", new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comfortable mouse pads", true, "admin-001", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "Designs",
                columns: new[] { "Id", "AdminId", "AltText", "CreatedBy", "CreatedOn", "Description", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "admin-001", "Galaxy Nebula design artwork", "admin-001", new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stunning galaxy nebula in deep space", "design_1.jpg", "https://picsum.photos/seed/design1/800/600", true, "admin-001", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.00m, "Galaxy Nebula #1" },
                    { 2, "admin-001", "Geometric Mandala design artwork", "admin-001", new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intricate geometric mandala pattern", "design_2.jpg", "https://picsum.photos/seed/design2/800/600", true, "admin-001", new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.80m, "Geometric Mandala #2" },
                    { 3, "admin-001", "Geometric Mandala design artwork", "admin-001", new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intricate geometric mandala pattern", "design_3.jpg", "https://picsum.photos/seed/design3/800/600", true, "admin-001", new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.88m, "Geometric Mandala #3" },
                    { 4, "admin-001", "Majestic Eagle design artwork", "admin-001", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful eagle in flight", "design_4.jpg", "https://picsum.photos/seed/design4/800/600", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.05m, "Majestic Eagle #4" },
                    { 5, "admin-001", "Majestic Eagle design artwork", "admin-001", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful eagle in flight", "design_5.jpg", "https://picsum.photos/seed/design5/800/600", true, "admin-001", new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.51m, "Majestic Eagle #5" },
                    { 6, "admin-001", "Vintage Script design artwork", "admin-001", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elegant vintage script typography", "design_6.jpg", "https://picsum.photos/seed/design6/800/600", true, "admin-001", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.72m, "Vintage Script #6" },
                    { 7, "admin-001", "Alien Planet design artwork", "admin-001", new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mysterious alien planet landscape", "design_7.jpg", "https://picsum.photos/seed/design7/800/600", true, "admin-001", new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.35m, "Alien Planet #7" },
                    { 8, "admin-001", "Ocean Waves design artwork", "admin-001", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful ocean waves crashing on shore", "design_8.jpg", "https://picsum.photos/seed/design8/800/600", true, "admin-001", new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.54m, "Ocean Waves #8" },
                    { 9, "admin-001", "Geometric Mandala design artwork", "admin-001", new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intricate geometric mandala pattern", "design_9.jpg", "https://picsum.photos/seed/design9/800/600", true, "admin-001", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.47m, "Geometric Mandala #9" },
                    { 10, "admin-001", "Alien Planet design artwork", "admin-001", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mysterious alien planet landscape", "design_10.jpg", "https://picsum.photos/seed/design10/800/600", true, "admin-001", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.29m, "Alien Planet #10" },
                    { 11, "admin-001", "Rocket Launch design artwork", "admin-001", new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocket launching into space", "design_11.jpg", "https://picsum.photos/seed/design11/800/600", true, "admin-001", new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.19m, "Rocket Launch #11" },
                    { 12, "admin-001", "Mountain Sunset design artwork", "admin-001", new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathtaking mountain landscape at sunset", "design_12.jpg", "https://picsum.photos/seed/design12/800/600", true, "admin-001", new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.01m, "Mountain Sunset #12" },
                    { 13, "admin-001", "Colorful Spiral design artwork", "admin-001", new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vibrant spiral design with flowing colors", "design_13.jpg", "https://picsum.photos/seed/design13/800/600", true, "admin-001", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.32m, "Colorful Spiral #13" },
                    { 14, "admin-001", "Ocean Waves design artwork", "admin-001", new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful ocean waves crashing on shore", "design_14.jpg", "https://picsum.photos/seed/design14/800/600", true, "admin-001", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.84m, "Ocean Waves #14" },
                    { 15, "admin-001", "Mountain Sunset design artwork", "admin-001", new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathtaking mountain landscape at sunset", "design_15.jpg", "https://picsum.photos/seed/design15/800/600", true, "admin-001", new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.65m, "Mountain Sunset #15" },
                    { 16, "admin-001", "Geometric Mandala design artwork", "admin-001", new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intricate geometric mandala pattern", "design_16.jpg", "https://picsum.photos/seed/design16/800/600", true, "admin-001", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.92m, "Geometric Mandala #16" },
                    { 17, "admin-001", "Forest Path design artwork", "admin-001", new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peaceful forest trail through tall trees", "design_17.jpg", "https://picsum.photos/seed/design17/800/600", true, "admin-001", new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.57m, "Forest Path #17" },
                    { 18, "admin-001", "Mountain Sunset design artwork", "admin-001", new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathtaking mountain landscape at sunset", "design_18.jpg", "https://picsum.photos/seed/design18/800/600", true, "admin-001", new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.51m, "Mountain Sunset #18" },
                    { 19, "admin-001", "Modern Sans Serif design artwork", "admin-001", new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean modern sans serif typography", "design_19.jpg", "https://picsum.photos/seed/design19/800/600", true, "admin-001", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.63m, "Modern Sans Serif #19" },
                    { 20, "admin-001", "Mountain Sunset design artwork", "admin-001", new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathtaking mountain landscape at sunset", "design_20.jpg", "https://picsum.photos/seed/design20/800/600", true, "admin-001", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.23m, "Mountain Sunset #20" },
                    { 21, "admin-001", "Coffee Lover design artwork", "admin-001", new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee-themed design for caffeine enthusiasts", "design_21.jpg", "https://picsum.photos/seed/design21/800/600", true, "admin-001", new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.69m, "Coffee Lover #21" },
                    { 22, "admin-001", "Tropical Fish design artwork", "admin-001", new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorful tropical fish in coral reef", "design_22.jpg", "https://picsum.photos/seed/design22/800/600", true, "admin-001", new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.98m, "Tropical Fish #22" },
                    { 23, "admin-001", "Vintage Script design artwork", "admin-001", new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elegant vintage script typography", "design_23.jpg", "https://picsum.photos/seed/design23/800/600", true, "admin-001", new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.26m, "Vintage Script #23" },
                    { 24, "admin-001", "Minimalist Lines design artwork", "admin-001", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean minimalist line art design", "design_24.jpg", "https://picsum.photos/seed/design24/800/600", true, "admin-001", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.69m, "Minimalist Lines #24" },
                    { 25, "admin-001", "Mountain Sunset design artwork", "admin-001", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathtaking mountain landscape at sunset", "design_25.jpg", "https://picsum.photos/seed/design25/800/600", true, "admin-001", new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.66m, "Mountain Sunset #25" },
                    { 26, "admin-001", "Galaxy Nebula design artwork", "admin-001", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stunning galaxy nebula in deep space", "design_26.jpg", "https://picsum.photos/seed/design26/800/600", true, "admin-001", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.83m, "Galaxy Nebula #26" },
                    { 27, "admin-001", "Minimalist Lines design artwork", "admin-001", new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean minimalist line art design", "design_27.jpg", "https://picsum.photos/seed/design27/800/600", true, "admin-001", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.19m, "Minimalist Lines #27" },
                    { 28, "admin-001", "Geometric Mandala design artwork", "admin-001", new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intricate geometric mandala pattern", "design_28.jpg", "https://picsum.photos/seed/design28/800/600", true, "admin-001", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.10m, "Geometric Mandala #28" },
                    { 29, "admin-001", "Rocket Launch design artwork", "admin-001", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocket launching into space", "design_29.jpg", "https://picsum.photos/seed/design29/800/600", true, "admin-001", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.72m, "Rocket Launch #29" },
                    { 30, "admin-001", "Majestic Eagle design artwork", "admin-001", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful eagle in flight", "design_30.jpg", "https://picsum.photos/seed/design30/800/600", true, "admin-001", new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.21m, "Majestic Eagle #30" },
                    { 31, "admin-001", "Motivational Quote design artwork", "admin-001", new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inspirational typography design", "design_31.jpg", "https://picsum.photos/seed/design31/800/600", true, "admin-001", new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.22m, "Motivational Quote #31" },
                    { 32, "admin-001", "Colorful Spiral design artwork", "admin-001", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vibrant spiral design with flowing colors", "design_32.jpg", "https://picsum.photos/seed/design32/800/600", true, "admin-001", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.73m, "Colorful Spiral #32" },
                    { 33, "admin-001", "Vintage Script design artwork", "admin-001", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elegant vintage script typography", "design_33.jpg", "https://picsum.photos/seed/design33/800/600", true, "admin-001", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.95m, "Vintage Script #33" },
                    { 34, "admin-001", "Forest Path design artwork", "admin-001", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peaceful forest trail through tall trees", "design_34.jpg", "https://picsum.photos/seed/design34/800/600", true, "admin-001", new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.59m, "Forest Path #34" },
                    { 35, "admin-001", "Alien Planet design artwork", "admin-001", new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mysterious alien planet landscape", "design_35.jpg", "https://picsum.photos/seed/design35/800/600", true, "admin-001", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.34m, "Alien Planet #35" },
                    { 36, "admin-001", "Coffee Lover design artwork", "admin-001", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee-themed design for caffeine enthusiasts", "design_36.jpg", "https://picsum.photos/seed/design36/800/600", true, "admin-001", new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.41m, "Coffee Lover #36" },
                    { 37, "admin-001", "Minimalist Lines design artwork", "admin-001", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean minimalist line art design", "design_37.jpg", "https://picsum.photos/seed/design37/800/600", true, "admin-001", new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.08m, "Minimalist Lines #37" },
                    { 38, "admin-001", "Geometric Mandala design artwork", "admin-001", new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intricate geometric mandala pattern", "design_38.jpg", "https://picsum.photos/seed/design38/800/600", true, "admin-001", new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.46m, "Geometric Mandala #38" },
                    { 39, "admin-001", "Colorful Spiral design artwork", "admin-001", new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vibrant spiral design with flowing colors", "design_39.jpg", "https://picsum.photos/seed/design39/800/600", true, "admin-001", new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.90m, "Colorful Spiral #39" },
                    { 40, "admin-001", "Ocean Waves design artwork", "admin-001", new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful ocean waves crashing on shore", "design_40.jpg", "https://picsum.photos/seed/design40/800/600", true, "admin-001", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.49m, "Ocean Waves #40" },
                    { 41, "admin-001", "Cute Cat design artwork", "admin-001", new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adorable cat illustration", "design_41.jpg", "https://picsum.photos/seed/design41/800/600", true, "admin-001", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.70m, "Cute Cat #41" },
                    { 42, "admin-001", "Cute Cat design artwork", "admin-001", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adorable cat illustration", "design_42.jpg", "https://picsum.photos/seed/design42/800/600", true, "admin-001", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.05m, "Cute Cat #42" },
                    { 43, "admin-001", "Motivational Quote design artwork", "admin-001", new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inspirational typography design", "design_43.jpg", "https://picsum.photos/seed/design43/800/600", true, "admin-001", new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.71m, "Motivational Quote #43" },
                    { 44, "admin-001", "Music Notes design artwork", "admin-001", new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Musical notes and instruments", "design_44.jpg", "https://picsum.photos/seed/design44/800/600", true, "admin-001", new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.03m, "Music Notes #44" },
                    { 45, "admin-001", "Mountain Sunset design artwork", "admin-001", new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathtaking mountain landscape at sunset", "design_45.jpg", "https://picsum.photos/seed/design45/800/600", true, "admin-001", new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.52m, "Mountain Sunset #45" },
                    { 46, "admin-001", "Vintage Script design artwork", "admin-001", new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elegant vintage script typography", "design_46.jpg", "https://picsum.photos/seed/design46/800/600", true, "admin-001", new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.20m, "Vintage Script #46" },
                    { 47, "admin-001", "Coffee Lover design artwork", "admin-001", new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee-themed design for caffeine enthusiasts", "design_47.jpg", "https://picsum.photos/seed/design47/800/600", true, "admin-001", new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.12m, "Coffee Lover #47" },
                    { 48, "admin-001", "Motivational Quote design artwork", "admin-001", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inspirational typography design", "design_48.jpg", "https://picsum.photos/seed/design48/800/600", true, "admin-001", new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.93m, "Motivational Quote #48" },
                    { 49, "admin-001", "Alien Planet design artwork", "admin-001", new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mysterious alien planet landscape", "design_49.jpg", "https://picsum.photos/seed/design49/800/600", true, "admin-001", new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.24m, "Alien Planet #49" },
                    { 50, "admin-001", "Majestic Eagle design artwork", "admin-001", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful eagle in flight", "design_50.jpg", "https://picsum.photos/seed/design50/800/600", true, "admin-001", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.98m, "Majestic Eagle #50" },
                    { 51, "admin-001", "Tropical Fish design artwork", "admin-001", new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorful tropical fish in coral reef", "design_51.jpg", "https://picsum.photos/seed/design51/800/600", true, "admin-001", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.22m, "Tropical Fish #51" },
                    { 52, "admin-001", "Retro Gaming design artwork", "admin-001", new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nostalgic retro gaming pixel art", "design_52.jpg", "https://picsum.photos/seed/design52/800/600", true, "admin-001", new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.65m, "Retro Gaming #52" },
                    { 53, "admin-001", "Alien Planet design artwork", "admin-001", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mysterious alien planet landscape", "design_53.jpg", "https://picsum.photos/seed/design53/800/600", true, "admin-001", new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.23m, "Alien Planet #53" },
                    { 54, "admin-001", "Coffee Lover design artwork", "admin-001", new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee-themed design for caffeine enthusiasts", "design_54.jpg", "https://picsum.photos/seed/design54/800/600", true, "admin-001", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.13m, "Coffee Lover #54" },
                    { 55, "admin-001", "Ocean Waves design artwork", "admin-001", new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful ocean waves crashing on shore", "design_55.jpg", "https://picsum.photos/seed/design55/800/600", true, "admin-001", new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.69m, "Ocean Waves #55" },
                    { 56, "admin-001", "Majestic Eagle design artwork", "admin-001", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful eagle in flight", "design_56.jpg", "https://picsum.photos/seed/design56/800/600", true, "admin-001", new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.89m, "Majestic Eagle #56" },
                    { 57, "admin-001", "Motivational Quote design artwork", "admin-001", new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inspirational typography design", "design_57.jpg", "https://picsum.photos/seed/design57/800/600", true, "admin-001", new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.77m, "Motivational Quote #57" },
                    { 58, "admin-001", "Majestic Eagle design artwork", "admin-001", new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful eagle in flight", "design_58.jpg", "https://picsum.photos/seed/design58/800/600", true, "admin-001", new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.65m, "Majestic Eagle #58" },
                    { 59, "admin-001", "Coffee Lover design artwork", "admin-001", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee-themed design for caffeine enthusiasts", "design_59.jpg", "https://picsum.photos/seed/design59/800/600", true, "admin-001", new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.45m, "Coffee Lover #59" },
                    { 60, "admin-001", "Minimalist Lines design artwork", "admin-001", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean minimalist line art design", "design_60.jpg", "https://picsum.photos/seed/design60/800/600", true, "admin-001", new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.33m, "Minimalist Lines #60" },
                    { 61, "admin-001", "Retro Gaming design artwork", "admin-001", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nostalgic retro gaming pixel art", "design_61.jpg", "https://picsum.photos/seed/design61/800/600", true, "admin-001", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.94m, "Retro Gaming #61" },
                    { 62, "admin-001", "Rocket Launch design artwork", "admin-001", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocket launching into space", "design_62.jpg", "https://picsum.photos/seed/design62/800/600", true, "admin-001", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.99m, "Rocket Launch #62" },
                    { 63, "admin-001", "Retro Gaming design artwork", "admin-001", new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nostalgic retro gaming pixel art", "design_63.jpg", "https://picsum.photos/seed/design63/800/600", true, "admin-001", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.47m, "Retro Gaming #63" },
                    { 64, "admin-001", "Cute Cat design artwork", "admin-001", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adorable cat illustration", "design_64.jpg", "https://picsum.photos/seed/design64/800/600", true, "admin-001", new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.10m, "Cute Cat #64" },
                    { 65, "admin-001", "Forest Path design artwork", "admin-001", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peaceful forest trail through tall trees", "design_65.jpg", "https://picsum.photos/seed/design65/800/600", true, "admin-001", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.05m, "Forest Path #65" },
                    { 66, "admin-001", "Coffee Lover design artwork", "admin-001", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee-themed design for caffeine enthusiasts", "design_66.jpg", "https://picsum.photos/seed/design66/800/600", true, "admin-001", new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.13m, "Coffee Lover #66" },
                    { 67, "admin-001", "Minimalist Lines design artwork", "admin-001", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean minimalist line art design", "design_67.jpg", "https://picsum.photos/seed/design67/800/600", true, "admin-001", new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.15m, "Minimalist Lines #67" },
                    { 68, "admin-001", "Vintage Script design artwork", "admin-001", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elegant vintage script typography", "design_68.jpg", "https://picsum.photos/seed/design68/800/600", true, "admin-001", new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.24m, "Vintage Script #68" },
                    { 69, "admin-001", "Minimalist Lines design artwork", "admin-001", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean minimalist line art design", "design_69.jpg", "https://picsum.photos/seed/design69/800/600", true, "admin-001", new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.02m, "Minimalist Lines #69" },
                    { 70, "admin-001", "Motivational Quote design artwork", "admin-001", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inspirational typography design", "design_70.jpg", "https://picsum.photos/seed/design70/800/600", true, "admin-001", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.34m, "Motivational Quote #70" },
                    { 71, "admin-001", "Majestic Eagle design artwork", "admin-001", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful eagle in flight", "design_71.jpg", "https://picsum.photos/seed/design71/800/600", true, "admin-001", new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.75m, "Majestic Eagle #71" },
                    { 72, "admin-001", "Cute Cat design artwork", "admin-001", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adorable cat illustration", "design_72.jpg", "https://picsum.photos/seed/design72/800/600", true, "admin-001", new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.84m, "Cute Cat #72" },
                    { 73, "admin-001", "Tropical Fish design artwork", "admin-001", new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorful tropical fish in coral reef", "design_73.jpg", "https://picsum.photos/seed/design73/800/600", true, "admin-001", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.09m, "Tropical Fish #73" },
                    { 74, "admin-001", "Minimalist Lines design artwork", "admin-001", new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean minimalist line art design", "design_74.jpg", "https://picsum.photos/seed/design74/800/600", true, "admin-001", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.81m, "Minimalist Lines #74" },
                    { 75, "admin-001", "Cute Cat design artwork", "admin-001", new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adorable cat illustration", "design_75.jpg", "https://picsum.photos/seed/design75/800/600", true, "admin-001", new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.24m, "Cute Cat #75" },
                    { 76, "admin-001", "Tropical Fish design artwork", "admin-001", new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorful tropical fish in coral reef", "design_76.jpg", "https://picsum.photos/seed/design76/800/600", true, "admin-001", new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.56m, "Tropical Fish #76" },
                    { 77, "admin-001", "Tropical Fish design artwork", "admin-001", new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorful tropical fish in coral reef", "design_77.jpg", "https://picsum.photos/seed/design77/800/600", true, "admin-001", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.13m, "Tropical Fish #77" },
                    { 78, "admin-001", "Retro Gaming design artwork", "admin-001", new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nostalgic retro gaming pixel art", "design_78.jpg", "https://picsum.photos/seed/design78/800/600", true, "admin-001", new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.92m, "Retro Gaming #78" },
                    { 79, "admin-001", "Vintage Script design artwork", "admin-001", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elegant vintage script typography", "design_79.jpg", "https://picsum.photos/seed/design79/800/600", true, "admin-001", new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.32m, "Vintage Script #79" },
                    { 80, "admin-001", "Majestic Eagle design artwork", "admin-001", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful eagle in flight", "design_80.jpg", "https://picsum.photos/seed/design80/800/600", true, "admin-001", new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.29m, "Majestic Eagle #80" },
                    { 81, "admin-001", "Music Notes design artwork", "admin-001", new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Musical notes and instruments", "design_81.jpg", "https://picsum.photos/seed/design81/800/600", true, "admin-001", new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.80m, "Music Notes #81" },
                    { 82, "admin-001", "Majestic Eagle design artwork", "admin-001", new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful eagle in flight", "design_82.jpg", "https://picsum.photos/seed/design82/800/600", true, "admin-001", new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.55m, "Majestic Eagle #82" },
                    { 83, "admin-001", "Cute Cat design artwork", "admin-001", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adorable cat illustration", "design_83.jpg", "https://picsum.photos/seed/design83/800/600", true, "admin-001", new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.61m, "Cute Cat #83" },
                    { 84, "admin-001", "Majestic Eagle design artwork", "admin-001", new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful eagle in flight", "design_84.jpg", "https://picsum.photos/seed/design84/800/600", true, "admin-001", new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.33m, "Majestic Eagle #84" },
                    { 85, "admin-001", "Vintage Script design artwork", "admin-001", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elegant vintage script typography", "design_85.jpg", "https://picsum.photos/seed/design85/800/600", true, "admin-001", new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.50m, "Vintage Script #85" },
                    { 86, "admin-001", "Mountain Sunset design artwork", "admin-001", new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathtaking mountain landscape at sunset", "design_86.jpg", "https://picsum.photos/seed/design86/800/600", true, "admin-001", new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.69m, "Mountain Sunset #86" },
                    { 87, "admin-001", "Modern Sans Serif design artwork", "admin-001", new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean modern sans serif typography", "design_87.jpg", "https://picsum.photos/seed/design87/800/600", true, "admin-001", new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.31m, "Modern Sans Serif #87" },
                    { 88, "admin-001", "Geometric Mandala design artwork", "admin-001", new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intricate geometric mandala pattern", "design_88.jpg", "https://picsum.photos/seed/design88/800/600", true, "admin-001", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.70m, "Geometric Mandala #88" },
                    { 89, "admin-001", "Coffee Lover design artwork", "admin-001", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee-themed design for caffeine enthusiasts", "design_89.jpg", "https://picsum.photos/seed/design89/800/600", true, "admin-001", new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.67m, "Coffee Lover #89" },
                    { 90, "admin-001", "Retro Gaming design artwork", "admin-001", new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nostalgic retro gaming pixel art", "design_90.jpg", "https://picsum.photos/seed/design90/800/600", true, "admin-001", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.12m, "Retro Gaming #90" },
                    { 91, "admin-001", "Majestic Eagle design artwork", "admin-001", new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful eagle in flight", "design_91.jpg", "https://picsum.photos/seed/design91/800/600", true, "admin-001", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.51m, "Majestic Eagle #91" },
                    { 92, "admin-001", "Coffee Lover design artwork", "admin-001", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee-themed design for caffeine enthusiasts", "design_92.jpg", "https://picsum.photos/seed/design92/800/600", true, "admin-001", new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.36m, "Coffee Lover #92" },
                    { 93, "admin-001", "Ocean Waves design artwork", "admin-001", new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful ocean waves crashing on shore", "design_93.jpg", "https://picsum.photos/seed/design93/800/600", true, "admin-001", new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.07m, "Ocean Waves #93" },
                    { 94, "admin-001", "Forest Path design artwork", "admin-001", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peaceful forest trail through tall trees", "design_94.jpg", "https://picsum.photos/seed/design94/800/600", true, "admin-001", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.22m, "Forest Path #94" },
                    { 95, "admin-001", "Colorful Spiral design artwork", "admin-001", new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vibrant spiral design with flowing colors", "design_95.jpg", "https://picsum.photos/seed/design95/800/600", true, "admin-001", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.62m, "Colorful Spiral #95" },
                    { 96, "admin-001", "Vintage Script design artwork", "admin-001", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elegant vintage script typography", "design_96.jpg", "https://picsum.photos/seed/design96/800/600", true, "admin-001", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.03m, "Vintage Script #96" },
                    { 97, "admin-001", "Minimalist Lines design artwork", "admin-001", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean minimalist line art design", "design_97.jpg", "https://picsum.photos/seed/design97/800/600", true, "admin-001", new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.40m, "Minimalist Lines #97" },
                    { 98, "admin-001", "Tropical Fish design artwork", "admin-001", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorful tropical fish in coral reef", "design_98.jpg", "https://picsum.photos/seed/design98/800/600", true, "admin-001", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.24m, "Tropical Fish #98" },
                    { 99, "admin-001", "Majestic Eagle design artwork", "admin-001", new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful eagle in flight", "design_99.jpg", "https://picsum.photos/seed/design99/800/600", true, "admin-001", new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.21m, "Majestic Eagle #99" },
                    { 100, "admin-001", "Coffee Lover design artwork", "admin-001", new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee-themed design for caffeine enthusiasts", "design_100.jpg", "https://picsum.photos/seed/design100/800/600", true, "admin-001", new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.23m, "Coffee Lover #100" }
                });

            migrationBuilder.InsertData(
                table: "BaseProducts",
                columns: new[] { "Id", "BasePrice", "CategoryId", "CreatedBy", "CreatedOn", "Description", "IsActive", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, 19.99m, 5, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comfortable cotton t-shirt with a relaxed fit", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic T-Shirt" },
                    { 2, 24.99m, 5, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-quality cotton t-shirt with a modern fit", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Premium T-Shirt" },
                    { 3, 39.99m, 6, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warm and comfortable hoodie for casual wear", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic Hoodie" },
                    { 4, 49.99m, 6, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-quality hoodie with premium materials", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Premium Hoodie" },
                    { 5, 16.99m, 7, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lightweight tank top perfect for summer", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic Tank Top" },
                    { 6, 22.99m, 8, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comfortable long sleeve shirt for cooler weather", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic Long Sleeve" },
                    { 7, 12.99m, 9, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spacious tote bag for everyday use", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tote Bag" },
                    { 8, 3.99m, 10, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Durable vinyl sticker for various surfaces", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vinyl Sticker" },
                    { 9, 15.99m, 11, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Protective case for smartphones", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone Case" },
                    { 10, 11.99m, 12, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-quality ceramic mug for beverages", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ceramic Mug" },
                    { 11, 8.99m, 13, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-quality poster print for wall decoration", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poster Print" },
                    { 12, 24.99m, 14, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Premium canvas print for wall art", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canvas Print" },
                    { 13, 2.99m, 15, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Decorative sticker for laptops and devices", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop Sticker" },
                    { 14, 9.99m, 16, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comfortable mouse pad for computer use", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mouse Pad" },
                    { 15, 14.99m, 9, "admin-001", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-quality tote bag with reinforced handles", true, "admin-001", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Premium Tote Bag" }
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
                    { 5, 1, 2, 1, true, 22.49m, 1 },
                    { 6, 1, 2, 1, true, 22.33m, 2 },
                    { 7, 1, 2, 1, true, 23.31m, 3 },
                    { 8, 1, 2, 1, true, 23.25m, 4 },
                    { 9, 1, 3, 1, true, 24.34m, 1 },
                    { 10, 1, 3, 1, true, 24.54m, 2 },
                    { 11, 1, 3, 1, true, 23.44m, 3 },
                    { 12, 1, 3, 1, true, 24.83m, 4 },
                    { 13, 1, 4, 1, true, 22.65m, 1 },
                    { 14, 1, 4, 1, true, 26.23m, 2 },
                    { 15, 1, 4, 1, true, 23.01m, 3 },
                    { 16, 1, 4, 1, true, 26.86m, 4 },
                    { 17, 1, 5, 1, true, 25.27m, 1 },
                    { 18, 1, 5, 1, true, 26.28m, 2 },
                    { 19, 1, 5, 1, true, 22.12m, 3 },
                    { 20, 1, 5, 1, true, 27.27m, 4 },
                    { 21, 1, 1, 2, true, 24.43m, 1 },
                    { 22, 1, 1, 2, true, 26.32m, 2 },
                    { 23, 1, 1, 2, true, 22.34m, 3 },
                    { 24, 1, 1, 2, true, 24.00m, 4 },
                    { 25, 1, 2, 2, true, 24.33m, 1 },
                    { 26, 1, 2, 2, true, 26.90m, 2 },
                    { 27, 1, 2, 2, true, 27.91m, 3 },
                    { 28, 1, 2, 2, true, 23.36m, 4 },
                    { 29, 1, 3, 2, true, 24.99m, 1 },
                    { 30, 1, 3, 2, true, 23.94m, 2 },
                    { 31, 1, 3, 2, true, 25.18m, 3 },
                    { 32, 1, 3, 2, true, 25.39m, 4 },
                    { 33, 1, 4, 2, true, 25.98m, 1 },
                    { 34, 1, 4, 2, true, 24.51m, 2 },
                    { 35, 1, 4, 2, true, 27.20m, 3 },
                    { 36, 1, 4, 2, true, 25.14m, 4 },
                    { 37, 1, 5, 2, true, 26.54m, 1 },
                    { 38, 1, 5, 2, true, 22.86m, 2 },
                    { 39, 1, 5, 2, true, 24.59m, 3 },
                    { 40, 1, 5, 2, true, 27.24m, 4 },
                    { 41, 1, 1, 3, true, 25.44m, 1 },
                    { 42, 1, 1, 3, true, 24.41m, 2 },
                    { 43, 1, 1, 3, true, 22.10m, 3 },
                    { 44, 1, 1, 3, true, 27.25m, 4 },
                    { 45, 1, 2, 3, true, 23.95m, 1 },
                    { 46, 1, 2, 3, true, 24.19m, 2 },
                    { 47, 1, 2, 3, true, 24.86m, 3 },
                    { 48, 1, 2, 3, true, 25.60m, 4 },
                    { 49, 1, 3, 3, true, 26.16m, 1 },
                    { 50, 1, 3, 3, true, 24.93m, 2 },
                    { 51, 1, 3, 3, true, 24.32m, 3 },
                    { 52, 1, 3, 3, true, 23.42m, 4 },
                    { 53, 1, 4, 3, true, 22.12m, 1 },
                    { 54, 1, 4, 3, true, 24.31m, 2 },
                    { 55, 1, 4, 3, true, 24.99m, 3 },
                    { 56, 1, 4, 3, true, 23.37m, 4 },
                    { 57, 1, 5, 3, true, 25.34m, 1 },
                    { 58, 1, 5, 3, true, 23.02m, 2 },
                    { 59, 1, 5, 3, true, 24.98m, 3 },
                    { 60, 1, 5, 3, true, 23.58m, 4 },
                    { 61, 1, 1, 4, true, 22.41m, 1 },
                    { 62, 1, 1, 4, true, 27.94m, 2 },
                    { 63, 1, 1, 4, true, 26.25m, 3 },
                    { 64, 1, 1, 4, true, 22.39m, 4 },
                    { 65, 1, 2, 4, true, 27.34m, 1 },
                    { 66, 1, 2, 4, true, 26.04m, 2 },
                    { 67, 1, 2, 4, true, 26.83m, 3 },
                    { 68, 1, 2, 4, true, 26.13m, 4 },
                    { 69, 1, 3, 4, true, 27.02m, 1 },
                    { 70, 1, 3, 4, true, 25.86m, 2 },
                    { 71, 1, 3, 4, true, 22.32m, 3 },
                    { 72, 1, 3, 4, true, 24.40m, 4 },
                    { 73, 1, 4, 4, true, 23.68m, 1 },
                    { 74, 1, 4, 4, true, 22.86m, 2 },
                    { 75, 1, 4, 4, true, 23.82m, 3 },
                    { 76, 1, 4, 4, true, 22.00m, 4 },
                    { 77, 1, 5, 4, true, 26.21m, 1 },
                    { 78, 1, 5, 4, true, 23.08m, 2 },
                    { 79, 1, 5, 4, true, 22.04m, 3 },
                    { 80, 1, 5, 4, true, 22.13m, 4 },
                    { 81, 1, 1, 5, true, 24.03m, 1 },
                    { 82, 1, 1, 5, true, 24.31m, 2 },
                    { 83, 1, 1, 5, true, 25.19m, 3 },
                    { 84, 1, 1, 5, true, 22.05m, 4 },
                    { 85, 1, 2, 5, true, 27.61m, 1 },
                    { 86, 1, 2, 5, true, 23.75m, 2 },
                    { 87, 1, 2, 5, true, 25.26m, 3 },
                    { 88, 1, 2, 5, true, 23.66m, 4 },
                    { 89, 1, 3, 5, true, 27.52m, 1 },
                    { 90, 1, 3, 5, true, 25.82m, 2 },
                    { 91, 1, 3, 5, true, 27.79m, 3 },
                    { 92, 1, 3, 5, true, 25.50m, 4 },
                    { 93, 1, 4, 5, true, 25.87m, 1 },
                    { 94, 1, 4, 5, true, 23.00m, 2 },
                    { 95, 1, 4, 5, true, 26.83m, 3 },
                    { 96, 1, 4, 5, true, 25.49m, 4 },
                    { 97, 1, 5, 5, true, 26.15m, 1 },
                    { 98, 1, 5, 5, true, 27.69m, 2 },
                    { 99, 1, 5, 5, true, 27.90m, 3 },
                    { 100, 1, 5, 5, true, 25.91m, 4 },
                    { 101, 1, 1, 6, true, 25.35m, 1 },
                    { 102, 1, 1, 6, true, 26.72m, 2 },
                    { 103, 1, 1, 6, true, 26.57m, 3 },
                    { 104, 1, 1, 6, true, 22.30m, 4 },
                    { 105, 1, 2, 6, true, 24.61m, 1 },
                    { 106, 1, 2, 6, true, 27.91m, 2 },
                    { 107, 1, 2, 6, true, 27.73m, 3 },
                    { 108, 1, 2, 6, true, 27.24m, 4 },
                    { 109, 1, 3, 6, true, 22.48m, 1 },
                    { 110, 1, 3, 6, true, 24.97m, 2 },
                    { 111, 1, 3, 6, true, 25.15m, 3 },
                    { 112, 1, 3, 6, true, 24.25m, 4 },
                    { 113, 1, 4, 6, true, 22.98m, 1 },
                    { 114, 1, 4, 6, true, 24.83m, 2 },
                    { 115, 1, 4, 6, true, 27.55m, 3 },
                    { 116, 1, 4, 6, true, 26.09m, 4 },
                    { 117, 1, 5, 6, true, 24.73m, 1 },
                    { 118, 1, 5, 6, true, 26.20m, 2 },
                    { 119, 1, 5, 6, true, 22.77m, 3 },
                    { 120, 1, 5, 6, true, 25.58m, 4 },
                    { 121, 1, 1, 7, true, 22.76m, 1 },
                    { 122, 1, 1, 7, true, 25.16m, 2 },
                    { 123, 1, 1, 7, true, 26.60m, 3 },
                    { 124, 1, 1, 7, true, 23.19m, 4 },
                    { 125, 1, 2, 7, true, 26.05m, 1 },
                    { 126, 1, 2, 7, true, 24.80m, 2 },
                    { 127, 1, 2, 7, true, 26.52m, 3 },
                    { 128, 1, 2, 7, true, 22.67m, 4 },
                    { 129, 1, 3, 7, true, 24.03m, 1 },
                    { 130, 1, 3, 7, true, 26.32m, 2 },
                    { 131, 1, 3, 7, true, 23.84m, 3 },
                    { 132, 1, 3, 7, true, 26.51m, 4 },
                    { 133, 1, 4, 7, true, 23.18m, 1 },
                    { 134, 1, 4, 7, true, 24.12m, 2 },
                    { 135, 1, 4, 7, true, 24.78m, 3 },
                    { 136, 1, 4, 7, true, 25.30m, 4 },
                    { 137, 1, 5, 7, true, 25.73m, 1 },
                    { 138, 1, 5, 7, true, 24.89m, 2 },
                    { 139, 1, 5, 7, true, 25.43m, 3 },
                    { 140, 1, 5, 7, true, 27.70m, 4 },
                    { 141, 1, 1, 8, true, 24.01m, 1 },
                    { 142, 1, 1, 8, true, 26.01m, 2 },
                    { 143, 1, 1, 8, true, 23.17m, 3 },
                    { 144, 1, 1, 8, true, 24.53m, 4 },
                    { 145, 1, 2, 8, true, 22.65m, 1 },
                    { 146, 1, 2, 8, true, 25.54m, 2 },
                    { 147, 1, 2, 8, true, 24.52m, 3 },
                    { 148, 1, 2, 8, true, 23.03m, 4 },
                    { 149, 1, 3, 8, true, 23.44m, 1 },
                    { 150, 1, 3, 8, true, 22.73m, 2 },
                    { 151, 1, 3, 8, true, 22.75m, 3 },
                    { 152, 1, 3, 8, true, 27.94m, 4 },
                    { 153, 1, 4, 8, true, 26.91m, 1 },
                    { 154, 1, 4, 8, true, 24.31m, 2 },
                    { 155, 1, 4, 8, true, 25.13m, 3 },
                    { 156, 1, 4, 8, true, 22.17m, 4 },
                    { 157, 1, 5, 8, true, 22.11m, 1 },
                    { 158, 1, 5, 8, true, 25.37m, 2 },
                    { 159, 1, 5, 8, true, 24.23m, 3 },
                    { 160, 1, 5, 8, true, 27.80m, 4 },
                    { 161, 1, 1, 9, true, 23.38m, 1 },
                    { 162, 1, 1, 9, true, 27.06m, 2 },
                    { 163, 1, 1, 9, true, 25.21m, 3 },
                    { 164, 1, 1, 9, true, 24.15m, 4 },
                    { 165, 1, 2, 9, true, 23.12m, 1 },
                    { 166, 1, 2, 9, true, 26.63m, 2 },
                    { 167, 1, 2, 9, true, 23.06m, 3 },
                    { 168, 1, 2, 9, true, 26.85m, 4 },
                    { 169, 1, 3, 9, true, 22.04m, 1 },
                    { 170, 1, 3, 9, true, 24.24m, 2 },
                    { 171, 1, 3, 9, true, 22.35m, 3 },
                    { 172, 1, 3, 9, true, 27.84m, 4 },
                    { 173, 1, 4, 9, true, 22.76m, 1 },
                    { 174, 1, 4, 9, true, 23.06m, 2 },
                    { 175, 1, 4, 9, true, 23.56m, 3 },
                    { 176, 1, 4, 9, true, 24.74m, 4 },
                    { 177, 1, 5, 9, true, 23.99m, 1 },
                    { 178, 1, 5, 9, true, 24.06m, 2 },
                    { 179, 1, 5, 9, true, 22.53m, 3 },
                    { 180, 1, 5, 9, true, 22.51m, 4 },
                    { 181, 1, 1, 10, true, 22.28m, 1 },
                    { 182, 1, 1, 10, true, 25.48m, 2 },
                    { 183, 1, 1, 10, true, 27.21m, 3 },
                    { 184, 1, 1, 10, true, 23.29m, 4 },
                    { 185, 1, 2, 10, true, 25.57m, 1 },
                    { 186, 1, 2, 10, true, 23.89m, 2 },
                    { 187, 1, 2, 10, true, 27.59m, 3 },
                    { 188, 1, 2, 10, true, 26.86m, 4 },
                    { 189, 1, 3, 10, true, 26.98m, 1 },
                    { 190, 1, 3, 10, true, 24.60m, 2 },
                    { 191, 1, 3, 10, true, 25.18m, 3 },
                    { 192, 1, 3, 10, true, 22.35m, 4 },
                    { 193, 1, 4, 10, true, 22.64m, 1 },
                    { 194, 1, 4, 10, true, 25.62m, 2 },
                    { 195, 1, 4, 10, true, 26.31m, 3 },
                    { 196, 1, 4, 10, true, 24.95m, 4 },
                    { 197, 1, 5, 10, true, 22.79m, 1 },
                    { 198, 1, 5, 10, true, 27.01m, 2 },
                    { 199, 1, 5, 10, true, 23.40m, 3 },
                    { 200, 1, 5, 10, true, 24.01m, 4 },
                    { 201, 1, 1, 11, true, 24.47m, 1 },
                    { 202, 1, 1, 11, true, 25.66m, 2 },
                    { 203, 1, 1, 11, true, 22.98m, 3 },
                    { 204, 1, 1, 11, true, 27.19m, 4 },
                    { 205, 1, 2, 11, true, 22.36m, 1 },
                    { 206, 1, 2, 11, true, 22.90m, 2 },
                    { 207, 1, 2, 11, true, 27.18m, 3 },
                    { 208, 1, 2, 11, true, 25.84m, 4 },
                    { 209, 1, 3, 11, true, 22.74m, 1 },
                    { 210, 1, 3, 11, true, 22.38m, 2 },
                    { 211, 1, 3, 11, true, 26.17m, 3 },
                    { 212, 1, 3, 11, true, 26.04m, 4 },
                    { 213, 1, 4, 11, true, 24.83m, 1 },
                    { 214, 1, 4, 11, true, 23.72m, 2 },
                    { 215, 1, 4, 11, true, 27.51m, 3 },
                    { 216, 1, 4, 11, true, 25.89m, 4 },
                    { 217, 1, 5, 11, true, 27.83m, 1 },
                    { 218, 1, 5, 11, true, 23.91m, 2 },
                    { 219, 1, 5, 11, true, 26.57m, 3 },
                    { 220, 1, 5, 11, true, 27.22m, 4 },
                    { 221, 1, 1, 12, true, 27.04m, 1 },
                    { 222, 1, 1, 12, true, 24.19m, 2 },
                    { 223, 1, 1, 12, true, 27.86m, 3 },
                    { 224, 1, 1, 12, true, 25.43m, 4 },
                    { 225, 1, 2, 12, true, 27.05m, 1 },
                    { 226, 1, 2, 12, true, 21.99m, 2 },
                    { 227, 1, 2, 12, true, 27.18m, 3 },
                    { 228, 1, 2, 12, true, 25.12m, 4 },
                    { 229, 1, 3, 12, true, 24.75m, 1 },
                    { 230, 1, 3, 12, true, 26.60m, 2 },
                    { 231, 1, 3, 12, true, 23.94m, 3 },
                    { 232, 1, 3, 12, true, 24.97m, 4 },
                    { 233, 1, 4, 12, true, 22.65m, 1 },
                    { 234, 1, 4, 12, true, 26.51m, 2 },
                    { 235, 1, 4, 12, true, 26.03m, 3 },
                    { 236, 1, 4, 12, true, 24.61m, 4 },
                    { 237, 1, 5, 12, true, 24.49m, 1 },
                    { 238, 1, 5, 12, true, 22.01m, 2 },
                    { 239, 1, 5, 12, true, 22.92m, 3 },
                    { 240, 1, 5, 12, true, 24.66m, 4 },
                    { 241, 1, 1, 13, true, 24.70m, 1 },
                    { 242, 1, 1, 13, true, 23.74m, 2 },
                    { 243, 1, 1, 13, true, 26.11m, 3 },
                    { 244, 1, 1, 13, true, 26.59m, 4 },
                    { 245, 1, 2, 13, true, 26.42m, 1 },
                    { 246, 1, 2, 13, true, 27.13m, 2 },
                    { 247, 1, 2, 13, true, 25.51m, 3 },
                    { 248, 1, 2, 13, true, 26.92m, 4 },
                    { 249, 1, 3, 13, true, 26.10m, 1 },
                    { 250, 1, 3, 13, true, 22.41m, 2 },
                    { 251, 1, 3, 13, true, 25.10m, 3 },
                    { 252, 1, 3, 13, true, 26.87m, 4 },
                    { 253, 1, 4, 13, true, 22.43m, 1 },
                    { 254, 1, 4, 13, true, 24.17m, 2 },
                    { 255, 1, 4, 13, true, 24.97m, 3 },
                    { 256, 1, 4, 13, true, 22.27m, 4 },
                    { 257, 1, 5, 13, true, 25.79m, 1 },
                    { 258, 1, 5, 13, true, 25.53m, 2 },
                    { 259, 1, 5, 13, true, 22.13m, 3 },
                    { 260, 1, 5, 13, true, 22.36m, 4 },
                    { 261, 1, 1, 14, true, 23.71m, 1 },
                    { 262, 1, 1, 14, true, 24.04m, 2 },
                    { 263, 1, 1, 14, true, 23.08m, 3 },
                    { 264, 1, 1, 14, true, 24.13m, 4 },
                    { 265, 1, 2, 14, true, 26.43m, 1 },
                    { 266, 1, 2, 14, true, 23.20m, 2 },
                    { 267, 1, 2, 14, true, 25.38m, 3 },
                    { 268, 1, 2, 14, true, 26.31m, 4 },
                    { 269, 1, 3, 14, true, 25.67m, 1 },
                    { 270, 1, 3, 14, true, 24.89m, 2 },
                    { 271, 1, 3, 14, true, 23.39m, 3 },
                    { 272, 1, 3, 14, true, 27.81m, 4 },
                    { 273, 1, 4, 14, true, 22.98m, 1 },
                    { 274, 1, 4, 14, true, 23.91m, 2 },
                    { 275, 1, 4, 14, true, 24.51m, 3 },
                    { 276, 1, 4, 14, true, 25.29m, 4 },
                    { 277, 1, 5, 14, true, 26.07m, 1 },
                    { 278, 1, 5, 14, true, 23.26m, 2 },
                    { 279, 1, 5, 14, true, 27.01m, 3 },
                    { 280, 1, 5, 14, true, 27.92m, 4 },
                    { 281, 1, 1, 15, true, 24.47m, 1 },
                    { 282, 1, 1, 15, true, 22.26m, 2 },
                    { 283, 1, 1, 15, true, 27.01m, 3 },
                    { 284, 1, 1, 15, true, 24.33m, 4 },
                    { 285, 1, 2, 15, true, 23.49m, 1 },
                    { 286, 1, 2, 15, true, 25.06m, 2 },
                    { 287, 1, 2, 15, true, 24.53m, 3 },
                    { 288, 1, 2, 15, true, 26.47m, 4 },
                    { 289, 1, 3, 15, true, 23.53m, 1 },
                    { 290, 1, 3, 15, true, 25.76m, 2 },
                    { 291, 1, 3, 15, true, 26.81m, 3 },
                    { 292, 1, 3, 15, true, 26.95m, 4 },
                    { 293, 1, 4, 15, true, 27.87m, 1 },
                    { 294, 1, 4, 15, true, 22.55m, 2 },
                    { 295, 1, 4, 15, true, 22.94m, 3 },
                    { 296, 1, 4, 15, true, 22.65m, 4 },
                    { 297, 1, 5, 15, true, 22.65m, 1 },
                    { 298, 1, 5, 15, true, 23.97m, 2 },
                    { 299, 1, 5, 15, true, 22.14m, 3 },
                    { 300, 1, 5, 15, true, 25.21m, 4 },
                    { 301, 1, 1, 16, true, 23.73m, 1 },
                    { 302, 1, 1, 16, true, 27.19m, 2 },
                    { 303, 1, 1, 16, true, 23.23m, 3 },
                    { 304, 1, 1, 16, true, 23.20m, 4 },
                    { 305, 1, 2, 16, true, 27.01m, 1 },
                    { 306, 1, 2, 16, true, 25.29m, 2 },
                    { 307, 1, 2, 16, true, 25.88m, 3 },
                    { 308, 1, 2, 16, true, 26.51m, 4 },
                    { 309, 1, 3, 16, true, 27.65m, 1 },
                    { 310, 1, 3, 16, true, 27.67m, 2 },
                    { 311, 1, 3, 16, true, 24.18m, 3 },
                    { 312, 1, 3, 16, true, 24.52m, 4 },
                    { 313, 1, 4, 16, true, 26.51m, 1 },
                    { 314, 1, 4, 16, true, 22.20m, 2 },
                    { 315, 1, 4, 16, true, 25.88m, 3 },
                    { 316, 1, 4, 16, true, 23.44m, 4 },
                    { 317, 1, 5, 16, true, 25.02m, 1 },
                    { 318, 1, 5, 16, true, 26.74m, 2 },
                    { 319, 1, 5, 16, true, 22.63m, 3 },
                    { 320, 1, 5, 16, true, 23.37m, 4 },
                    { 321, 1, 1, 17, true, 26.65m, 1 },
                    { 322, 1, 1, 17, true, 26.91m, 2 },
                    { 323, 1, 1, 17, true, 24.77m, 3 },
                    { 324, 1, 1, 17, true, 27.91m, 4 },
                    { 325, 1, 2, 17, true, 26.07m, 1 },
                    { 326, 1, 2, 17, true, 24.43m, 2 },
                    { 327, 1, 2, 17, true, 27.93m, 3 },
                    { 328, 1, 2, 17, true, 22.42m, 4 },
                    { 329, 1, 3, 17, true, 22.96m, 1 },
                    { 330, 1, 3, 17, true, 23.85m, 2 },
                    { 331, 1, 3, 17, true, 24.63m, 3 },
                    { 332, 1, 3, 17, true, 24.09m, 4 },
                    { 333, 1, 4, 17, true, 23.11m, 1 },
                    { 334, 1, 4, 17, true, 23.79m, 2 },
                    { 335, 1, 4, 17, true, 26.18m, 3 },
                    { 336, 1, 4, 17, true, 25.28m, 4 },
                    { 337, 1, 5, 17, true, 27.01m, 1 },
                    { 338, 1, 5, 17, true, 25.80m, 2 },
                    { 339, 1, 5, 17, true, 25.31m, 3 },
                    { 340, 1, 5, 17, true, 26.19m, 4 },
                    { 341, 1, 1, 18, true, 27.16m, 1 },
                    { 342, 1, 1, 18, true, 26.01m, 2 },
                    { 343, 1, 1, 18, true, 26.81m, 3 },
                    { 344, 1, 1, 18, true, 23.85m, 4 },
                    { 345, 1, 2, 18, true, 23.56m, 1 },
                    { 346, 1, 2, 18, true, 24.28m, 2 },
                    { 347, 1, 2, 18, true, 22.43m, 3 },
                    { 348, 1, 2, 18, true, 27.66m, 4 },
                    { 349, 1, 3, 18, true, 24.66m, 1 },
                    { 350, 1, 3, 18, true, 27.49m, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1, "Product variant 1 mockup view 1", "variant_1_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 1 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 2, "Product variant 1 mockup view 2", "variant_1_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 1 },
                    { 3, "Product variant 1 mockup view 3", "variant_1_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 1 },
                    { 4, "Product variant 1 mockup view 4", "variant_1_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 5, "Product variant 2 mockup view 1", "variant_2_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 2 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 6, "Product variant 2 mockup view 2", "variant_2_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 2 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 9, "Product variant 3 mockup view 1", "variant_3_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 3 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 10, "Product variant 3 mockup view 2", "variant_3_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 3 },
                    { 11, "Product variant 3 mockup view 3", "variant_3_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 3 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 13, "Product variant 4 mockup view 1", "variant_4_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 4 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 14, "Product variant 4 mockup view 2", "variant_4_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 4 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 17, "Product variant 5 mockup view 1", "variant_5_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 5 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 18, "Product variant 5 mockup view 2", "variant_5_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 5 },
                    { 19, "Product variant 5 mockup view 3", "variant_5_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 5 },
                    { 20, "Product variant 5 mockup view 4", "variant_5_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 21, "Product variant 6 mockup view 1", "variant_6_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 6 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 22, "Product variant 6 mockup view 2", "variant_6_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 6 },
                    { 23, "Product variant 6 mockup view 3", "variant_6_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 6 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 25, "Product variant 7 mockup view 1", "variant_7_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 7 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 26, "Product variant 7 mockup view 2", "variant_7_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 7 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 29, "Product variant 8 mockup view 1", "variant_8_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 8 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 30, "Product variant 8 mockup view 2", "variant_8_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 8 },
                    { 31, "Product variant 8 mockup view 3", "variant_8_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 8 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 33, "Product variant 9 mockup view 1", "variant_9_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 9 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 34, "Product variant 9 mockup view 2", "variant_9_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 9 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 37, "Product variant 10 mockup view 1", "variant_10_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 10 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 38, "Product variant 10 mockup view 2", "variant_10_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 10 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 41, "Product variant 11 mockup view 1", "variant_11_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 11 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 42, "Product variant 11 mockup view 2", "variant_11_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 11 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 45, "Product variant 12 mockup view 1", "variant_12_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 12 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 46, "Product variant 12 mockup view 2", "variant_12_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 12 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 49, "Product variant 13 mockup view 1", "variant_13_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 13 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 50, "Product variant 13 mockup view 2", "variant_13_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 13 },
                    { 51, "Product variant 13 mockup view 3", "variant_13_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 13 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 53, "Product variant 14 mockup view 1", "variant_14_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 14 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 54, "Product variant 14 mockup view 2", "variant_14_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 14 },
                    { 55, "Product variant 14 mockup view 3", "variant_14_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 14 },
                    { 56, "Product variant 14 mockup view 4", "variant_14_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 14 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 57, "Product variant 15 mockup view 1", "variant_15_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 15 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 58, "Product variant 15 mockup view 2", "variant_15_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 15 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 61, "Product variant 16 mockup view 1", "variant_16_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 16 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 62, "Product variant 16 mockup view 2", "variant_16_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 16 },
                    { 63, "Product variant 16 mockup view 3", "variant_16_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 16 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 65, "Product variant 17 mockup view 1", "variant_17_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 17 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 66, "Product variant 17 mockup view 2", "variant_17_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 17 },
                    { 67, "Product variant 17 mockup view 3", "variant_17_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 17 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 69, "Product variant 18 mockup view 1", "variant_18_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 18 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 70, "Product variant 18 mockup view 2", "variant_18_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 18 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 73, "Product variant 19 mockup view 1", "variant_19_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 19 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 74, "Product variant 19 mockup view 2", "variant_19_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 19 },
                    { 75, "Product variant 19 mockup view 3", "variant_19_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 19 },
                    { 76, "Product variant 19 mockup view 4", "variant_19_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 19 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 77, "Product variant 20 mockup view 1", "variant_20_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 20 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 78, "Product variant 20 mockup view 2", "variant_20_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 20 },
                    { 79, "Product variant 20 mockup view 3", "variant_20_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 20 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 81, "Product variant 21 mockup view 1", "variant_21_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 21 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 82, "Product variant 21 mockup view 2", "variant_21_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 21 },
                    { 83, "Product variant 21 mockup view 3", "variant_21_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 21 },
                    { 84, "Product variant 21 mockup view 4", "variant_21_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 21 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 85, "Product variant 22 mockup view 1", "variant_22_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 22 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 86, "Product variant 22 mockup view 2", "variant_22_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 22 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 89, "Product variant 23 mockup view 1", "variant_23_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 23 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 90, "Product variant 23 mockup view 2", "variant_23_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 23 },
                    { 91, "Product variant 23 mockup view 3", "variant_23_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 23 },
                    { 92, "Product variant 23 mockup view 4", "variant_23_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 23 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 93, "Product variant 24 mockup view 1", "variant_24_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 24 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 94, "Product variant 24 mockup view 2", "variant_24_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 24 },
                    { 95, "Product variant 24 mockup view 3", "variant_24_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 24 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 97, "Product variant 25 mockup view 1", "variant_25_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 25 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 98, "Product variant 25 mockup view 2", "variant_25_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 25 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 101, "Product variant 26 mockup view 1", "variant_26_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 26 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 102, "Product variant 26 mockup view 2", "variant_26_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 26 },
                    { 103, "Product variant 26 mockup view 3", "variant_26_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 26 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 105, "Product variant 27 mockup view 1", "variant_27_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 27 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 106, "Product variant 27 mockup view 2", "variant_27_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 27 },
                    { 107, "Product variant 27 mockup view 3", "variant_27_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 27 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 109, "Product variant 28 mockup view 1", "variant_28_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 28 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 110, "Product variant 28 mockup view 2", "variant_28_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 28 },
                    { 111, "Product variant 28 mockup view 3", "variant_28_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 28 },
                    { 112, "Product variant 28 mockup view 4", "variant_28_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 28 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 113, "Product variant 29 mockup view 1", "variant_29_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 29 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 114, "Product variant 29 mockup view 2", "variant_29_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 29 },
                    { 115, "Product variant 29 mockup view 3", "variant_29_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 29 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 117, "Product variant 30 mockup view 1", "variant_30_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 30 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 118, "Product variant 30 mockup view 2", "variant_30_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 30 },
                    { 119, "Product variant 30 mockup view 3", "variant_30_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 30 },
                    { 120, "Product variant 30 mockup view 4", "variant_30_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 30 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 121, "Product variant 31 mockup view 1", "variant_31_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 31 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 122, "Product variant 31 mockup view 2", "variant_31_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 31 },
                    { 123, "Product variant 31 mockup view 3", "variant_31_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 31 },
                    { 124, "Product variant 31 mockup view 4", "variant_31_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 31 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 125, "Product variant 32 mockup view 1", "variant_32_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 32 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 126, "Product variant 32 mockup view 2", "variant_32_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 32 },
                    { 127, "Product variant 32 mockup view 3", "variant_32_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 32 },
                    { 128, "Product variant 32 mockup view 4", "variant_32_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 32 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 129, "Product variant 33 mockup view 1", "variant_33_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 33 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 130, "Product variant 33 mockup view 2", "variant_33_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 33 },
                    { 131, "Product variant 33 mockup view 3", "variant_33_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 33 },
                    { 132, "Product variant 33 mockup view 4", "variant_33_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 33 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 133, "Product variant 34 mockup view 1", "variant_34_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 34 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 134, "Product variant 34 mockup view 2", "variant_34_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 34 },
                    { 135, "Product variant 34 mockup view 3", "variant_34_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 34 },
                    { 136, "Product variant 34 mockup view 4", "variant_34_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 34 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 137, "Product variant 35 mockup view 1", "variant_35_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 35 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 138, "Product variant 35 mockup view 2", "variant_35_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 35 },
                    { 139, "Product variant 35 mockup view 3", "variant_35_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 35 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 141, "Product variant 36 mockup view 1", "variant_36_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 36 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 142, "Product variant 36 mockup view 2", "variant_36_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 36 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 145, "Product variant 37 mockup view 1", "variant_37_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 37 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 146, "Product variant 37 mockup view 2", "variant_37_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 37 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 149, "Product variant 38 mockup view 1", "variant_38_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 38 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 150, "Product variant 38 mockup view 2", "variant_38_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 38 },
                    { 151, "Product variant 38 mockup view 3", "variant_38_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 38 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 153, "Product variant 39 mockup view 1", "variant_39_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 39 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 154, "Product variant 39 mockup view 2", "variant_39_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 39 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 157, "Product variant 40 mockup view 1", "variant_40_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 40 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 158, "Product variant 40 mockup view 2", "variant_40_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 40 },
                    { 159, "Product variant 40 mockup view 3", "variant_40_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 40 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 161, "Product variant 41 mockup view 1", "variant_41_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 41 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 162, "Product variant 41 mockup view 2", "variant_41_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 41 },
                    { 163, "Product variant 41 mockup view 3", "variant_41_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 41 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 165, "Product variant 42 mockup view 1", "variant_42_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 42 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 166, "Product variant 42 mockup view 2", "variant_42_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 42 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 169, "Product variant 43 mockup view 1", "variant_43_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 43 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 170, "Product variant 43 mockup view 2", "variant_43_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 43 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 173, "Product variant 44 mockup view 1", "variant_44_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 44 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 174, "Product variant 44 mockup view 2", "variant_44_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 44 },
                    { 175, "Product variant 44 mockup view 3", "variant_44_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 44 },
                    { 176, "Product variant 44 mockup view 4", "variant_44_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 44 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 177, "Product variant 45 mockup view 1", "variant_45_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 45 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 178, "Product variant 45 mockup view 2", "variant_45_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 45 },
                    { 179, "Product variant 45 mockup view 3", "variant_45_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 45 },
                    { 180, "Product variant 45 mockup view 4", "variant_45_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 45 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 181, "Product variant 46 mockup view 1", "variant_46_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 46 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 182, "Product variant 46 mockup view 2", "variant_46_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 46 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 185, "Product variant 47 mockup view 1", "variant_47_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 47 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 186, "Product variant 47 mockup view 2", "variant_47_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 47 },
                    { 187, "Product variant 47 mockup view 3", "variant_47_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 47 },
                    { 188, "Product variant 47 mockup view 4", "variant_47_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 47 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 189, "Product variant 48 mockup view 1", "variant_48_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 48 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 190, "Product variant 48 mockup view 2", "variant_48_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 48 },
                    { 191, "Product variant 48 mockup view 3", "variant_48_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 48 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 193, "Product variant 49 mockup view 1", "variant_49_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 49 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 194, "Product variant 49 mockup view 2", "variant_49_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 49 },
                    { 195, "Product variant 49 mockup view 3", "variant_49_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 49 },
                    { 196, "Product variant 49 mockup view 4", "variant_49_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 49 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 197, "Product variant 50 mockup view 1", "variant_50_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 50 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 198, "Product variant 50 mockup view 2", "variant_50_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 50 },
                    { 199, "Product variant 50 mockup view 3", "variant_50_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 201, "Product variant 51 mockup view 1", "variant_51_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 51 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 202, "Product variant 51 mockup view 2", "variant_51_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 51 },
                    { 203, "Product variant 51 mockup view 3", "variant_51_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 51 },
                    { 204, "Product variant 51 mockup view 4", "variant_51_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 51 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 205, "Product variant 52 mockup view 1", "variant_52_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 52 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 206, "Product variant 52 mockup view 2", "variant_52_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 52 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 209, "Product variant 53 mockup view 1", "variant_53_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 53 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 210, "Product variant 53 mockup view 2", "variant_53_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 53 },
                    { 211, "Product variant 53 mockup view 3", "variant_53_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 53 },
                    { 212, "Product variant 53 mockup view 4", "variant_53_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 53 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 213, "Product variant 54 mockup view 1", "variant_54_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 54 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 214, "Product variant 54 mockup view 2", "variant_54_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 54 },
                    { 215, "Product variant 54 mockup view 3", "variant_54_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 54 },
                    { 216, "Product variant 54 mockup view 4", "variant_54_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 54 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 217, "Product variant 55 mockup view 1", "variant_55_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 55 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 218, "Product variant 55 mockup view 2", "variant_55_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 55 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 221, "Product variant 56 mockup view 1", "variant_56_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 56 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 222, "Product variant 56 mockup view 2", "variant_56_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 56 },
                    { 223, "Product variant 56 mockup view 3", "variant_56_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 56 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 225, "Product variant 57 mockup view 1", "variant_57_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 57 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 226, "Product variant 57 mockup view 2", "variant_57_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 57 },
                    { 227, "Product variant 57 mockup view 3", "variant_57_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 57 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 229, "Product variant 58 mockup view 1", "variant_58_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 58 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 230, "Product variant 58 mockup view 2", "variant_58_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 58 },
                    { 231, "Product variant 58 mockup view 3", "variant_58_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 58 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 233, "Product variant 59 mockup view 1", "variant_59_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 59 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 234, "Product variant 59 mockup view 2", "variant_59_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 59 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 237, "Product variant 60 mockup view 1", "variant_60_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 60 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 238, "Product variant 60 mockup view 2", "variant_60_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 60 },
                    { 239, "Product variant 60 mockup view 3", "variant_60_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 60 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 241, "Product variant 61 mockup view 1", "variant_61_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 61 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 242, "Product variant 61 mockup view 2", "variant_61_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 61 },
                    { 243, "Product variant 61 mockup view 3", "variant_61_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 61 },
                    { 244, "Product variant 61 mockup view 4", "variant_61_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 61 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 245, "Product variant 62 mockup view 1", "variant_62_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 62 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 246, "Product variant 62 mockup view 2", "variant_62_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 62 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 249, "Product variant 63 mockup view 1", "variant_63_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 63 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 250, "Product variant 63 mockup view 2", "variant_63_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 63 },
                    { 251, "Product variant 63 mockup view 3", "variant_63_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 63 },
                    { 252, "Product variant 63 mockup view 4", "variant_63_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 63 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 253, "Product variant 64 mockup view 1", "variant_64_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 64 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 254, "Product variant 64 mockup view 2", "variant_64_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 64 },
                    { 255, "Product variant 64 mockup view 3", "variant_64_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 64 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 257, "Product variant 65 mockup view 1", "variant_65_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 65 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 258, "Product variant 65 mockup view 2", "variant_65_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 65 },
                    { 259, "Product variant 65 mockup view 3", "variant_65_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 65 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 261, "Product variant 66 mockup view 1", "variant_66_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 66 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 262, "Product variant 66 mockup view 2", "variant_66_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 66 },
                    { 263, "Product variant 66 mockup view 3", "variant_66_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 66 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 265, "Product variant 67 mockup view 1", "variant_67_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 67 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 266, "Product variant 67 mockup view 2", "variant_67_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 67 },
                    { 267, "Product variant 67 mockup view 3", "variant_67_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 67 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 269, "Product variant 68 mockup view 1", "variant_68_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 68 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 270, "Product variant 68 mockup view 2", "variant_68_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 68 },
                    { 271, "Product variant 68 mockup view 3", "variant_68_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 68 },
                    { 272, "Product variant 68 mockup view 4", "variant_68_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 68 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 273, "Product variant 69 mockup view 1", "variant_69_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 69 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 274, "Product variant 69 mockup view 2", "variant_69_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 69 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 277, "Product variant 70 mockup view 1", "variant_70_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 70 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 278, "Product variant 70 mockup view 2", "variant_70_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 70 },
                    { 279, "Product variant 70 mockup view 3", "variant_70_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 70 },
                    { 280, "Product variant 70 mockup view 4", "variant_70_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 70 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 281, "Product variant 71 mockup view 1", "variant_71_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 71 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 282, "Product variant 71 mockup view 2", "variant_71_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 71 },
                    { 283, "Product variant 71 mockup view 3", "variant_71_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 71 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 285, "Product variant 72 mockup view 1", "variant_72_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 72 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 286, "Product variant 72 mockup view 2", "variant_72_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 72 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 289, "Product variant 73 mockup view 1", "variant_73_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 73 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 290, "Product variant 73 mockup view 2", "variant_73_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 73 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 293, "Product variant 74 mockup view 1", "variant_74_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 74 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 294, "Product variant 74 mockup view 2", "variant_74_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 74 },
                    { 295, "Product variant 74 mockup view 3", "variant_74_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 74 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 297, "Product variant 75 mockup view 1", "variant_75_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 75 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 298, "Product variant 75 mockup view 2", "variant_75_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 75 },
                    { 299, "Product variant 75 mockup view 3", "variant_75_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 75 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 301, "Product variant 76 mockup view 1", "variant_76_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 76 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 302, "Product variant 76 mockup view 2", "variant_76_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 76 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 305, "Product variant 77 mockup view 1", "variant_77_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 77 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 306, "Product variant 77 mockup view 2", "variant_77_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 77 },
                    { 307, "Product variant 77 mockup view 3", "variant_77_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 77 },
                    { 308, "Product variant 77 mockup view 4", "variant_77_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 77 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 309, "Product variant 78 mockup view 1", "variant_78_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 78 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 310, "Product variant 78 mockup view 2", "variant_78_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 78 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 313, "Product variant 79 mockup view 1", "variant_79_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 79 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 314, "Product variant 79 mockup view 2", "variant_79_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 79 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 317, "Product variant 80 mockup view 1", "variant_80_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 80 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 318, "Product variant 80 mockup view 2", "variant_80_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 80 },
                    { 319, "Product variant 80 mockup view 3", "variant_80_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 80 },
                    { 320, "Product variant 80 mockup view 4", "variant_80_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 80 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 321, "Product variant 81 mockup view 1", "variant_81_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 81 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 322, "Product variant 81 mockup view 2", "variant_81_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 81 },
                    { 323, "Product variant 81 mockup view 3", "variant_81_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 81 },
                    { 324, "Product variant 81 mockup view 4", "variant_81_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 81 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 325, "Product variant 82 mockup view 1", "variant_82_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 82 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 326, "Product variant 82 mockup view 2", "variant_82_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 82 },
                    { 327, "Product variant 82 mockup view 3", "variant_82_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 82 },
                    { 328, "Product variant 82 mockup view 4", "variant_82_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 82 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 329, "Product variant 83 mockup view 1", "variant_83_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 83 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 330, "Product variant 83 mockup view 2", "variant_83_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 83 },
                    { 331, "Product variant 83 mockup view 3", "variant_83_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 83 },
                    { 332, "Product variant 83 mockup view 4", "variant_83_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 83 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 333, "Product variant 84 mockup view 1", "variant_84_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 84 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 334, "Product variant 84 mockup view 2", "variant_84_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 84 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 337, "Product variant 85 mockup view 1", "variant_85_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 85 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 338, "Product variant 85 mockup view 2", "variant_85_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 85 },
                    { 339, "Product variant 85 mockup view 3", "variant_85_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 85 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 341, "Product variant 86 mockup view 1", "variant_86_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 86 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 342, "Product variant 86 mockup view 2", "variant_86_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 86 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 345, "Product variant 87 mockup view 1", "variant_87_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 87 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 346, "Product variant 87 mockup view 2", "variant_87_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 87 },
                    { 347, "Product variant 87 mockup view 3", "variant_87_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 87 },
                    { 348, "Product variant 87 mockup view 4", "variant_87_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 87 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 349, "Product variant 88 mockup view 1", "variant_88_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 88 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 350, "Product variant 88 mockup view 2", "variant_88_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 88 },
                    { 351, "Product variant 88 mockup view 3", "variant_88_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 88 },
                    { 352, "Product variant 88 mockup view 4", "variant_88_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 88 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 353, "Product variant 89 mockup view 1", "variant_89_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 89 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 354, "Product variant 89 mockup view 2", "variant_89_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 89 },
                    { 355, "Product variant 89 mockup view 3", "variant_89_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 89 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 357, "Product variant 90 mockup view 1", "variant_90_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 90 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 358, "Product variant 90 mockup view 2", "variant_90_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 90 },
                    { 359, "Product variant 90 mockup view 3", "variant_90_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 90 },
                    { 360, "Product variant 90 mockup view 4", "variant_90_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 90 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 361, "Product variant 91 mockup view 1", "variant_91_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 91 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 362, "Product variant 91 mockup view 2", "variant_91_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 91 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 365, "Product variant 92 mockup view 1", "variant_92_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 92 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 366, "Product variant 92 mockup view 2", "variant_92_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 92 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 369, "Product variant 93 mockup view 1", "variant_93_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 93 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 370, "Product variant 93 mockup view 2", "variant_93_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 93 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 373, "Product variant 94 mockup view 1", "variant_94_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 94 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 374, "Product variant 94 mockup view 2", "variant_94_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 94 },
                    { 375, "Product variant 94 mockup view 3", "variant_94_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 94 },
                    { 376, "Product variant 94 mockup view 4", "variant_94_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 94 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 377, "Product variant 95 mockup view 1", "variant_95_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 95 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 378, "Product variant 95 mockup view 2", "variant_95_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 95 },
                    { 379, "Product variant 95 mockup view 3", "variant_95_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 95 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 381, "Product variant 96 mockup view 1", "variant_96_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 96 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 382, "Product variant 96 mockup view 2", "variant_96_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 96 },
                    { 383, "Product variant 96 mockup view 3", "variant_96_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 96 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 385, "Product variant 97 mockup view 1", "variant_97_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 97 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 386, "Product variant 97 mockup view 2", "variant_97_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 97 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 389, "Product variant 98 mockup view 1", "variant_98_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 98 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 390, "Product variant 98 mockup view 2", "variant_98_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 98 },
                    { 391, "Product variant 98 mockup view 3", "variant_98_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 98 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 393, "Product variant 99 mockup view 1", "variant_99_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 99 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 394, "Product variant 99 mockup view 2", "variant_99_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 99 },
                    { 395, "Product variant 99 mockup view 3", "variant_99_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 99 },
                    { 396, "Product variant 99 mockup view 4", "variant_99_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 99 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 397, "Product variant 100 mockup view 1", "variant_100_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 100 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 398, "Product variant 100 mockup view 2", "variant_100_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 100 },
                    { 399, "Product variant 100 mockup view 3", "variant_100_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 100 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 401, "Product variant 101 mockup view 1", "variant_101_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 101 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 402, "Product variant 101 mockup view 2", "variant_101_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 101 },
                    { 403, "Product variant 101 mockup view 3", "variant_101_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 101 },
                    { 404, "Product variant 101 mockup view 4", "variant_101_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 101 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 405, "Product variant 102 mockup view 1", "variant_102_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 102 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 406, "Product variant 102 mockup view 2", "variant_102_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 102 },
                    { 407, "Product variant 102 mockup view 3", "variant_102_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 102 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 409, "Product variant 103 mockup view 1", "variant_103_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 103 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 410, "Product variant 103 mockup view 2", "variant_103_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 103 },
                    { 411, "Product variant 103 mockup view 3", "variant_103_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 103 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 413, "Product variant 104 mockup view 1", "variant_104_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 104 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 414, "Product variant 104 mockup view 2", "variant_104_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 104 },
                    { 415, "Product variant 104 mockup view 3", "variant_104_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 104 },
                    { 416, "Product variant 104 mockup view 4", "variant_104_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 104 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 417, "Product variant 105 mockup view 1", "variant_105_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 105 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 418, "Product variant 105 mockup view 2", "variant_105_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 105 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 421, "Product variant 106 mockup view 1", "variant_106_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 106 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 422, "Product variant 106 mockup view 2", "variant_106_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 106 },
                    { 423, "Product variant 106 mockup view 3", "variant_106_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 106 },
                    { 424, "Product variant 106 mockup view 4", "variant_106_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 106 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 425, "Product variant 107 mockup view 1", "variant_107_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 107 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 426, "Product variant 107 mockup view 2", "variant_107_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 107 },
                    { 427, "Product variant 107 mockup view 3", "variant_107_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 107 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 429, "Product variant 108 mockup view 1", "variant_108_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 108 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 430, "Product variant 108 mockup view 2", "variant_108_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 108 },
                    { 431, "Product variant 108 mockup view 3", "variant_108_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 108 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 433, "Product variant 109 mockup view 1", "variant_109_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 109 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 434, "Product variant 109 mockup view 2", "variant_109_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 109 },
                    { 435, "Product variant 109 mockup view 3", "variant_109_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 109 },
                    { 436, "Product variant 109 mockup view 4", "variant_109_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 109 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 437, "Product variant 110 mockup view 1", "variant_110_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 110 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 438, "Product variant 110 mockup view 2", "variant_110_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 110 },
                    { 439, "Product variant 110 mockup view 3", "variant_110_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 110 },
                    { 440, "Product variant 110 mockup view 4", "variant_110_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 110 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 441, "Product variant 111 mockup view 1", "variant_111_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 111 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 442, "Product variant 111 mockup view 2", "variant_111_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 111 },
                    { 443, "Product variant 111 mockup view 3", "variant_111_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 111 },
                    { 444, "Product variant 111 mockup view 4", "variant_111_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 111 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 445, "Product variant 112 mockup view 1", "variant_112_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 112 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 446, "Product variant 112 mockup view 2", "variant_112_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 112 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 449, "Product variant 113 mockup view 1", "variant_113_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 113 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 450, "Product variant 113 mockup view 2", "variant_113_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 113 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 453, "Product variant 114 mockup view 1", "variant_114_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 114 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 454, "Product variant 114 mockup view 2", "variant_114_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 114 },
                    { 455, "Product variant 114 mockup view 3", "variant_114_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 114 },
                    { 456, "Product variant 114 mockup view 4", "variant_114_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 114 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 457, "Product variant 115 mockup view 1", "variant_115_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 115 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 458, "Product variant 115 mockup view 2", "variant_115_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 115 },
                    { 459, "Product variant 115 mockup view 3", "variant_115_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 115 },
                    { 460, "Product variant 115 mockup view 4", "variant_115_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 115 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 461, "Product variant 116 mockup view 1", "variant_116_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 116 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 462, "Product variant 116 mockup view 2", "variant_116_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 116 },
                    { 463, "Product variant 116 mockup view 3", "variant_116_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 116 },
                    { 464, "Product variant 116 mockup view 4", "variant_116_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 116 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 465, "Product variant 117 mockup view 1", "variant_117_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 117 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 466, "Product variant 117 mockup view 2", "variant_117_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 117 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 469, "Product variant 118 mockup view 1", "variant_118_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 118 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 470, "Product variant 118 mockup view 2", "variant_118_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 118 },
                    { 471, "Product variant 118 mockup view 3", "variant_118_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 118 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 473, "Product variant 119 mockup view 1", "variant_119_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 119 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 474, "Product variant 119 mockup view 2", "variant_119_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 119 },
                    { 475, "Product variant 119 mockup view 3", "variant_119_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 119 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 477, "Product variant 120 mockup view 1", "variant_120_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 120 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 478, "Product variant 120 mockup view 2", "variant_120_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 120 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 481, "Product variant 121 mockup view 1", "variant_121_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 121 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 482, "Product variant 121 mockup view 2", "variant_121_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 121 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 485, "Product variant 122 mockup view 1", "variant_122_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 122 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 486, "Product variant 122 mockup view 2", "variant_122_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 122 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 489, "Product variant 123 mockup view 1", "variant_123_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 123 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 490, "Product variant 123 mockup view 2", "variant_123_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 123 },
                    { 491, "Product variant 123 mockup view 3", "variant_123_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 123 },
                    { 492, "Product variant 123 mockup view 4", "variant_123_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 123 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 493, "Product variant 124 mockup view 1", "variant_124_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 124 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 494, "Product variant 124 mockup view 2", "variant_124_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 124 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 497, "Product variant 125 mockup view 1", "variant_125_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 125 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 498, "Product variant 125 mockup view 2", "variant_125_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 125 },
                    { 499, "Product variant 125 mockup view 3", "variant_125_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 125 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 501, "Product variant 126 mockup view 1", "variant_126_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 126 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 502, "Product variant 126 mockup view 2", "variant_126_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 126 },
                    { 503, "Product variant 126 mockup view 3", "variant_126_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 126 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 505, "Product variant 127 mockup view 1", "variant_127_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 127 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 506, "Product variant 127 mockup view 2", "variant_127_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 127 },
                    { 507, "Product variant 127 mockup view 3", "variant_127_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 127 },
                    { 508, "Product variant 127 mockup view 4", "variant_127_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 127 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 509, "Product variant 128 mockup view 1", "variant_128_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 128 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 510, "Product variant 128 mockup view 2", "variant_128_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 128 },
                    { 511, "Product variant 128 mockup view 3", "variant_128_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 128 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 513, "Product variant 129 mockup view 1", "variant_129_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 129 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 514, "Product variant 129 mockup view 2", "variant_129_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 129 },
                    { 515, "Product variant 129 mockup view 3", "variant_129_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 129 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 517, "Product variant 130 mockup view 1", "variant_130_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 130 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 518, "Product variant 130 mockup view 2", "variant_130_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 130 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 521, "Product variant 131 mockup view 1", "variant_131_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 131 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 522, "Product variant 131 mockup view 2", "variant_131_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 131 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 525, "Product variant 132 mockup view 1", "variant_132_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 132 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 526, "Product variant 132 mockup view 2", "variant_132_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 132 },
                    { 527, "Product variant 132 mockup view 3", "variant_132_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 132 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 529, "Product variant 133 mockup view 1", "variant_133_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 133 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 530, "Product variant 133 mockup view 2", "variant_133_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 133 },
                    { 531, "Product variant 133 mockup view 3", "variant_133_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 133 },
                    { 532, "Product variant 133 mockup view 4", "variant_133_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 133 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 533, "Product variant 134 mockup view 1", "variant_134_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 134 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 534, "Product variant 134 mockup view 2", "variant_134_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 134 },
                    { 535, "Product variant 134 mockup view 3", "variant_134_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 134 },
                    { 536, "Product variant 134 mockup view 4", "variant_134_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 134 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 537, "Product variant 135 mockup view 1", "variant_135_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 135 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 538, "Product variant 135 mockup view 2", "variant_135_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 135 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 541, "Product variant 136 mockup view 1", "variant_136_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 136 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 542, "Product variant 136 mockup view 2", "variant_136_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 136 },
                    { 543, "Product variant 136 mockup view 3", "variant_136_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 136 },
                    { 544, "Product variant 136 mockup view 4", "variant_136_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 136 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 545, "Product variant 137 mockup view 1", "variant_137_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 137 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 546, "Product variant 137 mockup view 2", "variant_137_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 137 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 549, "Product variant 138 mockup view 1", "variant_138_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 138 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 550, "Product variant 138 mockup view 2", "variant_138_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 138 },
                    { 551, "Product variant 138 mockup view 3", "variant_138_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 138 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 553, "Product variant 139 mockup view 1", "variant_139_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 139 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 554, "Product variant 139 mockup view 2", "variant_139_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 139 },
                    { 555, "Product variant 139 mockup view 3", "variant_139_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 139 },
                    { 556, "Product variant 139 mockup view 4", "variant_139_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 139 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 557, "Product variant 140 mockup view 1", "variant_140_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 140 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 558, "Product variant 140 mockup view 2", "variant_140_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 140 },
                    { 559, "Product variant 140 mockup view 3", "variant_140_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 140 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 561, "Product variant 141 mockup view 1", "variant_141_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 141 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 562, "Product variant 141 mockup view 2", "variant_141_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 141 },
                    { 563, "Product variant 141 mockup view 3", "variant_141_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 141 },
                    { 564, "Product variant 141 mockup view 4", "variant_141_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 141 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 565, "Product variant 142 mockup view 1", "variant_142_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 142 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 566, "Product variant 142 mockup view 2", "variant_142_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 142 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 569, "Product variant 143 mockup view 1", "variant_143_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 143 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 570, "Product variant 143 mockup view 2", "variant_143_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 143 },
                    { 571, "Product variant 143 mockup view 3", "variant_143_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 143 },
                    { 572, "Product variant 143 mockup view 4", "variant_143_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 143 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 573, "Product variant 144 mockup view 1", "variant_144_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 144 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 574, "Product variant 144 mockup view 2", "variant_144_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 144 },
                    { 575, "Product variant 144 mockup view 3", "variant_144_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 144 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 577, "Product variant 145 mockup view 1", "variant_145_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 145 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 578, "Product variant 145 mockup view 2", "variant_145_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 145 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 581, "Product variant 146 mockup view 1", "variant_146_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 146 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 582, "Product variant 146 mockup view 2", "variant_146_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 146 },
                    { 583, "Product variant 146 mockup view 3", "variant_146_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 146 },
                    { 584, "Product variant 146 mockup view 4", "variant_146_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 146 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 585, "Product variant 147 mockup view 1", "variant_147_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 147 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 586, "Product variant 147 mockup view 2", "variant_147_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 147 },
                    { 587, "Product variant 147 mockup view 3", "variant_147_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 147 },
                    { 588, "Product variant 147 mockup view 4", "variant_147_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 147 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 589, "Product variant 148 mockup view 1", "variant_148_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 148 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 590, "Product variant 148 mockup view 2", "variant_148_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 148 },
                    { 591, "Product variant 148 mockup view 3", "variant_148_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 148 },
                    { 592, "Product variant 148 mockup view 4", "variant_148_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 148 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 593, "Product variant 149 mockup view 1", "variant_149_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 149 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 594, "Product variant 149 mockup view 2", "variant_149_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 149 },
                    { 595, "Product variant 149 mockup view 3", "variant_149_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 149 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 597, "Product variant 150 mockup view 1", "variant_150_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 150 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 598, "Product variant 150 mockup view 2", "variant_150_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 150 },
                    { 599, "Product variant 150 mockup view 3", "variant_150_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 150 },
                    { 600, "Product variant 150 mockup view 4", "variant_150_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 150 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 601, "Product variant 151 mockup view 1", "variant_151_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 151 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 602, "Product variant 151 mockup view 2", "variant_151_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 151 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 605, "Product variant 152 mockup view 1", "variant_152_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 152 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 606, "Product variant 152 mockup view 2", "variant_152_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 152 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 609, "Product variant 153 mockup view 1", "variant_153_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 153 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 610, "Product variant 153 mockup view 2", "variant_153_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 153 },
                    { 611, "Product variant 153 mockup view 3", "variant_153_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 153 },
                    { 612, "Product variant 153 mockup view 4", "variant_153_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 153 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 613, "Product variant 154 mockup view 1", "variant_154_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 154 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 614, "Product variant 154 mockup view 2", "variant_154_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 154 },
                    { 615, "Product variant 154 mockup view 3", "variant_154_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 154 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 617, "Product variant 155 mockup view 1", "variant_155_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 155 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 618, "Product variant 155 mockup view 2", "variant_155_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 155 },
                    { 619, "Product variant 155 mockup view 3", "variant_155_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 155 },
                    { 620, "Product variant 155 mockup view 4", "variant_155_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 155 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 621, "Product variant 156 mockup view 1", "variant_156_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 156 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 622, "Product variant 156 mockup view 2", "variant_156_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 156 },
                    { 623, "Product variant 156 mockup view 3", "variant_156_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 156 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 625, "Product variant 157 mockup view 1", "variant_157_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 157 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 626, "Product variant 157 mockup view 2", "variant_157_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 157 },
                    { 627, "Product variant 157 mockup view 3", "variant_157_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 157 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 629, "Product variant 158 mockup view 1", "variant_158_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 158 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 630, "Product variant 158 mockup view 2", "variant_158_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 158 },
                    { 631, "Product variant 158 mockup view 3", "variant_158_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 158 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 633, "Product variant 159 mockup view 1", "variant_159_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 159 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 634, "Product variant 159 mockup view 2", "variant_159_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 159 },
                    { 635, "Product variant 159 mockup view 3", "variant_159_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 159 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 637, "Product variant 160 mockup view 1", "variant_160_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 160 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 638, "Product variant 160 mockup view 2", "variant_160_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 160 },
                    { 639, "Product variant 160 mockup view 3", "variant_160_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 160 },
                    { 640, "Product variant 160 mockup view 4", "variant_160_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 160 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 641, "Product variant 161 mockup view 1", "variant_161_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 161 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 642, "Product variant 161 mockup view 2", "variant_161_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 161 },
                    { 643, "Product variant 161 mockup view 3", "variant_161_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 161 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 645, "Product variant 162 mockup view 1", "variant_162_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 162 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 646, "Product variant 162 mockup view 2", "variant_162_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 162 },
                    { 647, "Product variant 162 mockup view 3", "variant_162_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 162 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 649, "Product variant 163 mockup view 1", "variant_163_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 163 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 650, "Product variant 163 mockup view 2", "variant_163_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 163 },
                    { 651, "Product variant 163 mockup view 3", "variant_163_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 163 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 653, "Product variant 164 mockup view 1", "variant_164_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 164 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 654, "Product variant 164 mockup view 2", "variant_164_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 164 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 657, "Product variant 165 mockup view 1", "variant_165_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 165 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 658, "Product variant 165 mockup view 2", "variant_165_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 165 },
                    { 659, "Product variant 165 mockup view 3", "variant_165_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 165 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 661, "Product variant 166 mockup view 1", "variant_166_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 166 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 662, "Product variant 166 mockup view 2", "variant_166_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 166 },
                    { 663, "Product variant 166 mockup view 3", "variant_166_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 166 },
                    { 664, "Product variant 166 mockup view 4", "variant_166_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 166 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 665, "Product variant 167 mockup view 1", "variant_167_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 167 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 666, "Product variant 167 mockup view 2", "variant_167_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 167 },
                    { 667, "Product variant 167 mockup view 3", "variant_167_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 167 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 669, "Product variant 168 mockup view 1", "variant_168_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 168 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 670, "Product variant 168 mockup view 2", "variant_168_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 168 },
                    { 671, "Product variant 168 mockup view 3", "variant_168_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 168 },
                    { 672, "Product variant 168 mockup view 4", "variant_168_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 168 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 673, "Product variant 169 mockup view 1", "variant_169_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 169 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 674, "Product variant 169 mockup view 2", "variant_169_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 169 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 677, "Product variant 170 mockup view 1", "variant_170_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 170 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 678, "Product variant 170 mockup view 2", "variant_170_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 170 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 681, "Product variant 171 mockup view 1", "variant_171_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 171 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 682, "Product variant 171 mockup view 2", "variant_171_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 171 },
                    { 683, "Product variant 171 mockup view 3", "variant_171_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 171 },
                    { 684, "Product variant 171 mockup view 4", "variant_171_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 171 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 685, "Product variant 172 mockup view 1", "variant_172_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 172 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 686, "Product variant 172 mockup view 2", "variant_172_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 172 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 689, "Product variant 173 mockup view 1", "variant_173_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 173 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 690, "Product variant 173 mockup view 2", "variant_173_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 173 },
                    { 691, "Product variant 173 mockup view 3", "variant_173_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 173 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 693, "Product variant 174 mockup view 1", "variant_174_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 174 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 694, "Product variant 174 mockup view 2", "variant_174_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 174 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 697, "Product variant 175 mockup view 1", "variant_175_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 175 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 698, "Product variant 175 mockup view 2", "variant_175_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 175 },
                    { 699, "Product variant 175 mockup view 3", "variant_175_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 175 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 701, "Product variant 176 mockup view 1", "variant_176_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 176 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 702, "Product variant 176 mockup view 2", "variant_176_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 176 },
                    { 703, "Product variant 176 mockup view 3", "variant_176_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 176 },
                    { 704, "Product variant 176 mockup view 4", "variant_176_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 176 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 705, "Product variant 177 mockup view 1", "variant_177_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 177 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 706, "Product variant 177 mockup view 2", "variant_177_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 177 },
                    { 707, "Product variant 177 mockup view 3", "variant_177_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 177 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 709, "Product variant 178 mockup view 1", "variant_178_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 178 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 710, "Product variant 178 mockup view 2", "variant_178_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 178 },
                    { 711, "Product variant 178 mockup view 3", "variant_178_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 178 },
                    { 712, "Product variant 178 mockup view 4", "variant_178_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 178 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 713, "Product variant 179 mockup view 1", "variant_179_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 179 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 714, "Product variant 179 mockup view 2", "variant_179_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 179 },
                    { 715, "Product variant 179 mockup view 3", "variant_179_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 179 },
                    { 716, "Product variant 179 mockup view 4", "variant_179_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 179 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 717, "Product variant 180 mockup view 1", "variant_180_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 180 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 718, "Product variant 180 mockup view 2", "variant_180_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 180 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 721, "Product variant 181 mockup view 1", "variant_181_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 181 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 722, "Product variant 181 mockup view 2", "variant_181_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 181 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 725, "Product variant 182 mockup view 1", "variant_182_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 182 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 726, "Product variant 182 mockup view 2", "variant_182_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 182 },
                    { 727, "Product variant 182 mockup view 3", "variant_182_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 182 },
                    { 728, "Product variant 182 mockup view 4", "variant_182_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 182 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 729, "Product variant 183 mockup view 1", "variant_183_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 183 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 730, "Product variant 183 mockup view 2", "variant_183_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 183 },
                    { 731, "Product variant 183 mockup view 3", "variant_183_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 183 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 733, "Product variant 184 mockup view 1", "variant_184_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 184 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 734, "Product variant 184 mockup view 2", "variant_184_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 184 },
                    { 735, "Product variant 184 mockup view 3", "variant_184_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 184 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 737, "Product variant 185 mockup view 1", "variant_185_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 185 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 738, "Product variant 185 mockup view 2", "variant_185_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 185 },
                    { 739, "Product variant 185 mockup view 3", "variant_185_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 185 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 741, "Product variant 186 mockup view 1", "variant_186_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 186 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 742, "Product variant 186 mockup view 2", "variant_186_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 186 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 745, "Product variant 187 mockup view 1", "variant_187_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 187 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 746, "Product variant 187 mockup view 2", "variant_187_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 187 },
                    { 747, "Product variant 187 mockup view 3", "variant_187_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 187 },
                    { 748, "Product variant 187 mockup view 4", "variant_187_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 187 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 749, "Product variant 188 mockup view 1", "variant_188_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 188 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 750, "Product variant 188 mockup view 2", "variant_188_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 188 },
                    { 751, "Product variant 188 mockup view 3", "variant_188_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 188 },
                    { 752, "Product variant 188 mockup view 4", "variant_188_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 188 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 753, "Product variant 189 mockup view 1", "variant_189_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 189 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 754, "Product variant 189 mockup view 2", "variant_189_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 189 },
                    { 755, "Product variant 189 mockup view 3", "variant_189_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 189 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 757, "Product variant 190 mockup view 1", "variant_190_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 190 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 758, "Product variant 190 mockup view 2", "variant_190_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 190 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 761, "Product variant 191 mockup view 1", "variant_191_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 191 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 762, "Product variant 191 mockup view 2", "variant_191_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 191 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 765, "Product variant 192 mockup view 1", "variant_192_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 192 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 766, "Product variant 192 mockup view 2", "variant_192_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 192 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 769, "Product variant 193 mockup view 1", "variant_193_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 193 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 770, "Product variant 193 mockup view 2", "variant_193_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 193 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 773, "Product variant 194 mockup view 1", "variant_194_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 194 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 774, "Product variant 194 mockup view 2", "variant_194_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 194 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 777, "Product variant 195 mockup view 1", "variant_195_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 195 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 778, "Product variant 195 mockup view 2", "variant_195_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 195 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 781, "Product variant 196 mockup view 1", "variant_196_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, 196 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 782, "Product variant 196 mockup view 2", "variant_196_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 196 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 785, "Product variant 197 mockup view 1", "variant_197_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 197 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 786, "Product variant 197 mockup view 2", "variant_197_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 197 },
                    { 787, "Product variant 197 mockup view 3", "variant_197_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 197 },
                    { 788, "Product variant 197 mockup view 4", "variant_197_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 197 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 789, "Product variant 198 mockup view 1", "variant_198_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 198 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 790, "Product variant 198 mockup view 2", "variant_198_mockup_2.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 198 },
                    { 791, "Product variant 198 mockup view 3", "variant_198_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 198 },
                    { 792, "Product variant 198 mockup view 4", "variant_198_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 198 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 793, "Product variant 199 mockup view 1", "variant_199_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 199 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 794, "Product variant 199 mockup view 2", "variant_199_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 199 },
                    { 795, "Product variant 199 mockup view 3", "variant_199_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, 199 },
                    { 796, "Product variant 199 mockup view 4", "variant_199_mockup_4.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 199 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 797, "Product variant 200 mockup view 1", "variant_200_mockup_1.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, true, 200 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 798, "Product variant 200 mockup view 2", "variant_200_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 200 },
                    { 799, "Product variant 200 mockup view 3", "variant_200_mockup_3.jpg", "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", true, 200 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 801, "Product variant 201 mockup view 1", "variant_201_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 201 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 802, "Product variant 201 mockup view 2", "variant_201_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 201 },
                    { 803, "Product variant 201 mockup view 3", "variant_201_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 201 },
                    { 804, "Product variant 201 mockup view 4", "variant_201_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 201 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 805, "Product variant 202 mockup view 1", "variant_202_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 202 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 806, "Product variant 202 mockup view 2", "variant_202_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 202 },
                    { 807, "Product variant 202 mockup view 3", "variant_202_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 202 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 809, "Product variant 203 mockup view 1", "variant_203_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 203 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 810, "Product variant 203 mockup view 2", "variant_203_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 203 },
                    { 811, "Product variant 203 mockup view 3", "variant_203_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 203 },
                    { 812, "Product variant 203 mockup view 4", "variant_203_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 203 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 813, "Product variant 204 mockup view 1", "variant_204_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 204 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 814, "Product variant 204 mockup view 2", "variant_204_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 204 },
                    { 815, "Product variant 204 mockup view 3", "variant_204_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 204 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 817, "Product variant 205 mockup view 1", "variant_205_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 205 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 818, "Product variant 205 mockup view 2", "variant_205_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 205 },
                    { 819, "Product variant 205 mockup view 3", "variant_205_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 205 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 821, "Product variant 206 mockup view 1", "variant_206_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 206 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 822, "Product variant 206 mockup view 2", "variant_206_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 206 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 825, "Product variant 207 mockup view 1", "variant_207_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 207 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 826, "Product variant 207 mockup view 2", "variant_207_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 207 },
                    { 827, "Product variant 207 mockup view 3", "variant_207_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 207 },
                    { 828, "Product variant 207 mockup view 4", "variant_207_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 207 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 829, "Product variant 208 mockup view 1", "variant_208_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 208 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 830, "Product variant 208 mockup view 2", "variant_208_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 208 },
                    { 831, "Product variant 208 mockup view 3", "variant_208_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 208 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 833, "Product variant 209 mockup view 1", "variant_209_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 209 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 834, "Product variant 209 mockup view 2", "variant_209_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 209 },
                    { 835, "Product variant 209 mockup view 3", "variant_209_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 209 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 837, "Product variant 210 mockup view 1", "variant_210_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 210 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 838, "Product variant 210 mockup view 2", "variant_210_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 210 },
                    { 839, "Product variant 210 mockup view 3", "variant_210_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 210 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 841, "Product variant 211 mockup view 1", "variant_211_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 211 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 842, "Product variant 211 mockup view 2", "variant_211_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 211 },
                    { 843, "Product variant 211 mockup view 3", "variant_211_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 211 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 845, "Product variant 212 mockup view 1", "variant_212_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 212 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 846, "Product variant 212 mockup view 2", "variant_212_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 212 },
                    { 847, "Product variant 212 mockup view 3", "variant_212_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 212 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 849, "Product variant 213 mockup view 1", "variant_213_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 213 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 850, "Product variant 213 mockup view 2", "variant_213_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 213 },
                    { 851, "Product variant 213 mockup view 3", "variant_213_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 213 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 853, "Product variant 214 mockup view 1", "variant_214_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 214 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 854, "Product variant 214 mockup view 2", "variant_214_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 214 },
                    { 855, "Product variant 214 mockup view 3", "variant_214_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 214 },
                    { 856, "Product variant 214 mockup view 4", "variant_214_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 214 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 857, "Product variant 215 mockup view 1", "variant_215_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 215 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 858, "Product variant 215 mockup view 2", "variant_215_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 215 },
                    { 859, "Product variant 215 mockup view 3", "variant_215_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 215 },
                    { 860, "Product variant 215 mockup view 4", "variant_215_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 215 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 861, "Product variant 216 mockup view 1", "variant_216_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 216 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 862, "Product variant 216 mockup view 2", "variant_216_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 216 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 865, "Product variant 217 mockup view 1", "variant_217_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 217 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 866, "Product variant 217 mockup view 2", "variant_217_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 217 },
                    { 867, "Product variant 217 mockup view 3", "variant_217_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 217 },
                    { 868, "Product variant 217 mockup view 4", "variant_217_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 217 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 869, "Product variant 218 mockup view 1", "variant_218_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 218 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 870, "Product variant 218 mockup view 2", "variant_218_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 218 },
                    { 871, "Product variant 218 mockup view 3", "variant_218_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 218 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 873, "Product variant 219 mockup view 1", "variant_219_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 219 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 874, "Product variant 219 mockup view 2", "variant_219_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 219 },
                    { 875, "Product variant 219 mockup view 3", "variant_219_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 219 },
                    { 876, "Product variant 219 mockup view 4", "variant_219_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 219 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 877, "Product variant 220 mockup view 1", "variant_220_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 220 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 878, "Product variant 220 mockup view 2", "variant_220_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 220 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 881, "Product variant 221 mockup view 1", "variant_221_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 221 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 882, "Product variant 221 mockup view 2", "variant_221_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 221 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 885, "Product variant 222 mockup view 1", "variant_222_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 222 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 886, "Product variant 222 mockup view 2", "variant_222_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 222 },
                    { 887, "Product variant 222 mockup view 3", "variant_222_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 222 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 889, "Product variant 223 mockup view 1", "variant_223_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 223 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 890, "Product variant 223 mockup view 2", "variant_223_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 223 },
                    { 891, "Product variant 223 mockup view 3", "variant_223_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 223 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 893, "Product variant 224 mockup view 1", "variant_224_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 224 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 894, "Product variant 224 mockup view 2", "variant_224_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 224 },
                    { 895, "Product variant 224 mockup view 3", "variant_224_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 224 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 897, "Product variant 225 mockup view 1", "variant_225_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 225 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 898, "Product variant 225 mockup view 2", "variant_225_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 225 },
                    { 899, "Product variant 225 mockup view 3", "variant_225_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 225 },
                    { 900, "Product variant 225 mockup view 4", "variant_225_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 225 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 901, "Product variant 226 mockup view 1", "variant_226_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 226 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 902, "Product variant 226 mockup view 2", "variant_226_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 226 },
                    { 903, "Product variant 226 mockup view 3", "variant_226_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 226 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 905, "Product variant 227 mockup view 1", "variant_227_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 227 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 906, "Product variant 227 mockup view 2", "variant_227_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 227 },
                    { 907, "Product variant 227 mockup view 3", "variant_227_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 227 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 909, "Product variant 228 mockup view 1", "variant_228_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 228 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 910, "Product variant 228 mockup view 2", "variant_228_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 228 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 913, "Product variant 229 mockup view 1", "variant_229_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 229 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 914, "Product variant 229 mockup view 2", "variant_229_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 229 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 917, "Product variant 230 mockup view 1", "variant_230_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 230 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 918, "Product variant 230 mockup view 2", "variant_230_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 230 },
                    { 919, "Product variant 230 mockup view 3", "variant_230_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 230 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 921, "Product variant 231 mockup view 1", "variant_231_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 231 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 922, "Product variant 231 mockup view 2", "variant_231_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 231 },
                    { 923, "Product variant 231 mockup view 3", "variant_231_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 231 },
                    { 924, "Product variant 231 mockup view 4", "variant_231_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 231 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 925, "Product variant 232 mockup view 1", "variant_232_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 232 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 926, "Product variant 232 mockup view 2", "variant_232_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 232 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 929, "Product variant 233 mockup view 1", "variant_233_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 233 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 930, "Product variant 233 mockup view 2", "variant_233_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 233 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 933, "Product variant 234 mockup view 1", "variant_234_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 234 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 934, "Product variant 234 mockup view 2", "variant_234_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 234 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 937, "Product variant 235 mockup view 1", "variant_235_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 235 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 938, "Product variant 235 mockup view 2", "variant_235_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 235 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 941, "Product variant 236 mockup view 1", "variant_236_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 236 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 942, "Product variant 236 mockup view 2", "variant_236_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 236 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 945, "Product variant 237 mockup view 1", "variant_237_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 237 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 946, "Product variant 237 mockup view 2", "variant_237_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 237 },
                    { 947, "Product variant 237 mockup view 3", "variant_237_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 237 },
                    { 948, "Product variant 237 mockup view 4", "variant_237_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 237 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 949, "Product variant 238 mockup view 1", "variant_238_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 238 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 950, "Product variant 238 mockup view 2", "variant_238_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 238 },
                    { 951, "Product variant 238 mockup view 3", "variant_238_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 238 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 953, "Product variant 239 mockup view 1", "variant_239_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 239 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 954, "Product variant 239 mockup view 2", "variant_239_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 239 },
                    { 955, "Product variant 239 mockup view 3", "variant_239_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 239 },
                    { 956, "Product variant 239 mockup view 4", "variant_239_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 239 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 957, "Product variant 240 mockup view 1", "variant_240_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 240 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 958, "Product variant 240 mockup view 2", "variant_240_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 240 },
                    { 959, "Product variant 240 mockup view 3", "variant_240_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 240 },
                    { 960, "Product variant 240 mockup view 4", "variant_240_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 240 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 961, "Product variant 241 mockup view 1", "variant_241_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 241 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 962, "Product variant 241 mockup view 2", "variant_241_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 241 },
                    { 963, "Product variant 241 mockup view 3", "variant_241_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 241 },
                    { 964, "Product variant 241 mockup view 4", "variant_241_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 241 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 965, "Product variant 242 mockup view 1", "variant_242_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 242 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 966, "Product variant 242 mockup view 2", "variant_242_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 242 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 969, "Product variant 243 mockup view 1", "variant_243_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 243 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 970, "Product variant 243 mockup view 2", "variant_243_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 243 },
                    { 971, "Product variant 243 mockup view 3", "variant_243_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 243 },
                    { 972, "Product variant 243 mockup view 4", "variant_243_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 243 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 973, "Product variant 244 mockup view 1", "variant_244_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 244 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 974, "Product variant 244 mockup view 2", "variant_244_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 244 },
                    { 975, "Product variant 244 mockup view 3", "variant_244_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 244 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 977, "Product variant 245 mockup view 1", "variant_245_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 245 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 978, "Product variant 245 mockup view 2", "variant_245_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 245 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 981, "Product variant 246 mockup view 1", "variant_246_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 246 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 982, "Product variant 246 mockup view 2", "variant_246_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 246 },
                    { 983, "Product variant 246 mockup view 3", "variant_246_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 246 },
                    { 984, "Product variant 246 mockup view 4", "variant_246_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 246 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 985, "Product variant 247 mockup view 1", "variant_247_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 247 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 986, "Product variant 247 mockup view 2", "variant_247_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 247 },
                    { 987, "Product variant 247 mockup view 3", "variant_247_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 247 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 989, "Product variant 248 mockup view 1", "variant_248_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 248 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 990, "Product variant 248 mockup view 2", "variant_248_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 248 },
                    { 991, "Product variant 248 mockup view 3", "variant_248_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 248 },
                    { 992, "Product variant 248 mockup view 4", "variant_248_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 248 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 993, "Product variant 249 mockup view 1", "variant_249_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 249 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 994, "Product variant 249 mockup view 2", "variant_249_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 249 },
                    { 995, "Product variant 249 mockup view 3", "variant_249_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 249 },
                    { 996, "Product variant 249 mockup view 4", "variant_249_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 249 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 997, "Product variant 250 mockup view 1", "variant_250_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 250 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 998, "Product variant 250 mockup view 2", "variant_250_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 250 },
                    { 999, "Product variant 250 mockup view 3", "variant_250_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 250 },
                    { 1000, "Product variant 250 mockup view 4", "variant_250_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 250 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1001, "Product variant 251 mockup view 1", "variant_251_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 251 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1002, "Product variant 251 mockup view 2", "variant_251_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 251 },
                    { 1003, "Product variant 251 mockup view 3", "variant_251_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 251 },
                    { 1004, "Product variant 251 mockup view 4", "variant_251_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 251 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1005, "Product variant 252 mockup view 1", "variant_252_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 252 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1006, "Product variant 252 mockup view 2", "variant_252_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 252 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1009, "Product variant 253 mockup view 1", "variant_253_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 253 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1010, "Product variant 253 mockup view 2", "variant_253_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 253 },
                    { 1011, "Product variant 253 mockup view 3", "variant_253_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 253 },
                    { 1012, "Product variant 253 mockup view 4", "variant_253_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 253 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1013, "Product variant 254 mockup view 1", "variant_254_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 254 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1014, "Product variant 254 mockup view 2", "variant_254_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 254 },
                    { 1015, "Product variant 254 mockup view 3", "variant_254_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 254 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1017, "Product variant 255 mockup view 1", "variant_255_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 255 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1018, "Product variant 255 mockup view 2", "variant_255_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 255 },
                    { 1019, "Product variant 255 mockup view 3", "variant_255_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 255 },
                    { 1020, "Product variant 255 mockup view 4", "variant_255_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 255 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1021, "Product variant 256 mockup view 1", "variant_256_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 256 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1022, "Product variant 256 mockup view 2", "variant_256_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 256 },
                    { 1023, "Product variant 256 mockup view 3", "variant_256_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 256 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1025, "Product variant 257 mockup view 1", "variant_257_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 257 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1026, "Product variant 257 mockup view 2", "variant_257_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 257 },
                    { 1027, "Product variant 257 mockup view 3", "variant_257_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 257 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1029, "Product variant 258 mockup view 1", "variant_258_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 258 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1030, "Product variant 258 mockup view 2", "variant_258_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 258 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1033, "Product variant 259 mockup view 1", "variant_259_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 259 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1034, "Product variant 259 mockup view 2", "variant_259_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 259 },
                    { 1035, "Product variant 259 mockup view 3", "variant_259_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 259 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1037, "Product variant 260 mockup view 1", "variant_260_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 260 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1038, "Product variant 260 mockup view 2", "variant_260_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 260 },
                    { 1039, "Product variant 260 mockup view 3", "variant_260_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 260 },
                    { 1040, "Product variant 260 mockup view 4", "variant_260_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 260 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1041, "Product variant 261 mockup view 1", "variant_261_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 261 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1042, "Product variant 261 mockup view 2", "variant_261_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 261 },
                    { 1043, "Product variant 261 mockup view 3", "variant_261_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 261 },
                    { 1044, "Product variant 261 mockup view 4", "variant_261_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 261 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1045, "Product variant 262 mockup view 1", "variant_262_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 262 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1046, "Product variant 262 mockup view 2", "variant_262_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 262 },
                    { 1047, "Product variant 262 mockup view 3", "variant_262_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 262 },
                    { 1048, "Product variant 262 mockup view 4", "variant_262_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 262 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1049, "Product variant 263 mockup view 1", "variant_263_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 263 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1050, "Product variant 263 mockup view 2", "variant_263_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 263 },
                    { 1051, "Product variant 263 mockup view 3", "variant_263_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 263 },
                    { 1052, "Product variant 263 mockup view 4", "variant_263_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 263 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1053, "Product variant 264 mockup view 1", "variant_264_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 264 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1054, "Product variant 264 mockup view 2", "variant_264_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 264 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1057, "Product variant 265 mockup view 1", "variant_265_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 265 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1058, "Product variant 265 mockup view 2", "variant_265_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 265 },
                    { 1059, "Product variant 265 mockup view 3", "variant_265_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 265 },
                    { 1060, "Product variant 265 mockup view 4", "variant_265_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 265 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1061, "Product variant 266 mockup view 1", "variant_266_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 266 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1062, "Product variant 266 mockup view 2", "variant_266_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 266 },
                    { 1063, "Product variant 266 mockup view 3", "variant_266_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 266 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1065, "Product variant 267 mockup view 1", "variant_267_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 267 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1066, "Product variant 267 mockup view 2", "variant_267_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 267 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1069, "Product variant 268 mockup view 1", "variant_268_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 268 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1070, "Product variant 268 mockup view 2", "variant_268_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 268 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1073, "Product variant 269 mockup view 1", "variant_269_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 269 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1074, "Product variant 269 mockup view 2", "variant_269_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 269 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1077, "Product variant 270 mockup view 1", "variant_270_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 270 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1078, "Product variant 270 mockup view 2", "variant_270_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 270 },
                    { 1079, "Product variant 270 mockup view 3", "variant_270_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 270 },
                    { 1080, "Product variant 270 mockup view 4", "variant_270_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 270 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1081, "Product variant 271 mockup view 1", "variant_271_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 271 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1082, "Product variant 271 mockup view 2", "variant_271_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 271 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1085, "Product variant 272 mockup view 1", "variant_272_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 272 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1086, "Product variant 272 mockup view 2", "variant_272_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 272 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1089, "Product variant 273 mockup view 1", "variant_273_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 273 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1090, "Product variant 273 mockup view 2", "variant_273_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 273 },
                    { 1091, "Product variant 273 mockup view 3", "variant_273_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 273 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1093, "Product variant 274 mockup view 1", "variant_274_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 274 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1094, "Product variant 274 mockup view 2", "variant_274_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 274 },
                    { 1095, "Product variant 274 mockup view 3", "variant_274_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 274 },
                    { 1096, "Product variant 274 mockup view 4", "variant_274_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 274 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1097, "Product variant 275 mockup view 1", "variant_275_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 275 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1098, "Product variant 275 mockup view 2", "variant_275_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 275 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1101, "Product variant 276 mockup view 1", "variant_276_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 276 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1102, "Product variant 276 mockup view 2", "variant_276_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 276 },
                    { 1103, "Product variant 276 mockup view 3", "variant_276_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 276 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1105, "Product variant 277 mockup view 1", "variant_277_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 277 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1106, "Product variant 277 mockup view 2", "variant_277_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 277 },
                    { 1107, "Product variant 277 mockup view 3", "variant_277_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 277 },
                    { 1108, "Product variant 277 mockup view 4", "variant_277_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 277 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1109, "Product variant 278 mockup view 1", "variant_278_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 278 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1110, "Product variant 278 mockup view 2", "variant_278_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 278 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1113, "Product variant 279 mockup view 1", "variant_279_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 279 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1114, "Product variant 279 mockup view 2", "variant_279_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 279 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1117, "Product variant 280 mockup view 1", "variant_280_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 280 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1118, "Product variant 280 mockup view 2", "variant_280_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 280 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1121, "Product variant 281 mockup view 1", "variant_281_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 281 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1122, "Product variant 281 mockup view 2", "variant_281_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 281 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1125, "Product variant 282 mockup view 1", "variant_282_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 282 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1126, "Product variant 282 mockup view 2", "variant_282_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 282 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1129, "Product variant 283 mockup view 1", "variant_283_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 283 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1130, "Product variant 283 mockup view 2", "variant_283_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 283 },
                    { 1131, "Product variant 283 mockup view 3", "variant_283_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 283 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1133, "Product variant 284 mockup view 1", "variant_284_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 284 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1134, "Product variant 284 mockup view 2", "variant_284_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 284 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1137, "Product variant 285 mockup view 1", "variant_285_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 285 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1138, "Product variant 285 mockup view 2", "variant_285_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 285 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1141, "Product variant 286 mockup view 1", "variant_286_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 286 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1142, "Product variant 286 mockup view 2", "variant_286_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 286 },
                    { 1143, "Product variant 286 mockup view 3", "variant_286_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 286 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1145, "Product variant 287 mockup view 1", "variant_287_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 287 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1146, "Product variant 287 mockup view 2", "variant_287_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 287 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1149, "Product variant 288 mockup view 1", "variant_288_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 288 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1150, "Product variant 288 mockup view 2", "variant_288_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 288 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1153, "Product variant 289 mockup view 1", "variant_289_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 289 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1154, "Product variant 289 mockup view 2", "variant_289_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 289 },
                    { 1155, "Product variant 289 mockup view 3", "variant_289_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 289 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1157, "Product variant 290 mockup view 1", "variant_290_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 290 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1158, "Product variant 290 mockup view 2", "variant_290_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 290 },
                    { 1159, "Product variant 290 mockup view 3", "variant_290_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 290 },
                    { 1160, "Product variant 290 mockup view 4", "variant_290_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 290 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1161, "Product variant 291 mockup view 1", "variant_291_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 291 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1162, "Product variant 291 mockup view 2", "variant_291_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 291 },
                    { 1163, "Product variant 291 mockup view 3", "variant_291_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 291 },
                    { 1164, "Product variant 291 mockup view 4", "variant_291_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 291 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1165, "Product variant 292 mockup view 1", "variant_292_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 292 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1166, "Product variant 292 mockup view 2", "variant_292_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 292 },
                    { 1167, "Product variant 292 mockup view 3", "variant_292_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 292 },
                    { 1168, "Product variant 292 mockup view 4", "variant_292_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 292 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1169, "Product variant 293 mockup view 1", "variant_293_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 293 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1170, "Product variant 293 mockup view 2", "variant_293_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 293 },
                    { 1171, "Product variant 293 mockup view 3", "variant_293_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 293 },
                    { 1172, "Product variant 293 mockup view 4", "variant_293_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 293 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1173, "Product variant 294 mockup view 1", "variant_294_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 294 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1174, "Product variant 294 mockup view 2", "variant_294_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 294 },
                    { 1175, "Product variant 294 mockup view 3", "variant_294_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 294 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1177, "Product variant 295 mockup view 1", "variant_295_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 295 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1178, "Product variant 295 mockup view 2", "variant_295_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 295 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1181, "Product variant 296 mockup view 1", "variant_296_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 296 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1182, "Product variant 296 mockup view 2", "variant_296_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 296 },
                    { 1183, "Product variant 296 mockup view 3", "variant_296_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 296 },
                    { 1184, "Product variant 296 mockup view 4", "variant_296_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 296 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1185, "Product variant 297 mockup view 1", "variant_297_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 297 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1186, "Product variant 297 mockup view 2", "variant_297_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 297 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1189, "Product variant 298 mockup view 1", "variant_298_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 298 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1190, "Product variant 298 mockup view 2", "variant_298_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 298 },
                    { 1191, "Product variant 298 mockup view 3", "variant_298_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 298 },
                    { 1192, "Product variant 298 mockup view 4", "variant_298_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 298 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1193, "Product variant 299 mockup view 1", "variant_299_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, 299 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1194, "Product variant 299 mockup view 2", "variant_299_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 299 },
                    { 1195, "Product variant 299 mockup view 3", "variant_299_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 299 },
                    { 1196, "Product variant 299 mockup view 4", "variant_299_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 299 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1197, "Product variant 300 mockup view 1", "variant_300_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 300 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1198, "Product variant 300 mockup view 2", "variant_300_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, 300 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1201, "Product variant 301 mockup view 1", "variant_301_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 301 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1202, "Product variant 301 mockup view 2", "variant_301_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 301 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1205, "Product variant 302 mockup view 1", "variant_302_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 302 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1206, "Product variant 302 mockup view 2", "variant_302_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 302 },
                    { 1207, "Product variant 302 mockup view 3", "variant_302_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 302 },
                    { 1208, "Product variant 302 mockup view 4", "variant_302_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 302 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1209, "Product variant 303 mockup view 1", "variant_303_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 303 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1210, "Product variant 303 mockup view 2", "variant_303_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 303 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1213, "Product variant 304 mockup view 1", "variant_304_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 304 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1214, "Product variant 304 mockup view 2", "variant_304_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 304 },
                    { 1215, "Product variant 304 mockup view 3", "variant_304_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 304 },
                    { 1216, "Product variant 304 mockup view 4", "variant_304_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 304 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1217, "Product variant 305 mockup view 1", "variant_305_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 305 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1218, "Product variant 305 mockup view 2", "variant_305_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 305 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1221, "Product variant 306 mockup view 1", "variant_306_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 306 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1222, "Product variant 306 mockup view 2", "variant_306_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 306 },
                    { 1223, "Product variant 306 mockup view 3", "variant_306_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 306 },
                    { 1224, "Product variant 306 mockup view 4", "variant_306_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 306 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1225, "Product variant 307 mockup view 1", "variant_307_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 307 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1226, "Product variant 307 mockup view 2", "variant_307_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 307 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1229, "Product variant 308 mockup view 1", "variant_308_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 308 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1230, "Product variant 308 mockup view 2", "variant_308_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 308 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1233, "Product variant 309 mockup view 1", "variant_309_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 309 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1234, "Product variant 309 mockup view 2", "variant_309_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 309 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1237, "Product variant 310 mockup view 1", "variant_310_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 310 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1238, "Product variant 310 mockup view 2", "variant_310_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 310 },
                    { 1239, "Product variant 310 mockup view 3", "variant_310_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 310 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1241, "Product variant 311 mockup view 1", "variant_311_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 311 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1242, "Product variant 311 mockup view 2", "variant_311_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 311 },
                    { 1243, "Product variant 311 mockup view 3", "variant_311_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 311 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1245, "Product variant 312 mockup view 1", "variant_312_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 312 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1246, "Product variant 312 mockup view 2", "variant_312_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 312 },
                    { 1247, "Product variant 312 mockup view 3", "variant_312_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 312 },
                    { 1248, "Product variant 312 mockup view 4", "variant_312_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 312 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1249, "Product variant 313 mockup view 1", "variant_313_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 313 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1250, "Product variant 313 mockup view 2", "variant_313_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 313 },
                    { 1251, "Product variant 313 mockup view 3", "variant_313_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 313 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1253, "Product variant 314 mockup view 1", "variant_314_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 314 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1254, "Product variant 314 mockup view 2", "variant_314_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 314 },
                    { 1255, "Product variant 314 mockup view 3", "variant_314_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 314 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1257, "Product variant 315 mockup view 1", "variant_315_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 315 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1258, "Product variant 315 mockup view 2", "variant_315_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 315 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1261, "Product variant 316 mockup view 1", "variant_316_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 316 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1262, "Product variant 316 mockup view 2", "variant_316_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 316 },
                    { 1263, "Product variant 316 mockup view 3", "variant_316_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 316 },
                    { 1264, "Product variant 316 mockup view 4", "variant_316_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 316 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1265, "Product variant 317 mockup view 1", "variant_317_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 317 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1266, "Product variant 317 mockup view 2", "variant_317_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 317 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1269, "Product variant 318 mockup view 1", "variant_318_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 318 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1270, "Product variant 318 mockup view 2", "variant_318_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 318 },
                    { 1271, "Product variant 318 mockup view 3", "variant_318_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 318 },
                    { 1272, "Product variant 318 mockup view 4", "variant_318_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 318 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1273, "Product variant 319 mockup view 1", "variant_319_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 319 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1274, "Product variant 319 mockup view 2", "variant_319_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 319 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1277, "Product variant 320 mockup view 1", "variant_320_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 320 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1278, "Product variant 320 mockup view 2", "variant_320_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 320 },
                    { 1279, "Product variant 320 mockup view 3", "variant_320_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 320 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1281, "Product variant 321 mockup view 1", "variant_321_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 321 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1282, "Product variant 321 mockup view 2", "variant_321_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 321 },
                    { 1283, "Product variant 321 mockup view 3", "variant_321_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 321 },
                    { 1284, "Product variant 321 mockup view 4", "variant_321_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 321 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1285, "Product variant 322 mockup view 1", "variant_322_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 322 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1286, "Product variant 322 mockup view 2", "variant_322_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 322 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1289, "Product variant 323 mockup view 1", "variant_323_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 323 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1290, "Product variant 323 mockup view 2", "variant_323_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 323 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1293, "Product variant 324 mockup view 1", "variant_324_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 324 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1294, "Product variant 324 mockup view 2", "variant_324_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 324 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1297, "Product variant 325 mockup view 1", "variant_325_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 325 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1298, "Product variant 325 mockup view 2", "variant_325_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 325 },
                    { 1299, "Product variant 325 mockup view 3", "variant_325_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 325 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1301, "Product variant 326 mockup view 1", "variant_326_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 326 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1302, "Product variant 326 mockup view 2", "variant_326_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 326 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1305, "Product variant 327 mockup view 1", "variant_327_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 327 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1306, "Product variant 327 mockup view 2", "variant_327_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 327 },
                    { 1307, "Product variant 327 mockup view 3", "variant_327_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 327 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1309, "Product variant 328 mockup view 1", "variant_328_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 328 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1310, "Product variant 328 mockup view 2", "variant_328_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 328 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1313, "Product variant 329 mockup view 1", "variant_329_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 329 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1314, "Product variant 329 mockup view 2", "variant_329_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 329 },
                    { 1315, "Product variant 329 mockup view 3", "variant_329_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 329 },
                    { 1316, "Product variant 329 mockup view 4", "variant_329_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 329 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1317, "Product variant 330 mockup view 1", "variant_330_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 330 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1318, "Product variant 330 mockup view 2", "variant_330_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 330 },
                    { 1319, "Product variant 330 mockup view 3", "variant_330_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 330 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1321, "Product variant 331 mockup view 1", "variant_331_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 331 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1322, "Product variant 331 mockup view 2", "variant_331_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 331 },
                    { 1323, "Product variant 331 mockup view 3", "variant_331_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 331 },
                    { 1324, "Product variant 331 mockup view 4", "variant_331_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 331 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1325, "Product variant 332 mockup view 1", "variant_332_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 332 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1326, "Product variant 332 mockup view 2", "variant_332_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 332 },
                    { 1327, "Product variant 332 mockup view 3", "variant_332_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 332 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1329, "Product variant 333 mockup view 1", "variant_333_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 333 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1330, "Product variant 333 mockup view 2", "variant_333_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 333 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1333, "Product variant 334 mockup view 1", "variant_334_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 334 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1334, "Product variant 334 mockup view 2", "variant_334_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 334 },
                    { 1335, "Product variant 334 mockup view 3", "variant_334_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 334 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1337, "Product variant 335 mockup view 1", "variant_335_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 335 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1338, "Product variant 335 mockup view 2", "variant_335_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 335 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1341, "Product variant 336 mockup view 1", "variant_336_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 336 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1342, "Product variant 336 mockup view 2", "variant_336_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 336 },
                    { 1343, "Product variant 336 mockup view 3", "variant_336_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 336 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1345, "Product variant 337 mockup view 1", "variant_337_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 337 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1346, "Product variant 337 mockup view 2", "variant_337_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 337 },
                    { 1347, "Product variant 337 mockup view 3", "variant_337_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 337 },
                    { 1348, "Product variant 337 mockup view 4", "variant_337_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 337 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1349, "Product variant 338 mockup view 1", "variant_338_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 338 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1350, "Product variant 338 mockup view 2", "variant_338_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 338 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1353, "Product variant 339 mockup view 1", "variant_339_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 339 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1354, "Product variant 339 mockup view 2", "variant_339_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 339 },
                    { 1355, "Product variant 339 mockup view 3", "variant_339_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 339 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1357, "Product variant 340 mockup view 1", "variant_340_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 340 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1358, "Product variant 340 mockup view 2", "variant_340_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 340 },
                    { 1359, "Product variant 340 mockup view 3", "variant_340_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 340 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1361, "Product variant 341 mockup view 1", "variant_341_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 341 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1362, "Product variant 341 mockup view 2", "variant_341_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 341 },
                    { 1363, "Product variant 341 mockup view 3", "variant_341_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 341 },
                    { 1364, "Product variant 341 mockup view 4", "variant_341_mockup_4.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 341 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1365, "Product variant 342 mockup view 1", "variant_342_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 342 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1366, "Product variant 342 mockup view 2", "variant_342_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 342 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1369, "Product variant 343 mockup view 1", "variant_343_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 343 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1370, "Product variant 343 mockup view 2", "variant_343_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 343 },
                    { 1371, "Product variant 343 mockup view 3", "variant_343_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 343 },
                    { 1372, "Product variant 343 mockup view 4", "variant_343_mockup_4.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 343 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1373, "Product variant 344 mockup view 1", "variant_344_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 344 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1374, "Product variant 344 mockup view 2", "variant_344_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 344 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1377, "Product variant 345 mockup view 1", "variant_345_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 345 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1378, "Product variant 345 mockup view 2", "variant_345_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 345 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1381, "Product variant 346 mockup view 1", "variant_346_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 346 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[] { 1382, "Product variant 346 mockup view 2", "variant_346_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 346 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1385, "Product variant 347 mockup view 1", "variant_347_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 347 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1386, "Product variant 347 mockup view 2", "variant_347_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 347 },
                    { 1387, "Product variant 347 mockup view 3", "variant_347_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 347 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1389, "Product variant 348 mockup view 1", "variant_348_mockup_1.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, true, 348 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1390, "Product variant 348 mockup view 2", "variant_348_mockup_2.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 348 },
                    { 1391, "Product variant 348 mockup view 3", "variant_348_mockup_3.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 348 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1393, "Product variant 349 mockup view 1", "variant_349_mockup_1.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, true, 349 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1394, "Product variant 349 mockup view 2", "variant_349_mockup_2.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 349 },
                    { 1395, "Product variant 349 mockup view 3", "variant_349_mockup_3.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, 349 },
                    { 1396, "Product variant 349 mockup view 4", "variant_349_mockup_4.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 349 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId" },
                values: new object[] { 1397, "Product variant 350 mockup view 1", "variant_350_mockup_1.jpg", "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", true, true, 350 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "FileName", "ImageUrl", "IsActive", "ProductVariantId" },
                values: new object[,]
                {
                    { 1398, "Product variant 350 mockup view 2", "variant_350_mockup_2.jpg", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", true, 350 },
                    { 1399, "Product variant 350 mockup view 3", "variant_350_mockup_3.jpg", "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop", true, 350 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "admin-001" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-001" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-002" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-003" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-005" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-006" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-007" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-008" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-009" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-010" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-011" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-012" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-013" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-014" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-015" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-016" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-017" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-018" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-019" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-020" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-021" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-022" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-023" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-024" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-025" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-026" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-027" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-028" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-029" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "customer-030" });

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
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 10);

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
                table: "Designs",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 100);

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
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 9);

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
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 18);

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
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 34);

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
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 42);

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
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 51);

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
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 70);

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
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 79);

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
                keyValue: 84);

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
                keyValue: 93);

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
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 103);

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
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 111);

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
                keyValue: 120);

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
                keyValue: 126);

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
                keyValue: 129);

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
                keyValue: 135);

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
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 142);

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
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 154);

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
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 163);

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
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 174);

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
                keyValue: 180);

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
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 186);

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
                keyValue: 189);

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
                keyValue: 201);

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
                keyValue: 204);

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
                keyValue: 225);

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
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 234);

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
                keyValue: 243);

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
                keyValue: 246);

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
                keyValue: 252);

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
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 261);

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
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 270);

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
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 274);

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
                keyValue: 279);

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
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 286);

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
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 306);

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
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 310);

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
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 342);

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
                keyValue: 348);

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
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 357);

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
                keyValue: 360);

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
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 366);

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
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 375);

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
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 393);

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
                keyValue: 396);

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
                keyValue: 405);

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
                keyValue: 411);

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
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 418);

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
                keyValue: 423);

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
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 427);

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
                keyValue: 438);

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
                keyValue: 444);

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
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 453);

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
                keyValue: 456);

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
                keyValue: 459);

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
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 478);

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
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 486);

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
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 499);

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
                keyValue: 507);

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
                keyValue: 513);

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
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 525);

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
                keyValue: 531);

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
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 543);

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
                keyValue: 546);

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
                keyValue: 561);

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
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 570);

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
                keyValue: 573);

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
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 582);

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
                keyValue: 585);

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
                keyValue: 588);

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
                keyValue: 591);

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
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 595);

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
                keyValue: 600);

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
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 609);

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
                keyValue: 612);

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
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 633);

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
                keyValue: 645);

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
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 657);

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
                keyValue: 663);

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
                keyValue: 669);

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
                keyValue: 672);

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
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 681);

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
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 694);

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
                keyValue: 705);

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
                keyValue: 711);

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
                keyValue: 714);

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
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 718);

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
                keyValue: 729);

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
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 739);

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
                keyValue: 750);

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
                keyValue: 753);

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
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 766);

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
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 778);

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
                keyValue: 795);

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
                keyValue: 801);

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
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 810);

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
                keyValue: 813);

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
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 822);

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
                keyValue: 828);

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
                keyValue: 831);

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
                keyValue: 849);

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
                keyValue: 855);

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
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 862);

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
                keyValue: 876);

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
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 882);

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
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 907);

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
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 919);

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
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 930);

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
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 938);

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
                keyValue: 945);

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
                keyValue: 960);

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
                keyValue: 963);

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
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 969);

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
                keyValue: 972);

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
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 981);

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
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 990);

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
                keyValue: 993);

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
                keyValue: 999);

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
                keyValue: 1002);

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
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1011);

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
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1015);

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
                keyValue: 1020);

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
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1027);

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
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1038);

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
                keyValue: 1044);

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
                keyValue: 1047);

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
                keyValue: 1050);

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
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1059);

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
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1063);

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
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1074);

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
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1089);

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
                keyValue: 1095);

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
                keyValue: 1101);

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
                keyValue: 1110);

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
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1126);

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
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1134);

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
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1146);

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
                keyValue: 1170);

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
                keyValue: 1173);

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
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1182);

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
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1191);

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
                keyValue: 1194);

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
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "ProductVariantImages",
                keyColumn: "Id",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-001");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-002");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-003");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-004");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-005");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-006");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-007");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-008");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-009");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-010");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-011");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-012");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-013");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-014");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-015");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-016");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-017");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-018");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-019");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-020");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-021");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-022");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-023");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-024");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-025");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-026");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-027");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-028");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-029");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-030");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

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
                table: "BaseProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5);

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
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-001");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
