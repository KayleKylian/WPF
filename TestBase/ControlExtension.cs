using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TestBase.ControlExtension
{
    public class TextExtensor
    {
        public static string Clear(TextBox text) => text.Text = string.Empty;
        public static void CountChanger(TextBlock number, string signal) 
        {
            int actualNumber;
            int.TryParse(number.Text, out actualNumber);
            if (signal == "+") actualNumber++;
            else if (signal == "-") actualNumber--;
            number.Text = actualNumber.ToString();
        }
    }
}
