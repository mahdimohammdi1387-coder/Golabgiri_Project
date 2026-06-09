using Golabgiri.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Glabgiri.DAL.Context
{
    public class AraghijatDbContext: DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<ActivitiesItem> ActivitiesItems { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<ProductUnit> ProductUnits { get; set; }
        public virtual DbSet<Production> Production { get; set; }
        public virtual DbSet<Login> Login { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Index
            modelBuilder.Entity<Product>()
                .HasIndex(p => p.ProductName);
            modelBuilder.Entity<Transaction>()
                .HasIndex(x => x.CustomerId);
            modelBuilder.Entity<Transaction>()
                .HasIndex(x => x.Date);
            modelBuilder.Entity<Customer>()
                .HasIndex(x=> new { x.Name , x.Family });
            modelBuilder.Entity<Customer>()
                .HasIndex(p => p.PhoneNumber).IsUnique();
            modelBuilder.Entity<Production>()
               .HasIndex(x => x.ProductId);
            modelBuilder.Entity<Production>()
                .HasIndex(x => x.Date);
            modelBuilder.Entity<Payment>()
               .HasIndex(x => x.TransactionId);
            modelBuilder.Entity<Payment>()
                .HasIndex(x => x.Date);
            modelBuilder.Entity<ActivitiesItem>()
               .HasIndex(x => x.ActivityId);
            modelBuilder.Entity<ActivitiesItem>()
                .HasIndex(x => x.ProductId);
            #endregion
            #region Relations
            modelBuilder.Entity<Payment>()
             .HasRequired(p => p.transaction)
             .WithMany(b => b.Payment)
             .HasForeignKey(p => p.TransactionId)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<ActivitiesItem>()
                .HasRequired(p => p.Product)
                .WithMany(b => b.ActivitiesItem)
                .HasForeignKey(p => p.ProductId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<ActivitiesItem>()
               .HasRequired(p => p.Transaction)
               .WithMany(b => b.ActivitiesItem)
               .HasForeignKey(p => p.ActivityId)
               .WillCascadeOnDelete(false);
            modelBuilder.Entity<ActivitiesItem>()
              .HasRequired(p => p.Production)
              .WithMany(b => b.ActivitiesItem)
              .HasForeignKey(p => p.ActivityId)
              .WillCascadeOnDelete(false);
            modelBuilder.Entity<ActivitiesItem>()
              .HasRequired(p => p.ProductUnit)
              .WithMany(b => b.ActivitiesItem)
              .HasForeignKey(p => p.ProductUnitId)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
              .HasRequired(p => p.ProductUnit)
              .WithMany(b => b.Product)
              .HasForeignKey(p => p.ProductUnitId)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Production>()
              .HasRequired(p => p.Product)
              .WithMany(b => b.Production)
              .HasForeignKey(p => p.ProductId)
              .WillCascadeOnDelete(false);
            modelBuilder.Entity<Production>()
              .HasRequired(p => p.ProductUnit)
              .WithMany(b => b.Production)
              .HasForeignKey(p => p.ProductUnitId)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction>()
                .HasRequired(p => p.Customer)
                .WithMany(b => b.Transaction)
                .HasForeignKey(p => p.CustomerId)
                .WillCascadeOnDelete(false);
            #endregion
            #region PropertyType
            modelBuilder.Entity<Transaction>()
                .Property(p => p.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Production>()
                .Property(p => p.TotalAmount)
                .HasPrecision(19, 4);
            modelBuilder.Entity<Production>()
               .Property(p => p.Value)
               .HasPrecision(19, 4);
            modelBuilder.Entity<Production>()
               .Property(p => p.UnitPrice)
               .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
               .Property(p => p.Value)
               .HasPrecision(19, 4);
            modelBuilder.Entity<Product>()
               .Property(p => p.UnitPrice)
               .HasPrecision(19, 4);

            modelBuilder.Entity<Payment>()
               .Property(p => p.Amount)
               .HasPrecision(19, 4);

            modelBuilder.Entity<Customer>()
               .Property(p => p.Credit)
               .HasPrecision(19, 4);
            modelBuilder.Entity<Customer>()
              .Property(p => p.Debit)
              .HasPrecision(19, 4);

            modelBuilder.Entity<ActivitiesItem>()
               .Property(p => p.TotalAmount)
               .HasPrecision(19, 4);
            modelBuilder.Entity<ActivitiesItem>()
               .Property(p => p.Value)
               .HasPrecision(19, 4);
            modelBuilder.Entity<ActivitiesItem>()
               .Property(p => p.UnitPrice)
               .HasPrecision(19, 4);
            #endregion
            base.OnModelCreating(modelBuilder);
        }

    }
}
