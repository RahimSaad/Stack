using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stack
{
    /*
     * a stack based on a dynamic array
     * Capacity: the size of the array upon which the stack is built(arr)
     * Top: value refers to the stack top element
     * arr: an array that the stack is built upon
     */
    class DynamicMemoryStack<T> where T : class
    {
        public int Capacity => arr.Length;
        int Top;
        T[] arr;

        public DynamicMemoryStack()
        {
            Top = -1;
            arr = new T[1];
        }

        /*
         * incase the stack is full or half of it is empty ,this method adjust the capacity 
         * to ensure available space or to save unused space
         * newCapacity: is the desired capacity for the stack
         */
        private void adjustCapacity(int newCapacity)
        {
            T[] tmp = new T[newCapacity];
            for (int i = 0; i <= Top; i++)
            {
                tmp[i] = this.arr[i];
            }
            this.arr = tmp;
        }

        /*
         * push item to the stack if it's not full ,if the stack is full the capacity get doublicated
         * item: an item to be pushed into the stack
         * before using it u should ensure that the stack is not full through [isFull()]
         */
        public void push(T item)
        {
            if (isFull())
            {
                adjustCapacity(arr.Length*2);
            }
            arr[++Top] = item;
        }

        /*
         * pops item from the stack if it's not Empty ,if the stack is Empty it outs null and return false the capacity get doublicated
         * item: an item to be outs from the stack
         * before using it u should ensure that the stack is not empty through [isEmpty()]
         */
        public T pop()
        {
            if (Top < 0.5 * arr.Length)
            {
                adjustCapacity((int)(0.5 * arr.Length));
            }
            return arr[Top--];
        }

        /*
         * return boolean indicate whether the stack is full or not
         */
        public bool isFull()
        {
            return Top == arr.Length - 1;
        }

        /*
         * return boolean indicate whether the stack is empty or not
         */
        public bool isEmpty()
        {
            return Top == -1;
        }
    }
}
