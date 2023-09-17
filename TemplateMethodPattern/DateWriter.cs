namespace TemplateMethodPattern
{
    public class DateWriter : FileWriter
    {
        protected override string Format(DateTime value)
        {
            return date.ToString("MM/dd/yyyy");
        }
    }
}
