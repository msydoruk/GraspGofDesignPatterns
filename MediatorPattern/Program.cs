using MediatorPattern;
using MediatorPattern.UI;

var conciergeService = new ConciergeService();

var conciergeTaxiRequest = new ConciergeTaxiRequest();
var conciergeHouseRequest = new ConciergeHouseRequest();
var conciergeFlowersRequest = new ConciergeFlowersRequest();

conciergeService.Register(conciergeTaxiRequest);
conciergeService.Register(conciergeHouseRequest);
conciergeService.Register(conciergeFlowersRequest);

conciergeTaxiRequest.Send();
conciergeHouseRequest.Send();
conciergeFlowersRequest.Send();