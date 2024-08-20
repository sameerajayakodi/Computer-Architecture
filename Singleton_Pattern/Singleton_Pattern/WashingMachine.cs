using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    public class WashingMachine
    {
        private WashingMachine() { }

        private static WashingMachine instance = new WashingMachine();

        public static WashingMachine GetInstance()
        {
            return instance;
        }

        public void ShowMessage() {
            Console.WriteLine("I am Singleton object");
        }
        
       }
    }

