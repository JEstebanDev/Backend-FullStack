namespace AssemblyTask.Project
{
    public class Calculate
    {
        private int value = 0;
        public string name = "Juanito";
        public static string lastname = "Castaño";
        private static string dni = "12333";

        public double ValueDouble { get; set; }
        private double ValueDouble2 { get; set; }
        public static double Data { get; set; }
        private static double Data2 { get; set; }
        public Calculate()
        {

        }

        private protected Calculate(int a)
        {

        }

        public Calculate(int a, int b)
        {

        }
        public int Addition2(int a, int b)
        {
            return a + b;
        }
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        private static int Substraction(int a, int b)
        {
            return a - b;
        }

        private int Substraction3(int a, int b, int c)
        {
            return a - b - c;
        }
    }
}
