using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinearList
{
    /// <summary>
    /// 线性表链式结构
    /// </summary>
    public class LinkList<T> : ILinearList<T>
    {
        private LinkNode<T> firstNode;

        public int Length
        {
            get
            {
                var node = firstNode;
                int length = 0;
                while (node != null)
                {
                    length++;
                    node = node.NextNode;
                }
                return length;
            }
        }

        public void Add(T item)
        {
            if (firstNode == null)
            {
                firstNode = new LinkNode<T> { Node = item };
            }
            else
            {
                LinkNode<T> node = firstNode;
                while (node.NextNode != null)
                {
                    node = node.NextNode;
                }
                node.NextNode = new LinkNode<T> { Node = item };
            }
        }

        public void Clear()
        {
            firstNode = null;
        }

        public void Delete(int index)
        {
            if (firstNode == null)
            {
                throw new Exception("List is empty");
            }
            if (index < 0)
            {
                throw new Exception("Location exception");
            }
            var node = firstNode.NextNode;
            var prevNode = firstNode;
            int i;
            for (i = 1; i < index && node != null; i++)
            {
                prevNode = node;
                node = node.NextNode;
            }
            if (i == index)
            {
                if (node.NextNode != null)
                {
                    prevNode.NextNode = node.NextNode;
                }
                else
                {
                    prevNode.NextNode = null;
                }
            }
            else
            {
                throw new Exception("Locaion exception");
            }
        }

        public T GetItem(int index)
        {
            if (firstNode == null)
            {
                throw new Exception("List is empty");
            }
            if (index < 0)
            {
                throw new Exception("Location exception");
            }
            var node = firstNode.NextNode;
            int i;
            for (i = 1; i < index && node != null; i++)
            {
                node = node.NextNode;
            }
            if (i == index)
            {
                return node.Node;
            }
            else
            {
                throw new Exception("Locaion exception");
            }
        }

        public void Insert(T item, int index)
        {
            if (firstNode == null)
            {
                throw new Exception("List is empty");
            }
            if (index < 0)
            {
                throw new Exception("Location exception");
            }
            var node = firstNode.NextNode;
            int i;
            for (i = 1; i < index && node != null; i++)
            {
                node = node.NextNode;
            }
            if (i == index)
            {
                var nextNode = node.NextNode == null ? null : node.NextNode;
                node.NextNode = new LinkNode<T> { Node = item, NextNode = nextNode };
            }
            else
            {
                throw new Exception("Locaion exception");
            }
        }

        public bool IsEmpty()
        {
            return firstNode == null;
        }

        public int LocateItem(T t)
        {
            var index = 0;
            var node = firstNode;
            while (!node.Node.Equals(t))
            {
                index++;
                if (node.NextNode == null)
                {
                    return -1;
                }
                node = node.NextNode;
            }
            return index;
        }
    }

    public class LinkNode<T>
    {
        public T Node
        {
            get; set;
        }

        public LinkNode<T> NextNode
        {
            get; set;
        }
    }
}
