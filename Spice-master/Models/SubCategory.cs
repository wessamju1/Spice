using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        // you can use this to change the display of a property in asp-for 
        //[Display(Name="Category Name ")]
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { set; get; }
    
        [ForeignKey("CategoryId")]
        public virtual Category Category { set; get; }
    
    
    }
}
