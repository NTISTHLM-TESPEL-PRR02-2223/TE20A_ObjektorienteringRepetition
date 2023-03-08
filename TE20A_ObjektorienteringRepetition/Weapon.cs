using System;

public class Weapon
{
  public string name;
  public int damage;

  public int Attack()
  {
    Random generator = new Random();

    if (generator.Next(10) == 0)
    {
      return damage * 2;
    }

    return damage;
  }
}
