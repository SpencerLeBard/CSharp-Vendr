using System;
using Vendr.Interfaces;

namespace Vendr.Models
{
  abstract class Snacks : IPurchasable
  {
    public string Title { get; set; }
    // public int Price { get; set; }
    public string Description { get; set; }
    public bool IsAvailable { get; set; }

    public Snacks(string title, int price, string description, bool isAvailable)
    {
      Title = title;
      // Price = price;
      Description = description;
      IsAvailable = isAvailable;
    }
  }
}