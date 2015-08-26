using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinearList
{
    public interface ILinearList<T>
    {
        /// <summary>
        /// 数组长度
        /// </summary>
        int Length
        {
            get;
        }

        /// <summary>
        /// 数组是否为空
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        /// <summary>
        ///清空表 
        /// </summary>
        void Clear();

        /// <summary>
        ///通过索引获取数据元素 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T GetItem(int index);

        /// <summary>
        /// 返回数据元素的索引
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int LocateItem(T t);

        /// <summary>
        /// 将数据元素插入到指定位置
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        void Insert(T item, int index);

        /// <summary>
        /// 在数组末尾添加元素
        /// </summary>
        /// <param name="item"></param>
        void Add(T item);

        /// <summary>
        /// 删除指定索引的元素
        /// </summary>
        /// <param name="index"></param>
        void Delete(int index);
    }
}
