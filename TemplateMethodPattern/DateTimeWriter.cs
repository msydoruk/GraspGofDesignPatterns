namespace TemplateMethodPattern
{
    public class DateTimeWriter : FileWriter
    {
        protected override string Format(DateTime value)
        {
            return date.ToString("MM/dd/yyyy hh:mm tt");
        }
    }
}
