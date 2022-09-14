using AL_SPA.CoreBusiness;
using AL_SPA.UseCases.PluginInterfaces;

namespace AL_SPA.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>
            {
                new Inventory{
                    EquipmentCategory=EquipmentCategoryEnum.Destroyer,
                    Name="Prototype Twin 130mm Model 1936 Main Gun Mount",
                    RarityCategory=EquipmentRarityEnum.Super_Rare,
                    Quantity=2
                },
                new Inventory{
                    EquipmentCategory=EquipmentCategoryEnum.Cargo,
                    Name="Torpedo Materials (Cargo)",
                    RarityCategory=EquipmentRarityEnum.Elite,
                    Quantity=1
                },
                new Inventory{
                    EquipmentCategory=EquipmentCategoryEnum.Battleship,
                    Name="Quadruple 356mm (BL 14\" Mk VII)",
                    RarityCategory=EquipmentRarityEnum.Rare,
                    Quantity=5
                },
            };
        }
        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);
            return _inventories.Where(x=>x.Name.Contains(name,StringComparison.OrdinalIgnoreCase));
        }
    }
}