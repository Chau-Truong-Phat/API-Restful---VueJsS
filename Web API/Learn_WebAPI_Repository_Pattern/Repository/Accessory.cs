//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accessory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accessory()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public string Id { get; set; }
        public string Name { get; set; }
        public System.DateTime GoodsReceiptDate { get; set; }
        public int Inventory { get; set; }
        public double Price { get; set; }
        public string WarrantyTime { get; set; }
        public string CalculationUnit { get; set; }
        public string CPU { get; set; }
        public string ProcessingSpeed { get; set; }
        public string Size { get; set; }
        public string Socket { get; set; }
        public string Chipset { get; set; }
        public string Memory { get; set; }
        public string Version { get; set; }
        public string Bus { get; set; }
        public string BIT { get; set; }
        public string Power { get; set; }
        public int ProducerId { get; set; }
        public string CategoryId { get; set; }
        public string Avatar { get; set; }
        public string Cores { get; set; }
        public string Threads { get; set; }
        public int Status { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Producer Producer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
