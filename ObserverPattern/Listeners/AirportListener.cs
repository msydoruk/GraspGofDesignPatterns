using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class AirportListener : IEmergencyListener
    {
        private const int MinimalForceLever = 6;

        public void Inform(int forceLevel)
        {
            if (forceLevel >= MinimalForceLever)
                Console.WriteLine($"Airport: Keep safe place. Storm force: {forceLevel}.");
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
