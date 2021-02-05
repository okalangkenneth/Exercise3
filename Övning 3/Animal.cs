using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3
{
    public abstract class Animal
    {

        public int Age { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

        public Animal(int age, string name, int weight)
        {
            Age = age;
            Name = name;
            Weight = weight;
        }

        public abstract string DoSound();

        public virtual string Stats() 
        {
            return $"Age: {Age} Name: {Name} Weight: {Weight}";
        }
        
        public virtual string MyDogFunction()   

        {
            return $"{Age},{Name},{Weight},";
        }

    }
    class Horse : Animal
    {
        public Horse(int age, string name, int weight, string mane) : base(age, name, weight)
        {
            Mane = mane;

        }
        public string Mane { get; set; }

        public override string Stats()
        {
            return base.Stats() + $"{Mane}";
        }
        public override string DoSound()
        {
            string message="Neighing";
            return message;
        }

    }
    class Dog : Animal
    {

        public Dog(int age, string name, int weight, string paws) : base(age, name, weight)
        {
            Paws = paws;

        }
        public string Paws { get; set; }

        public override string Stats()
        {
            return base.Stats() + $"{Paws}";
        }
        public override string DoSound()
        {
            string message = "Awuuuu";
            return message;
            
        }
        public override string MyDogFunction()
        {
            string message = "woof wooof";
            return message;
        }
        
    }
    class Hedgehog : Animal
    {
        public Hedgehog(int age, string name, int weight, string spikes) : base(age, name, weight)
        {
            Spikes = spikes;

        }
        public string Spikes { get; set; }

        public override string Stats()
        {
            return base.Stats() + $"{Spikes}";
        }
        public override string DoSound()
        {
            string message="Snuffling";
            return message;
        }

    }
    class Worm : Animal
    {
        public Worm(int age, string name, int weight, string smooth) : base(age, name, weight)
        {
            Smooth = smooth;

        }
        public string Smooth { get; set; }

        public override string Stats()
        {
            return base.Stats() + $"{Smooth}";
        }
        public override string DoSound()
        {
            string mesage="Grunting";
            return mesage;
        }
    }
    class Bird : Animal
    {
        public Bird(int age, string name, int weight, string feathers) : base(age, name, weight)
        {
            Feathers = feathers;

        }
        public string Feathers { get; set; }

        public override string Stats()
        {
            return base.Stats() + $"{Feathers}";
        }
        public override string DoSound()
        {
            string message="Chiping";
            return message;
        }    
    }
    class Wolf : Animal
    {
        public Wolf(int age, string name, int weight, string hairy) : base(age, name, weight)
        {
            Hairy = hairy;

        }
        public string Hairy { get; set; }

        public override string Stats()
        {
            return base.Stats() + $"{Hairy}";
        }
        public override string DoSound()
        {
            string message="Howling";
            return message;
        }

    }
    class Pelican : Bird
    {

        public Pelican(int age, string name, int weight, string feathers, string haswidebick) : base(age, name, weight, feathers)
        {
            HasWideBick = haswidebick;
        }
        public string HasWideBick { get; set; }

        public override string Stats()
        {
            return base.Stats() + $"{ HasWideBick}";
        }
    }
    class Flamingo : Bird
    {

        public Flamingo(int age, string name, int weight, string colorful, string feathers) : base(age, name, weight, feathers)

        {
            Colorful = colorful;
        }
        public string Colorful { get; set; }

        public override string Stats()
        {
            return base.Stats() + $"{ Colorful}";
        }
    }
    class Swan : Bird
    {
        public Swan(int age, string name, int weight, string feathers, string longneck) : base(age, name, weight, feathers)

        {
            LongKneck = longneck;
        }
        public string LongKneck { get; set; }

        public override string Stats()
        {
            return base.Stats() + $"{ LongKneck}";
        }
    }
    interface IPerson // Defination of Interface
    {

    }
    class Wolfman : Wolf, IPerson  // Wolfman Impliments the IPerson interface   
    {

        public Wolfman(int age, string name, int weight, string hairy) : base(age, name, weight, hairy)
        {

        }
        public string Talk(string message)
        {
            
            return message;
        }
    }

    // Vi  bör lägga det i Bird klass om vi vill att samtliga fåglar behöver ett nytt attribut.
    // I Animal abstrakt klass.


}





