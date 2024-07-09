namespace CSharp15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int arraySize = int.Parse(Console.ReadLine());

            string[] array = new string[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Enter element {i + 1}:");
                array[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the file path to save the array:");
            string filePath = Console.ReadLine();

            try
            {
                File.WriteAllLines(filePath, array);
                Console.WriteLine("Array successfully saved to the file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
            }
        }
    }
}
