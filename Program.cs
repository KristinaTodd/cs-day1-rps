using System;
using System.Threading;

namespace cs_day1_rps
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.BackgroundColor = ConsoleColor.Gray;
      Console.Clear();
      Console.WriteLine("HELLO!");
      Console.WriteLine("What is your name?");
      string name = Console.ReadLine();
      Console.Clear();
      Console.WriteLine("Welcome " + name + "!");
      bool running = true;
      while (running)
      {
        Console.WriteLine("Do you want to play a game with me? (y/n)");
        if (Console.ReadKey().KeyChar == 'n')
        {
          running = false;
          break;
        }
        Console.Clear();
        Console.WriteLine("OKAY! Let's play!");
        Console.WriteLine(@"
                                   88         
                                   88         
                                   88         
8bdPPYba.    .adPPYba.   aadPPYba  88   d8a   
88P     a8  aa       8a a8      aa 88 a8a
88          8b       d8 8b         88888
88          8a       a8 8a.    .aa 88  Yba
88            YbbdP88*   *Ybbd88*  88   Y8a


8b,dPPYba    adPPYYba, 8bdPPYba.   .adPPYba.  8bdPPYba.  
88P     8a         88P 8a     8P   88     88P Y8P     a8
88       d8  adPPPPP88 88      d8  8P******** 88          
88b     a8   88     88 88b    a8   8b.   .aa  88          
88YbbdPP*     98bbdPY8 88YbbdP*      8Ybbd8   88
88                     88
88                     88


.adPPYba.  .adPPYba.  88 .adPPYba. .adPPYba   .PDPPYba.  8bdPPYba. .adPPYba.
I8I     ** a8*     ** 88 I8I    ** I8I    ** a8*     *8a Y8P    a8 I8I    **
  **Y8ba.  8b         88   **Y8ba.   **Y8ba. 8b       d8 88         **Y8ba.
aa    I8I  *8a.   .aa 88 aa    I8I  aa    I8I *8a    .a8 88        aa    I8I
**YbbdP**   **Ybbd8*  88 **YbbdP**  **YbbdP**   *YbbdP** 88        **YbbdP**
");

        Thread.Sleep(1000);
        Console.WriteLine("MAKE YOUR CHOICE");
        string[] choices = new string[]{
            "rock",
            "paper",
            "scissors"
        };
        Random rnd = new Random();
        int compChoice = rnd.Next(3);

        var computerChoice = choices[compChoice];

        string playerChoice = Console.ReadLine().ToLower().Trim();


        if (playerChoice == "paper")
        {

        }

      }

    }
  }
}
