using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinearList
{
    /// <summary>
    /// 线性表顺序结构
    /// </summary>
    public class SequentialList<T> : ILinearList<T>
    {
        private T[] list;

        private int length = 0;

        public int MaxSize
        {
            private set;
            get;
        }

        public int Length
        {
            get { return length; }
        }

        public SequentialList(int maxSize)
        {
            if (maxSize <= 0)
            {
                throw new Exception("the maxSize can not be less than zero");
            }
            MaxSize = maxSize;
            list = new T[maxSize];
        }

        public bool IsEmpty()
        {
            return length == 0;
        }

        public void Clear()
        {
            length = 0;
        }

        public T GetItem(int index)
        {
            return list[index];
        }

        public int LocateItem(T t)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Equals(t))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(T item, int index)
        {
            if (isFull())
            {
                throw new Exception("This linear list is full");
            }
            if (index < 0 || index > length)
            {
                throw new Exception("Location exception");
            }
            length++;
            for (int i = length - 1; i > index; i--)
            {
                list[i] = list[i - 1];
            }
            list[index] = item;
        }

        public void Add(T item)
        {
            if (isFull())
            {
                throw new Exception("This linear list is full");
            }
            length++;
            list[length - 1] = item;
        }

        public void Delete(int index)
        {
            if (index < 0 || index > length - 1)
            {
                throw new Exception("Location exception");
            }
            length--;
            for (int i = index; i < length; i++)
            {
                list[i] = list[i + 1];
            }
        }

        bool isFull()
        {
            return length >= MaxSize;
        }

    }
}
