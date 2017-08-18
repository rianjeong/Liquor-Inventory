using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LiquorInventory.Models
{
    public partial class MonthlyCost
    {
        [Key]
        public int MonthlyCostId { get; set; }
        public string Month { get; set; }

        [Display(Name = "Current Inventory Total")]
        public double CurrentInventoryCost { get; set; }

        [Display(Name = "Previous Month")]
        public string PreviousMonth { get; set; }

        [Display(Name = "Previous Month Inventory Total")]
        public double PreviousInventoryCost { get; set; }

        [Display(Name = "Monthly Sales")]
        public double MonthlySales { get; set; }

        public double Difference { get { return CurrentInventoryCost - PreviousInventoryCost; } set { } }

        [Display(Name = "Pour Cost")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:P}")]
        public double PourCost { get { return computePourCost(); } set { } }


        public double computePourCost()
        {
            double getCost = 0;
            if (Difference < 0)
            {
                getCost = Difference + CurrentInventoryCost;
                double costPerc = getCost / MonthlySales;
                return costPerc;
            }

            else
            {
                getCost = CurrentInventoryCost - Difference;
                double costPerc = getCost / MonthlySales;
                return costPerc;
            }
        }         
    }
}