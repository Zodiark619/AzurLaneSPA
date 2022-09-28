using ASP.CoreBusiness;

namespace ASP.UseCases.Inventories
{
    public interface IViewInventoryByIdUseCase
    {
        Task<Inventory> ExecuteAsync(int inventoryId);
    }
}