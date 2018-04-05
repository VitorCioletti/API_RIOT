namespace riotAPI_teste.APIConnection
{
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using Newtonsoft.Json;

	public static class ChampionReader
	{
		public static IEnumerable<Champion> GetList() =>
			GetChampionsInRepository(JsonConvert.DeserializeObject<ChampionWrapper>(new StreamReader("Characters.txt").ReadToEnd()));

		private static IEnumerable<Champion> GetChampionsInRepository(ChampionWrapper champions)
		{
			return champions.Data.Where(c =>
			{
				var imagePath = $"../UserInferface/Images/Champions/Square/{c.Value.name}Square.png";

				if (File.Exists(imagePath))
				{
					c.Value.image.path = imagePath;
					return true;
				}
				else
					return false;
			}).Select(c => c.Value);
		}
	}
}
