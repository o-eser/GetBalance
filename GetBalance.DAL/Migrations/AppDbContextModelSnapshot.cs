﻿// <auto-generated />
using System;
using GetBalance.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GetBalance.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FoodMeal", b =>
                {
                    b.Property<int>("FoodsFoodId")
                        .HasColumnType("int");

                    b.Property<int>("MealsMealId")
                        .HasColumnType("int");

                    b.HasKey("FoodsFoodId", "MealsMealId");

                    b.HasIndex("MealsMealId");

                    b.ToTable("FoodMeal");
                });

            modelBuilder.Entity("GetBalance.DATA.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodId"), 1L, 1);

                    b.Property<decimal>("Calories")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Carbohydrate")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("Fat")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Protein")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("FoodId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("GetBalance.DATA.FoodCategory", b =>
                {
                    b.Property<int>("FoodCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodCategoryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FoodCategoryId");

                    b.ToTable("FoodCategories");
                });

            modelBuilder.Entity("GetBalance.DATA.Meal", b =>
                {
                    b.Property<int>("MealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MealType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MealId");

                    b.HasIndex("UserId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("GetBalance.DATA.Portion", b =>
                {
                    b.Property<int>("PortionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PortionId"), 1L, 1);

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int>("PortionName")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("PortionId");

                    b.HasIndex("FoodId", "PortionName")
                        .IsUnique();

                    b.ToTable("Portions");
                });

            modelBuilder.Entity("GetBalance.DATA.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnOrder(1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasColumnOrder(2);

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GetBalance.DATA.UserDetail", b =>
                {
                    b.Property<int>("UserDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserDetailId"), 1L, 1);

                    b.Property<int>("ActivityLevel")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CurrentWeight")
                        .HasColumnType("decimal(4,2)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(4,2)");

                    b.Property<double>("HipCircumference")
                        .HasColumnType("float");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("NeckCircumference")
                        .HasColumnType("float");

                    b.Property<int>("TrainingLevel")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<double>("WaistCircumference")
                        .HasColumnType("float");

                    b.HasKey("UserDetailId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("GetBalance.DATA.UserTarget", b =>
                {
                    b.Property<int>("UserTargetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserTargetId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("StartingWeight")
                        .HasColumnType("decimal(4,2)");

                    b.Property<short>("TargetCalorie")
                        .HasMaxLength(5)
                        .HasColumnType("smallint");

                    b.Property<decimal>("TargetCarbPercentage")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("TargetFatPercentage")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("TargetProteinPercentage")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("TargetWeight")
                        .HasColumnType("decimal(4,2)");

                    b.Property<int>("UserDetailId")
                        .HasColumnType("int");

                    b.HasKey("UserTargetId");

                    b.HasIndex("UserDetailId")
                        .IsUnique();

                    b.ToTable("UserTargets");
                });

            modelBuilder.Entity("FoodMeal", b =>
                {
                    b.HasOne("GetBalance.DATA.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodsFoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GetBalance.DATA.Meal", null)
                        .WithMany()
                        .HasForeignKey("MealsMealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GetBalance.DATA.Food", b =>
                {
                    b.HasOne("GetBalance.DATA.FoodCategory", "FoodCategory")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodCategory");
                });

            modelBuilder.Entity("GetBalance.DATA.Meal", b =>
                {
                    b.HasOne("GetBalance.DATA.User", "User")
                        .WithMany("Meals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("GetBalance.DATA.Portion", b =>
                {
                    b.HasOne("GetBalance.DATA.Food", "Food")
                        .WithMany("Portions")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");
                });

            modelBuilder.Entity("GetBalance.DATA.UserDetail", b =>
                {
                    b.HasOne("GetBalance.DATA.User", "User")
                        .WithOne("UserDetail")
                        .HasForeignKey("GetBalance.DATA.UserDetail", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("GetBalance.DATA.UserTarget", b =>
                {
                    b.HasOne("GetBalance.DATA.UserDetail", "UserDetail")
                        .WithOne("UserTarget")
                        .HasForeignKey("GetBalance.DATA.UserTarget", "UserDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDetail");
                });

            modelBuilder.Entity("GetBalance.DATA.Food", b =>
                {
                    b.Navigation("Portions");
                });

            modelBuilder.Entity("GetBalance.DATA.FoodCategory", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("GetBalance.DATA.User", b =>
                {
                    b.Navigation("Meals");

                    b.Navigation("UserDetail")
                        .IsRequired();
                });

            modelBuilder.Entity("GetBalance.DATA.UserDetail", b =>
                {
                    b.Navigation("UserTarget")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
