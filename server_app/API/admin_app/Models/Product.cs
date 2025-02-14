﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace admin_app.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Comments = new HashSet<Comment>();
            this.Detail_Order = new HashSet<Detail_Order>();
        }
    
        public string id_product { get; set; }

        [Display(Name = "Loại sản phẩm: ")]
        public string id_category { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        [Display(Name = "Tên sản phẩm")]
        public string name_product { get; set; }

        [Required(ErrorMessage = "Giá không được để trống")]
        [Display(Name = "Giá sản phẩm")]
        public string price_product { get; set; }

        

        [Display(Name = "Hình ảnh")]
        [DataType(DataType.Upload)]
        public string image { get; set; }

        [Required(ErrorMessage = "Mô tả không được để trống")]
        [Display(Name = "Mô tả sản phẩm")]
        public string describe { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detail_Order> Detail_Order { get; set; }
    }
}
