namespace WhatAChamp
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using System.Windows;
	using System.Windows.Controls;
	using System.Windows.Threading;

	public partial class WhatAChampUI : Window
    {
        public WhatAChampUI()
        {
            InitializeComponent();
			FillTypeClassesComboBox();
        }

		public static Task LoadSelectedChampion(Champion selectedChampion)
		{
			return Task.Run(() =>
			{
				Action loadSelectedChampion = () =>
				{
					var existingWindow = Window.GetWindow(Application.Current.Windows[0]) as WhatAChampUI;

					existingWindow.GoBack.Visibility = Visibility.Visible;
					existingWindow.lbl_selectChamp.Visibility = Visibility.Collapsed;
					existingWindow.cmb_typeClasses.Visibility = Visibility.Collapsed;

					ChampionInfo.LoadSelectedChampion(selectedChampion, existingWindow);

					existingWindow.ChampList.Visibility = Visibility.Collapsed;
					existingWindow.ChampInfo.Visibility = Visibility.Visible;
				};

				Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, loadSelectedChampion);
			});
		}

		private void FillTypeClassesComboBox()
		{
			cmb_typeClasses.ItemsSource = new List<string>
			{
				"Mage", "Support", "Tank", "Assassin", "Fighter", "All"
			}.OrderBy(e => e);

			cmb_typeClasses.SelectedIndex = 0;
		}

		private async void FilterChampionsByType(string selectedType) =>
			await LoadFilteredChampions(selectedType);

		private Task LoadFilteredChampions(string selectedType)
		{
			return Task.Run(() =>
			{
				Dispatcher.Invoke(() =>
				{
					ChampList.ChampionsList.ItemsSource = null;

					if (selectedType == "All")
						ChampList.ChampionsList.ItemsSource = ChampionReader.LoadedChampions;
					else
					{
						ChampList.ChampionsList.ItemsSource = ChampionReader.LoadedChampions.AsParallel()
																							.Where(c => c.tags.Contains(selectedType))
																							.OrderBy(x => x.name);
					}
				});
			});
		}

		private void Button_Click(object sender, RoutedEventArgs e) =>
			Close();

		private void Image_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			GoBack.Visibility = Visibility.Collapsed;

			ChampInfo.Visibility = Visibility.Collapsed;
			ChampList.Visibility = Visibility.Visible;
		}

		private void GoBack_Click(object sender, RoutedEventArgs e)
		{
			GoBack.Visibility = Visibility.Hidden;
			lbl_selectChamp.Visibility = Visibility.Visible;
			cmb_typeClasses.Visibility = Visibility.Visible;

			ChampInfo.Visibility = Visibility.Collapsed;
			ChampList.Visibility = Visibility.Visible;
		}

		private void cmb_typeClasses_SelectionChanged(object sender, SelectionChangedEventArgs e) =>
			FilterChampionsByType(((ComboBox)sender).SelectedItem.ToString());
	}
}
