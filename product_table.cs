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
    
    public partial class product_table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product_table()
        {
            this.order_details = new HashSet<order_detail>();
            this.product_image = new HashSet<product_image>();
        }
    
        public int Pro_id { get; set; }
        public string Pro_details { get; set; }
        public decimal Pro_price { get; set; }
        public Nullable<int> Pro_qty { get; set; }
        public string Pro_name { get; set; }
        public Nullable<int> Cat_Id { get; set; }
    
        public virtual categories_table categories_table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_detail> order_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product_image> product_image { get; set; }
    }
}