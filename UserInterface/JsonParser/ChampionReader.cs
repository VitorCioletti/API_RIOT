namespace WhatAChamp
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using Newtonsoft.Json;

	public static class ChampionReader
	{
		public static IEnumerable<Champion> LoadedChampions;

		public static IEnumerable<Champion> GetList() =>
			GetChampionsInRepository(JsonConvert.DeserializeObject<ChampionWrapper>(new StreamReader("pack://application:,,,/Sites/Json/Characters.txt").ReadToEnd()));

		private static IEnumerable<Champion> GetChampionsInRepository(ChampionWrapper champions)
		{
			LoadedChampions = champions.Data.Where(c =>
			{
				var basePath = @"pack://application:,,,/Sites/Images/Champions";

				var basePathSkills = $@"{basePath}/Skills/";
				var basePathSquare = $@"{basePath}/Square/";
				var basePathMainArt = $@"{basePath}/MainArt/";

				c.Value.image.iconPath = $@"{basePathSquare}{c.Value.name}Square.png";
				c.Value.image.originalLoadingPath = $@"{basePathMainArt}{c.Value.name}_OriginalLoading.jpg";

				c.Value.image.passivePath = $@"{basePathSkills}{c.Value.name}_P.png";
				c.Value.image.QPath = $@"{basePathSkills}{c.Value.name}_Q.png";
				c.Value.image.WPath = $@"{basePathSkills}{c.Value.name}_W.png";
				c.Value.image.EPath = $@"{basePathSkills}{c.Value.name}_E.png";
				c.Value.image.RPath = $@"{basePathSkills}{c.Value.name}_R.png";

				return true;
			}).Select(c => c.Value).OrderBy(c => c.name).ToList();

			return LoadedChampions;
		}
	}
}
