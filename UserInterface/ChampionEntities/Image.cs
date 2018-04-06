using Newtonsoft.Json;

namespace WhatAChamp
{
    public class Image
    {
        public string full { get; set; }
        public string sprite { get; set; }
        public string group { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
		public string iconPath { get; set; }
		public string originalLoadingPath { get; set; }
		public string passivePath { get; set; }
		public string QPath { get; set; }
		public string WPath { get; set; }
		public string EPath { get; set; }
		public string RPath { get; set; }
	}
}
