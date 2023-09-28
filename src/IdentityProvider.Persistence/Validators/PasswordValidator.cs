namespace IdentityProvider.Persistence.Validators
{
    public class PasswordValidator
    {
        public static string Symbols { get; } = "!@#$%^&*()_+-=?><:\"{}\\|][';/.,]";

        public static (bool result, string message) IsStrongPassword(string password)
        {
            if (password.Length < 8)
            {
                return (result: false, message: "Password can not be than 8 characters");
            }
            bool IsNumberExists = false;
            bool IsLowerCaseExists = false;
            bool IsUpperCaseExists = false;
            bool IsCharacterCaseExists = false;

            foreach (var s in password)
            {
                if (char.IsDigit(s)) IsNumberExists = true;
                if (char.IsLower(s)) IsLowerCaseExists = true;
                if (char.IsUpper(s)) IsUpperCaseExists = true;
                if (Symbols.Contains(s)) { IsCharacterCaseExists = true; }
            }

            if (IsCharacterCaseExists == false)
            {
                return (result: false, message: "Password should contain at least one Character");
            }

            if (IsLowerCaseExists == false)
            {
                return (result: false, message: "Password chould contain at least one Lower case");
            }

            if (IsUpperCaseExists == false)
            {
                return (result: false, message: "Password should contain at least one Upper case");
            }

            if (IsNumberExists == false)
            {
                return (result: false, message: "Password should contain at least one Number");
            }

            return (result: true, message: "");
        }
    }
}
