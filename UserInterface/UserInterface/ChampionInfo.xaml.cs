namespace WhatAChamp
{
	using System.Windows.Controls;

	public partial class ChampionInfo : UserControl
	{
		public ChampionInfo()
		{
			InitializeComponent();
		}

		public static void LoadSelectedChampion(Champion selectedChampion, WhatAChampUI window)
		{
			var champInfoWindow = window.ChampInfo;

			champInfoWindow.ChampInfo.DataContext = selectedChampion;

			champInfoWindow.PassiveSkillDescription.Text = selectedChampion.spells[0].description;

			champInfoWindow.QSkillDescription.Text = selectedChampion.spells[1].description;
			champInfoWindow.QSkillCost.Text += selectedChampion.spells[1].cost;
			champInfoWindow.QSkillCooldown.Text += selectedChampion.spells[1].coolDownBurn;
			champInfoWindow.QSkillEffect.Text += selectedChampion.spells[1].effect;
			champInfoWindow.QSkillRange.Text += selectedChampion.spells[1].range;

			champInfoWindow.ChampionAttack.Value = selectedChampion.info["attack"];
			champInfoWindow.ChampionDefense.Value = selectedChampion.info["defense"];
			champInfoWindow.ChampionMagic.Value = selectedChampion.info["magic"];
			champInfoWindow.ChampionDifficulty.Value = selectedChampion.info["difficulty"];
		}
	}
}
