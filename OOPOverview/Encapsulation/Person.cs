using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person
    {
        private int age;

        public void SetAge(int age)
        {
            if (age < 0)
            {
                throw new Exception("Yaşınız negatif olamaz");
            }

            this.age = age;
        }

        public int GetAge()
        {
            return this.age;
        }

        private string name;
        public string Name
        {
            get { return this.name; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Ad boş olamaz");
                }
                this.name = value;
            }
        }


        public decimal Salary { get; set; }

        //public bool IsActive { private get; set; }

    }


}
