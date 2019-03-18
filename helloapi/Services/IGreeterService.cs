using System;
using helloapi.Models;

namespace helloapi.Services
{
    public interface IGreeterService
    {
        Greeting GetGreeting();
        Greeting GetGreeting(string name);
    }
}
