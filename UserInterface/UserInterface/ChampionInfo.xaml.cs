namespace WhatAChamp
{
    using System.Collections.Generic;
    using System.Linq;
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
			champInfoWindow.WikiLol.Tag = selectedChampion.name;
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
		}

        private void FillWeakAgainstOf(string champion) =>
            ListWeakAgainst.List.ItemsSource = GetChampionFullInformations(CounterScrapper.GetWeakAgainstOf());

        private void FillStrongAgainstOf(string champion) =>
            ListStrongAgainst.List.ItemsSource = GetChampionFullInformations(CounterScrapper.GetStrongAgainstOf());

        private void FillEvenWith(string champion) =>
            ListEvenWith.List.ItemsSource = GetChampionFullInformations(CounterScrapper.GetEvenWith());

        private void FillGoodWith(string champion) =>
           ListWellWith.List.ItemsSource = GetChampionFullInformations(CounterScrapper.GetWellWith());

        private IEnumerable<Champion> GetChampionFullInformations(IEnumerable<string> champions) =>
            ChampionList.List.Where(c => champions.Contains(c.name));

        private void OpenBrowser(string path) =>
            System.Diagnostics.Process.Start(path);

        private void OpenLoLKing(object sender, System.Windows.Input.MouseButtonEventArgs e) =>
			OpenBrowser(@"http://www.lolking.net/builds/champion/" + ((System.Windows.Controls.Image)sender).Tag);

		private void OpenOriginalLoL(object sender, System.Windows.Input.MouseButtonEventArgs e) =>
			OpenBrowser(@"https://www.na.leagueoflegends.com/en/game-info/champions/" + ((System.Windows.Controls.Image)sender).Tag);

		private void OpenLolWiki(object sender, System.Windows.Input.MouseButtonEventArgs e) =>
			OpenBrowser(@"http://www.leagueoflegends.wikia.com/wiki/" + ((System.Windows.Controls.Image)sender).Tag);

		private void OpenChampGG(object sender, System.Windows.Input.MouseButtonEventArgs e) =>
			OpenBrowser("http://www.champion.gg/champion/" + ((System.Windows.Controls.Image)sender).Tag);

		private void ListWeakAgainst_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (((UIElement)sender).IsVisible)
				FillWeakAgainstOf(ChampionName.Content.ToString());
		}

		private void ListStrongAgainst_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			if (((UIElement)sender).IsVisible)
				FillStrongAgainstOf(ChampionName.Content.ToString());
		}

		private void ListWellWith_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			if (((UIElement)sender).IsVisible)
				FillGoodWith(ChampionName.Content.ToString());
		}

		private void ListEvenWith_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			if (((UIElement)sender).IsVisible)
				FillEvenWith(ChampionName.Content.ToString());
		}
	}
}