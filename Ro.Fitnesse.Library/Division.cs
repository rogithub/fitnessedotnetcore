using System;

namespace Ro.Fitnesse.Library
{
  public class Division
  {
    private double numerator, denominator;

    public void SetNumerator(double numerator)
    {
      this.numerator = numerator;
    }

    public void SetDenominator(double denominator)
    {
      this.denominator = denominator;
    }

    public double Quotient()
    {
      return numerator/denominator;
    }
  }
}
