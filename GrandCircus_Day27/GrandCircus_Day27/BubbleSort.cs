using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day27
{
    public class BubbleSort
    {
        public List<int> Sort(List<int> unsorted)
        {
            if (unsorted == null || unsorted.Count <= 1)
            {
                return unsorted;
            }

            for (int i = 0; i < unsorted.Count; i++)
            {
                for (int j = i + 1; j < unsorted.Count; j++)
                {
                    if (unsorted[i].CompareTo(unsorted[j]) >= 0)
                    {
                        var temp = unsorted[j];
                        unsorted[j] = unsorted[i];
                        unsorted[i] = temp;
                    }
                }
            }
            return unsorted;
        }
    }
}
