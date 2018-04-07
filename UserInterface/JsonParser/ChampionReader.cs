namespace WhatAChamp
{
	using System;
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
				var basePath = AppDomain.CurrentDomain.BaseDirectory;

				c.Value.image.iconPath = $@"{basePath}\Images\Champions\Square\{c.Value.name}Square.png";
				c.Value.image.originalLoadingPath = $@"{basePath}\Images\Champions\MainArt\{c.Value.name}_OriginalLoading.jpg";

				c.Value.image.passivePath = $@"{basePath}\Images\Champions\Skills\{c.Value.name}_P.png";
				c.Value.image.QPath = $@"{basePath}Images\Champions\Skills\{c.Value.name}_Q.png";
				c.Value.image.WPath = $@"{basePath}Images\Champions\Skills\{c.Value.name}_W.png";
				c.Value.image.EPath = $@"{basePath}Images\Champions\Skills\{c.Value.name}_E.png";
				c.Value.image.RPath = $@"{basePath}Images\Champions\Skills\{c.Value.name}_R.png";

				return true;
			}).Select(c => c.Value).OrderBy(c => c.name).ToList();
		}
	}
}
