//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tb_orderdetail
    {
        public int id { get; set; }
        public string OrderDetailId { get; set; }
        public string OrderId { get; set; }
        public int BookId { get; set; }
        public int ordermount { get; set; }
        public string poststatus { get; set; }
        public string Recevstatus { get; set; }
        public decimal sigletotalprice { get; set; }
    }
}
