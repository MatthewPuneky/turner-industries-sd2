using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Common.Menus
{
    public static class MenuFactory<T> where T : Menu, new()
    {
        public static Menu GenerateConstructorless() => new T();
    }
}
