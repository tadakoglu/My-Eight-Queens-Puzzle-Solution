using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TADAKOGLUHOMEWORK1
{
    public class Stack
    {
        //SPECIAL STACK- T.ADAKOGLU
        private ArrayList items;
        private int topindex;
        public Stack()
        {
            items = new ArrayList();
            topindex = -1;
        }
        public Stack(int size)
        {
            items = new ArrayList(size);
            topindex = -1;
        }
        public object Items(int index)
        {
            return items[index];
        }
        public int Count
        {
            get { return items.Count; }
        }
        public void Push(object item)
        {

            items.Add(item);
            topindex++;

        }
        public object Pop()
        {
            if (Count == 0)
                throw new Exception("Stack is empty!");


            object temp = items[topindex];
            items.RemoveAt(topindex);
            topindex--;
            return temp;

        }
        public object Peek()
        {
            return items[topindex];
        }
        public void Clear()
        {
            items.Clear();
            topindex = -1;
        }
        public bool isFull()
        {
            return topindex == items.Count - 1;
        }
        private bool isEmpty()
        {
            return topindex == -1;
        }
    }
}
