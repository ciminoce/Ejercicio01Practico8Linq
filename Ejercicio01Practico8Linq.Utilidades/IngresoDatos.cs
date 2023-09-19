namespace Ejercicio01Practico8Linq.Utilidades
{
    public static class IngresoDatos
    {
        public static string PedirCharEnRango(string mensaje, char char1, char char2)
        {
            char cX;
            do
            {

                Console.Write(mensaje);
                var tecla = Console.ReadKey();
                if (tecla.KeyChar.ToString().ToUpper() == char1.ToString().ToUpper()
                    || tecla.KeyChar.ToString().ToUpper() == char2.ToString().ToUpper())
                {
                    cX = tecla.KeyChar;
                    break;
                }
                Console.WriteLine("Tecla presionada no válida");
            } while (true);
            return cX.ToString().ToUpper();

        }
        public static string PedirString(string mensaje)
        {
            string? cX;
            do
            {

                Console.Write(mensaje);
                cX = Console.ReadLine();
                if (!string.IsNullOrEmpty(cX) || !string.IsNullOrWhiteSpace(cX))
                {
                    break;
                }
                Console.WriteLine("No ingresó nada por la consola");
            } while (true);
            return cX;
        }
        public static int PedirInt(string mensaje)
        {
            int nro;
            string cX;
            do
            {
                cX = PedirString(mensaje);
                if (int.TryParse(cX, out nro))
                {
                    break;
                }
                Console.WriteLine("Número no válido");
            } while (true);
            return nro;
        }
        public static int PedirIntEnRango(string mensaje, int valorMenor, int valorMayor)
        {
            bool error = true;
            int valorInt;
            string? cX;
            do
            {
                cX = PedirString(mensaje);
                if (!int.TryParse(cX, out valorInt))
                {
                    Console.WriteLine("Error al intentar ingresar un valor entero");
                }
                else if (valorInt < valorMenor || valorInt > valorMayor)
                {
                    Console.WriteLine($"ERROR valor fuera del rango permitido {valorMenor} y {valorMayor}");
                }
                else
                {
                    error = false;
                }
            } while (error);

            return valorInt;
        }
        public static double PedirDoubleEnRango(string mensaje, double valorMenor, double valorMayor)
        {
            bool error = true;
            double valorDouble;
            string? cX;
            do
            {
                cX = PedirString(mensaje);
                if (!double.TryParse(cX, out valorDouble))
                {
                    Console.WriteLine("Error al intentar ingresar un valor entero");
                }
                else if (valorDouble < valorMenor || valorDouble > valorMayor)
                {
                    Console.WriteLine($"ERROR valor fuera del rango permitido {valorMenor} y {valorMayor}");
                }
                else
                {
                    error = false;
                }
            } while (error);

            return valorDouble;
        }

    }
}