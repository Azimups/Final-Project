﻿// <auto-generated />
using C_upsB.DataAccesLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace C_upsB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220517133416_AddBlogTables")]
    partial class AddBlogTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("C_upsB.Models.AboutDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FounderImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FounderStory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntroContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AboutDetails");
                });

            modelBuilder.Entity("C_upsB.Models.AboutImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutLittleImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutMainImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AboutImages");
                });

            modelBuilder.Entity("C_upsB.Models.AboutTexts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutTextFirst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTextSecond")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreHeader")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AboutTexts");
                });

            modelBuilder.Entity("C_upsB.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogDetailImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentHeaderThird")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentHeaderTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InfoCoffe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InfoComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InfoDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntroContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Questions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleEight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleFifth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleFirst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleFourth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSecond")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSeven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleThird")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("preHeader")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("C_upsB.Models.BlogRelated", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BlogRelateds");
                });

            modelBuilder.Entity("C_upsB.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BtnText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeaturedDrinkFirst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeaturedDrinkSecond")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeaturedDrinkThird")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeaturedHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeaderText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("C_upsB.Models.Drink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<double>("Description")
                        .HasColumnType("float");

                    b.Property<string>("InformationHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NutritionalCalories")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NutritionalCholesterol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NutritionalSodium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NutritionalTotalCarbs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NutritionalTotalFat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NutritionalTotalFiber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NutritionalTotalProtein")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NutritionalTotalSugar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeLCalories")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeLCholesterol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeLSodium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeLTotalCarbs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeLTotalFat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeLTotalFiber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeLTotalProtein")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeLTotalSugar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeMCalories")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeMCholesterol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeMSodium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeMTotalCarbs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeMTotalFat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeMTotalFiber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeMTotalProtein")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeMTotalSugar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeSCalories")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeSCholesterol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeSSodium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeSTotalCarbs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeSTotalFat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeSTotalFiber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeSTotalProtein")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeSTotalSugar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeFirst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeSecond")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeThird")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("C_upsB.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ButtonText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Headline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationAddressCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationAddressCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationAddressPostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationAddressState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationHours")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondHeadline")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("C_upsB.Models.Stylish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdHeader")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stylish");
                });

            modelBuilder.Entity("C_upsB.Models.Drink", b =>
                {
                    b.HasOne("C_upsB.Models.Category", "Category")
                        .WithMany("Drinks")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("C_upsB.Models.Category", b =>
                {
                    b.Navigation("Drinks");
                });
#pragma warning restore 612, 618
        }
    }
}
