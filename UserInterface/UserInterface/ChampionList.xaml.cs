namespace WhatAChamp
{
	using System.Windows.Controls;
	using System.Windows.Media;

	public partial class ChampionList : UserControl
	{
		public ChampionList()
		{
			InitializeComponent();
			LoadChampions();
		}

		private void LoadChampions() =>
			ChampionsList.ItemsSource = ChampionReader.GetList();

		private void Image_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) =>
			WhatAChampUI.LoadSelectedChampion((Champion)((System.Windows.Controls.Image)sender).DataContext);

		private void Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e) =>
			((System.Windows.Controls.Border)sender).BorderBrush = new SolidColorBrush(Colors.Red);

		private void Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e) =>
			((System.Windows.Controls.Border)sender).BorderBrush = new SolidColorBrush(Colors.Transparent);
	}
}
