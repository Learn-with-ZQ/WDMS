//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.ORDERS = new HashSet<ORDER>();
            this.Products = new HashSet<Product>();
        }
    
        public int UID { get; set; }
        [Required]
        [DisplayName("Name")]
        public string UName { get; set; }
        [Required]
        [DisplayName("Address")]
        public string UAddress { get; set; }
        [Required]
        [DisplayName("CNIC")]
        public Nullable<long> UCNIC { get; set; }
        [Required]
        [DisplayName("Phone")]
        public Nullable<long> UPhoneNumber { get; set; }
        [Required]
        [DisplayName("Username")]
        public string UUserName { get; set; }
        [Required]
        [DisplayName("Password")]
        public string UPassword { get; set; }
        public Nullable<int> URole { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER> ORDERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
