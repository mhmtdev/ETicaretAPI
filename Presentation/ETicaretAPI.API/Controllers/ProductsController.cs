using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;

        readonly private ICustomerWriteRepository _customerWriteRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            //Order order = await _orderReadRepository.GetByIdAsync("831110ec-df54-46c2-816a-26e3a75c1fe6");
            //order.Address = "çanakkale";
            //await _orderWriteRepository.SaveAsync();


            //var customerId = Guid.NewGuid();
            //await _customerWriteRepository.AddAsync(new() { Id = customerId, Name = "mhmt" });

            //await _orderWriteRepository.AddAsync(new()
            //{
            //    Description = "SADF dfsdf",
            //    Address = "ankara",
            //    CustomerId = customerId
            //});
            //await _orderWriteRepository.SaveAsync();

            //await _productWriteRepository.AddAsync(new()
            //{
            //    Name = "C Product",
            //    Price = 1.500F,
            //    Stock = 10,
            //    CreatedDate = DateTime.UtcNow,
            //});
            //await _productWriteRepository.SaveAsync();

            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new(){ Id = Guid.NewGuid(), Name="Product 1", Price=100, CreatedDate=DateTime.UtcNow, Stock=10 },
            //    new(){ Id = Guid.NewGuid(), Name="Product 2", Price=200, CreatedDate=DateTime.UtcNow, Stock=20 },
            //    new(){ Id = Guid.NewGuid(), Name="Product 3", Price=300, CreatedDate=DateTime.UtcNow, Stock=130 },
            //});
            //await _productWriteRepository.SaveAsync();
        }
    }
}
