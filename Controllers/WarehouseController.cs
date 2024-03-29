﻿using Microsoft.AspNetCore.Mvc;
using WebAppGrapQL.Abstractions;
using WebAppGrapQL.Models.Dto;

namespace WebAppGrapQL.Controllers
{
    public class WarehouseController : IWarehouseService
    {
        private static Dictionary<int, List<WarehouseItem>> warehouses = new Dictionary<int, List<WarehouseItem>>
    {
        { 1, new List<WarehouseItem> { new WarehouseItem { Id = 1, Name = "Product - 1", Quantity = 50 } } },
        { 2, new List<WarehouseItem> { new WarehouseItem { Id = 2, Name = "Product - 2", Quantity = 30 } } }

    };

        public List<WarehouseItem> GetItems(int warehouseId)
        {
            if (warehouses.ContainsKey(warehouseId))
            {
                return warehouses[warehouseId];
            }
            else
            {
                return new List<WarehouseItem>();
            }
        }
    }
}
