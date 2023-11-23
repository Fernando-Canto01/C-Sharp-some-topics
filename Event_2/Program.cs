namespace Event_2;

class Program
{
    static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Suscriber suscriber = new Suscriber();
        publisher.Name = "Fernando José Canto Cetina";
        publisher.NamePublication = "C#";
        suscriber.Suscribe(publisher);
        suscriber.Notify();
    }
}


public class Publisher
{
    public string Name { get; set; }
    public string NamePublication { get; set; }
    public delegate void Publication();
    public event Publication EventPublication;

    public void InvokeEvent()
    {
        EventPublication?.Invoke();
    }

}


public class Suscriber
{
    Publisher _Publisher;
    public void Suscribe(Publisher publisher) => _Publisher = publisher;
    public void AddHeaderFormat() => _Publisher.EventPublication += delegate ()
    {
        System.Console.WriteLine($"Name:{_Publisher.Name} / Title:{_Publisher.NamePublication}");
    };

    public void AddBodyFormat() => _Publisher.EventPublication += delegate ()
    {
        System.Console.WriteLine($"C# es un lenguaje de programación desarrollado por Microsoft, orientado a objetos");
    };

    public void AddDateFormat() => _Publisher.EventPublication += delegate ()
    {
        System.Console.WriteLine($"Date: {DateTime.Now}");
    };

    public void Notify()
    {
        AddHeaderFormat();
        AddBodyFormat();
        AddDateFormat();
        _Publisher.InvokeEvent();
    }


}
