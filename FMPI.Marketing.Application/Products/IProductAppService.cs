using System.Collections.Generic;

namespace FMPI.Marketing.Application
{
    public interface IProductAppService
    {
        List<ProductOutputDto> GetProducts;
    }
}