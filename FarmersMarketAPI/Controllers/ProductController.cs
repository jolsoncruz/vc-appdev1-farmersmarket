using System;
using Microsoft.AspNetCore.Mvc;
using FarmersMarketAPI.Services;
using FarmersMarketAPI.Models;

namespace FarmersMarketAPI.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class ProductController: Controller
    {
        private readonly MongoDBServices _mongoDBService;

        public ProductController(MongoDBServices mongoDBService)
        {
            _mongoDBService = mongoDBService;
        }

        //demo

        [HttpGet]
        public async Task<List<Product>> Get()
        {
            return await _mongoDBService.GetAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product p)
        {
            await _mongoDBService.CreateAsync(p);
            return CreatedAtAction(nameof(Get), new { Id = p.Id }, p);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStock(string id, [FromBody] double stock)
        {
            await _mongoDBService.UpdateStockAsync(id, stock);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _mongoDBService.DeleteAsync(id);
            return NoContent();
        }

        //end of demo
    }
}
