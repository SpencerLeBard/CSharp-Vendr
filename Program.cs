using System;
using Vendr.Controller;

namespace Vendr
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(@"
____   ____                 .___       
\   \ /   /____   ____    __| _/______ 
 \   Y   // __ \ /    \  / __ |\_  __ \
  \     /\  ___/|   |  \/ /_/ | |  | \/
   \___/  \___  >___|  /\____ | |__|   
              \/     \/      \/       ");
      new VendrController().Run();

    }
  }
}
