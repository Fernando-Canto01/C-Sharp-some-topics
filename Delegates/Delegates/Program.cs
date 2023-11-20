namespace Delegates
{
    internal class Program
    {
        //1.Estableciendo firma y un tipo de retorno
        public delegate void ToDo(string par);
        public delegate int Operation(int num1, int num2);

        //2.Estableciendo firma y un tipo de retorno igual al delegado 
        public static void ToShow(string str)
        {
            Console.WriteLine(str);
        }
        //2.Estableciendo firma y un tipo de retorno igual al delegado
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        //2.Estableciendo firma y un tipo de retorno igual al delegado
        public static int Rest(int num1, int num2)
        {
            return num1 - num2;
        }
        //2.Estableciendo firma y un tipo de retorno igual al delegado
        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
        //2.Estableciendo firma y un tipo de retorno igual al delegado
        public static int Div(int num1, int num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
            //3.Asociamos su instancia con un método 
            ToDo AnAction = new ToDo(ToShow);
            //4.Invocamos al método con los argumentos especificos
            AnAction("C#");
            /*
             * 3.Asociamos su instancia con un método 
             * 4.Invocamos al método con los argumentos especificos
             * (Todo en una misma línea)
             */
            Console.WriteLine(new Operation(Sum).Invoke(2, 1));
            Console.WriteLine(new Operation(Rest).Invoke(2, 1));
            Console.WriteLine(new Operation(Mult).Invoke(2, 1));
            Console.WriteLine(new Operation(Div).Invoke(2, 1));
        }
    }
}
