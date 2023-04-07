using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeYourTestApp
{
    public abstract class TestBase<T> where T : class, new()
    {
        protected static T instance;

        public string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tests");


        public static T Instance 
        { get 
            { if (instance == null)
                { instance = new T(); } 
                return instance; }
        }

        
    }
}
