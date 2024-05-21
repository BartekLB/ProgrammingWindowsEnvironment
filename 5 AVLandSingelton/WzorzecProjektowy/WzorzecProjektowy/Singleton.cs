using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecProjektowy
{
    public class Singleton<T> where T : class, new()
    {
        private static T instance = null;
        private static readonly object padlock = new object();

        protected Singleton() { }

        public static T Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new T();
                    }
                    return instance;
                }
            }
        }
    }
    public class MyClass : Singleton<MyClass>
    {
        public MyClass() { }
    }
}
