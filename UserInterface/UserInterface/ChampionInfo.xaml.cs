namespace UserInterface
{
	using riotAPI_teste;
	using System;
	using System.Windows.Controls;
	using System.Windows.Media.Imaging;

	public partial class ChampionInfo : UserControl
	{
		public ChampionInfo()
		{
			InitializeComponent();
		}

		public static void LoadSelectedChampion(Champion selectedChampion, WhatAChamp window)
		{
			var champInfoWindow = window.ChampInfo;

			champInfoWindow.ChampInfo.DataContext = selectedChampion;

			//champInfoWindow.ChampionName.Content = selectedChampion.name;
			champInfoWindow.ChampionTitle.Content = selectedChampion.title;

			champInfoWindow.ChampionAttack.Value = selectedChampion.info["attack"];
			champInfoWindow.ChampionDefense.Value = selectedChampion.info["defense"];
			champInfoWindow.ChampionMagic.Value = selectedChampion.info["magic"];
			champInfoWindow.ChampionDifficulty.Value = selectedChampion.info["difficulty"];


			/*Func<string, BitmapImage> BindToPath = (path) =>
			{
				var bitmapImage = new BitmapImage();
				bitmapImage.UriSource = new Uri(path, UriKind.Relative);

				bitmapImage.BeginInit();

				return bitmapImage;
			};


			var bitmapOriginalLoading = BindToPath(selectedChampion.image.originalLoadingPath);
			champInfoWindow.ChampionMainArt.Source = bitmapOriginalLoading;
			bitmapOriginalLoading.EndInit();

			var bitmapPassive = BindToPath(selectedChampion.image.passivePath);
			champInfoWindow.ChampionPassive.Source = bitmapPassive;
			bitmapPassive.EndInit();

			var bitmapQ = BindToPath(selectedChampion.image.QPath);
			champInfoWindow.ChampionSkillQ.Source = bitmapQ;
			bitmapQ.EndInit();

			var bitmapW = BindToPath(selectedChampion.image.WPath);
			champInfoWindow.ChampionSkillW.Source = bitmapW;
			bitmapW.EndInit();

			var bitmapE = BindToPath(selectedChampion.image.EPath);
			champInfoWindow.ChampionSkillE.Source = bitmapE;
			bitmapE.EndInit();

			var bitmapR = BindToPath(selectedChampion.image.RPath);
			champInfoWindow.ChampionSkillR.Source = bitmapR;
			bitmapR.EndInit();*/

			champInfoWindow.ChampionLore.Text = selectedChampion.lore;
		}
	}
}
