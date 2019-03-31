

1. The electronic color code (http://en.wikipedia.org/wiki/Electronic_color_code) is used to indicate the values or ratings of electronic components, very commonly for resistors. Write a class that implements the following interface. Feel free to include any supporting types as necessary.

public interface IOhmValueCalculator
{
   /// <summary>
   /// Calculates the Ohm value of a resistor based on the band colors.
   /// </summary>
   /// <param name="bandAColor">The color of the first figure of component value band.</param>
   /// <param name="bandBColor">The color of the second significant figure band.</param>
   /// <param name="bandCColor">The color of the decimal multiplier band.</param>
   /// <param name="bandDColor">The color of the tolerance value band.</param>
   int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);
}

2. Created a .NET MVC web application that will allow someone to use the calculator I created in step 1.

3. Wrote unit test cases using XUnit to test the functionality written in steps 1 and 2.
