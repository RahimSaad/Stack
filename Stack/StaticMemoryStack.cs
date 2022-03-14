using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stack
{
    /*
     * a stack based on a static array
     * Size: the size of the array upon which the stack has been built(arr)
     * Top: value refers to the stack top element
     * arr: an array that the stack has been built upon
     */
    class StaticMemoryStack<T> where T: class
    {
        public int Size { get; }
        int Top;
        T[] arr;

        public StaticMemoryStack(int size)
        {
            if (size < 0){ throw new Exception("stack size cannot be negative"); } // to ensure the size of the stack won't be negative
            this.Size = size;
            this.Top = -1;
            this.arr = new T[this.Size];
        }

        /*
         * push item to the stack
         * before using it u should ensure that the stack is not full through [isFull()]
         * item: an item to be pushed into the stack 
         */
        public void push(T item)
        {
            arr[++Top] = item;
        }

        /*
         * pops item from the stack 
         * before using it u should ensure that the stack is not empty through [isEmpty()]
         * item: an item to be outs from the stack
         */
        public T pop()
        {
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
