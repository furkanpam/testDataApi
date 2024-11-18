using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ConnectionProvider.Domain.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "ExchangeRates",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    result = table.Column<string>(type: "text", nullable: false),
                    documentation = table.Column<string>(type: "text", nullable: false),
                    terms_of_use = table.Column<string>(type: "text", nullable: false),
                    time_last_update_unix = table.Column<long>(type: "bigint", nullable: false),
                    time_last_update_utc = table.Column<string>(type: "text", nullable: false),
                    time_next_update_unix = table.Column<long>(type: "bigint", nullable: false),
                    time_next_update_utc = table.Column<string>(type: "text", nullable: false),
                    base_code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConversionRates",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AED = table.Column<double>(type: "double precision", nullable: true),
                    ARS = table.Column<double>(type: "double precision", nullable: true),
                    AUD = table.Column<double>(type: "double precision", nullable: true),
                    BGN = table.Column<double>(type: "double precision", nullable: true),
                    BRL = table.Column<double>(type: "double precision", nullable: true),
                    BSD = table.Column<double>(type: "double precision", nullable: true),
                    CAD = table.Column<double>(type: "double precision", nullable: true),
                    CHF = table.Column<double>(type: "double precision", nullable: true),
                    CLP = table.Column<double>(type: "double precision", nullable: true),
                    CNY = table.Column<double>(type: "double precision", nullable: true),
                    COP = table.Column<double>(type: "double precision", nullable: true),
                    CZK = table.Column<double>(type: "double precision", nullable: true),
                    DKK = table.Column<double>(type: "double precision", nullable: true),
                    DOP = table.Column<double>(type: "double precision", nullable: true),
                    EGP = table.Column<double>(type: "double precision", nullable: true),
                    EUR = table.Column<double>(type: "double precision", nullable: true),
                    FJD = table.Column<double>(type: "double precision", nullable: true),
                    GBP = table.Column<double>(type: "double precision", nullable: true),
                    GTQ = table.Column<double>(type: "double precision", nullable: true),
                    HKD = table.Column<double>(type: "double precision", nullable: true),
                    HRK = table.Column<double>(type: "double precision", nullable: true),
                    HUF = table.Column<double>(type: "double precision", nullable: true),
                    IDR = table.Column<double>(type: "double precision", nullable: true),
                    ILS = table.Column<double>(type: "double precision", nullable: true),
                    INR = table.Column<double>(type: "double precision", nullable: true),
                    ISK = table.Column<double>(type: "double precision", nullable: true),
                    JPY = table.Column<double>(type: "double precision", nullable: true),
                    KRW = table.Column<double>(type: "double precision", nullable: true),
                    KZT = table.Column<double>(type: "double precision", nullable: true),
                    MXN = table.Column<double>(type: "double precision", nullable: true),
                    MYR = table.Column<double>(type: "double precision", nullable: true),
                    NOK = table.Column<double>(type: "double precision", nullable: true),
                    NZD = table.Column<double>(type: "double precision", nullable: true),
                    PAB = table.Column<double>(type: "double precision", nullable: true),
                    PEN = table.Column<double>(type: "double precision", nullable: true),
                    PHP = table.Column<double>(type: "double precision", nullable: true),
                    PKR = table.Column<double>(type: "double precision", nullable: true),
                    PLN = table.Column<double>(type: "double precision", nullable: true),
                    PYG = table.Column<double>(type: "double precision", nullable: true),
                    RON = table.Column<double>(type: "double precision", nullable: true),
                    RUB = table.Column<double>(type: "double precision", nullable: true),
                    SAR = table.Column<double>(type: "double precision", nullable: true),
                    SEK = table.Column<double>(type: "double precision", nullable: true),
                    SGD = table.Column<double>(type: "double precision", nullable: true),
                    THB = table.Column<double>(type: "double precision", nullable: true),
                    TRY = table.Column<double>(type: "double precision", nullable: true),
                    TWD = table.Column<double>(type: "double precision", nullable: true),
                    UAH = table.Column<double>(type: "double precision", nullable: true),
                    USD = table.Column<double>(type: "double precision", nullable: true),
                    UYU = table.Column<double>(type: "double precision", nullable: true),
                    ZAR = table.Column<double>(type: "double precision", nullable: true),
                    ExchangeRateDataId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConversionRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConversionRates_ExchangeRates_ExchangeRateDataId",
                        column: x => x.ExchangeRateDataId,
                        principalSchema: "public",
                        principalTable: "ExchangeRates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConversionRates_ExchangeRateDataId",
                schema: "public",
                table: "ConversionRates",
                column: "ExchangeRateDataId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConversionRates",
                schema: "public");

            migrationBuilder.DropTable(
                name: "ExchangeRates",
                schema: "public");
        }
    }
}
