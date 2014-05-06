using Windows.UI.Xaml.Navigation;

namespace ObservableTest
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            DataContext = new MainViewModel();
        }
    }

}
