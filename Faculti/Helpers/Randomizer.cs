using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculti.Helpers
{
    class Randomizer
    {
        public static int GenerateVerificationCode()
        {
            Random randomizer = new Random();
            return randomizer.Next(1000, 9999);
        }
    }
}
