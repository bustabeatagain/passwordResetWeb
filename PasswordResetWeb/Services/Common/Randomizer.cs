using System;

namespace PasswordResetWeb.Services.Common
{
    public class Randomizer : RandomizerBase
    {
        private Random Random {get;set;}
        public Randomizer()
        {
            Random = new Random();
        }
        public override int GetInt(int min, int max)
        {
            return Random.Next(min, max);
        }
    }
}