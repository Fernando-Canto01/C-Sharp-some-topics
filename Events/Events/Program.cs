namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publicador pub = new Publicador();
            Suscriptor sub = new Suscriptor();
            sub.Suscribirse(pub);
            pub.GenerarEvento("Hola mundo");
        }
    }
}
