﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class oldmansoldgameEntities : DbContext
    {
        public oldmansoldgameEntities()
            : base("name=oldmansoldgameEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Matches> Matches { get; set; }
        public virtual DbSet<MatchQueue> MatchQueue { get; set; }
        public virtual DbSet<Usr> Usr { get; set; }
    }
}