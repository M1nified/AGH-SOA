using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    public class Person
    {
        public string Name;
        public int Age;

								public Person()
								{

								}
								public Person(string name, int age)
								{
												Name = name;
												Age = age;
								}
								public object Clone()
								{
												return this.MemberwiseClone();
								}
				}
}
