namespace BlazorTrainLangBarGpt.Components
{
    public class CultureState
    {
        public string CurrentCulture { get; set; }

        public event Action OnCultureChanged;

        public void SetCulture(string culture)
        {
            CurrentCulture = culture;
            OnCultureChanged?.Invoke();
        }
    }
}
