using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class StormService : EmergencyService
    {
        private int forceLevel;
        private const int MinimalForceLevel = 1;

        public override void Add(IEmergencyListener emergencyListener)
        {
            emergencyListeners.Add(emergencyListener);
        }

        public override void Remove(IEmergencyListener emergencyListener)
        {
            emergencyListeners.Remove(emergencyListener);
        }

        protected override void Notify()
        {
            foreach (var emergencyListener in emergencyListeners)
            {
                emergencyListener.Inform(forceLevel);
            }
        }

        public void SetForceLevel(int level)
        {
            this.forceLevel = level;
            if (forceLevel > MinimalForceLevel)
            {
                Notify();
            }
        }
    }
}
