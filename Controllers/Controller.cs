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
      Console.WriteLine("Options: 1.) Snacks");
      string input = Console.ReadLine().ToLower();
      Console.Clear();
      switch (input)
      {
        case "buy":
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