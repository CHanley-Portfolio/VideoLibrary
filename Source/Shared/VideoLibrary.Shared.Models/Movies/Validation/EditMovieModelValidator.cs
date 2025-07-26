using FluentValidation;

namespace VideoLibrary.Shared.Models.Movies.Validation
{
    public class EditMovieModelValidator: AbstractValidator<EditMovieModel>
    {
        public EditMovieModelValidator()
        {
            RuleFor(m => m.Title).NotEmpty().MaximumLength(200);
            RuleFor(m => m.Description).MaximumLength(3000);
            RuleFor(m => m.Tagline).MaximumLength(500);
            RuleFor(m => m.CountryId).MaximumLength(2);
            RuleFor(m => m.LanguageId).MaximumLength(3);
            RuleFor(m => m.Year)
                .NotEmpty()
                .GreaterThanOrEqualTo(1930)
                .LessThanOrEqualTo(DateTime.Today.Year + 2);
            RuleFor(m => m.Runtime).NotEmpty().GreaterThanOrEqualTo(45).LessThanOrEqualTo(240);
            RuleFor(m => m.RatingId).NotEmpty();
        }
    }
}
