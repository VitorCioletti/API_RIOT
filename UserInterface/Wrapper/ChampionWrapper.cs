namespace WhatAChamp
{
    using System.Collections.Generic;

    public class ChampionWrapper
    {
        public Dictionary<string, Champion> Data { get; set; }

        public Dictionary<int, string> Keys { get; set; }

        public string Format { get; set; }

        public string Type { get; set; }

        public string Version { get; set; }
    }
}
