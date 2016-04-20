using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class Program
    {
        static int ToCelsius(int f)
        {
            int C;
            C = (int)(5.0f / 9.0f * ((float)f - 32.0f));
            return C;
        }

        static string Input(string Prompt)
        {
            Console.Write("What is the temperature in Fahrenheit? ");
            string textLine = Console.ReadLine();
            return textLine;
        }

        static void Main(string[] args)
        {
            String textLine, outLine;
            int celsius, fahrenheit;

            do
            {
                textLine = Input("What is the temperature in Fahrenheit? ");
                if (textLine != "")
                {
                    fahrenheit = int.Parse(textLine);
                    celsius = ToCelsius(fahrenheit);
                    outLine = (String.Format("Temperature in Celsius: {0:N0}", celsius.ToString()));
                    Console.WriteLine(outLine);
                }
            } while (textLine != "");
        }
    }
}
