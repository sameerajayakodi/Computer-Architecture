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
        private static volatile WashingMachine washingMachine = null;
       

        public static WashingMachine GetInstant()
        {
            lock (washingMachine) {
                if (washingMachine == null)
                {
                    washingMachine = new WashingMachine();
                }

            }

            return washingMachine;
        }

        public void GetMessage()
        {
            Console.WriteLine("I am Washing Machine");
        }
    }
    }

