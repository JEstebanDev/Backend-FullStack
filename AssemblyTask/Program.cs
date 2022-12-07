using System.Reflection;

namespace AssemblyTask
{
    internal class Program
    {
        private static readonly Assembly Assembly = Assembly.GetExecutingAssembly();
        private static readonly Module[] Modules = Assembly.GetModules();

        private const BindingFlags FlagInstance = BindingFlags.Instance;
        private const BindingFlags FlagStatic = BindingFlags.Static;
        private const BindingFlags FlagInstanceStatic = BindingFlags.Instance | BindingFlags.Static;

        private const BindingFlags FlagNoPublic = BindingFlags.NonPublic;
        private const BindingFlags FlagPublicNoPublic = BindingFlags.Public | BindingFlags.NonPublic;

        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
        }
        private static void Menu()
        {
            Console.WriteLine("\n---------Menu Assembly Type---------\n");
            Console.WriteLine("Select one of the following options:");
            Console.WriteLine("1: Name of the assembly's modules");
            Console.WriteLine("2: Name of all the assembly's types");
            Console.WriteLine("3: Specific information of a assembly's type");
            Console.Write("\n\nType the value to know about it or type Ctrl + C to exit: ");
            var testString = Console.ReadLine();
            switch (testString)
            {
                case "1":
                    ShowModules();
                    break;
                case "2":
                    ShowTypes();
                    break;
                case "3":
                    SecondMenu();
                    break;
            }
        }


        private static void SecondMenu()
        {
            const bool correct = true;
            while (correct)
            {
                Console.WriteLine("Insert the assembly's type name:");
                var assemblyValue = Console.ReadLine();
                if (assemblyValue != null && ValidateAssembly(assemblyValue))
                {
                    ThirdMenu(assemblyValue);
                    return;
                }
                Console.WriteLine("Error assembly not found!");
            }
        }

        private static void ThirdMenu(string assemblyValue)
        {
            const bool correct = true;
            while (correct)
            {
                Console.WriteLine("\nInsert the Methods, Constructors, Fields or Properties");
                var getOption = Console.ReadLine();
                var op1 = getOption is "Methods";
                var op2 = getOption is "Constructors";
                var op3 = getOption is "Fields";
                var op4 = getOption is "Properties";
                if (op1 | op2 | op3 | op4)
                {
                    if (getOption != null) FourthMenu(assemblyValue, getOption);
                    return;
                }
                Console.WriteLine("Error type not found!");
            }
        }

        private static void FourthMenu(string assemblyValue, string option)
        {
            const bool correct = true;
            while (correct)
            {
                Console.WriteLine("\nInsert the filtering options:");
                Console.WriteLine("Type your option : Instances, Statics or Both");
                var getFilter1 = Console.ReadLine();


                if (getFilter1 != null && (getFilter1.Equals("Instances") || getFilter1.Equals("Statics") || getFilter1.Equals("Both")))
                {
                    var filter = getFilter1 switch
                    {
                        "Instances" => FlagInstance,
                        "Statics" => FlagStatic,
                        "Both" => FlagInstanceStatic,
                        _ => throw new ArgumentOutOfRangeException()
                    };

                    Console.WriteLine("\nType your option : (1)Non Public or (2)both");
                    var getFilter2 = Convert.ToInt32(Console.ReadLine());
                    if (getFilter2 is > 0 and < 3)
                    {
                        var filter2 = getFilter2 switch
                        {
                            1 => FlagNoPublic,
                            2 => FlagPublicNoPublic,
                            _ => throw new ArgumentOutOfRangeException()
                        };

                        ShowFilter(assemblyValue, option, filter, filter2);
                        return;
                    }
                }
                Console.WriteLine("Error option not found!");
            }
        }

        private static void ShowFilter(string assemblyValue, string option, BindingFlags filter1, BindingFlags filter2)
        {

            var assembly = Assembly.GetType(assemblyValue);
            if (option.Equals("Methods"))
            {

                foreach (var method in assembly.GetMethods(filter1 | filter2))
                {
                    Console.WriteLine("Methods: " + method + " isPublic: " + method.IsPublic);
                }
            }
            if (option.Equals("Constructors"))
            {

                foreach (var constructor in assembly.GetConstructors(filter1 | filter2))
                {
                    Console.WriteLine("Constructors: " + constructor + " isPublic: " + constructor.IsPublic);
                }
            }
            if (option.Equals("Fields"))
            {

                foreach (var fields in assembly.GetFields(filter1 | filter2))
                {
                    Console.WriteLine("Fields: " + fields + " isPublic: " + fields.IsPublic);
                }
            }
            if (option.Equals("Properties"))
            {

                foreach (var property in assembly.GetProperties(filter1 | filter2))
                {
                    Console.WriteLine("Properties: " + property + " isPublic: ");
                }
            }
        }

        private static bool ValidateAssembly(string assemblyValueType)
        {
            return Modules.SelectMany(module => module.GetTypes()).Any(type => type.FullName == assemblyValueType);
        }

        private static void ShowTypes()
        {
            var types = new List<Type>();
            if (types == null) throw new ArgumentNullException(nameof(types));
            foreach (var module in Modules)
            {
                foreach (var type in module.GetTypes())
                {
                    types.Add(type);
                    Console.WriteLine("Type: " + type);
                }
            }
        }

        private static void ShowModules()
        {
            foreach (var module in Modules)
            {
                Console.WriteLine("Module: " + module);
            }
        }
    }
}