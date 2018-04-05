namespace UserInterface
{
	using System;
	using System.Linq;
	using System.Windows.Controls;
	using riotAPI_teste;
	using riotAPI_teste.APIConnection;

	public partial class ChampionList : UserControl
	{
		public ChampionList()
		{
			InitializeComponent();
		}

		private void LoadChampions()
		{
			var championsList = ChampionReader.GetList();

			for (int row = 0; row <= 11; row++)
			{
				for (int column = 0; column <= 11; column++)
				{
					var champion = new Image
					{
						Source = "",
						
					};

					List.Children.Add(champion);
				}
			}

		}
	}
}
