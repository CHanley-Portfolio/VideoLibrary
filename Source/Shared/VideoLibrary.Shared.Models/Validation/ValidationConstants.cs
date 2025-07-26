namespace VideoLibrary.Shared.Models.Validation
{
    public static class ValidationConstants
    {
        public const string RequiredErrorMsg = "Field is required.";
        public const string StringLengthErrorMsg = "Please enter a maximum of {MaxLength} characters.";
        public const string MinStringLengthErrorMsg = "At least {MinLength} characters must be entered.";
        public const string GreaterThanErrorMsg = "Please enter a value greater than {ComparisonValue}.";
        public const string GreaterThanOrEqualErrorMsg = "Please enter a value greater than or equal to {ComparisonValue}.";
        public const string LessThanErrorMsg = "Please enter a value less than {ComparisonValue}.";
        public const string LessThanOrEqualErrorMsg = "Please enter a value less than or equal to {ComparisonValue}.";
    }
}
