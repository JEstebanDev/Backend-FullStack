using System;
using System.Runtime.InteropServices;

namespace DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\nTYPES LIST");
                var types = new[] { "bool", "byte", "char", "short", "int", "long", "float", "double", "decimal", "string" };

                var real_Types = new[] { typeof(bool), typeof(byte), typeof(char), typeof(short), typeof(int),
                typeof(long), typeof(float), typeof(double), typeof(decimal), typeof(string)};

                foreach (var type in types)
                    Console.Write(type + ", ");
                
                string testString;
                Console.Write("\n\nType the value to know about it or type Ctrl + C to exit: ");
                testString = Console.ReadLine();

                for (int i = 0; i < types.Length; i++)
                    if (types[i].Equals(testString))
                        showData(real_Types[i].FullName);
            }
        }

        private static void showData(string fullName)
        {
            if (fullName.Equals("System.String"))
            {
                Type myType = Type.GetType(fullName);
                Console.WriteLine("Type name = " + myType.FullName);
                Console.WriteLine("Data type = " + (myType.IsValueType ? "Value data type" : "Reference data type"));
            }
            else
            {
                try
                {
                    Console.WriteLine("| {0, -15} | {1, 7} | {2, 15} | {3, 30} | {4, 30} |", "Type", "Size", "Data type", "Min", "Max");
                    Console.WriteLine("|-----------------|---------|-----------------|--------------------------------|--------------------------------|");
                    Type myType = Type.GetType(fullName);
                    Console.WriteLine(
                       "| {0, -15} | {1, 7} | {2, 15} | {3, 30} | {4, 30} |",
                       myType.FullName,
                       Marshal.SizeOf(Activator.CreateInstance(myType)),
                       myType.IsValueType ? "Value data type" : "Reference data type",
                       myType.GetField("MinValue") != null ? myType.GetField("MinValue").GetValue(null) : "N/A",
                       myType.GetField("MaxValue") != null ? myType.GetField("MaxValue").GetValue(null) : "N/A");
                }
                catch (TypeLoadException e)
                {
                    Console.WriteLine("{0}: Unable to load type", e.GetType().Name);
                }
            }
        }
    }
}
