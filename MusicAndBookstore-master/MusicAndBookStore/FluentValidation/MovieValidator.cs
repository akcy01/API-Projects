using FluentValidation;
using MusicAndBookStore.Entities;

namespace MusicAndBookStore.FluentValidation
{
    public class MovieValidator : AbstractValidator<Movie>
    {
        public MovieValidator() 
        {
            RuleFor(p => p.DirectorName).NotEmpty().WithMessage("Yönetmensiz film olmaz. Lütfen yönetmen adını giriniz.");
            RuleFor(p => p.Name).NotEmpty().WithMessage("İsimsiz film olmaz. Lütfen filmin adını giriniz.");
            RuleFor(p => p.IMDBRate).NotEmpty().WithMessage("Lütfen IMDB puanını giriniz.");
            RuleFor(p => p.ReleaseDate).NotEmpty().LessThan(DateTime.UtcNow);
            RuleFor(p => p.Genre).NotEmpty().WithMessage("Filmin türü olmak zorunda. Lütfen türü giriniz.");
            RuleFor(p => p.BasePrice).NotEmpty().WithMessage("Filmin fiyatı olmak zorunda. Lütfen filmin fiyatını giriniz.");
        }
    }
}
