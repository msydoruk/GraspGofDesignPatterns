using ObserverPattern;

var stormService = new StormService();

var schoolListener = new SchoolListener();
var roadListener = new RoadListener();
var airportListener = new AirportListener();

schoolListener.Subscribe(stormService);
roadListener.Subscribe(stormService);
airportListener.Subscribe(stormService);

stormService.SetForceLevel(6);

schoolListener.Unsubscribe(stormService);
roadListener.Unsubscribe(stormService);

stormService.SetForceLevel(7);