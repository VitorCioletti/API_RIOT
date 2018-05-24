namespace WhatAChamp
{
	using HtmlAgilityPack;
	using System.Collections.Generic;
	using System.Linq;

	public static class CounterScrapper
	{
		public static IEnumerable<string> GetWeakAgainstOf(string champion) =>
			ScrapCounterOf(champion, "weak-block");

		public static IEnumerable<string> GetStrongAgainstOf(string champion) =>
			ScrapCounterOf(champion, "strong-block");

		public static IEnumerable<string> GetEvenWith(string champion) =>
			ScrapCounterOf(champion, "even-block");

		public static IEnumerable<string> GetWellWith(string champion) =>
			ScrapCounterOf(champion, "good-block");

		private static IEnumerable<string> ScrapCounterOf(string champion, string block)
		{
			var url = $"http://www.lolcounter.com/champions/" + champion.ToLower();

			var document = new HtmlWeb().Load(url);

			return document.DocumentNode.SelectNodes($@"//div[@class=""{block}""]")
										.Descendants()
										.Take(3)
										.Where(e => e.Attributes.Contains("class") && e.Attributes["class"].Value == "name")
										.Select(c => c.InnerHtml);
		}
    }
}
