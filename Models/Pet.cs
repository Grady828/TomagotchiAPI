using System;
using System.Collections.Generic;

namespace TomagotchiAPI.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; } = DateTime.Now;
        public int HappinessLevel { get; set; } = 0;
        public int HungerLevel { get; set; } = 0;

        public List<Playtime> Playtimes { get; set; }
        public List<Feeding> Feedings { get; set; }
        public List<Scolding> Scoldings { get; set; }

    }

}