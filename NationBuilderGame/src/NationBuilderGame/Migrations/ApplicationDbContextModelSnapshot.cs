using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using NationBuilderGame.Models;

namespace NationBuilderGame.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("NationBuilderGame.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("NationBuilderGame.Models.Economy", b =>
                {
                    b.Property<int>("EconomyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CapitalModifier");

                    b.Property<string>("Description");

                    b.Property<int>("NationId");

                    b.Property<int>("PopulationModifier");

                    b.Property<int>("ResourceModifier");

                    b.Property<int>("StabilityModifier");

                    b.Property<string>("Type");

                    b.Property<string>("UserId");

                    b.HasKey("EconomyId");

                    b.HasAnnotation("Relational:TableName", "Economies");
                });

            modelBuilder.Entity("NationBuilderGame.Models.Geography", b =>
                {
                    b.Property<int>("GeographyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CapitalModifier");

                    b.Property<string>("Description");

                    b.Property<int>("NationId");

                    b.Property<int>("PopulationModifier");

                    b.Property<int>("ResourceModifier");

                    b.Property<int>("StabilityModifier");

                    b.Property<string>("Type");

                    b.Property<string>("UserId");

                    b.HasKey("GeographyId");

                    b.HasAnnotation("Relational:TableName", "Geographies");
                });

            modelBuilder.Entity("NationBuilderGame.Models.Government", b =>
                {
                    b.Property<int>("GovernmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CapitalModifier");

                    b.Property<string>("Description");

                    b.Property<int>("NationId");

                    b.Property<int>("PopulationModifier");

                    b.Property<int>("ResourceModifier");

                    b.Property<int>("StabilityModifier");

                    b.Property<string>("Type");

                    b.Property<string>("UserId");

                    b.HasKey("GovernmentId");

                    b.HasAnnotation("Relational:TableName", "Goverments");
                });

            modelBuilder.Entity("NationBuilderGame.Models.Nation", b =>
                {
                    b.Property<int>("NationId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capital");

                    b.Property<string>("Name");

                    b.Property<int>("Population");

                    b.Property<float>("Stability");

                    b.Property<string>("UserId");

                    b.HasKey("NationId");

                    b.HasAnnotation("Relational:TableName", "Nations");
                });

            modelBuilder.Entity("NationBuilderGame.Models.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Iron");

                    b.Property<int>("NationId");

                    b.Property<int>("Oil");

                    b.Property<int>("Timber");

                    b.Property<string>("UserId");

                    b.HasKey("ResourceId");

                    b.HasAnnotation("Relational:TableName", "Resources");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("NationBuilderGame.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("NationBuilderGame.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("NationBuilderGame.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("NationBuilderGame.Models.Economy", b =>
                {
                    b.HasOne("NationBuilderGame.Models.Nation")
                        .WithOne()
                        .HasForeignKey("NationBuilderGame.Models.Economy", "NationId");

                    b.HasOne("NationBuilderGame.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("NationBuilderGame.Models.Geography", b =>
                {
                    b.HasOne("NationBuilderGame.Models.Nation")
                        .WithOne()
                        .HasForeignKey("NationBuilderGame.Models.Geography", "NationId");

                    b.HasOne("NationBuilderGame.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("NationBuilderGame.Models.Government", b =>
                {
                    b.HasOne("NationBuilderGame.Models.Nation")
                        .WithOne()
                        .HasForeignKey("NationBuilderGame.Models.Government", "NationId");

                    b.HasOne("NationBuilderGame.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("NationBuilderGame.Models.Nation", b =>
                {
                    b.HasOne("NationBuilderGame.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("NationBuilderGame.Models.Resource", b =>
                {
                    b.HasOne("NationBuilderGame.Models.Nation")
                        .WithOne()
                        .HasForeignKey("NationBuilderGame.Models.Resource", "NationId");

                    b.HasOne("NationBuilderGame.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}
