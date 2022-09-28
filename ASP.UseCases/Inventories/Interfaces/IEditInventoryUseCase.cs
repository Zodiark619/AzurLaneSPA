using ASP.CoreBusiness;

namespace ASP.UseCases.Inventories
{
    public interface IEditInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}