using FlyWeightPattern.Base;
using FlyWeightPattern.Unit;

TankUnit.SharedInformation = new SharedUnitInformation(22, 88);
InfantryUnit.SharedInformation = new SharedUnitInformation(56, 33);

var units = new List<UnitBase>
{
    new TankUnit(10, 20),
    new TankUnit(11, 21),
    new TankUnit(12, 24),
    new TankUnit(14, 26),
    new TankUnit(15, 23),
    new TankUnit(16, 29),
    new InfantryUnit(50, 10),
    new InfantryUnit(51, 11),
    new InfantryUnit(52, 14),
    new InfantryUnit(54, 16),
    new InfantryUnit(55, 13),
    new InfantryUnit(56, 19)
};

foreach (var unit in units)
{
    Console.WriteLine(unit.GetUnitInformation());
}
