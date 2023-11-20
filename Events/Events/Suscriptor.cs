namespace Events
{
    internal class Suscriptor
    {
        public void Suscribirse(Publicador publicador)
        {
            //1. Suscribirse al evento
            publicador.MiEvento += ManejadorDelEvento;
        }

        private void ManejadorDelEvento(string mensaje)
        {
            Console.WriteLine($"Evento recibido: {mensaje}");
        }
    }
}
