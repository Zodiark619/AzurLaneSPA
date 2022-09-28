using ASP.CoreBusiness;

namespace ASP.UseCases.Inventories
{
    public interface IAddInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}