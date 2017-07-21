using Newtonsoft.Json;

namespace riotAPI_teste
{
    class Stat
    {
        [JsonProperty("armor")]
        public double armor { get; set; }
        [JsonProperty("armorPerLevel")]
        public double armorPerLevel { get; set; }
        [JsonProperty("attackDamage")]
        public double attackDamage { get; set; }
        [JsonProperty("attackDamagePerLevel")]
        public double attackDamagePerLevel { get; set; }
        [JsonProperty("attackRange")]
        public double attackRange { get; set; }
        [JsonProperty("attackSpeedOffSet")]
        public double attackSpeedOffSet { get; set; }
        [JsonProperty("attackSpeedPerLevel")]
        public double attackSpeedPerLevel { get; set; }
        [JsonProperty("crit")]
        public double crit { get; set; }
        [JsonProperty("critPerLevel")]
        public double critPerLevel { get; set; }
        [JsonProperty("hp")]
        public double hp { get; set; }
        [JsonProperty("hpPerLevel")]
        public double hpPerLevel { get; set; }
        [JsonProperty("hpRegen")]
        public double hpRegen { get; set; }
        [JsonProperty("hpRegenPerLevel")]
        public double hpRegenPerLevel { get; set; }
        [JsonProperty("moveSpeed")]
        public double moveSpeed { get; set; }
        [JsonProperty("mp")]
        public double mp { get; set; }
        [JsonProperty("mpPerLevel")]
        public double mpPerLevel { get; set; }
        [JsonProperty("spellBlock")]
        public double spellBlock { get; set; }
        [JsonProperty("spellBlockPerLevel")]
        public double spellBlockPerLevel { get; set; }
    }
}
