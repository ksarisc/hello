using System;

namespace helloapi.Models
{
    public interface IGreeter
    {
        string New();
        string New(string name);
    }
}
