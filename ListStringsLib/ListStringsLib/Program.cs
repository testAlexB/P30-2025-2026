using System.Collections.Generic;

namespace ListStringsLib
{
    class Program
    {
        static private void Main()
        {
           List<string> listStrings =  ListStringsModule.InputListStrings();

           List<int> numbers = ListStringsModule.FindIndexesWithContainsText("abc", listStrings);

           ListIntegersModule.PrintNumbers(numbers);
        }
    }
}
