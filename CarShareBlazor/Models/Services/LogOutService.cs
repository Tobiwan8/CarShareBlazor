namespace CarShareBlazor.Models.Services
{
    public class LogOutService
    {
        private bool _isLoggedOut = false;
        public bool IsLoggedOut => _isLoggedOut;

        public event Action? OnLoggedOut;

        public void SetLoggedOut(bool value)
        {
            _isLoggedOut = value;
            OnLoggedOut?.Invoke();
        }
    }
}
