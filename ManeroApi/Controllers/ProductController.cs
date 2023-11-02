using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Models;
using DataAccess.Models.Schemas;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace ManeroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _productRepository;
        public ProductController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpPost]
        public async Task<ActionResult<Product>> Create(ProductSchema productToCreate)
        {

            try
            {
                if (productToCreate is not null)
                {
                    var entity = productToCreate.ConvertProductSchemaToProductEntity();
                    var res = await _productRepository.CreateAsync(entity);
                    var a = await _productRepository.GetAsync(x => x.ProductName == "string");
                    Debug.WriteLine(JsonConvert.SerializeObject(a, Formatting.None, new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    }));
                    if (res is DataAccess.Enums.StatusMessage.Success)
                        return Ok(JsonConvert.SerializeObject(entity, Formatting.None, new JsonSerializerSettings
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        }));
                }
                return BadRequest($"{JsonConvert.SerializeObject(productToCreate)} is in a invalid format.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Something went wrong {ex.Message}.");
            }
        }
    }
}
