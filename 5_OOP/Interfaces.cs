using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP
{
    /// <summary>
    /// Интерфейсный класс
    /// </summary>
    public interface IBaseCollection
    {
        void Add(object obj);
        void Remove(object obj);
    }

    public static class BaseCollectionExtension
    {
        public static void AddRange(this IBaseCollection collection, IEnumerable<object> objects)
        {
            foreach (var item in objects)
                collection.Add(item);
        }
    }
     
    //public abstract class IBaseCollection
    //{
    //    public abstract void Add(object obj);
    //    public abstract void Remove(object obj);
    //}

    /// <summary>
    /// При использовании интерфейса, мы обязаны реализовать интерфейс
    /// </summary>
    public class BaseList : IBaseCollection
    {
        private object[] items;
        private int count = 0;
        public BaseList(int initialCapacity)
        {
            items = new object[initialCapacity];
        }

        public void Add(object obj)
        {
            items[count] = obj;
            count++;
        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}
