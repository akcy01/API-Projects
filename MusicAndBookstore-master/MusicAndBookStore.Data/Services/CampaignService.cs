using Microsoft.AspNetCore.Mvc;
using MusicAndBookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndBookStore.Data.Services
{
    public class CampaignService : ICampaignRulesService
    {
        private readonly ApplicationDbContext _context;
        public CampaignService(ApplicationDbContext context)
        {
            _context = context;
        }

        List<double> itemsPrices = new List<double>();
        List<double> booksPrices = new List<double>();
        public void CalculateProducts(List<PurchasedProduct> purchaseProducts)
        {
            foreach (var item in purchaseProducts)
            {
                var getProductById = _context.Products.Where(x => x.ProductId == item.ProductId).FirstOrDefault();

                if (getProductById == null)
                    throw new Exception("Geçersiz ProductId girdiniz.");

                var type = getProductById.GetType();

                if (type.Name == "Book")
                {
                    for (int i = 0; i < item.Count; i++)
                    {
                        double finalPrice = getProductById.BasePrice + 2;
                        booksPrices.Add(finalPrice);
                    }
                }

                if (type.Name == "MusicAlbum")
                {
                    for (int i = 0; i < item.Count; i++)
                    {
                        double finalPrice = getProductById.BasePrice - (getProductById.BasePrice * 5) / 100 ;
                        itemsPrices.Add(finalPrice);

                    }
                }

                if (type.Name == "Movie")
                {
                    for (int i = 0; i < item.Count; i++)
                    {
                        double finalPrice = getProductById.BasePrice + (getProductById.BasePrice * 15) / 100;
                        itemsPrices.Add(finalPrice);
                    }
                }
            }
        }

        public double ReturnTotalValue()
        {
            var minBookPrice = 0;
            if (booksPrices.Count >= 2)
            {
                minBookPrice = (int)booksPrices.Min();
            }

            if(itemsPrices.Count != 0)
            {
                var minItemPrice = itemsPrices.Min();

                if (itemsPrices.Count >= 2)
                {
                    minItemPrice = minItemPrice - (int)(itemsPrices.Min() * 50) / 100;
                }

                if (minBookPrice > minItemPrice)
                {
                    booksPrices.Remove(minBookPrice);
                }
                else
                {
                    itemsPrices.Remove(itemsPrices.Min());
                    itemsPrices.Add(minItemPrice);
                }

                var itemSonuc = itemsPrices.Sum() + booksPrices.Sum();
                return itemSonuc;
            }
       
            var sonuc = booksPrices.Sum();
            return sonuc;
        }
    }
}
