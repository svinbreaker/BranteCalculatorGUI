namespace BranteCalculatorWPF
{
    public class Settings
    {
        private string _locale;
        
        public Settings(string locale) 
        {
            Locale = locale;
        }
        
        public event EventHandler? LocaleChanged;
        
        public string Locale
        {
            get => _locale;
            set
            {
                if (_locale != value)
                {
                    _locale = value;
                    OnLocaleChanged();
                }
            }
        }
        
        private void OnLocaleChanged()
        {
            LocaleChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
