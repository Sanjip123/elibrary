//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class product_image
    {
        public int Img_id { get; set; }
        public int Pro_id { get; set; }
        public string Img_path { get; set; }
    
        public virtual product_table product_table { get; set; }
    }
}
