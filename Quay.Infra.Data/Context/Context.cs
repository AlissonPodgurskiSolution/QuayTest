﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Quay.Domain.Entities;
using Quay.Infra.Data.EntityConfig;

namespace Quay.Infra.Data.Context
{
    public class Context : DbContext
    {
        public Context()
            : base("QuayDBContext")
        {
        }

        public DbSet<Previsao> Previsoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new PrevisaoConfiguration());
        }
    }
}