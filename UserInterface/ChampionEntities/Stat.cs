using Newtonsoft.Json;

namespace WhatAChamp
{
    public class Stat
    {
        public double armor { get; set; }
        public double armorPerLevel { get; set; }
        public double attackDamage { get; set; }
        public double attackDamagePerLevel { get; set; }
        public double attackRange { get; set; }
        public double attackSpeedOffSet { get; set; }
        public double attackSpeedPerLevel { get; set; }
        public double crit { get; set; }
        public double critPerLevel { get; set; }
        public double hp { get; set; }
        public double hpPerLevel { get; set; }
        public double hpRegen { get; set; }
        public double hpRegenPerLevel { get; set; }
        public double moveSpeed { get; set; }
        public double mp { get; set; }
        public double mpPerLevel { get; set; }
        public double spellBlock { get; set; }
        public double spellBlockPerLevel { get; set; }
    }
}
