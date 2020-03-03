using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P04Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            int i = 0;

            for (; i < stones.Count; i += 2)
            {
                yield return stones[i];
            }

            if (i < stones.Count - 1)
            {
                i = stones.Count - 1;
            }
            else
            {
                i--;
            }

            for (; i >= 0; i -= 2)
            {
                yield return stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
