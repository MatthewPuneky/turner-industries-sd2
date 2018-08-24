using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Builder
{
    public abstract class CharacterBuilder
    {
        public abstract void BuildArmor();
        public abstract void BuildWeapon();
        public abstract void BuildAttributes();

        public abstract Character GetResult();
    }
}
