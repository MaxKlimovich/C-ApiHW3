using WebAppGrapQL.Models.Dto;

namespace WebAppGrapQL.Abstractions
{
    public class IWarehouseService
    {
        List<WarehouseItem> GetItems(int warehouseId);
    }
}
