namespace VideoLibrary.Shared.Models.Validation
{
    public class ValidationLanguageManager : FluentValidation.Resources.LanguageManager
    {
        public ValidationLanguageManager()
        {
            SetValidatorMessage("NotNullValidator", ValidationConstants.RequiredErrorMsg);
            SetValidatorMessage("NotEmptyValidator", ValidationConstants.RequiredErrorMsg);
            SetValidatorMessage("MaxLengthValidator", ValidationConstants.StringLengthErrorMsg);
            SetValidatorMessage("MinLengthValidator", ValidationConstants.MinStringLengthErrorMsg);
            SetValidatorMessage("GreaterThanValidator", ValidationConstants.GreaterThanErrorMsg);
            SetValidatorMessage("GreaterThanOrEqualValidator", ValidationConstants.GreaterThanOrEqualErrorMsg);
            SetValidatorMessage("LessThanValidator", ValidationConstants.LessThanErrorMsg);
            SetValidatorMessage("LessThanOrEqualValidator", ValidationConstants.LessThanOrEqualErrorMsg);
        }

        private void SetValidatorMessage(string validator, string message)
        {
            AddTranslation("en", validator, message);
            AddTranslation("en-US", validator, message);
            AddTranslation("en-GB", validator, message);
        }
    }
}
