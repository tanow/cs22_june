using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace p08_z14
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arr = { "ус", "пех", "резерв", "вал", "про" };
            arr[0] = arr[4];
            arr[2] = arr[0];
            arr[1] = arr[3];
            arr[3] = arr[1];
            
        }
    }
}
