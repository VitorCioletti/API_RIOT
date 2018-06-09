namespace WhatAChamp
{
	using HtmlAgilityPack;
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static class BuildScrapper
	{
		private static HtmlDocument Document;


		public static Tuple<string, string> GetBuildWinRate()
		{
			var winRate = GetBuildWrapper().Descendants("strong").ToList();

			return new Tuple<string, string>(winRate[0].InnerText, winRate[1].InnerText);
		}

		public static IEnumerable<Item> GetCommomBuild()
		{
			var build = GetBuildWrapper();

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

		private static HtmlNode GetBuildWrapper() =>
			Document.DocumentNode.SelectNodes(@"//div[@class=""build-wrapper""][1]").First();
	}
}
