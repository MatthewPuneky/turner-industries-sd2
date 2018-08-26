using System;
using System.Collections.Generic;
using System.Linq;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers
{
    public static class EnumHelper
    {
        public static List<string> PoistionValuesToStringList(Type enumType)
        {
            if (enumType.IsEnum)
            {
                return Enum.GetValues(enumType)
                    .Cast<int>()
                    .Select(x => x.ToString())
                    .ToList();
            }

            throw new Exception("Failed to call with correct type.");
        }
    }
}
