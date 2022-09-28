using ASP.CoreBusiness;

namespace ASP.UseCases.Akashi_Inventories
{
    public interface IShipWaifu_name
    {
        Task<IEnumerable<ShipWaifu>> GetAllWaifu(string name="");
    }
}