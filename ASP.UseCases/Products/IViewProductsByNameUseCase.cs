using ASP.CoreBusiness;

namespace ASP.UseCases.Products
{
    public interface IViewProductsByNameUseCase
    {
        Task<IEnumerable<Product>> ExecuteAsync(string name = "");
    }
}