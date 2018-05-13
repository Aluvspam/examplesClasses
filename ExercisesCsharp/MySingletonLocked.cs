using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercisesCsharp
{
    public class MySingletonLocked//wiki
    {
        private static object myLock = new object();
        private static  MySingletonLocked mySingletonLocked = null;

        private MySingletonLocked()
        {

        }
        private static MySingletonLocked GetInstance()
        {
            if(mySingletonLocked == null)// prima verificare
            {
                lock(myLock)
                {
                    if(mySingletonLocked==null)//2
                    {
                        mySingletonLocked = new MySingletonLocked();
                    }
                }
            }
            return mySingletonLocked;
        }
       /* In this example, the "lock hint" is the mySingleton object which is no longer null when 
        * fully constructed and ready for use.

In.NET Framework 4.0, the Lazy<T> class was introduced, which internally uses double-checked 
locking by default (ExecutionAndPublication mode) to store either the exception that was thrown 
during construction, or the result of the function that was passed to Lazy<T>:[12]*/

    }
    }
public class MySingleton
{
    private static readonly Lazy<MySingleton> _mySingleton = new Lazy<MySingleton>(() => new MySingleton());

    private MySingleton() { }

    public static MySingleton Instance
    {
        get
        {
            return _mySingleton.Value;
        }
    }
}

// Bad code! 
public sealed class SingletonBad
{
    private static SingletonBad instance = null;

    private SingletonBad()
    {
    }

    public static SingletonBad Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SingletonBad();
            }
            return instance;
        }
    }
}
//good code
public sealed class Singleton
{
    private static Singleton instance = null;
    private static readonly object padlock = new object();

    Singleton()
    {
    }

    public static Singleton Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}//http://csharpindepth.com/Articles/General/Singleton.aspx