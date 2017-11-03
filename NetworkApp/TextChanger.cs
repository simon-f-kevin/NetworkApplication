using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Core
{
    public class TextChanger
    {
        public static string ChangeText(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
            {
                return "";
            }

            return new string(input.Reverse().ToArray());
        }
    }
}