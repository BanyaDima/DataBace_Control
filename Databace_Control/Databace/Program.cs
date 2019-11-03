using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databace
{
    class Program
    {
        static void Main(string[] args)
        {
            var match = new MatchesRepository();

            match.GetInfo();

        }
    }
}
