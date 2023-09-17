using System.Drawing;

namespace PrototypePattern
{
    public class Vehicle
    {
        public Vehicle()
        {
            Color = Color.Red;
            Number = 0;
            Type = VehicleType.Passenger;
        }

        public VehicleType Type { get; private set; }

        public Color Color { get; set; }

        public int Number { get; set; }

        public Vehicle CloneByType(VehicleType vehicleType)
        {
            var newVehicle = (Vehicle)MemberwiseClone();
            switch (vehicleType)
            {
                case VehicleType.Passenger:
                    newVehicle.Type = VehicleType.Passenger;
                    break;
                case VehicleType.Cargo:
                    newVehicle.Type = VehicleType.Cargo;
                    break;
                case VehicleType.Minivan:
                    newVehicle.Type = VehicleType.Minivan;
                    break;
            }

            return newVehicle;
        }
    }
}
