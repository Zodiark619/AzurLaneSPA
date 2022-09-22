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
                    Name="Akagi",Class=Class.Aircraft_Carrier,Faction=Faction.Sakura_Empire,Rarity=Rarity.Super_Rare
                },
                new ShipWaifu
                {
                    Name="Kaga",Class=Class.Aircraft_Carrier,Faction=Faction.Sakura_Empire,Rarity=Rarity.Super_Rare
                },
                new ShipWaifu
                {
                    Name="Aulick",Class=Class.Destroyer,Faction=Faction.Eagle_Union,Rarity=Rarity.Common
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
                    Name="Jersey",Class=Class.Destroyer,Faction=Faction.Royal_Navy,Rarity=Rarity.Rare
                },
                new ShipWaifu
                {
                    Name="Queen Elizabeth",Class=Class.Battleship,Faction=Faction.Royal_Navy,Rarity=Rarity.Elite
                },
                new ShipWaifu
                {
                    Name="Illustrious",Class=Class.Aircraft_Carrier,Faction=Faction.Royal_Navy,Rarity=Rarity.Super_Rare
                },
                new ShipWaifu
                {
                    Name="Prinz Eugen",Class=Class.Heavy_Cruiser,Faction=Faction.Iron_Blood,Rarity=Rarity.Super_Rare
                },
            };
        }

        public async Task<IEnumerable<ShipWaifu>> GetWaifuNameAsync(string name)
        {
            if (!string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_waifus);

            return _waifus.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
