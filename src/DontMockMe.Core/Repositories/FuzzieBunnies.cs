using System.Collections.Generic;
using DontMockMe.Core.Models;

namespace DontMockMe.Core.Repositories
{
    public class FuzzieBunnies
    {
        public IList<FuzzieBunny> GetThemBunnies()
        {
            return new List<FuzzieBunny>();
        }
    }
}