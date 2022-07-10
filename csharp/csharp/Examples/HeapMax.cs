using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Examples
{
    internal class HeapMax : Heap
    {
        public int Poll()
        {
            if (items.Count == 0) throw new IndexOutOfRangeException();
            var item = items[0];
            items[0] = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            HeapifyDown();
            return item;
        }

        public void Add(int num)
        {
            items.Add(num);
            HeapifyUp();
        }

        private void HeapifyUp()
        {
            var index = items.Count - 1;
            while (HasParent(index) && Parent(index) < items[index])
            {
                Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }
        }

        private void HeapifyDown()
        {
            var index = 0;
            while (HasLeftChild(index))
            {
                var biggerChildIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && items[GetLeftChildIndex(index)] < items[GetRightChildIndex(index)])
                {
                    biggerChildIndex = GetRightChildIndex(index);
                }

                if (items[index] > items[biggerChildIndex]) break;
                else
                {
                    Swap(index, biggerChildIndex);
                    index = biggerChildIndex;
                }
            }
        }
    }
}
