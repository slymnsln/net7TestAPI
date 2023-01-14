using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        DataResult<List<Product>> GetAll();
        DataResult<List<Product>> GetAllByCategoryId(int id);
        DataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        DataResult<List<ProductDetailDto>> GetProductDetails();
        DataResult<Product> GetById(int productId);
        IResult Add(Product product);
    }
}
