
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsCase.Utils.Helper
{
    public static class Extensions
    {
        public static string SplitCoordinates(String str)
        {
            var result = string.Empty;
            if (!string.IsNullOrWhiteSpace(str))
            {
                var splittedValue = str.Split(' ');
                if (splittedValue.Length == 2)
                {
                     result = String.Join(", ", splittedValue);

                    return result;
                }
            
            }
            return result;
        }

      
    }
}
