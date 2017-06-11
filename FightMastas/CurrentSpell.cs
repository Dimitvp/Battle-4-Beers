using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas
{
    public class CurrentSpell
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int ManaCost { get; set; }
        public int Cooldown { get; set; }
        public int Duration { get; set; }
        public int SacrificialHP { get; set; }
        public bool isAmplifier = false;
    }
}
