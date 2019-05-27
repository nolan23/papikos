using Microsoft.EntityFrameworkCore.Migrations;

namespace PapiKos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Alamat = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nama = table.Column<string>(nullable: true),
                    NomorTelephone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NamaKos = table.Column<string>(nullable: true),
                    JumlahKamar = table.Column<int>(nullable: false),
                    DeskripsiTambahan = table.Column<string>(nullable: true),
                    Alamat = table.Column<string>(nullable: true),
                    OwnerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kos_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kamar",
                columns: table => new
                {
                    KamarId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Gambar = table.Column<string>(nullable: true),
                    UkuranKamar = table.Column<string>(nullable: true),
                    HargaKamar = table.Column<string>(nullable: true),
                    StatusKamar = table.Column<string>(nullable: true),
                    DeskripsiKamar = table.Column<string>(nullable: true),
                    KosId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kamar", x => x.KamarId);
                    table.ForeignKey(
                        name: "FK_Kamar_Kos_KosId",
                        column: x => x.KosId,
                        principalTable: "Kos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kamar_KosId",
                table: "Kamar",
                column: "KosId");

            migrationBuilder.CreateIndex(
                name: "IX_Kos_OwnerId",
                table: "Kos",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Kamar");

            migrationBuilder.DropTable(
                name: "Kos");

            migrationBuilder.DropTable(
                name: "Owner");
        }
    }
}
