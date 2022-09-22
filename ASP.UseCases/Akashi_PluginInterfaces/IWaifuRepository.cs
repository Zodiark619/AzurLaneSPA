using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP.CoreBusiness;

namespace ASP.UseCases.Akashi_PluginInterfaces
{
    public interface  IWaifuRepository
    {
        Task<IEnumerable<ShipWaifu>> GetWaifuNameAsync(string name);
    }
}
