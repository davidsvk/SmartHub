﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SmartHub.Infrastructure.Persistence.Database;

namespace SmartHub.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200531203343_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("character varying(50000)")
                        .HasMaxLength(50000);

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SubjectId")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("character varying(50000)")
                        .HasMaxLength(50000);

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SubjectId")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SmartHub.Domain.Entities.Devices.Device", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("GroupId")
                        .HasColumnType("text");

                    b.Property<string>("HomeId")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PluginName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PluginType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PrimaryConnection")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SecondaryConnection")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("HomeId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("SmartHub.Domain.Entities.Groups.Group", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CreatorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("HomeId")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("SmartHub.Domain.Entities.Homes.Home", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Homes");
                });

            modelBuilder.Entity("SmartHub.Domain.Entities.Plugins.Plugin", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("AssemblyFilepath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("AssemblyVersion")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("HomeId")
                        .HasColumnType("text");

                    b.Property<bool>("HttpSupport")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDownloaded")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("MqttSupport")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PluginType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Plugins");
                });

            modelBuilder.Entity("SmartHub.Domain.Entities.Roles.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("SmartHub.Domain.Entities.Settings.Setting", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CreatorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("DownloadServerUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Filepath")
                        .HasColumnType("text");

                    b.Property<string>("HomeId")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PluginPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WatchPathAbsolut")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("SmartHub.Domain.Entities.Users.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("HomeId")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PersonInfo")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("SmartHub.Domain.Entities.Roles.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SmartHub.Domain.Entities.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SmartHub.Domain.Entities.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("SmartHub.Domain.Entities.Roles.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartHub.Domain.Entities.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SmartHub.Domain.Entities.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartHub.Domain.Entities.Devices.Device", b =>
                {
                    b.HasOne("SmartHub.Domain.Entities.Groups.Group", null)
                        .WithMany("Devices")
                        .HasForeignKey("GroupId");

                    b.HasOne("SmartHub.Domain.Entities.Homes.Home", null)
                        .WithMany("Devices")
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("SmartHub.Domain.Entities.Devices.Company", "Company", b1 =>
                        {
                            b1.Property<string>("DeviceId")
                                .HasColumnType("text");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("character varying(200)")
                                .HasMaxLength(200)
                                .HasDefaultValue("");

                            b1.Property<string>("ShortName")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("character varying(4)")
                                .HasMaxLength(4)
                                .HasDefaultValue("");

                            b1.HasKey("DeviceId");

                            b1.ToTable("Devices");

                            b1.WithOwner()
                                .HasForeignKey("DeviceId");
                        });

                    b.OwnsOne("SmartHub.Domain.Entities.Devices.IpAddress", "Ip", b1 =>
                        {
                            b1.Property<string>("DeviceId")
                                .HasColumnType("text");

                            b1.Property<string>("Ipv4")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("character varying(15)")
                                .HasMaxLength(15)
                                .HasDefaultValue("0.0.0.0");

                            b1.HasKey("DeviceId");

                            b1.ToTable("Devices");

                            b1.WithOwner()
                                .HasForeignKey("DeviceId");
                        });
                });

            modelBuilder.Entity("SmartHub.Domain.Entities.Groups.Group", b =>
                {
                    b.HasOne("SmartHub.Domain.Entities.Homes.Home", "Home")
                        .WithMany("Groups")
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SmartHub.Domain.Entities.Homes.Home", b =>
                {
                    b.OwnsOne("SmartHub.Domain.Entities.Homes.Address", "Address", b1 =>
                        {
                            b1.Property<string>("HomeId")
                                .HasColumnType("text");

                            b1.Property<string>("City")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("character varying(100)")
                                .HasMaxLength(100)
                                .HasDefaultValue("");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("character varying(100)")
                                .HasMaxLength(100)
                                .HasDefaultValue("");

                            b1.Property<string>("State")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("character varying(100)")
                                .HasMaxLength(100)
                                .HasDefaultValue("");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("character varying(200)")
                                .HasMaxLength(200)
                                .HasDefaultValue("");

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("character varying(20)")
                                .HasMaxLength(20)
                                .HasDefaultValue("");

                            b1.HasKey("HomeId");

                            b1.ToTable("Homes");

                            b1.WithOwner()
                                .HasForeignKey("HomeId");
                        });
                });

            modelBuilder.Entity("SmartHub.Domain.Entities.Plugins.Plugin", b =>
                {
                    b.HasOne("SmartHub.Domain.Entities.Homes.Home", null)
                        .WithMany("Plugins")
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("SmartHub.Domain.Entities.Devices.Company", "Company", b1 =>
                        {
                            b1.Property<string>("PluginId")
                                .HasColumnType("text");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("character varying(200)")
                                .HasMaxLength(200)
                                .HasDefaultValue("");

                            b1.Property<string>("ShortName")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("character varying(4)")
                                .HasMaxLength(4)
                                .HasDefaultValue("");

                            b1.HasKey("PluginId");

                            b1.ToTable("Plugins");

                            b1.WithOwner()
                                .HasForeignKey("PluginId");
                        });
                });

            modelBuilder.Entity("SmartHub.Domain.Entities.Settings.Setting", b =>
                {
                    b.HasOne("SmartHub.Domain.Entities.Homes.Home", null)
                        .WithMany("Settings")
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SmartHub.Domain.Entities.Users.User", b =>
                {
                    b.HasOne("SmartHub.Domain.Entities.Homes.Home", "Home")
                        .WithMany("Users")
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("SmartHub.Domain.Entities.ValueObjects.PersonName", "PersonName", b1 =>
                        {
                            b1.Property<string>("UserId")
                                .HasColumnType("text");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("character varying(100)")
                                .HasMaxLength(100)
                                .HasDefaultValue("");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("character varying(200)")
                                .HasMaxLength(200)
                                .HasDefaultValue("");

                            b1.Property<string>("MiddleName")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("character varying(100)")
                                .HasMaxLength(100)
                                .HasDefaultValue("");

                            b1.HasKey("UserId");

                            b1.ToTable("AspNetUsers");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}