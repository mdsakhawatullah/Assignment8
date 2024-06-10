namespace Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[2];
            jaggedArray[2] = new int[4];

            int num = 1;

            for(int i=0; i<jaggedArray.Length; i++)
            {
                for(int j=0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = num;
                    num++;
                }
            }


            Print(jaggedArray);
        }

        static void Print(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
