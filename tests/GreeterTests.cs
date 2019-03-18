using System;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using helloapi.Controllers;
using helloapi.Models;
using helloapi.Services;

namespace tests
{
    public class GreetingTests
    {
        GreetingsController _controller;
        IGreeterService _service;
        public GreetingTests()
        {
            _service = new GreeterService();
            _controller = new GreetingsController(_service);
        }

        [Fact]
        public void HelloReturnsOk()
        {
            var okResult = _controller.Get().Result;
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GreetingReturnsHelloWorld()
        {
            var expected = new Greeting{
                Message = "Hello, World!"
            };
            var actual = _service.GetGreeting();
            Assert.Equal(expected.Message, actual.Message); //Not
        }

        [Fact]
        public void HelloNameReturnsOk()
        {
            var okResult = _controller.Get("Name").Result;
            Assert.IsType<OkObjectResult>(okResult);
        }
        
        [Fact]
        public void GreetingNameReturnsHelloName()
        {
            var expected = new Greeting{
                Name = "Name",
                Message = "Hello, Name!"
            };
            var actual = _service.GetGreeting("Name");
            Assert.Equal(expected.Message, actual.Message); //Not
        }
        
        [Fact]
        public void GreetingnameNOTReturnsHelloName()
        {
            var expected = "Hello, name!";
            var actual = _service.GetGreeting("Name").Message;
            Assert.NotEqual(expected, actual);
        }
    }
}
