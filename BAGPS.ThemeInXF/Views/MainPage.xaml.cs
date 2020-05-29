using BAGPS.ThemeInXF.Theme;
using Xamarin.Forms;

namespace BAGPS.ThemeInXF.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DarkTheme_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                var mergedDictionaries = Application.Current.Resources.MergedDictionaries;
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new DarkTheme());
            }
        }

        private void LightTheme_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                var mergedDictionaries = Application.Current.Resources.MergedDictionaries;
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new LightTheme());
            }
        }

        private void ClassicTheme_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                var mergedDictionaries = Application.Current.Resources.MergedDictionaries;
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new ClassicTheme());
            }
        }

    }
}