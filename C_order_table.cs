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
    
    public partial class C_order_table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_order_table()
        {
            this.order_details = new HashSet<order_detail>();
        }
    
        public int O_id { get; set; }
        public Nullable<System.DateTime> O_date { get; set; }
        public string O_address { get; set; }
        public string O_phone { get; set; }
        public Nullable<decimal> O_total { get; set; }
        public string O_status { get; set; }
        public Nullable<int> U_id { get; set; }
    
        public virtual user_table user_table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_detail> order_details { get; set; }
    }
}