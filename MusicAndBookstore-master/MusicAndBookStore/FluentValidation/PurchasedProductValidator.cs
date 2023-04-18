using FluentValidation;
using MusicAndBookStore.Entities;

namespace MusicAndBookStore.FluentValidation
{
    public class PurchasedProductValidator : AbstractValidator<PurchasedProduct>
    {
        public PurchasedProductValidator() 
        {
            //RuleFor(p => p.ProductId).Must(x => int.Equals(int 4));
        }
    }
}
