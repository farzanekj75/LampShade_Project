using _0_Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Configuration.Permissions
{
    public class InvenoryPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Inventory" , new List<PermissionDto>
                    {
                        new PermissionDto(InventoryPermission.ListInventories , "ListInventory"),
                        new PermissionDto(InventoryPermission.SearchInventories , "SearchInventory"),
                        new PermissionDto(InventoryPermission.CreateInventory , "CreateInventory"),
                        new PermissionDto(InventoryPermission.EditInventory , "EditInventory"),
                    }
                }
            };
        }
    }
}
