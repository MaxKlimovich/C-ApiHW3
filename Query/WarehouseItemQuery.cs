using WebAppGrapQL.Abstractions;
using WebAppGrapQL.Models.Dto;

namespace WebAppGrapQL.Query
{
    public class WarehouseItemQuery
    {
        public List<WarehouseItem> GetItems(int warehouseId, [Service] IWarehouseService warehouseService)
        {
            return warehouseService.GetItems(warehouseId);
        }
    }
}
