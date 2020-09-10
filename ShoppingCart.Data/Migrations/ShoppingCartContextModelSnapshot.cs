﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingCart.Data.Models;

namespace ShoppingCart.Data.Migrations
{
    [DbContext(typeof(ShoppingCartContext))]
    partial class ShoppingCartContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShoppingCart.Data.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Address3")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<bool?>("IsDelivery")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("ShoppingCart.Data.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CategoryID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ShoppingCart.Data.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnName("OrderID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateShipped")
                        .HasColumnType("datetime");

                    b.Property<string>("Status")
                        .HasColumnType("char(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("money");

                    b.Property<int>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ShoppingCart.Data.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnName("OrderID")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("money");

                    b.Property<int?>("ProductId")
                        .HasColumnName("ProductID")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal?>("SubTotal")
                        .HasColumnType("money");

                    b.HasKey("Id", "OrderId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("ShoppingCart.Data.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .HasColumnName("PaymentID")
                        .HasColumnType("int");

                    b.Property<decimal?>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime?>("DatePayment")
                        .HasColumnType("datetime");

                    b.Property<int>("OrderId")
                        .HasColumnName("OrderID")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentType")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("ShoppingCart.Data.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProductID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnName("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Specification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ShoppingCart.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRegister")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<bool?>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ShoppingCart.Data.Models.Address", b =>
                {
                    b.HasOne("ShoppingCart.Data.Models.User", "User")
                        .WithMany("Address")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Address_User")
                        .IsRequired();
                });

            modelBuilder.Entity("ShoppingCart.Data.Models.Order", b =>
                {
                    b.HasOne("ShoppingCart.Data.Models.User", "User")
                        .WithMany("Order")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Order_User")
                        .IsRequired();
                });

            modelBuilder.Entity("ShoppingCart.Data.Models.OrderDetail", b =>
                {
                    b.HasOne("ShoppingCart.Data.Models.Order", "Order")
                        .WithMany("OrderDetail")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_OrderDetail_Order")
                        .IsRequired();

                    b.HasOne("ShoppingCart.Data.Models.Product", "Product")
                        .WithMany("OrderDetail")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_OrderDetail_Product");
                });

            modelBuilder.Entity("ShoppingCart.Data.Models.Payment", b =>
                {
                    b.HasOne("ShoppingCart.Data.Models.Order", "Order")
                        .WithMany("Payment")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_Payment_Order")
                        .IsRequired();

                    b.HasOne("ShoppingCart.Data.Models.User", "User")
                        .WithMany("Payment")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Payment_User")
                        .IsRequired();
                });

            modelBuilder.Entity("ShoppingCart.Data.Models.Product", b =>
                {
                    b.HasOne("ShoppingCart.Data.Models.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Product_Category")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
