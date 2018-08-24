using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Builder
{
    public class CharacterBuilderDirector
    {
        public void Construct(CharacterBuilder builder)
        {
            builder.BuildArmor();
            builder.BuildWeapon();
            builder.BuildAttributes();
        }
    }
}
