using System;

namespace helloapi.Models
{
    public class Greeter : IGreeter
    {
        private static string Get(string name = null)
        {
            if (!String.IsNullOrWhiteSpace(name)) {
                return $"Hello, {name}!";
            }
            return $"Hello, World!";
        }
        public string New()
        {
            return Get();
        }
        public string New(string name)
        {
            return Get(name);
        }
    }
}
