internal class Program
{
    private static void Main(string[] args)
    {
        void ControlWork()
        {
            
            string[] array = {"Три", ":)", "+", "Kazan", "Семь", "Архитектор", "NY"};
            Console.Write("[");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    Console.Write(array[i] + ", ");
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }
        
        ControlWork();
    }
}