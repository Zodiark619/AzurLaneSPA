using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.CoreBusiness
{
    /*
     akagi aircraft carrier super rare sakura empire
     kaga aircraft carrier super rare sakura empire
     aulick destroyer common eagle union 
     jersey destroyer rare royal navy
   queen elizabeth battleship elite royal navy
    illustrious aircraft carrier super rare royal navy
    prinz eugen heavy cruiser super rare iron blood
     */
    public enum Rarity
    {
        Common,
        Rare,
        Elite,
        [Display(Name = "Super Rare")]
        Super_Rare
    }
    public enum Faction
    {
        [Display(Name = "Iron Blood")]
        Iron_Blood,
        [Display(Name = "Eagle Union")]
        Eagle_Union,
        [Display(Name = "Royal Navy")]
        Royal_Navy,
        [Display(Name = "Sakura Empire")]
        Sakura_Empire,

    }
    public enum Class
    {
        [Display(Name = "Aircraft Carrier")]
        Aircraft_Carrier,
        Destroyer,
        Battleship,
        [Display(Name = "Heavy Cruiser")]
        Heavy_Cruiser,
    }
    public class ShipWaifu
    {
        public string Name { get; set; }
        public Rarity Rarity { get; set; }
        public Faction Faction { get; set; }
        public Class Class { get; set; }

    }
}
