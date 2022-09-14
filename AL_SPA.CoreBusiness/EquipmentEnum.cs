using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL_SPA.CoreBusiness
{
    public enum EquipmentCategoryEnum
    {
        Destroyer,
        [Display(Name="Light Cruiser")]
        Light_Cruiser,
        [Display(Name = "Heavy Cruiser")]
        Heavy_Cruiser,
        [Display(Name = "Large Cruiser")]
        Large_Cruiser,
        Battleship,
        Cargo


    }
    public enum EquipmentRarityEnum
    {
        Common,
        Rare,
        Elite,
        [Display(Name = "Super Rare")]
        Super_Rare,
        Legendary

    }
}
