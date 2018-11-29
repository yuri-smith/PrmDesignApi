using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrmDesignApi.Models.CRM;
using PrmDesignApi.Models.WareHouse;
using PrmDesignApi.Models.Design;

namespace PrmDesignApi.Models
{
    public class PrmDesignContext : DbContext
    {
        public PrmDesignContext(DbContextOptions<PrmDesignContext> options)
            : base(options)
        { }
        public PrmDesignContext() { }

        public DbSet<Dim> Dims { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyProfile> CompanyProfiles { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<CompanyRelation> CompanyRelations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Ware> Wares { get; set; }
        public DbSet<WaresSeller> WaresSellers { get; set; }
        public DbSet<Airbill> Airbills { get; set; }
        public DbSet<AirbillRow> AirbillRows { get; set; }
        public DbSet<PrmDesignApi.Models.WareHouse.Action> Actions { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<ProductParameterValue> ProductParameterValues { get; set; }
        public DbSet<ProductTypeParameter> ProductTypeParameters { get; set; }
        public DbSet<Combination> Combinations { get; set; }
        public DbSet<CombinationParameter> CombinationParameters { get; set; }
        public DbSet<CombinationWare> CombinationWares { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet <UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //https://stackoverflow.com/questions/49219379/ef-core-two-one-to-one-on-one-principal-key
            //class EntityA
            //{
            //    Guid Id { get; set; }
            //    EntityB Property1 { get; set; }
            //    EntityB Property2 { get; set; }
            //    int Property1Id { get; set; }    //New
            //    int Property2Id { get; set; }    //New
            //}

            //class EntityB
            //{
            //    int Id { get; set; }
            //    //Removed EntityA property
            //}

            //modelBuilder.Entity<EntityA>()
            //    .HasOne<EntityB>(a => a.Property1)
            //    .WithOne()    //No navigation property in EntityB
            //    .HasForeignKey<EntityA>(a => a.Property1Id);

            //modelBuilder.Entity<EntityA>()
            //    .HasOne<EntityB>(a => a.Property2)
            //    .WithOne()    //No navigation property in EntityB
            //    .HasForeignKey<EntityA>(a => a.Property2Id);

            modelBuilder.Entity<CompanyProfile>()
                .HasOne<Address>(pf => pf.LegalAddress)
                .WithOne()    //No navigation property in Address
                .HasForeignKey<CompanyProfile>(pf => pf.LegalAddressId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CompanyProfile>()
                .HasOne<Address>(pf => pf.ActualAddress)
                .WithOne()    //No navigation property in Address
                .HasForeignKey<CompanyProfile>(pf => pf.ActualAddressId)
                .OnDelete(DeleteBehavior.Restrict);

            //https://stackoverflow.com/questions/39728016/self-referencing-many-to-many-relations
            //public class Ticket
            //{
            //    public int Id { get; set; }
            //    public string Title { get; set; }

            //    public virtual ICollection<Relation> RelatedTo { get; set; }
            //    public virtual ICollection<Relation> RelatedFrom { get; set; }
            //}

            //public class Relation
            //{
            //    public int FromId { get; set; }
            //    public int ToId { get; set; }

            //    public virtual Ticket TicketFrom { get; set; }
            //    public virtual Ticket TicketTo { get; set; }
            //}

            //modelBuilder.Entity<Relation>()
            //    .HasKey(e => new { e.FromId, e.ToId });

            //modelBuilder.Entity<Relation>()
            //    .HasOne(e => e.TicketFrom)
            //    .WithMany(e => e.RelatedTo)
            //    .HasForeignKey(e => e.FromId);

            //modelBuilder.Entity<Relation>()
            //    .HasOne(e => e.TicketTo)
            //    .WithMany(e => e.RelatedFrom)
            //    .HasForeignKey(e => e.ToId);

            modelBuilder.Entity<CompanyRelation>()
                    .HasKey(cr => new { cr.SellerId, cr.ShopperId });
            modelBuilder.Entity<CompanyRelation>()
                .HasOne(cr => cr.Seller)
                .WithMany(c => c.Sellers)
                .HasForeignKey(cr => cr.SellerId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CompanyRelation>()
                .HasOne(cr => cr.Shopper)
                .WithMany(c => c.Shoppers)
                .HasForeignKey(cr => cr.ShopperId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Seller)
                .WithMany(c => c.OrdersAsSeller)
                .HasForeignKey(o => o.SellerId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Shopper)
                .WithMany(c => c.OredersAsShopper)
                .HasForeignKey(o => o.ShopperId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<WaresSeller>()
                .HasKey(ws => new { ws.WareId, ws.SellerId });
            //modelBuilder.Entity<WaresSeller>()
            //    .HasOne(ws => ws.Seller)
            //    .WithMany(w => w.Sellers)
            //    .HasForeignKey(ws => ws.SellerId);
            //modelBuilder.Entity<WaresSeller>()
            //    .HasOne(ws => ws.Ware)
            //    .WithMany(cmp => cmp.
            //    .HasForeignKey(ws => ws.WareId);

            modelBuilder.Entity<Airbill>()
                .HasOne(o => o.Seller)
                .WithMany(c => c.AirbillsAsSeller)
                .HasForeignKey(o => o.SellerId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Airbill>()
                .HasOne(o => o.Shopper)
                .WithMany(c => c.AirbillsAsShopper)
                .HasForeignKey(o => o.ShopperId)
                .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Company>()
            //    .HasAlternateKey(c => c.INN);

            modelBuilder.Entity<ProductParameterValue>()
                .HasKey(ppv => new { ppv.ProductId, ppv.ParameterId });

            modelBuilder.Entity<ProductTypeParameter>()
                .HasKey(ptp => new { ptp.ProductTypeId, ptp.ParameterId });

            modelBuilder.Entity<CombinationParameter>()
                .HasKey(cp => new { cp.CombinationId, cp.ParameterId });
        }

    }
}
