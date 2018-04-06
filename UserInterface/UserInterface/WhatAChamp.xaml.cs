namespace UserInterface
{
	using riotAPI_teste;
	using System.Windows;

	public partial class WhatAChamp : Window
    {
        public WhatAChamp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

		public static void LoadSelectedChampion(Champion selectedChampion)
		{
			var existingWindow = Window.GetWindow(Application.Current.Windows[0]) as WhatAChamp;

			ChampionInfo.LoadSelectedChampion(selectedChampion, existingWindow);

			existingWindow.ChampList.Visibility = Visibility.Collapsed;
			existingWindow.ChampInfo.Visibility = Visibility.Visible;
		}

		private void Image_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			ChampInfo.Visibility = Visibility.Collapsed;
			ChampList.Visibility = Visibility.Visible;
		}
	}
}
