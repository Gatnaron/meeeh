﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace meeeh
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SmartStoreEntities1 : DbContext
    {
        public SmartStoreEntities1()
            : base("name=SmartStoreEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HomeAssistant> HomeAssistants { get; set; }
        public virtual DbSet<Lamp> Lamps { get; set; }
        public virtual DbSet<Lock> Locks { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Socket> Sockets { get; set; }
        public virtual DbSet<Termostat> Termostats { get; set; }
    }
}
