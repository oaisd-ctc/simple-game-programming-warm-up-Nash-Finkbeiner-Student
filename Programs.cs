using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Dice Game \n \nIn this game you and a computer Rival will play 10 rounds\nwhere you will each roll a 6-sided dice, and the player\nwith the highest dice value will win the round. The player\nwho wins the most rounds wins the game. Good luck!");
        Console.WriteLine("Press any key to start...");
        Console.ReadKey();
        int rscore = 0;
        int yscore = 0;
        for(int i = 1; i < 11; i++)
        {
            int dicer = Rival();
            Console.WriteLine("Round " + i + "\nRival rolled a " + dicer);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Random rnd = new Random();
            int dicey = rnd.Next(1, 11);
            Console.WriteLine("You rolled a " + dicey);
            if(dicer > dicey)
            {
                Console.WriteLine("The Rival won this round.");
                rscore++;
            }
            else
            {
                Console.WriteLine("You won this round.");
                yscore++;
            }
            Console.WriteLine("The score is now - You : " + yscore + " Rival : " + rscore + ".");
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();
        }
        Console.WriteLine("Game over.");
        Console.WriteLine("The score is now - You : " + yscore + " Rival : " + rscore + ".");
        if(rscore > yscore)
        {
            Console.WriteLine("You lost!");
        }
        else
        {
            Console.WriteLine("You win!");
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    public static int Rival()
    {
        Random rnd = new Random();
        int dice = rnd.Next(1, 11);
        return dice;
    }
}