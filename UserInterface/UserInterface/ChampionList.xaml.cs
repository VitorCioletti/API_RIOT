namespace WhatAChamp
{
	using System.Windows.Controls;

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
	}
}
