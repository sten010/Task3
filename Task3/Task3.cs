namespace ConsoleApp_test
{
    interface IParam
    {
        public string? Value { get; set; } 
    }
    public class Task3 : IParam
    {
        public string? Value { get; set; }

        public void Main()
        {
            Console.WriteLine("Укажите задание");
            int task =Convert.ToInt32( Console.ReadLine());

            switch (task)
            {
                case 1:
                    MassiveTask1();
                    break;
                case 2:
                    MassiveTask2();
                    break;
                case 3:
                    MassiveTask3();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
        private void MassiveTask1()
        {
            Console.WriteLine("Введите с клавиатуры строку произвольной длины");
            string? v = Console.ReadLine();
            Value = v;
            if (string.IsNullOrEmpty(Value))
            {
                Console.WriteLine("Пустое значения");
            }
            char[] masive = Value.ToCharArray();
            Console.WriteLine(masive.Count());
            Console.ReadKey();
        }
        private void MassiveTask2()
        {
            Random random = new Random();
            int size = 20;
            int[] a = new int[size];
            for (int i = 0; size > i; i++)
            {
                a[i] = random.Next(0, 1000);
            }
            List<int> b = new List<int>();
            b.AddRange(a.Where(c => c <= 888));
            b.Sort();
            Console.WriteLine(string.Join("\n\r", b));
            Console.ReadKey();
        }
        private void MassiveTask3()
        {
            Random random = new Random();
            int size = 10;
            int[,] massive = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    massive[i, j] = random.Next(100);
                    Console.Write("{0,4}", massive[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
