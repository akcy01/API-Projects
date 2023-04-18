using FluentValidation;
using MusicAndBookStore.Entities;

namespace MusicAndBookStore.FluentValidation
{
    public class MusicAlbumValidator : AbstractValidator<MusicAlbum>
    {
        public MusicAlbumValidator() 
        {
            RuleFor(p => p.SingerName).NotEmpty().WithMessage("Müzisyensiz şarkı olmaz. Lütfen sanatçının adını giriniz.");
            RuleFor(p => p.Name).NotEmpty().WithMessage("İsimsiz müzik albümü olmaz. Lütfen albümün adını giriniz.");
            RuleFor(p => p.NumberOfSongs).NotEmpty().WithMessage("Lütfen albümde kaç şarkı olduğunu giriniz.");
            RuleFor(p => p.ReleaseDate).NotEmpty().LessThan(DateTime.UtcNow);
            RuleFor(p => p.Genre).NotEmpty().WithMessage("Şarkının türü olmak zorunda. Lütfen türü giriniz.");
            RuleFor(p => p.BasePrice).NotEmpty().WithMessage("Şarkının fiyatı olmak zorunda. Lütfen filmin fiyatını giriniz.");
        }
    }
}
