using System;
using System.Resources;

namespace BusinessLogic
{
    public class BusinessClass
    {
        public void DoSometing()
        {
            Console.WriteLine("DoSomething()");

            //code that exists in external .dll - just to reproduce
            ResourceManager resourceManager = new ResourceManager("BusinessLogic", typeof(BusinessClass).Assembly);
            resourceManager.GetString("MyResource");
        }
    }
}
