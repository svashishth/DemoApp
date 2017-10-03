using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ConsoleApp.DesignPatterns_Singleton
{
    public class Singleton
    {
        private static readonly object _objectInstance = new object();
        private static Singleton _instance = null;

        public static Singleton SingleObject { get {
                if(_instance==null)
                {
                    lock (_objectInstance)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            } }

        private Singleton()
        {
            
        }

    }
}
