using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicAndBookStore.Data;
using MusicAndBookStore.Data.Repositories.IRepository;
using MusicAndBookStore.Data.Services;
using MusicAndBookStore.Entities;
using Newtonsoft.Json;
using System.Collections;
using System.Linq;
using System.Text.Json.Serialization;

namespace MusicAndBookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IProductRepository _productRepository;
        private readonly ICampaignRulesService _campaignRulesService;

        public ProductController(ApplicationDbContext context, IProductRepository productRepository, ICampaignRulesService campaignRulesService)
        {
            _context = context;
            _productRepository = productRepository;
            _campaignRulesService = campaignRulesService;
        }

        [HttpGet("getAllProducts")]
        public IActionResult GetAllProducts()
        {
            var products = _productRepository.GetAllProducts();
            return Ok(products);
        }

        [HttpPost("purchasedProducts")]
        public IActionResult GetTotalAmount(List<PurchasedProduct> purchasedProductList)
        {
            _campaignRulesService.CalculateProducts(purchasedProductList);
            var sonuc = _campaignRulesService.ReturnTotalValue();
            return Ok("Aldığınız ürünlerin toplam fiyatı => " + sonuc);
        }
    }
}
