namespace Task
{
    public static class Utility
    {
        public static int RectanglePerimeter(int w, int h)
        {
            return ((w + h) * 2);
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }



}
