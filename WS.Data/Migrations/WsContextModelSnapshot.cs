﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WS.Data.Context;

namespace WS.Data.Migrations
{
    [DbContext(typeof(WsContext))]
    partial class WsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetClient", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Banco")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Orgao")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Server")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("Vencimento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValue(new DateTime(2025, 12, 14, 9, 48, 32, 285, DateTimeKind.Local).AddTicks(7645));

                    b.HasKey("ClientId");

                    b.ToTable("AspNetClient");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetClientMenu", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<bool>("Editar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("Excluir")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("Exibir")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("Inserir")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.HasKey("ClientId", "MenuId");

                    b.HasIndex("MenuId");

                    b.HasIndex("ModuleId");

                    b.ToTable("AspNetClientMenu");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetClientModule", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Vencimento")
                        .HasColumnType("Date");

                    b.HasKey("ClientId", "ModuleId");

                    b.HasIndex("ModuleId");

                    b.ToTable("AspNetClientModule");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetMenu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Menu")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<int>("Ordem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("MenuId");

                    b.HasIndex("ModuleId");

                    b.ToTable("AspNetMenu");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetModule", b =>
                {
                    b.Property<int>("ModuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ImgMenu")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Module")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Ordem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("ModuleId");

                    b.ToTable("AspNetModule");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RoleId")
                        .UseIdentityColumn();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRole");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetRoleMenu", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<bool>("Editar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("Excluir")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("Exibir")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("Inserir")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "MenuId");

                    b.HasIndex("MenuId");

                    b.HasIndex("ModuleId");

                    b.ToTable("AspNetRoleMenu");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetRoleModule", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "ModuleId");

                    b.HasIndex("ModuleId");

                    b.ToTable("AspNetRoleModule");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserId")
                        .UseIdentityColumn();

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUser");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetUserMenu", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<bool>("Editar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("Excluir")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("Exibir")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("Inserir")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "MenuId");

                    b.HasIndex("MenuId");

                    b.HasIndex("ModuleId");

                    b.ToTable("AspNetUserMenu");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetUserModule", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ModuleId");

                    b.HasIndex("ModuleId");

                    b.ToTable("AspNetUserModule");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("WS.Core.Domain.AspNetRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("WS.Core.Domain.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("WS.Core.Domain.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("WS.Core.Domain.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetClientMenu", b =>
                {
                    b.HasOne("WS.Core.Domain.AspNetClient", "aspNetClient")
                        .WithMany("aspNetClientMenus")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WS.Core.Domain.AspNetMenu", "aspNetMenu")
                        .WithMany("aspNetClientMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WS.Core.Domain.AspNetModule", "aspNetModule")
                        .WithMany("aspNetClientMenus")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("aspNetClient");

                    b.Navigation("aspNetMenu");

                    b.Navigation("aspNetModule");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetClientModule", b =>
                {
                    b.HasOne("WS.Core.Domain.AspNetClient", "aspNetClient")
                        .WithMany("aspNetClientModules")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WS.Core.Domain.AspNetModule", "aspNetModule")
                        .WithMany("aspNetClientModules")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aspNetClient");

                    b.Navigation("aspNetModule");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetMenu", b =>
                {
                    b.HasOne("WS.Core.Domain.AspNetModule", "Module")
                        .WithMany("aspNetMenus")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetRoleMenu", b =>
                {
                    b.HasOne("WS.Core.Domain.AspNetMenu", "aspNetMenu")
                        .WithMany("aspNetRoleMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WS.Core.Domain.AspNetModule", "aspNetModule")
                        .WithMany("aspNetRoleMenus")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WS.Core.Domain.AspNetRole", "aspNetRole")
                        .WithMany("aspNetRoleMenus")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aspNetMenu");

                    b.Navigation("aspNetModule");

                    b.Navigation("aspNetRole");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetRoleModule", b =>
                {
                    b.HasOne("WS.Core.Domain.AspNetModule", "aspNetModule")
                        .WithMany("aspNetRoleModules")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WS.Core.Domain.AspNetRole", "aspNetRole")
                        .WithMany("aspNetRoleModule")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aspNetModule");

                    b.Navigation("aspNetRole");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetUserMenu", b =>
                {
                    b.HasOne("WS.Core.Domain.AspNetMenu", "aspNetMenu")
                        .WithMany("aspNetUserMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WS.Core.Domain.AspNetModule", "aspNetModule")
                        .WithMany("aspNetUserMenus")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WS.Core.Domain.AspNetUser", "aspNetUser")
                        .WithMany("aspNetUserMenus")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aspNetMenu");

                    b.Navigation("aspNetModule");

                    b.Navigation("aspNetUser");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetUserModule", b =>
                {
                    b.HasOne("WS.Core.Domain.AspNetModule", "aspNetModule")
                        .WithMany("aspNetUserModules")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WS.Core.Domain.AspNetUser", "aspNetUser")
                        .WithMany("aspNetUserModules")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aspNetModule");

                    b.Navigation("aspNetUser");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetUserRole", b =>
                {
                    b.HasOne("WS.Core.Domain.AspNetRole", "aspNetRole")
                        .WithMany("aspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WS.Core.Domain.AspNetUser", "aspNetUser")
                        .WithMany("aspNetUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aspNetRole");

                    b.Navigation("aspNetUser");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetClient", b =>
                {
                    b.Navigation("aspNetClientMenus");

                    b.Navigation("aspNetClientModules");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetMenu", b =>
                {
                    b.Navigation("aspNetClientMenus");

                    b.Navigation("aspNetRoleMenus");

                    b.Navigation("aspNetUserMenus");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetModule", b =>
                {
                    b.Navigation("aspNetClientMenus");

                    b.Navigation("aspNetClientModules");

                    b.Navigation("aspNetMenus");

                    b.Navigation("aspNetRoleMenus");

                    b.Navigation("aspNetRoleModules");

                    b.Navigation("aspNetUserMenus");

                    b.Navigation("aspNetUserModules");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetRole", b =>
                {
                    b.Navigation("aspNetRoleMenus");

                    b.Navigation("aspNetRoleModule");

                    b.Navigation("aspNetUserRoles");
                });

            modelBuilder.Entity("WS.Core.Domain.AspNetUser", b =>
                {
                    b.Navigation("aspNetUserMenus");

                    b.Navigation("aspNetUserModules");

                    b.Navigation("aspNetUserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
