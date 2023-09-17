using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class EmergencyService
    {
        protected List<IEmergencyListener> emergencyListeners = new();

        public abstract void Add(IEmergencyListener emergencyListener);

        public abstract void Remove(IEmergencyListener emergencyListener);

        protected abstract void Notify();
    }
}
