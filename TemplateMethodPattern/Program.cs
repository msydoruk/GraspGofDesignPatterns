using TemplateMethodPattern;

FileWriter dateWriter = new DateWriter();
FileWriter dateTimeWriter = new DateTimeWriter();

dateTimeWriter.Save(DateTime.UtcNow);
dateWriter.Save(DateTime.UtcNow);