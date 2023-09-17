using AdapterPattern;

var germanyFoundation = FoundationFactory.GetFoundation(Country.Germany);
Console.WriteLine(germanyFoundation.GetMembers());
Console.WriteLine(germanyFoundation.GetNumberInvestments());
Console.WriteLine(germanyFoundation.GetBudget());

var italianFoundation = FoundationFactory.GetFoundation(Country.Italy);
Console.WriteLine(italianFoundation.GetMembers());
Console.WriteLine(italianFoundation.GetNumberInvestments());
Console.WriteLine(italianFoundation.GetBudget());