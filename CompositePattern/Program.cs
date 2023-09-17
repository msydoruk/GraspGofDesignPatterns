using CompositePattern;

var rootLocation = new Location("Root", 0);

var childLeafLocation1 = new LeafLocation("LeafChild_1", 0);
var childLocation2 = new Location("Child_2", 0);
var childLocation3 = new Location("Child_3", 0);

rootLocation.Add(childLeafLocation1);
rootLocation.Add(childLocation2);
rootLocation.Add(childLocation3);

var childLocation21 = new Location("Child_2_1", 0);
var childLocation22 = new Location("Child_2_2", 0);
var childLocation23 = new Location("Child_2_3", 0);

childLocation2.Add(childLocation21);
childLocation2.Add(childLocation22);
childLocation2.Add(childLocation23);

var childLocation221 = new LeafLocation("Child_2_2_1", 0);
var childLocation222 = new LeafLocation("Child_2_2_2", 0);
var childLocation223 = new LeafLocation("Child_2_2_3", 0);

childLocation22.Add(childLocation221);
childLocation22.Add(childLocation222);
childLocation22.Add(childLocation223);

childLeafLocation1.IncrementVersionForChildElements();
childLeafLocation1.IncrementVersionForChildElements();
childLocation2.IncrementVersionForChildElements();
childLocation22.IncrementVersionForChildElements();
childLocation22.IncrementVersionForChildElements();
rootLocation.Display();

childLeafLocation1.DecrementVersionForChildElements();
childLocation22.DecrementVersionForChildElements();
rootLocation.Display();

