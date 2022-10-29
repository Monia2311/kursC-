using ConsoleApp1.Lessons.Classes;

namespace ConsoleApp1.Lessons
{
    public class L1ObjectVariables
    {
        public static void Test1()
        {
            Console.WriteLine("Variables");
            Dog dog=new Dog();
            dog.Jump();
            dog.Bark();
            dog.Name = "Burek";
            dog.Race = "Golden Retriever";
            dog.Age = 2;
            Console.WriteLine("Attention here is dog: "+dog.Name);
            Console.WriteLine("Race: "+dog.Race);
            Console.WriteLine("Age: "+dog.Age);

            Dog.Eat();
            
        }

        public static void Test2()
        {
            Dog westieDog = new Dog();
            westieDog.Race = "WHWT";
            westieDog.Age = 5;
            westieDog.Name = "Skiper";
            westieDog.GoodBoi = true;
            westieDog.Present();
            DogOffspringStats stats = westieDog.Breed();
            Console.WriteLine("Number of female pups: "+ stats.NumberOfFemalePups);
            Console.WriteLine("Number of male pups: " + stats.NumberOfMalePups);
            Console.WriteLine(westieDog.Breed().NumberOfFemalePups);
            westieDog.Jump();
            westieDog.Bark();
            Console.WriteLine(westieDog.Add(12, 3));

        }

        public static void WriteSomething()
        {
            Console.WriteLine("Something...");
        }
    }
}
