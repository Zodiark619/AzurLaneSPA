using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AL_SPA.CoreBusiness;
using AL_SPA.UseCases.PluginInterfaces;

namespace AL_SPA.UseCases.Inventories
{
	public class ViewInventoryByNameUseCase
	{
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoryByNameUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }
		public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await inventoryRepository.GetInventoriesByNameAsync(name);
        }
	}
}
