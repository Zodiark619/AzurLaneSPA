using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP.CoreBusiness;
using ASP.UseCases.Akashi_PluginInterfaces;

namespace ASP.Plugins.InMemory
{
    public class WaifuRepository : IWaifuRepository
    {
        private List<ShipWaifu> _waifus;
        
        public WaifuRepository()
        {
            _waifus = new List<ShipWaifu>
            { 
                new ShipWaifu
                {
                    Id=1,Name="Akagi",Class=Class.Aircraft_Carrier,Faction=Faction.Sakura_Empire,Rarity=Rarity.Super_Rare
                },
                new ShipWaifu
                {
                    Id=2,Name="Kaga",Class=Class.Aircraft_Carrier,Faction=Faction.Sakura_Empire,Rarity=Rarity.Super_Rare
                },
                new ShipWaifu
                {
                    Id=3,Name="Aulick",Class=Class.Destroyer,Faction=Faction.Eagle_Union,Rarity=Rarity.Common
                },
                /*
    akagi aircraft carrier super rare sakura empire
    kaga aircraft carrier super rare sakura empire
    aulick destroyer common eagle union 
    jersey destroyer rare royal navy
  queen elizabeth battleship elite royal navy
   illustrious aircraft carrier super rare royal navy
   prinz eugen heavy cruiser super rare iron blood
    */
                new ShipWaifu
                {
                    Id=4,Name="Jersey",Class=Class.Destroyer,Faction=Faction.Royal_Navy,Rarity=Rarity.Rare
                },
                new ShipWaifu
                {
                    Id=5,Name="Queen Elizabeth",Class=Class.Battleship,Faction=Faction.Royal_Navy,Rarity=Rarity.Elite
                },
                new ShipWaifu
                {
                    Id=6,Name="Illustrious",Class=Class.Aircraft_Carrier,Faction=Faction.Royal_Navy,Rarity=Rarity.Super_Rare
                },
                new ShipWaifu
                {
                    Id=7,Name="Prinz Eugen",Class=Class.Heavy_Cruiser,Faction=Faction.Iron_Blood,Rarity=Rarity.Super_Rare
                },
            };
        }

        public async Task<IEnumerable<ShipWaifu>> GetWaifuNameAsync(string name)
        {

            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_waifus);
            return _waifus.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase));

           /* if (string.IsNullOrWhiteSpace(name)) 

                return _waifus.Where(x => x.Class.Equals(_class)).Where(x => x.Faction.Equals(_faction)).Where(x => x.Rarity.Equals(_rarity));

            return _waifus.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).Where(x => x.Class.Equals(_class)).Where(x => x.Faction.Equals(_faction)).Where(x => x.Rarity.Equals(_rarity));
        */
        }
    }
}
