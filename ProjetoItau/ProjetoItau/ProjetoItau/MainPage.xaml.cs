using System.ComponentModel;
using Xamarin.Forms;

namespace ProjetoItau
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            //SetValue(NavigationPage.BarBackgroundColorProperty, Color.FromHex("#EB7100"));
        }

        private void GoTo_AtalhoPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PaginaDeAtalho());
        }

        private void po(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PaginaDeAtalho());

        }
    }
}
