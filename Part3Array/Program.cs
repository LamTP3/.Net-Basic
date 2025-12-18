namespace Part3Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int[] mang1 = new int[5] { 1, 2, 3, 4, 6};
            //int[] mang1 = [1, 2, 3, 4, 6 ];

            //Console.WriteLine($"length = {mang1.Length}");

            //for (int i = 0; i < mang1.Length; i++)
            //{
            //    //mang1[i] = i;
            //    Console.WriteLine(mang1[i]); 
            //}

            //f();
            f1();
        }

        static void f()
        {
            //int[] mang1 = new int[5] { 1, 2, 3, 4, 6};
            //int[] mang1 = [1, 2, 3, 4, 6];

            //Console.WriteLine($"length = {mang1.Length}");

            //for (int i = 0; i <= mang1.Length; i++)
            //{
            //    //mang1[i] = i;
            //    Console.WriteLine(mang1[i]);
            //}
            int[,] mang2chieu =
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11}
            };

            int[,,] mang3chieu = {
                {
                    {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                    { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11},
                }
            };

            //Console.WriteLine(mang2chieu[1, 5]);
            Console.WriteLine(mang3chieu[0, 1, 3]);

        }

        static void f1()
        {
            int[][] mm = new int[4][];

            mm[0] =new int[4];

            mm[0][0] = 1;
        }
    }

}
