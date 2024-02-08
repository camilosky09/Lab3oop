namespace Lab3oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Dog's name:");
            string dogName = Console.ReadLine();
            Dog dog = new Dog();
            dog.Name = dogName;
            dog.Colour = "Red"; 
            dog.Age = 8;

            Console.WriteLine($"Dog's Name: {dog.Name}");
            Console.WriteLine($"Dog's Colour: {dog.Colour}");
            Console.WriteLine($"Dog's Age: {dog.Age}");
            dog.Eat();

            Console.WriteLine("Enter the Cat's name:");
            string catName = Console.ReadLine();
            Cat cat = new Cat();
            cat.Name = catName;
            cat.Colour = "white";
            cat.Age = 4;

            Console.WriteLine($"Cat's Name : {cat.Name}");
            Console.WriteLine($"Cat's Colour: {cat.Colour}");
            Console.WriteLine($"Cat's Age: {cat.Age}");
            cat.Eat(); 



        }
    }
}
