using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Examples
{
    internal class Heap
    {
        protected List<int> items = new List<int>();

        protected int GetLeftChildIndex(int parentIndex) { return 2 * parentIndex + 1; }
        protected int GetRightChildIndex(int parentIndex) { return 2 * parentIndex + 2; }
        protected int GetParentIndex(int childIndex) { return (childIndex - 1) / 2; }


        protected bool HasLeftChild(int index) { return GetLeftChildIndex(index) < items.Count; }
        protected bool HasRightChild(int index) { return GetRightChildIndex(index) < items.Count; }
        protected bool HasParent(int index) { return GetParentIndex(index) >= 0; }


        protected int LeftChild(int index) { return items[GetLeftChildIndex(index)]; }
        protected int RightChild(int index) { return items[GetRightChildIndex(index)]; }
        protected int Parent(int index) { return items[GetParentIndex(index)]; }


        protected void Swap(int indexOne, int indexTwo)
        {
            int temp = items[indexOne];
            items[indexOne] = items[indexTwo];
            items[indexTwo] = temp;
        }

        public int Peek()
        {
            if (items.Count == 0) throw new IndexOutOfRangeException();
            return items[0];
        }
    }
}
