using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Prism.Unity.Windows;
using Prism.Windows.Navigation;

namespace Grading_App
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : PrismUnityApplication
    {

        public App()
        {
            InitializeComponent();
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            if (args.Kind == ActivationKind.Launch)
            {
                NavigationService.Navigate("Main", null);
                Window.Current.Activate();
            }

            return Task.FromResult<object>(null);
        }

        protected override Task OnInitializeAsync(IActivatedEventArgs args)
        {
            //Container.RegisterInstance<INavigationService>(NavigationService);
            return base.OnInitializeAsync(args);
        }
    }
}
