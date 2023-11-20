namespace Events
{
    internal class Publicador
    {
        //1.Declaración del delegado
        public delegate void MiEventoDelegado(string mensaje);

        //2.Declaración del evento
        public event MiEventoDelegado MiEvento;

        //3.Declaración del generador de eventos
        public void GenerarEvento(string mensaje)
        {
            //4.Verificar si hay suscriptores
            if (MiEvento != null)
            {
                //5.Invocar el evento
                MiEvento(mensaje);
            }
        }
    }
}
