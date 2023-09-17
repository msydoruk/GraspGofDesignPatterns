using PrototypePattern;

var defaultVehicle = new Vehicle();
var passengerVehicle = defaultVehicle.CloneByType(VehicleType.Passenger);
var cargoVehicle = defaultVehicle.CloneByType(VehicleType.Cargo);
var minivanVehicle = defaultVehicle.CloneByType(VehicleType.Minivan);

Console.WriteLine(GetAllProperties(passengerVehicle));
Console.WriteLine(GetAllProperties(cargoVehicle));
Console.WriteLine(GetAllProperties(minivanVehicle));

static string GetAllProperties(object obj)
{
    return string.Join(" ", obj.GetType().GetProperties().Select(prop => prop.GetValue(obj)));
}