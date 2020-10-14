namespace PasswordResetWeb.Services
{
    public abstract class PasswordManagerBase
    {
        public abstract void Reset(string userName, string newPassword);
    }
}