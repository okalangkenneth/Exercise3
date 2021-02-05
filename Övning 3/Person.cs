using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3
{
    class Person
    
    {
        private int age;
        private string fName;
        private string lName;
        private int height;
        private int weight;
    

    public int Age
    {
            get { return age;}
            set {
              if (age >= 0)
                  age = value;
                }
    }    
     public string FName
     {
            get { return fName;}
            set {
                if (int.Parse(value) >= 2 || int.Parse(value) <= 10)
                    fName = value;
                }
     }
        public string LName
        {
            get { return lName;}
            set {
                if (int.Parse(value) >= 3 || int.Parse(value) <= 15)
                    lName = value;

                }
        }
        public int Height
        {
            get { return height; }
            set { height = value;} 
        }
        public int Weight 
        {
            get { return weight; }
            set { weight = value;}
        }
    }
}
