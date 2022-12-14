using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP.CoreBusiness;

namespace ASP.UseCases.PluginInterfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsByNameAsync(string name);
    }
}
