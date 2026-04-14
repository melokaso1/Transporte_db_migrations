using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace ejercicio_5.Migrations
{
    /// <inheritdoc />
    public partial class MigrationTest1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    iso_code = table.Column<string>(type: "char(3)", nullable: false),
                    name = table.Column<string>(type: "varchar(60)", nullable: false),
                    phone_code = table.Column<string>(type: "varchar(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DocumentCategory",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentCategory", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DocumentStatus",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentStatus", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonStatus",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonStatus", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StatusBids",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusBids", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StatusLoads",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusLoads", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Type_loads",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_loads", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TypeVehicles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    capacity_kg = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    axles = table.Column<int>(type: "int", nullable: false),
                    capacity_m3 = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeVehicles", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StatesOrRegions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(60)", nullable: false),
                    country_id = table.Column<int>(type: "int", nullable: false),
                    code = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatesOrRegions", x => x.id);
                    table.ForeignKey(
                        name: "FK_StatesOrRegions_Countries_country_id",
                        column: x => x.country_id,
                        principalTable: "Countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TypeDocuments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeDocuments", x => x.id);
                    table.ForeignKey(
                        name: "FK_TypeDocuments_DocumentCategory_category_id",
                        column: x => x.category_id,
                        principalTable: "DocumentCategory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CitiesOrMunicipalities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(60)", nullable: false),
                    statereg_id = table.Column<int>(type: "int", nullable: false),
                    code = table.Column<string>(type: "varchar(10)", nullable: false),
                    coordinates = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitiesOrMunicipalities", x => x.id);
                    table.ForeignKey(
                        name: "FK_CitiesOrMunicipalities_StatesOrRegions_statereg_id",
                        column: x => x.statereg_id,
                        principalTable: "StatesOrRegions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "varchar(60)", nullable: false),
                    last_name = table.Column<string>(type: "varchar(60)", nullable: false),
                    phone = table.Column<string>(type: "varchar(15)", nullable: false),
                    city_id = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "date", nullable: false),
                    person_status_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.id);
                    table.ForeignKey(
                        name: "FK_Persons_CitiesOrMunicipalities_city_id",
                        column: x => x.city_id,
                        principalTable: "CitiesOrMunicipalities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_PersonStatus_person_status_id",
                        column: x => x.person_status_id,
                        principalTable: "PersonStatus",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Costumers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    person_id = table.Column<int>(type: "int", nullable: false),
                    is_frequent = table.Column<bool>(type: "boolean(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Costumers_Persons_person_id",
                        column: x => x.person_id,
                        principalTable: "Persons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    person_id = table.Column<int>(type: "int", nullable: false),
                    license_category = table.Column<string>(type: "varchar(50)", nullable: false),
                    experience_years = table.Column<int>(type: "int", nullable: false),
                    is_aviable = table.Column<bool>(type: "boolean(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Drivers_Persons_person_id",
                        column: x => x.person_id,
                        principalTable: "Persons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    plate = table.Column<string>(type: "varchar(50)", nullable: false),
                    type_vehicle_id = table.Column<int>(type: "int", nullable: false),
                    brand = table.Column<string>(type: "varchar(50)", nullable: false),
                    model = table.Column<string>(type: "varchar(50)", nullable: false),
                    year = table.Column<string>(type: "varchar(4)", nullable: false),
                    color = table.Column<string>(type: "varchar(50)", nullable: false),
                    owner_id = table.Column<int>(type: "int", nullable: false),
                    status_vehicle_id = table.Column<int>(type: "int", nullable: false),
                    chassis_number = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Persons_owner_id",
                        column: x => x.owner_id,
                        principalTable: "Persons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_TypeVehicles_type_vehicle_id",
                        column: x => x.type_vehicle_id,
                        principalTable: "TypeVehicles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_vehicles_status_vehicle_id",
                        column: x => x.status_vehicle_id,
                        principalTable: "vehicles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Loads",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TypeLoadId = table.Column<int>(type: "int", nullable: false),
                    OriginCityId = table.Column<int>(type: "int", nullable: false),
                    DestinationCityId = table.Column<int>(type: "int", nullable: false),
                    OriginAddress = table.Column<string>(type: "text", nullable: false),
                    DestinationAddress = table.Column<string>(type: "text", nullable: false),
                    OriginCords = table.Column<string>(type: "longtext", nullable: true),
                    DestinationCords = table.Column<string>(type: "longtext", nullable: true),
                    WeightTons = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    VolumeM3 = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PickupDate = table.Column<DateTime>(type: "timestamp", nullable: false),
                    OfferedPrice = table.Column<decimal>(type: "decimal(19,2)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loads", x => x.id);
                    table.ForeignKey(
                        name: "FK_Loads_CitiesOrMunicipalities_DestinationCityId",
                        column: x => x.DestinationCityId,
                        principalTable: "CitiesOrMunicipalities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Loads_CitiesOrMunicipalities_OriginCityId",
                        column: x => x.OriginCityId,
                        principalTable: "CitiesOrMunicipalities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Loads_Costumers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Costumers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Loads_StatusLoads_StatusId",
                        column: x => x.StatusId,
                        principalTable: "StatusLoads",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Loads_Type_loads_TypeLoadId",
                        column: x => x.TypeLoadId,
                        principalTable: "Type_loads",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DocumentsDrivers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    driver_id = table.Column<int>(type: "int", nullable: false),
                    type_document_id = table.Column<int>(type: "int", nullable: false),
                    document_number = table.Column<string>(type: "varchar(50)", nullable: false),
                    expiration_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    file_url = table.Column<string>(type: "varchar(255)", nullable: false),
                    document_status_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentsDrivers", x => x.id);
                    table.ForeignKey(
                        name: "FK_DocumentsDrivers_DocumentStatus_document_status_id",
                        column: x => x.document_status_id,
                        principalTable: "DocumentStatus",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DocumentsDrivers_Drivers_driver_id",
                        column: x => x.driver_id,
                        principalTable: "Drivers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DocumentsDrivers_TypeDocuments_type_document_id",
                        column: x => x.type_document_id,
                        principalTable: "TypeDocuments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bids",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid(36)", nullable: false),
                    load_id = table.Column<int>(type: "uuid", nullable: false),
                    driver_id = table.Column<int>(type: "uuid", nullable: false),
                    vehicle_id = table.Column<int>(type: "uuid", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(19,2)", nullable: false),
                    AteToPickup = table.Column<TimeSpan>(type: "time", nullable: false),
                    StatusBidsId = table.Column<int>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bids", x => x.id);
                    table.ForeignKey(
                        name: "FK_Bids_Drivers_driver_id",
                        column: x => x.driver_id,
                        principalTable: "Drivers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bids_Loads_load_id",
                        column: x => x.load_id,
                        principalTable: "Loads",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bids_StatusBids_StatusBidsId",
                        column: x => x.StatusBidsId,
                        principalTable: "StatusBids",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bids_Vehicles_vehicle_id",
                        column: x => x.vehicle_id,
                        principalTable: "Vehicles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_driver_id",
                table: "Bids",
                column: "driver_id");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_load_id",
                table: "Bids",
                column: "load_id");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_StatusBidsId",
                table: "Bids",
                column: "StatusBidsId");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_vehicle_id",
                table: "Bids",
                column: "vehicle_id");

            migrationBuilder.CreateIndex(
                name: "IX_CitiesOrMunicipalities_code",
                table: "CitiesOrMunicipalities",
                column: "code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CitiesOrMunicipalities_statereg_id",
                table: "CitiesOrMunicipalities",
                column: "statereg_id");

            migrationBuilder.CreateIndex(
                name: "IX_Costumers_person_id",
                table: "Costumers",
                column: "person_id");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_iso_code",
                table: "Countries",
                column: "iso_code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DocumentsDrivers_document_status_id",
                table: "DocumentsDrivers",
                column: "document_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentsDrivers_driver_id",
                table: "DocumentsDrivers",
                column: "driver_id");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentsDrivers_type_document_id",
                table: "DocumentsDrivers",
                column: "type_document_id");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_person_id",
                table: "Drivers",
                column: "person_id");

            migrationBuilder.CreateIndex(
                name: "IX_Loads_CustomerId",
                table: "Loads",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Loads_DestinationCityId",
                table: "Loads",
                column: "DestinationCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Loads_OriginCityId",
                table: "Loads",
                column: "OriginCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Loads_StatusId",
                table: "Loads",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Loads_TypeLoadId",
                table: "Loads",
                column: "TypeLoadId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_city_id",
                table: "Persons",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_person_status_id",
                table: "Persons",
                column: "person_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_StatesOrRegions_code",
                table: "StatesOrRegions",
                column: "code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StatesOrRegions_country_id",
                table: "StatesOrRegions",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_TypeDocuments_category_id",
                table: "TypeDocuments",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_owner_id",
                table: "Vehicles",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_status_vehicle_id",
                table: "Vehicles",
                column: "status_vehicle_id");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_type_vehicle_id",
                table: "Vehicles",
                column: "type_vehicle_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bids");

            migrationBuilder.DropTable(
                name: "DocumentsDrivers");

            migrationBuilder.DropTable(
                name: "Loads");

            migrationBuilder.DropTable(
                name: "StatusBids");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "DocumentStatus");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "TypeDocuments");

            migrationBuilder.DropTable(
                name: "Costumers");

            migrationBuilder.DropTable(
                name: "StatusLoads");

            migrationBuilder.DropTable(
                name: "Type_loads");

            migrationBuilder.DropTable(
                name: "TypeVehicles");

            migrationBuilder.DropTable(
                name: "vehicles");

            migrationBuilder.DropTable(
                name: "DocumentCategory");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "CitiesOrMunicipalities");

            migrationBuilder.DropTable(
                name: "PersonStatus");

            migrationBuilder.DropTable(
                name: "StatesOrRegions");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
