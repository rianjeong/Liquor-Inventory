using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LiquorInventory.Models
{
    public partial class Cocktail
    {
        [Key]
        public int cocktailId { get; set; }

        [Display(Name = "Cocktail Name")]
        public string cocktailName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        [Display(Name = "Cocktail Price")]
        public double cocktailPrice { get; set; }

        public virtual ICollection<Liquor> Liquors{ get; set; }
        
    }
}