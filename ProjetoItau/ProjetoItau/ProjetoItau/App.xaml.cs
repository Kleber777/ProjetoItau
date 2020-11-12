using Xamarin.Forms;

namespace ProjetoItau
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var pagina = new NavigationPage(new MainPage());
            //MainPage = pagina;


            MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.FromHex("#FF7200") };
            //MainPage = new NavigationPage(new MainPage());
        }

        
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
