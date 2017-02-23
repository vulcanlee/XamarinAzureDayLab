using Prism.Unity;
using PrismUnityApp3.Views;

namespace PrismUnityApp3
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MDPage/NaviPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<P1Page>();
            Container.RegisterTypeForNavigation<P2Page>();
            Container.RegisterTypeForNavigation<P3Page>();
            Container.RegisterTypeForNavigation<NaviPage>();
            Container.RegisterTypeForNavigation<MDPage>();
        }
    }
}
