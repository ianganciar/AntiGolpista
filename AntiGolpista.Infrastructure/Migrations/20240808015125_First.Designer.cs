﻿// <auto-generated />
using System;
using AntiGolpista.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AntiGolpista.Infrastructure.Migrations
{
    [DbContext(typeof(AntiGolpistaDbContext))]
    [Migration("20240808015125_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AntiGolpista.Domain.Entities.Companies.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BannerImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BannerImageUrl");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DocumentImageUrl");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("IsVerified");

                    b.Property<string>("ProfileImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ProfileImageUrl");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.Occurrences.FraudulentOccurrence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OccurrenceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UntrustedPhoneNumberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UntrustedPhoneNumberId");

                    b.ToTable("FraudulentOccurrences");
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.Occurrences.SuspiciousOccurrence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OccurrenceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UntrustedPhoneNumberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UntrustedPhoneNumberId");

                    b.ToTable("SuspiciousOccurrences");
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.Occurrences.TrustedOccurrence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OccurrenceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrustedPhoneNumberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrustedPhoneNumberId");

                    b.ToTable("TrustedOccurrences");
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.PhoneNumbers.TrustedPhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("TrustedPhoneNumbers");
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.PhoneNumbers.UntrustedPhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("untrustedPhoneNumbers");
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.Companies.Company", b =>
                {
                    b.HasOne("AntiGolpista.Domain.Entities.Users.User", "User")
                        .WithMany("Companies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.OwnsOne("AntiGolpista.Domain.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<int>("CompanyId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Name");

                            b1.HasKey("CompanyId");

                            b1.ToTable("Companies");

                            b1.WithOwner()
                                .HasForeignKey("CompanyId");
                        });

                    b.OwnsOne("AntiGolpista.Domain.ValueObjects.PhoneNumber", "SupportPhoneNumber", b1 =>
                        {
                            b1.Property<int>("CompanyId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)")
                                .HasColumnName("SupportPhoneNumber");

                            b1.HasKey("CompanyId");

                            b1.ToTable("Companies");

                            b1.WithOwner()
                                .HasForeignKey("CompanyId");
                        });

                    b.OwnsOne("AntiGolpista.Domain.ValueObjects.Document", "Document", b1 =>
                        {
                            b1.Property<int>("CompanyId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)")
                                .HasColumnName("Document");

                            b1.HasKey("CompanyId");

                            b1.ToTable("Companies");

                            b1.WithOwner()
                                .HasForeignKey("CompanyId");
                        });

                    b.Navigation("Document")
                        .IsRequired();

                    b.Navigation("Name")
                        .IsRequired();

                    b.Navigation("SupportPhoneNumber")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.Occurrences.FraudulentOccurrence", b =>
                {
                    b.HasOne("AntiGolpista.Domain.Entities.PhoneNumbers.UntrustedPhoneNumber", "UntrustedPhoneNumber")
                        .WithMany("FraudulentOcurrences")
                        .HasForeignKey("UntrustedPhoneNumberId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UntrustedPhoneNumber");
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.Occurrences.SuspiciousOccurrence", b =>
                {
                    b.HasOne("AntiGolpista.Domain.Entities.PhoneNumbers.UntrustedPhoneNumber", "UntrustedPhoneNumber")
                        .WithMany("SuspiciousOcurrences")
                        .HasForeignKey("UntrustedPhoneNumberId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UntrustedPhoneNumber");
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.Occurrences.TrustedOccurrence", b =>
                {
                    b.HasOne("AntiGolpista.Domain.Entities.PhoneNumbers.TrustedPhoneNumber", "TrustedPhoneNumber")
                        .WithMany("TrustedOccurrences")
                        .HasForeignKey("TrustedPhoneNumberId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("TrustedPhoneNumber");
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.PhoneNumbers.TrustedPhoneNumber", b =>
                {
                    b.HasOne("AntiGolpista.Domain.Entities.Companies.Company", "Company")
                        .WithMany("TrustedPhonesNumbers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.OwnsOne("AntiGolpista.Domain.ValueObjects.PhoneNumber", "PhoneNumber", b1 =>
                        {
                            b1.Property<int>("TrustedPhoneNumberId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)")
                                .HasColumnName("PhoneNumber");

                            b1.HasKey("TrustedPhoneNumberId");

                            b1.ToTable("TrustedPhoneNumbers");

                            b1.WithOwner()
                                .HasForeignKey("TrustedPhoneNumberId");
                        });

                    b.Navigation("Company");

                    b.Navigation("PhoneNumber")
                        .IsRequired();
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.PhoneNumbers.UntrustedPhoneNumber", b =>
                {
                    b.HasOne("AntiGolpista.Domain.Entities.Companies.Company", "Company")
                        .WithMany("UntrustedPhoneNumbers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.OwnsOne("AntiGolpista.Domain.ValueObjects.PhoneNumber", "PhoneNumber", b1 =>
                        {
                            b1.Property<int>("UntrustedPhoneNumberId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)")
                                .HasColumnName("PhoneNumber");

                            b1.HasKey("UntrustedPhoneNumberId");

                            b1.ToTable("untrustedPhoneNumbers");

                            b1.WithOwner()
                                .HasForeignKey("UntrustedPhoneNumberId");
                        });

                    b.Navigation("Company");

                    b.Navigation("PhoneNumber")
                        .IsRequired();
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.Users.User", b =>
                {
                    b.OwnsOne("AntiGolpista.Domain.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<int>("UserId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Name");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("AntiGolpista.Domain.ValueObjects.PhoneNumber", "PhoneNumber", b1 =>
                        {
                            b1.Property<int>("UserId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)")
                                .HasColumnName("PhoneNumber");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("AntiGolpista.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<int>("UserId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Email");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("Name")
                        .IsRequired();

                    b.Navigation("PhoneNumber")
                        .IsRequired();
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.Companies.Company", b =>
                {
                    b.Navigation("TrustedPhonesNumbers");

                    b.Navigation("UntrustedPhoneNumbers");
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.PhoneNumbers.TrustedPhoneNumber", b =>
                {
                    b.Navigation("TrustedOccurrences");
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.PhoneNumbers.UntrustedPhoneNumber", b =>
                {
                    b.Navigation("FraudulentOcurrences");

                    b.Navigation("SuspiciousOcurrences");
                });

            modelBuilder.Entity("AntiGolpista.Domain.Entities.Users.User", b =>
                {
                    b.Navigation("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}
