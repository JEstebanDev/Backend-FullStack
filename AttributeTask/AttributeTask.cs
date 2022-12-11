using System.Reflection;

namespace AttributesTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            //set the value
            var cs = new Client
            {
                ClientName = "Juan"
            };

            //System Reflection to find the attribute and the value name 
            var value = Assembly.GetExecutingAssembly().GetType("AttributesTask.Client");
            var properties = typeof(Client).GetProperties();
            var countTabs = 0;
            foreach (var prop in properties)
            {
                //save the tabs in te variable countTabs
                countTabs = prop.GetCustomAttributes().Count();
                //print the property name and the attribute quantity types 
                Console.WriteLine("Property Name: " + prop.Name + " Quantity: " + prop.GetCustomAttributes().Count());
            }
            //Adding the tabs to the value
            var tabs = "    ";
            for (var i = 0; i < countTabs; i++)
            {
                tabs += tabs;
            }
            //print the result
            Console.WriteLine(tabs + value?.GetProperty("ClientName")?.GetValue(cs));

        }
    }

    internal class Client
    {
        [Tab]
        [Tab]
        [Tab]
        [Tab]
        public string? ClientName { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class Tab : Attribute
    {
    }
}


