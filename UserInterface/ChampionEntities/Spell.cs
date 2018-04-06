using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WhatAChamp
{
    public class Spell
    {
        public string name { get; set; }
        public string description { get; set; }
        public string sanitizedDescription { get; set; }
        public string toolTip { get; set; }
        public string sanitizedToolTip { get; set; }
        public LevelTip levelTip { get; set; }
        public Image image { get; set; }
        public string resource { get; set; }
        public int maxRank { get; set; }
        public List<int> cost { get; set; }
        public string costType { get; set; }
        public string costBurn { get; set; }
        public List<string> coolDown { get; set; }
        public string coolDownBurn { get; set; }
        public List<dynamic> effect { get; set; }
        public List<string> effectBurn { get; set; }
        public List<Vars> vars { get; set; }
        public List<int> range { get; set; }
        public string rangeBurn { get; set; }
        public string key { get; set; }
    }
}
