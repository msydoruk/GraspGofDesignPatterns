using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IEmergencyListener
    {
        void Inform(int forceLevel);

        void Subscribe(EmergencyService emergencyService);

        void Unsubscribe(EmergencyService emergencyService);
    }
}
