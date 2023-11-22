namespace Func_Action_Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reverse.Cadena str;
            str = new Reverse().InvertirCadena;
            Console.WriteLine(str("Hello"));

            Func<string, string, string> nombreCompleto = delegate (string nombre, string apellido)
            {
                return $"Nombre: {nombre} Apellido: {apellido}";
            };

            Func<string, string, string> nombreCompleto2 = (nombre, apellido) => $"{nombre}{apellido}";

            List<int> list = new List<int>();
            for (int i = 1; i <= 10; ++i)
                list.Add(i);

            var pares = list.FindAll(x => x % 2 == 0);
            pares.ForEach(x => Console.WriteLine(x));
            var impares = list.FindAll(x => x % 3 == 0);
            Console.WriteLine("Números pares");
            pares.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Números impares");
            impares.ForEach(x => Console.WriteLine(x));
        }
    }

    class Reverse
    {
        public delegate string Cadena(string str);

        public string InvertirCadena(string str)
        {
            return new string(str.Reverse().ToArray());
        }

    }

}

