using FluentValidation;
using MusicAndBookStore.Entities;

namespace MusicAndBookStore.FluentValidation
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator() 
        {
            RuleFor(p => p.WriterName).NotEmpty().WithMessage("Yazarsız kitap olmaz. Lütfen yazar giriniz.");
            RuleFor(p => p.Name).NotEmpty().WithMessage("İsimsiz kitap olmaz. Lütfen kitabın adını giriniz.");
            RuleFor(p => p.ISBNNumber).NotEmpty().WithMessage("Lütfen ISBN numarasını giriniz.");
            RuleFor(p => p.ReleaseDate).NotEmpty().LessThan(DateTime.UtcNow);
            RuleFor(p => p.Genre).NotEmpty().WithMessage("Kitabın türü olmak zorunda. Lütfen türü giriniz.");
            RuleFor(p => p.BasePrice).NotEmpty().WithMessage("Kitabın fiyatı olmak zorunda. Lütfen kitabın fiyatını giriniz.");
        }
    }
}
