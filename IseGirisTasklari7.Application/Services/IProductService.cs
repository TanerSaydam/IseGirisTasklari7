using IseGirisTasklari7.Application.Features.Products.Commands.CreateProduct;

namespace IseGirisTasklari7.Application.Services;

public interface IProductService
{
    Task AddAsync(CreateProductCommand request);
}
