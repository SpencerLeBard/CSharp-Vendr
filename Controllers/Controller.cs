using System;
using Vendr.Services;

namespace Vendr.Controller
{
  class VendrController
  {
    private VendrService _Service { get; set; } = new VendrService();
    public bool _Running { get; set; } = true;
    public void Run()
    {
      while (_Running)
      {
        GetUserInput();
      }
    }

    private void GetUserInput()
    {
      Console.WriteLine("Options: 1.) Poptarts 2.) Your Mom 3.) Your Dad 4.) PickleRick ");
      string input = Console.ReadLine().ToLower();
      Console.Clear();
      switch (input)
      {
        case "1":
          Buy();
          break;
        case "2":
          Buy();
          break;
        case "3":
          Buy();
          break;
        case "4":
          Buy();
          break;
        default:
          Console.WriteLine("Fool of a took");
          break;
      }
    }

    private void Buy()
    {
      Console.WriteLine(_Service.GetPurchasables());
      Console.ReadLine();
    }
  }
}