﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ying.BookShop.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookShopEntities : DbContext
    {
        public BookShopEntities()
            : base("name=BookShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_manager> tb_manager { get; set; }
        public virtual DbSet<tb_bookinfo> tb_bookinfo { get; set; }
        public virtual DbSet<tb_booktypeinfo> tb_booktypeinfo { get; set; }
        public virtual DbSet<tb_comment> tb_comment { get; set; }
        public virtual DbSet<tb_customerinfo> tb_customerinfo { get; set; }
        public virtual DbSet<tb_order> tb_order { get; set; }
        public virtual DbSet<tb_orderdetail> tb_orderdetail { get; set; }
        public virtual DbSet<tb_parameter> tb_parameter { get; set; }
        public virtual DbSet<tb_reply> tb_reply { get; set; }
        public virtual DbSet<tb_shopbook> tb_shopbook { get; set; }
    }
}
