namespace WhatAChamp
{
    using System.Collections.Generic;
    using System.Linq;
	using System.Text;
	using System.Web;
	using System.Windows;
	using System.Windows.Controls;

    public partial class ChampionInfo : UserControl
	{
		public static Champion SelectedChampion;

		public ChampionInfo()
		{
			InitializeComponent();
		}

		public static void LoadSelectedChampion(Champion selectedChampion, WhatAChampUI window)
		{
			SelectedChampion = selectedChampion;

			var champInfoWindow = window.ChampInfo;

			champInfoWindow.ChampInfo.DataContext = selectedChampion;

			champInfoWindow.LolCGG.Tag = selectedChampion.name;
			champInfoWindow.LolKing.Tag = selectedChampion.name;
			champInfoWindow.OficialLol.Tag = selectedChampion.name;

			champInfoWindow.ChampionEnemyTip.ToolTip = selectedChampion.enemyTips[0];
			champInfoWindow.ChampionFriendlyTip.ToolTip = selectedChampion.enemyTips[1];
			champInfoWindow.ChampionTags.Content += " " + string.Join(", ", selectedChampion.tags);

			champInfoWindow.PassiveSkillName.Text = selectedChampion.passive.name;
			champInfoWindow.PassiveSkillDescription.Text = selectedChampion.passive.description;

			champInfoWindow.QSkillName.Text = selectedChampion.spells[0].name;
			champInfoWindow.QSkillDescription.Text = selectedChampion.spells[0].description;
			champInfoWindow.QSkillCost.Text += string.Join(", ", selectedChampion.spells[0].cost);
			champInfoWindow.QSkillCooldown.Text += selectedChampion.spells[0].coolDownBurn;
			champInfoWindow.QSkillEffect.Text += selectedChampion.spells[0].effect[0];
			champInfoWindow.QSkillRange.Text += selectedChampion.spells[0].range[0];

			champInfoWindow.WSkillName.Text = selectedChampion.spells[1].name;
			champInfoWindow.WSkillDescription.Text = selectedChampion.spells[1].description;
			champInfoWindow.WSkillCost.Text += string.Join(", ", selectedChampion.spells[1].cost);
			champInfoWindow.WSkillCooldown.Text += selectedChampion.spells[1].coolDownBurn;
			champInfoWindow.WSkillEffect.Text += selectedChampion.spells[1].effect[0];
			champInfoWindow.WSkillRange.Text += selectedChampion.spells[1].range[0];

			champInfoWindow.ESkillName.Text = selectedChampion.spells[2].name;
			champInfoWindow.ESkillDescription.Text = selectedChampion.spells[2].description;
			champInfoWindow.ESkillCost.Text += string.Join(", ", selectedChampion.spells[2].cost);
			champInfoWindow.ESkillCooldown.Text += selectedChampion.spells[2].coolDownBurn;
			champInfoWindow.ESkillEffect.Text += selectedChampion.spells[2].effect[0];
			champInfoWindow.ESkillRange.Text += selectedChampion.spells[2].range[0];

			champInfoWindow.RSkillName.Text = selectedChampion.spells[3].name;
			champInfoWindow.RSkillDescription.Text = selectedChampion.spells[3].description;
			champInfoWindow.RSkillCost.Text += string.Join(", ", selectedChampion.spells[3].cost);
			champInfoWindow.RSkillCooldown.Text += selectedChampion.spells[3].coolDownBurn;
			champInfoWindow.RSkillEffect.Text += selectedChampion.spells[3].effect[0];
			champInfoWindow.RSkillRange.Text += selectedChampion.spells[3].range[0];

			var attack = selectedChampion.info["attack"];
			var defense = selectedChampion.info["defense"];
			var magic = selectedChampion.info["defense"];
			var difficulty = selectedChampion.info["difficulty"];
			var moveSpeed = selectedChampion.stats.moveSpeed;
			var hp = selectedChampion.stats.hp;
			var mp = selectedChampion.stats.mp;

			champInfoWindow.ChampionAttack.Value = attack;
			champInfoWindow.ChampionDefense.Value = defense;
			champInfoWindow.ChampionMagic.Value = magic;
			champInfoWindow.ChampionDifficulty.Value = difficulty;
			champInfoWindow.ChampionAttackSpeed.Value = moveSpeed;
			champInfoWindow.ChampionHp.Value = hp;
			champInfoWindow.ChampionMP.Value = mp;
			champInfoWindow.ChampionMS.Value = moveSpeed;

			champInfoWindow.AttackLabel.Content = $"{attack}/{champInfoWindow.ChampionAttack.Maximum}";
			champInfoWindow.DefenseLabel.Content = $"{defense}/{champInfoWindow.ChampionDefense.Maximum}";
			champInfoWindow.MagicLabel.Content = $"{magic}/{champInfoWindow.ChampionMagic.Maximum}";
			champInfoWindow.DifficultyLabel.Content = $"{difficulty}/{champInfoWindow.ChampionDifficulty.Maximum}";
			champInfoWindow.AttackSpeedLabel.Content = $"{moveSpeed}/{champInfoWindow.ChampionAttackSpeed.Maximum}";
			champInfoWindow.HpLabel.Content = $"{moveSpeed}/{champInfoWindow.ChampionHp.Maximum}";
			champInfoWindow.MpLabel.Content = $"{mp}/{champInfoWindow.ChampionMP.Maximum}";
			champInfoWindow.MoveSpeedLabel.Content = $"{moveSpeed}/{champInfoWindow.ChampionMS.Maximum}";

			UpdateScrappers();
		}

		private static void UpdateScrappers()
		{
			ChampionScrapper.UpdateDocumentSelectedChampion();
			BuildScrapper.UpdateDocumentSelectedChampion();
		}

        private void FillWeakAgainstOf() =>
            ListWeakAgainst.List.ItemsSource = GetChampionFullInformations(ChampionScrapper.GetWeakAgainstOf());

        private void FillStrongAgainstOf() =>
            ListStrongAgainst.List.ItemsSource = GetChampionFullInformations(ChampionScrapper.GetStrongAgainstOf());

        private void FillEvenWith() =>
            ListEvenWith.List.ItemsSource = GetChampionFullInformations(ChampionScrapper.GetEvenWith());

        private void FillGoodWith() =>
           ListWellWith.List.ItemsSource = GetChampionFullInformations(ChampionScrapper.GetWellWith());

		private void FillCommomBuild() =>
			CommomBuild.ItemsSource = BuildScrapper.GetCommomBuild();

		private void FillWinRateGames()
		{

		}

        private IEnumerable<Champion> GetChampionFullInformations(IEnumerable<string> champions) =>
            ChampionList.List.Where(c => champions.Contains(c.name));

        private void OpenBrowser(string path) =>
            System.Diagnostics.Process.Start(path);

		private bool IsSenderVisible(object sender) => ((UIElement)sender).IsVisible;

        private void OpenLoLKing(object sender, System.Windows.Input.MouseButtonEventArgs e) =>
			OpenBrowser(@"http://www.lolking.net/builds/champion/" + ((System.Windows.Controls.Image)sender).Tag);

		private void OpenOriginalLoL(object sender, System.Windows.Input.MouseButtonEventArgs e) =>
			OpenBrowser(@"https://www.na.leagueoflegends.com/en/game-info/champions/" + ((System.Windows.Controls.Image)sender).Tag);

		private void OpenChampGG(object sender, System.Windows.Input.MouseButtonEventArgs e) =>
			OpenBrowser("http://www.champion.gg/champion/" + ((System.Windows.Controls.Image)sender).Tag);

		private void ListWeakAgainst_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (IsSenderVisible(sender))
				FillWeakAgainstOf();
		}

		private void ListStrongAgainst_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			if (IsSenderVisible(sender))
				FillStrongAgainstOf();
		}

		private void ListWellWith_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			if (IsSenderVisible(sender))
				FillGoodWith();
		}

		private void ListEvenWith_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			if (IsSenderVisible(sender))
				FillEvenWith();
		}

		private void CommomBuild_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			if (IsSenderVisible(sender))
				FillCommomBuild();
		}

		private void WinRateGames_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			if (IsSenderVisible(sender))
				FillWinRateGames();
		}

		private void Image_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			var item = ((System.Windows.Controls.Image)sender).DataContext as Item;

			var decodedUrl = HttpUtility.HtmlDecode(item.InfoLink.AbsoluteUri);
			decodedUrl = HttpUtility.UrlDecode(decodedUrl, Encoding.GetEncoding(1252));

			OpenBrowser(decodedUrl);
		}
	}
}