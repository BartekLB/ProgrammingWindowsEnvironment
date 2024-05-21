using System;
using System.Collections.Generic;
using WzorzecProjektowy;

namespace Sprawdzenie
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myObj1 = MyClass.Instance;
            MyClass myObj2 = MyClass.Instance;

            if (myObj1 == myObj2)
            {
                Console.WriteLine("myObj1 i myObj2 są tym samym obiektem");
            }
            else
            {
                Console.WriteLine("myObj1 i myObj2 są różnymi obiektami");
            }
        }
    }
}