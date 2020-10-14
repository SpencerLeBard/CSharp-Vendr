using System;
using Vendr.Interfaces;

namespace Vendr.Models
{
  class Snack : IPurchasable
  {
    public string Title { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }
    public bool IsAvailable { get; set; }

    public Snack(string title, int price, string description)
    {
      Title = title;
      Price = price;
      Description = description;
      IsAvailable = true;
    }
  }
}