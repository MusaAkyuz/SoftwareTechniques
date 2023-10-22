namespace EventHandlerDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", "Doe");
            PersonListener personListener = new PersonListener();

            person.OnPersonCreated += personListener.EventHandler;

            person.TriggerEvent("Jane", "Doe");
            person.Event_OnPersonCreated();
        }
    }

    public delegate void OnPersonCreated(string name, string surname);

    public class Person
    {
        public event OnPersonCreated OnPersonCreated;

        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void TriggerEvent(string Name, string Surname)
        {
            OnPersonCreated(Name, Surname);
        }

        public void Event_OnPersonCreated()
        {
            OnPersonCreated?.Invoke(Name, Surname);
        }
    }

    public class PersonListener
    {
        public void EventHandler(string name, string surname)
        {
            Console.WriteLine($"Person {name} {surname} created!");
        }
    }
}