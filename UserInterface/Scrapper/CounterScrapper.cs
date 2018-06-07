namespace WhatAChamp
{
	using HtmlAgilityPack;
	using System.Collections.Generic;
	using System.Linq;

	public static class CounterScrapper
	{
		private static HtmlDocument document;

		static CounterScrapper()
		{
			var url = $"http://www.lolcounter.com/champions/" + ChampionInfo.SelectedChampion.name.ToLower();

			document = new HtmlWeb().Load(url);
		}

		public static IEnumerable<string> GetWeakAgainstOf() =>
			ScrapDataFrom("weak-block");

		public static IEnumerable<string> GetStrongAgainstOf() =>
			ScrapDataFrom("strong-block");

		public static IEnumerable<string> GetEvenWith() =>
			ScrapDataFrom("even-block");

		public static IEnumerable<string> GetWellWith() =>
			ScrapDataFrom("good-block");

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
