using System;

namespace ConsoleApp2new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] listofnumbers = { 6, 9, 12 };
            int number = 3;
            newNumber(listofnumbers, 3);

        }

        static void newNumber(int[] listofnumbers, int number)
        {
            int[] newone = new int[listofnumbers.Length + 1];
            for (int i = 0; i < listofnumbers.Length; i++)
            {
                newone[i] = listofnumbers[i];
            }
            newone[new.Length - 1] = number;
        }


    }
}
