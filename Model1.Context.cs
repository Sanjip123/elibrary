﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace elibrary
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities3 : DbContext
    {
        public Entities3()
            : base("name=Entities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_order_table> C_order_table { get; set; }
        public virtual DbSet<categories_table> categories_tables { get; set; }
        public virtual DbSet<order_detail> order_details { get; set; }
        public virtual DbSet<product_image> product_images { get; set; }
        public virtual DbSet<product_table> product_tables { get; set; }
        public virtual DbSet<user_table> user_tables { get; set; }
    }
}
