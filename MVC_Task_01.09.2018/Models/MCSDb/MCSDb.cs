namespace MVC_Task_01._09._2018.Models.MCSDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MCSDb : DbContext
    {
        public MCSDb()
            : base("name=MCSDb")
        {
        }

        public virtual DbSet<newEquipment> newEquipment { get; set; }
        public virtual DbSet<TablesLocation> TablesLocation { get; set; }
        public virtual DbSet<TablesManufacturer> TablesManufacturer { get; set; }
        public virtual DbSet<TablesModel> TablesModel { get; set; }
        public virtual DbSet<TrackServiceHistory> TrackServiceHistory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TablesLocation>()
                .HasMany(e => e.newEquipment)
                .WithRequired(e => e.TablesLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesManufacturer>()
                .HasMany(e => e.newEquipment)
                .WithRequired(e => e.TablesManufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesModel>()
                .HasMany(e => e.newEquipment)
                .WithRequired(e => e.TablesModel)
                .WillCascadeOnDelete(false);
        }
    }
}
