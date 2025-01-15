using System;

class ATM
{
    public static void Main(string[] args)
    {
        int amount = 2560;
        int[] notes = { 2000, 1000, 500, 200, 100, 50, 10 };
        foreach (int note in notes)
        {
            int count = amount / note;
            if (count > 0) {
                Console.WriteLine("Rs." + note + " : " + count + " note");
                amount %= note;
            }
        }
        Console.ReadKey();
       
    }

    
}
