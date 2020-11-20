using System;

namespace Test
{
    public interface Person
    {
        public String GetFirstName();
        public String GetLastName();
    }
    class Adult :Person
    {
        public Adult(String FName, String LName)
        {
            FirstName = FName;
            LastName = LName;
        }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }
    }

    class Child :Person
    {
        public Child(String FName, String LName)
        {
            FirstName = FName;
            LastName = LName;
        }

        public String FirstName { get; set; }
        public String LastName { get; set; }
        

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Person[] array = new Person[2];
            array[0] = new Adult("Karunasree", "Jetty");
            array[1] = new Child("Avijith", "Kumar");

            foreach (Person item in array)
            {
                Console.WriteLine(item.GetFirstName() + " " + item.GetLastName());
                
            }
            Console.ReadLine();

        }
    }
}
