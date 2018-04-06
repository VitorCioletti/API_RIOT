namespace UserInterface
{
	using riotAPI_teste;
	using riotAPI_teste.APIConnection;
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
			WhatAChamp.LoadSelectedChampion((Champion)((System.Windows.Controls.Image)sender).DataContext);
	}
}
