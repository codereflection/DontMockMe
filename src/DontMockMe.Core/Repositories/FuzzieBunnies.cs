using System;
using System.Collections.Generic;
using DontMockMe.Core.Models;

namespace DontMockMe.Core.Repositories
{
    public class FuzzieBunnies
    {
        public IList<FuzzieBunny> GetThemBunnies()
        {
            return new[]
                       {
                           new FuzzieBunny { Name = "Fluffy", Color = "Pink" },
                           new FuzzieBunny { Name = "Midnight", Color = "Black" },
                           new FuzzieBunny { Name = "PunkRockBunny", Color = "Blue" },
                           new FuzzieBunny { Name = "DrEvil", Color = "Red" },
                       };
        }

        public static Func<IList<FuzzieBunny>> GetAll = () => new FuzzieBunnies().GetThemBunnies();
    }
}