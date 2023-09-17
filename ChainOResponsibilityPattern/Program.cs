using ChainOResponsibilityPattern;

IHelpService helpService = new HelpService();
var fileDepartmentResponse = helpService.ProcessMessageFromEmployee(HelpCommand.FireDepartment);
Console.WriteLine(fileDepartmentResponse);

var policeMessageResponse = helpService.ProcessMessageFromEmployee(HelpCommand.Police);
Console.WriteLine(policeMessageResponse);

var medicalAssistanceResponse = helpService.ProcessMessageFromEmployee(HelpCommand.MedicalAssistance);
Console.WriteLine(medicalAssistanceResponse);

var notSpecificResponse = helpService.ProcessMessageFromEmployee(HelpCommand.NotSpecific);
Console.WriteLine(notSpecificResponse);
