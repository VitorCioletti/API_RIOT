namespace UserInterface
{
	using System.Threading;
	using System.Windows;

	public partial class MainWindow : Window
    {
        public MainWindow()
        {
			InitializeLoading();
            InitializeComponent();
        }

		private void InitializeLoading()
		{
			var loadingScreen = new Loading();
			loadingScreen.BeginInit();

			loadingScreen.Show();
			Thread.Sleep(5000);
			loadingScreen.Close();
		}
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
