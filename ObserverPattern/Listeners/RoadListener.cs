using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class RoadListener : IEmergencyListener
    {
        private const int MinimalForceLever = 5;

        public void Inform(int forceLevel)
        {
            if (forceLevel >= MinimalForceLever)
                Console.WriteLine($"Road: Keep safe place. Storm force: {forceLevel}.");
        }

        public void Subscribe(EmergencyService emergencyService)
        {
            emergencyService.Add(this);
        }

        public void Unsubscribe(EmergencyService emergencyService)
        {
            emergencyService.Remove(this);
        }
    }
}
