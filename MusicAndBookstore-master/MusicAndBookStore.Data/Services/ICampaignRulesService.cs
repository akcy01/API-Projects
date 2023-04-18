using MusicAndBookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndBookStore.Data.Services
{
    public interface ICampaignRulesService
    {
        void CalculateProducts(List<PurchasedProduct> purchaseProducts);
        double ReturnTotalValue();
    }
}
