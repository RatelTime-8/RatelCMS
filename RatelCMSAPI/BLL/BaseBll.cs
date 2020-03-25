using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 单例模式类BaseBll
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseBll<T> where T : new()
    {
        //定义一个私有变量_instance
        private static T _instace;
        /// <summary>
        /// 程序运行时，创建一个静态只读的进程辅助对象
        /// </summary>
        private static readonly object syncRoot = new object();
        /// <summary>
        ///  此方法是本类实例的唯一全局访问点
        /// </summary>
        public static T Instance
        {
            get
            { //先判断实例是否存在，不存在再加锁处理
                if (_instace == null)
                {  //在同一时刻加了锁的那部分程序只有一个线程可以进入，
                    lock (syncRoot)
                    {  //如实例不存在，则New一个新实例，否则返回已有实例
                        if (_instace == null)
                        {
                            _instace = new T();
                        }
                    }
                }
                //返回已有实例
                return _instace;
            }
        }
    }
}
