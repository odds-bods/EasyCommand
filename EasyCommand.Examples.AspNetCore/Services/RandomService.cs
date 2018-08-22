using System;

namespace EasyCommand.Examples.AspNetCore.Services
{
    public class RandomService : IRandomService
    {
        private Random random = new Random();

        public int Next()
        {
            return random.Next(0, 100);
        }
    }
}