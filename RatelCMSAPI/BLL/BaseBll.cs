using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public abstract class BaseBll<T> where T :new()
    {
        private static T instace;
        private static readonly object syncRoot = new object();
        public static T GetBaseBll()
        {
            if (instace==null)
            {
                lock (syncRoot)
                {
                    if (instace==null)
                    {
                        instace = new T();
                    }
                }
            }
            return instace;
        }

    }
}
