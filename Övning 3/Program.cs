using System;
using System.Text;
using System.Collections.Generic;

namespace Övning_3
{

    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                Person person = new Person();
                person.Age = 28;
                person.LName = "9";
                person.FName = "13";
                person.Height = 12;
                person.Weight = 25;

                System.Console.WriteLine("{0} {1} {2} {3} {4}",
                person.Age,
                person.LName,
                person.FName,
                person.Height,
                person.Weight);

                
            }
            catch (Exception ex)
            {

                System.Console.WriteLine("There was a problem");
                System.Console.WriteLine(ex.Message);

            }

            PersonHandlar personHandlar = new PersonHandlar();

            Person myperson1 = personHandlar.CreatePerson(78, "Kenneth", "Okalang", 120, 100);
            Person myperson2 = personHandlar.CreatePerson(83, "peter", "ilut", 89, 99);
            Person myperson3 = personHandlar.CreatePerson(6, "charles", "Ilemu", 45, 23);

            personHandlar.SetFName(myperson3, "Iyalet");
            Console.WriteLine(myperson3.FName);

            // Att implimentera Talk() och skriva ut vad Wolfman säger.

            Wolfman mywolfman = new Wolfman(34, "wolfman", 56, "blackhairy");
            Console.WriteLine(mywolfman.Talk("awuuuuuuuuu"));

            // F:13  De bör läggas i Bird klassen.
            // F:14  I Animal klassen
            
            // Skapat listan some tar emot djur
            
            List<Animal> animals = new List<Animal>();
            animals.Add(new Horse(78, "fury", 67, "Thick"));
            animals.Add(new Dog(78, "flafy", 67, "fourpaws"));
            animals.Add(new Hedgehog(7, "spiky", 67, "painfulspikes"));
            animals.Add(new Bird(3, "fågel", 2, "black"));
            animals.Add(new Worm(4, "wormy", 2, "and curvy"));
            animals.Add(new Wolf(3, "wolfy", 20, "grey"));

            // Skriv ut djur i listan
            foreach (var item in animals)
                Console.WriteLine(item.Stats());

            // Foreach loop låter oss komma åt elementen i djurlistan, enligt de olika djurnamnen.

            // Anropa Animals Sound
            foreach (var item in animals)
                Console.WriteLine(item.DoSound());
            

            // Dog List
                List<Animal> dogList = new List<Animal>();
                dogList.Add(new Dog(23, "Bulldog", 45, "four"));
                dogList.Add(new Dog(48, "Shepard", 98, "three paws"));

            // Skriv ut Stats() method för alla hundar på Animals.
             foreach (var dog in dogList)
              Console.WriteLine(dog.Stats());

            // Skapat egen metod    
             foreach (var dog in dogList)
              Console.WriteLine(dog.MyDogFunction());

             //  Kommer inte åt den metoden från Animals listan för den tillhör inte bland först argument och finns ingen
             //  defination om det som de andra två metoden i Animal. Det borde deklareras i början. När man gor det så går den att
             //  skriva metoden på animals listan
                
             //dogList.Add(new Horse(45, "Fury", 150, "Thick"));  
             //F:9 Går inte Add Horse till Dog för att de är inte samma object.
             // Can not convert Horse to Dog.
             //F:10 Lista måste vara Animal för att båda Horse och Dog att vara till sammans.

                List<UserError> listUserError = new List<UserError>();

                listUserError.Add(new NumericInputError());
                listUserError.Add(new TextInputError());

                // Skapat egna definitioner
                listUserError.Add(new DivideByZeroException());
                listUserError.Add(new ArgumentException());
                listUserError.Add(new FormatException());

                foreach (UserError error in listUserError)

                    Console.WriteLine(error.UEMessage());
            
                

            /*Polymorphism är viktig att beharska för den låter dig koda till ett gränssnitt som minskar kopplingen, 
              ökar återanvändbarheten och gör din kod lättare att läsa.

              Polymorfism kan ändra och använda kod via en bra struktur eftersom det hjälper till att organisera arbete
              och prioritera uppgifter med det enda syftet att få bättre resultat.

              En abstrakt klass låter dig skapa funktioner som subklasser kan implementera eller 'override'. 
              Ett gränssnitt låter dig bara definiera funktionalitet, inte implementera den. Och medan en klass endast kan 
              utvidga en abstrakt klass kan den dra nytta av flera gränssnitt.*/


              Console.ReadLine();
        }

    }
}

            
        
    
