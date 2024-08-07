namespace InsertInArray;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter the number of elements in the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Enter elements number {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter element to insert: ");
        int X = int.Parse(Console.ReadLine());

        Console.Write("Enter the position to insert: ");
        int index = int.Parse(Console.ReadLine());

        if (index <= 1 || index >= array.Length - 1)
        {
            Console.WriteLine("Can not insert.");
        }
        else
        {

            int[] newArray = new int[array.Length + 1];
            for (int i = 0, j = 0; i < newArray.Length; i++)
            {
                if (i == index)
                {
                    newArray[i] = X;
                }
                else
                {
                    newArray[i] = array[j++];
                }
            }

            
            Console.WriteLine("Array after inserting new element:");
            foreach (int item in newArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}

