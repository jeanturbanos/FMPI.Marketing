using System.Collections.Generic;
using FMPI.Marketing.Core.Models;

namespace FMPI.Marketing.Application
{
    public class ProductAppService: IProductAppService
    {
        private SMFargoContext _context = null;
        public ProductAppService()
        {
            _context = new SMFargoContext();
        }

        public override List<ProductOutputDto> GetProducts()
        {
            List<InventoryMaster2> itemList = _context.InventoryMaster2.Take(100).ToList();
            
        }
    }
}