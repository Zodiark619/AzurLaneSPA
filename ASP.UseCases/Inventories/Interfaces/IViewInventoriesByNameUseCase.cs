using ASP.CoreBusiness;

namespace ASP.UseCases.Inventories
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}