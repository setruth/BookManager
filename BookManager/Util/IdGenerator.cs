using System;

namespace BookManager.Util
{
    public static class IdGenerator
    {
        private static readonly object LockObj = new object();
        private static readonly Random _random = new Random();

        public static string GenerateId()
        {
            lock (LockObj)
            {
                return $"{DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()}-{_random.Next(1000, 9999)}";
            }
        }
    }
}