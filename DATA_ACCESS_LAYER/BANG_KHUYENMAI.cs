//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA_ACCESS_LAYER
{
    using System;
    using System.Collections.Generic;
    
    public partial class BANG_KHUYENMAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANG_KHUYENMAI()
        {
            this.BANG_KHACHHANG = new HashSet<BANG_KHACHHANG>();
        }
    
        public string idkhuyenmai { get; set; }
        public string giamgia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANG_KHACHHANG> BANG_KHACHHANG { get; set; }
    }
}