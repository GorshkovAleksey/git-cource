using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Lion
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Lion(string name, int age)
        {
            LionException ex = new LionException();
            if (age > 30)
            {
                ex.Name = name;
                ex.ObjectAge = age;
                ex.MaxAge = 30;
                ex.Description = "Обычно львы не живут больше 30 лет";
                ex.HelpLink = "https://www.lions.ru";
                throw ex;
            }
            Name = name;
            Age = age;
        }
    }
    public class LionException : Exception
    {
        public string Name { get; set; }
        public int ObjectAge { get; set; }
        public int MaxAge { get; set; }
        public string Description { get; set; }
    }
}