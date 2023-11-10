using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcercisesWeek1.Assignment3
{
    public abstract class Animal
    {
        #nullable disable
        public string Name { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public void GetName()
        {
            Console.WriteLine(Name);
        }

        public abstract void Eat();
    }
}
