using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Prism.Unity.Windows;
using Grading_App.Services;
using Microsoft.Practices.Unity;

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

        protected override async Task OnInitializeAsync(IActivatedEventArgs args)
        {
            await base.OnInitializeAsync(args);

            Container
                .RegisterType<IDataSeedService, DataSeedService>();
        }
    }
}
