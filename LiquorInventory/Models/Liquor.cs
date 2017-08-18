using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LiquorInventory.Models
{
    public partial class Liquor
    {
        [Key]
        public int liquorId { get; set; }

        [Display(Name = "Liquor")]
        public string liquorName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        [Display(Name = "Liquor Cost")]
        public double liquorCost { get; set; }

        [Display(Name = "Liquor Inventory")]
        public double liquorInventory { get; set; }

        [Display(Name = "Total Liquor Inventory")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        public double liquorInventoryCost { get { return  liquorCost * liquorInventory; } set { } }

        public virtual ICollection<Cocktail> Cocktails { get; set; }

        
        

    }

    
}