
namespace CiclodeVidaApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
           var window = base.CreateWindow(activationState);
            window.Created += (s, a) =>
            {
                System.Diagnostics.Debug.WriteLine("1). Sucedio el evento Created");
            };
            window.Activated += (s, a) =>
            {
                System.Diagnostics.Debug.WriteLine("2). Sucedio el evento Activated");
            };
            window.Deactivated += (s, a) =>
            {
                System.Diagnostics.Debug.WriteLine("3). Sucedio el evento Deactivated");
            };
            window.Stopped += (s, a) =>
            {
                System.Diagnostics.Debug.WriteLine("4). Sucedio el evento Sttoped");
            };
            window.Resumed += (s, a) =>
            {
                System.Diagnostics.Debug.WriteLine("5). Sucedio el evento Resumed");
            };
            window.Destroying += (s, a) =>
            {
                System.Diagnostics.Debug.WriteLine("6). Sucedio el evento Destroying");
            };

            return window;
        }
    }
}
