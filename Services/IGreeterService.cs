using System;
using helloapi.Models;

namespace helloapi.Services
{
    public interface IGreeterService
    {
        IGreeter GetGreeter();
    }
}
