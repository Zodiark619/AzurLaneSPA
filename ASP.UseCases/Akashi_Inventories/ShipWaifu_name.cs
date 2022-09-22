using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP.CoreBusiness;
using ASP.UseCases.Akashi_PluginInterfaces;

namespace ASP.UseCases.Akashi_Inventories
{
    public class ShipWaifu_name
    {
        private readonly IWaifuRepository waifuRepository;

        public ShipWaifu_name(IWaifuRepository waifuRepository)
        {
            this.waifuRepository = waifuRepository;
        }
        public async Task<IEnumerable<ShipWaifu>> GetAllWaifu(string name)
        {
            return await waifuRepository.GetWaifuNameAsync(name);
        }

    }
}
