using System;
using fit;

namespace Ro.Fitnesse.Library
{
  public class Division: ColumnFixture
  {
    private double numerator, denominator, quotient;

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
      quotient = numerator/denominator;
      return quotient;
    }
  }
}
