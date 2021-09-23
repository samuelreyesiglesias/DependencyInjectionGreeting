using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionGreeting.Interfaces
{
    public interface IGreetings
    {
        public string[] Greetings { get; set; }
        public string Greeting { get;  }
    }
    public interface IGreetingTransient : IGreetings
    {
    }
    public interface IGreetingScoped : IGreetings
    {
    }

    public interface IGreetingSingleton: IGreetings
    {
    }

    public interface IGreetingSingletonInstance : IGreetings { }
}
