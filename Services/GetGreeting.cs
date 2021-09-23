using DependencyInjectionGreeting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionGreeting.Services
{
    public class GetGreeting: IGreetingTransient,IGreetingScoped,IGreetingSingleton,IGreetingSingletonInstance
    {
        public string[] Greetings { get; set; } = new string[] { "Hi","Hello","How are You","Good to see you","Howdy","Wahts Up"};
        public string Greeting { get; set; }

        public GetGreeting()
        {
            Random SelectedRandom = new Random();
            Greeting=Greetings[SelectedRandom.Next(0, (Greetings.Length-1))];
        }
        public GetGreeting(int Index)
        {
            try
            {
               Greeting= Greetings[Index];
            }
            catch (Exception Ex)
            {
               Greeting=Greetings[0];
            }
        }
    }
}
