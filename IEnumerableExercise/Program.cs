namespace IEnumerableExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<User> user = new List<User>()
            {
                new (1, "Edgar", "Mexico"),
                new(2, "Esteban", "Colombia"),
                new (3, "Xochihua", "Mexico"),
                new(4, "Joaquin", "Argentina"),
                new (5, "Diego", "Bolivia"),
                new(6, "Jose", "Venezuela")
            };
            Console.WriteLine("Filter By Country");
            var value1 = user.Filter((typeUser) => typeUser.Country == "Mexico");
            value1.ListData();
            Console.WriteLine("-------------------");
            Console.WriteLine("Filter By Name");
            var value2 = user.Filter((typeUser) => typeUser.Name == "Diego");
            value2.ListData();
            Console.WriteLine("-------------------");
            Console.WriteLine("Map Users");
            var value3 = user.Map((typeUser) =>
                {
                    typeUser.Name += " Roman";
                    return typeUser;
                }
            );
            value3.ListData();
        }
    }
}

