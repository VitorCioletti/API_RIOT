using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace riotAPI_teste.Entities
{
    class Stats
    {
        [JsonProperty("armor")]
        public double armor;
        [JsonProperty("armorPerLevel")]
        public double armorPerLevel;
        [JsonProperty("attackDamage")]
        public double attackDamage;
        [JsonProperty("attackDamagePerLevel")]
        public double attackDamagePerLevel;
        [JsonProperty("attackRange")]
        public double attackRange;
        [JsonProperty("attackSpeedOffSet")]
        public double attackSpeedOffSet;
        [JsonProperty("attackSpeedPerLevel")]
        public double attackSpeedPerLevel;
        [JsonProperty("crit")]
        public double crit;
        [JsonProperty("critPerLevel")]
        public double critPerLevel;
        [JsonProperty("hp")]
        public double hp;
        [JsonProperty("hpPerLevel")]
        public double hpPerLevel;
        [JsonProperty("hpRegen")]
        public double hpRegen;
        [JsonProperty("hpRegenPerLevel")]
        public double hpRegenPerLevel;
        [JsonProperty("moveSpeed")]
        public double moveSpeed;
        [JsonProperty("mp")]
        public double mp;
        [JsonProperty("mpPerLevel")]
        public double mpPerLevel;
        [JsonProperty("spellBlock")]
        public double spellBlock;
        [JsonProperty("spellBlockPerLevel")]
        public double spellBlockPerLevel;
    }
}
