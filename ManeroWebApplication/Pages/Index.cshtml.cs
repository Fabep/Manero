﻿using DataAccess.Contexts;
using DataAccess.Handlers.Repositories;
using DataAccess.Models;
using DataAccess.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManeroWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProductRepository _productRepository;

        public IndexModel( ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> BestSellers { get; set; } 

        public async Task OnGet()
        {
           var productList = await _productRepository.GetAllAsync(x => x.ProductPrice < 900);

            BestSellers = productList
                .Select(p => new Product
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    ProductDescription = p.ProductDescription,
                    ProductPrice = p.ProductPrice,
                    Rating = p.Rating ?? 0,
                    Quantity = p.Quantity ?? 0
                })
                .ToList();
        }
    }
}