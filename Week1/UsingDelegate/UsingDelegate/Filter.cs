using System;
using System.Collections.Generic;
using System.Text;

namespace UsingDelegate
{
    public static class Filter
    {
        //public delegate bool Criteria(int value);
        //public delegate void Show(int value);
        //->   Action<int> showAction
        public static int[] FilterArray(int[] array, Func<int,bool> myCriteriaFunction)
        {    // get int return bool
            //return even numbers -> delegate
            List<int> result = new List<int>();
            foreach (var value in array)
            {
                if (myCriteriaFunction(value))
                {
                    result.Add(value);
                }
                //showAction(value);
            }
            return result.ToArray();
        }
    }
}
