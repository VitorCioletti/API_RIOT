namespace WhatAChamp
{
	using HtmlAgilityPack;
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static class BuildScrapper
	{
		private static HtmlDocument Document;

		private static Tuple<string, string> GetBuildWinRate()
		{
			var teste = Document.DocumentNode.SelectNodes(@"//div[@class=""build-text""]")
								 .Descendants("strong");

			return null;
		}

		public static IEnumerable<Item> GetCommomBuild()
		{
			var build = Document.DocumentNode.SelectNodes(@"//div[@class=""build-wrapper""][1]").First();

			var buildList = build.Descendants("img")
								 .Select(e =>
									{
										var item = new Item();
										item.ImageSource = new Uri($"http:{e.GetAttributeValue("src", "")}");

										return item;
									}
								 )
								 .ToList();

			var linkList = build.Descendants("a")
				 .Select(e => new Uri(e.GetAttributeValue("href", "")))
				 .ToList();

			for (int i = 0; i < buildList.Count(); i++)
				buildList[i].InfoLink = linkList[i];

			return buildList;
		}

		public static void UpdateDocumentSelectedChampion()
		{
			var url = $"http://champion.gg/champion/" + ChampionInfo.SelectedChampion.name.ToLower();

			Document = new HtmlWeb().Load(url);
		}
	}
}
