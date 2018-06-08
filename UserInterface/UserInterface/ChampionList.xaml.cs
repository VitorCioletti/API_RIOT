namespace WhatAChamp
{
	using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using System.Windows.Controls;
    using System.Windows.Media;

    public partial class ChampionList : UserControl
	{
        public static IEnumerable<Champion> List;

		public ChampionList()
		{
			InitializeComponent();
			LoadChampions();
		}

		private void LoadChampions()
        {
            List = ChampionReader.GetList();
            ChampionsList.ItemsSource = List;
        }

		private async void Image_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			RenderLoadingScreen();

			Action<Task> closeLoadingScreen = (t) => Dispatcher.Invoke(() => Opacity = 1);

			await WhatAChampUI.LoadSelectedChampion((Champion)((System.Windows.Controls.Image)sender).DataContext)
							  .ContinueWith(closeLoadingScreen);
		}

		private void RenderLoadingScreen() => Opacity = 0.5;

		private void Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e) =>
			((System.Windows.Controls.Border)sender).BorderBrush = new SolidColorBrush(Colors.Red);

		private void Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e) =>
			((System.Windows.Controls.Border)sender).BorderBrush = new SolidColorBrush(Colors.Transparent);
	}
}
