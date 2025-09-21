using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedBubble.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingnewseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd2ead10-fd2f-4079-a435-0fa96bc4c77c", "AQAAAAIAAYagAAAAEIDH3dgaGGhS/3S9dodWfs7ayJiU1PzhTwqO4z9dhtnCm3l3PuIo+9/AMY/7HrUS4g==", "87fbcfde-844c-400a-91bc-ea04aff4bb1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6843c4eb-dd44-405d-9cc0-b948a37de522", "AQAAAAIAAYagAAAAELro+722CtH2JyZIonsVxhpF2vRA2mkQXjZS3rwgN526H4tUnKBjCUPnQmZcAnASHg==", "0cafd5d4-d080-4f96-9380-073e9c87518f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ba0c73b-20cd-47f2-9c60-f3c650d0c9a8", "AQAAAAIAAYagAAAAEKjJh2U+NWeWWfZWfietLZG8/RQ29FOs2m0AOBvHUhknO4GlKHzSM5voxXNKncVBiQ==", "540721b3-8734-4bef-8f32-3575477a982d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59aac6f7-fab3-4c11-8c4f-d3352e3d4c74", "AQAAAAIAAYagAAAAEMO2rIFqk6YVc6EvTTPgfKlDVFwWrAS+/7xQGsAvFJxnueS2rq/6yiGwCuvY4hdS3Q==", "535fc3fa-46fe-480d-b400-355e6d80c299" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cc872b8-b7b7-47c2-8b41-c9cfdc0dc7cf", "AQAAAAIAAYagAAAAEKor8FE6+24/2lbBaJC64w74TzXvWCTX4KyWT/fAA7kMbDfC12tRsBX/vZq29NCidg==", "6c1b297b-6f0c-4726-b259-43be11355342" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9388836-7fad-47f0-89e1-f99665f2e861", "AQAAAAIAAYagAAAAEMKU6WgTFcLRj3sh/hkOdFbRT2FdmEtqtdmGVkoZW5xqDFY9h3YRjasgPYu+/DidrQ==", "16dea4f7-3e96-4365-a77c-0d96e885ed29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "704993d3-0916-434c-b481-6f4d60c29de1", "AQAAAAIAAYagAAAAEIDOHC+OmWOAeZPlNZKR/lhoLGeiZxk6qCTcLnmtQXUJbnPlbHUnzdaCDoPlkRov5A==", "b2f2f316-a3b8-47ba-854f-b665e00e0cca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcf7d8d9-1f47-4f63-b744-582bcbd890ee", "AQAAAAIAAYagAAAAEEGgn7EQ+fA+LV4R/+crXUiv7dTZZQPccgw2r4hw3SVj//8LDvvZHa/+BOS4rFCb1A==", "2644b21c-0a4d-4ecd-8943-db78ca1eb58b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94d88e80-5731-4288-be8f-c1d2f870c466", "AQAAAAIAAYagAAAAEO23UwHfK8GemE4+U2zsE0HhxCZsFi6zqOui2DXmOYAaZchE8voblY1ffxciJPjzMg==", "df9111f3-c786-4a85-b91f-a7f6fe8ec9c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ac14813-12b3-422b-ac6d-417bd10b2ada", "AQAAAAIAAYagAAAAEKLeXRdRtIktE0eouaQ8KvYszGeUw1veTs1JT197pM3bbORPKG3w85aIiSojQCL3aQ==", "49853de4-efa5-4724-bf7f-a3e1a61c7bb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a09f6ef-2146-41da-abd0-2d82f31dfee2", "AQAAAAIAAYagAAAAEE312Xk3siOcR50nuDzy9jNg434wBgI3FlqOYD1iGFZgoNxWSUzODrh5j4Y4QMoAng==", "102e47e4-6935-4887-8e9b-7106d599ba2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58099acb-40bf-4ed7-adcc-73a0e5b9afac", "AQAAAAIAAYagAAAAELSDZZYArqLdoH7hSH8RsBe3mbUsM5JLNpOyHDG8CNyFSbgZk4C3MnjyyctHzT+ZtQ==", "5cca3bc5-5fe2-4f5c-9235-57fae3edab92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "707ed7d6-3ec2-4b73-bf6a-8731800e22ad", "AQAAAAIAAYagAAAAECzGolE2XewP6uxTsLhrbn3B55VKNGkbh/cDs7FkfTKSsBBaqABOZPrWErZ5a9dhzQ==", "ff65ac3d-d0a1-4eb7-973f-c85e37aaf012" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b314a796-4c7b-4324-b24c-565d8eae171e", "AQAAAAIAAYagAAAAEMfD+PD0SBoXc62QrzDIGXJrD46+C3vGZeBHyH21stF5BSbC9cm8ktlSjuKhiYLt/A==", "b5fbbc8e-4f0a-4634-b3b5-3e6ff382e3c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f951a01b-d2e3-4294-9520-13ff999c13c3", "AQAAAAIAAYagAAAAEOs7aExNUuyCzowRh7s0kozyWKdDp3z6V+aajjVogGuDZIK7szqDl0b8c2Np+v5uYQ==", "d2f05fba-16db-48a6-a178-5870f0e9c4a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6d76936-b4c7-46e9-80a1-6691fd3d5785", "AQAAAAIAAYagAAAAEObmVNA92b3CEkXWhXWsNy/iMHPDpiyUZBqT56KC/oYCYauly0ZriupQsKxZ3P6+vA==", "80e9a68e-eb1d-45cb-a000-746f6ac73913" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "888352a7-55c7-4df6-acb3-c189ce3e67d7", "AQAAAAIAAYagAAAAEGzvvL9LH1EzxvhP/rzZmgOfx7+WXYp3ZQHveshBtrOtTdVFtAY9Q8qao1VMnJiyfw==", "3bccf4f4-d0b5-4614-9a36-7748808d5d76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98d929b8-13e7-4f9e-90f8-98961171a28f", "AQAAAAIAAYagAAAAEMt3QqLry5wy+mwmHCOOScDlN3CuZSqx4ALfKSn/vDkaU00qQ/lVWXPJS26I5YIKvw==", "726cb46d-b77f-4ac0-b681-9319b38424cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "239396b3-68d4-4709-abac-c62d82bf273c", "AQAAAAIAAYagAAAAEFaN5fYRmtnys68/KZpMrtVjbwrW1jno52puVmw3+aaBnI+LtpEqW041iBv58GIzKw==", "acf1ccb4-0128-4e3a-b660-91ccb9a4b348" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c89e750e-815f-4259-b661-2ae7c47cc0ab", "AQAAAAIAAYagAAAAEOZJXJ+cgxJy2bthmCW6IGBXm1CG+unYYW0CXV2000/Y2I4LUBDUTcZHrWWzyNzAsQ==", "7876f856-a886-417e-8b07-a64dbc9ac5b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-020",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2b09ff9-831c-4838-b700-d5da3f55da8f", "AQAAAAIAAYagAAAAEPshxvAU42MheZJmr6zeTYcZ6fRwMdkCuYL0lXxrpt69CR2Q3qP0dperJ+nBSfLFbA==", "982a662f-21b4-4173-b27a-d5d62b0de9a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-021",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d19ca8b-c6a5-4f60-a41c-6b4cd9881874", "AQAAAAIAAYagAAAAEI74klgDIlT+zaZ17cFztapMY3ip29XHNZ+OIrz/ejM1UFoMa5b47xw4SNZG7mx/XQ==", "f609e417-0a24-47ea-bd88-b2b764fa0dca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c48db150-2963-4757-b0e7-a089414c1142", "AQAAAAIAAYagAAAAEPPBUpNtsS3GLgIIzZWd0PMsxU7a1Y5BECJuOLPVU7aOWRmEvzgiN3Jjj1M+BzG+rw==", "5c7de3cc-cf49-4209-a5f4-f879a52c60c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-023",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12e642ee-4fed-4df6-8341-337322b1036c", "AQAAAAIAAYagAAAAEBu9LH63NuuKBZ+1zw1LlwNjfwQYcpcVVvpNZ3ArDGzyiSZKAqfu6qum+OYVmYsJWA==", "4ada1399-570a-482e-b4da-48267e03e8f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-024",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "997fe8dd-0372-4f75-999c-88194cc5279c", "AQAAAAIAAYagAAAAEKpLu/GX6GIbw9Mc68uypucKoDlrbafpAbnF0imrjZGCyZmvkGLRFFIjXUtvjYbisg==", "68ea9c54-cf5e-4e26-942d-341c9c9c57fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-025",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc294d57-d94d-4115-9749-2ec5de36465b", "AQAAAAIAAYagAAAAEBy1PJwR6/ag7bufYo3s8x3vJMmH/ZaN5w0gDF1z5tfKfOZusOK6kcC9TlhnBqL4AQ==", "2b1cfb5c-fa15-4506-be9d-df1d77df15f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-026",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c521e58-6c35-4253-bff2-d84d23b943f7", "AQAAAAIAAYagAAAAEFjzpjpF7DvjMD/zDm5CA2rfRSpWnOzEz3qFpOPLasbPOV1NtHQdLbJm1IdS61qCVQ==", "5c047cd2-742e-45ad-81c0-30f3a8eaab8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7b2414a-7944-4d11-87bb-5b276a6cfa77", "AQAAAAIAAYagAAAAEFEB64cnDPWqifzbgzWdINbo8BeWcF1bY3F4BPqf+d18++FS8UFlkMdz1/lpN8Bl0w==", "5db91b7f-6a98-456d-bae8-3975af429888" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-028",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b33339fe-98f9-4da9-954b-41426eb784c6", "AQAAAAIAAYagAAAAEKaQsnbW5Sng1VQs4QTUdPIpqhEwbAs7jaPsNwkRKBgW0Uc78U54vKm28UZzai9oMw==", "650ca4b0-b86a-42af-9416-2053ecad6cd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-029",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd9e9d66-aab4-4703-a8d1-7c23c97cd769", "AQAAAAIAAYagAAAAENLsL8kxnjvVCNn6y5vtomEkskSsbSfeMl9i0iXeKDUIzZZqE89vs1Bwy14D7qltOg==", "bea4cf16-fa96-4f60-842d-a44f12e62d64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-030",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfe57dbc-4e46-4bba-ab80-e0ac75e98454", "AQAAAAIAAYagAAAAEFcKhdTwDiaYEaq9FBvAhN1BC4GJjfG7J64TpU/oH/5Usdk4fIYVNCEKj20kgYC7Lg==", "a24a738b-f69a-4a5a-b5cc-50b6e6e5ffbc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
