namespace WhatAChamp
{
	using HtmlAgilityPack;
	using System.Collections.Generic;
	using System.Linq;

	public static class ChampionScrapper
	{
		private static HtmlDocument document;

		public static IEnumerable<string> GetWeakAgainstOf() => ScrapDataFrom("weak-block");

		public static IEnumerable<string> GetStrongAgainstOf() => ScrapDataFrom("strong-block");

		public static IEnumerable<string> GetEvenWith() => ScrapDataFrom("even-block");

		public static IEnumerable<string> GetWellWith() => ScrapDataFrom("good-block");

		public static void UpdateDocumentSelectedChampion()
		{
			var url = $"http://www.lolcounter.com/champions/" + ChampionInfo.SelectedChampion.name.ToLower();

			document = new HtmlWeb().Load(url);
		}

		private static IEnumerable<string> ScrapDataFrom(string block)
		{
			return document.DocumentNode.SelectNodes($@"//div[@class=""{block}""]")
										.Descendants()
										.Where(e => e.Attributes.Contains("class") && e.Attributes["class"].Value == "name")
										.Take(6)
										.Select(e => e.InnerHtml);
		}
    }
}
