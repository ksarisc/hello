using System;
using helloapi.Models;

namespace helloapi.Services
{
    public class GreeterService : IGreeterService
    {
        public Greeting GetGreeting()
        {
            return CraftHello();
        }
        public Greeting GetGreeting(string name)
        {
            return CraftHello(name);
        }

        private static Greeting CraftHello(string name = null)
        {
            if (!String.IsNullOrWhiteSpace(name)) {
                return new Greeting{
                    Name = name,
                    Message = $"Hello, {name}!"
                };
            }
            return new Greeting{ Message = $"Hello, World!" };
        }
    }
}
