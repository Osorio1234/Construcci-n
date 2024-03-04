//1;

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Fracciones");
        Console.WriteLine("-------------------------");

        Console.WriteLine("Ingrese la primera fracción en el formato 'numerador/denominador':");
        int[] fraccion1 = ObtenerFraccion();

        Console.WriteLine("Ingrese el operador (+, -, *, /):");
        char operador = ObtenerOperador();

        Console.WriteLine("Ingrese la segunda fracción en el formato 'numerador/denominador':");
        int[] fraccion2 = ObtenerFraccion();

        try
        {
            int[] resultado = Calcular(fraccion1, fraccion2, operador);
            Console.WriteLine($"El resultado es: {resultado[0]}/{resultado[1]}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static int[] ObtenerFraccion()
    {
        int numerador, denominador;

        while (true)
        {
            string entrada = Console.ReadLine();
            string[] partes = entrada.Split('/');

            if (partes.Length == 2 && int.TryParse(partes[0], out numerador) && int.TryParse(partes[1], out denominador))
            {
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese la fracción en el formato 'numerador/denominador':");
            }
        }

        return new int[] { numerador, denominador };
    }

    static char ObtenerOperador()
    {
        return Console.ReadLine()[0];
    }

    static int[] Calcular(int[] fraccion1, int[] fraccion2, char operador)
    {
        int numerador, denominador;
        switch (operador)
        {
            case '+':
                numerador = fraccion1[0] * fraccion2[1] + fraccion2[0] * fraccion1[1];
                denominador = fraccion1[1] * fraccion2[1];
                break;
            case '-':
                numerador = fraccion1[0] * fraccion2[1] - fraccion2[0] * fraccion1[1];
                denominador = fraccion1[1] * fraccion2[1];
                break;
            case '*':
                numerador = fraccion1[0] * fraccion2[0];
                denominador = fraccion1[1] * fraccion2[1];
                break;
            case '/':
                if (fraccion2[0] != 0)
                {
                    numerador = fraccion1[0] * fraccion2[1];
                    denominador = fraccion1[1] * fraccion2[0];
                }
                else
                {
                    throw new DivideByZeroException("No se puede dividir entre cero");
                }
                break;
            default:
                throw new ArgumentException("Operador no válido");
        }
        Simplificar(ref numerador, ref denominador);
        return new int[] { numerador, denominador };
    }

    static int MCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void Simplificar(ref int numerador, ref int denominador)
    {
        int mcd = MCD(numerador, denominador);
        numerador /= mcd;
        denominador /= mcd;
    }
}*/

//2;

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Verificación de número especial");
        Console.WriteLine("--------------------------------");

        Console.WriteLine("Ingrese un número:");
        int numero = int.Parse(Console.ReadLine());

        if (EsNumeroEspecial(numero))
        {
            Console.WriteLine($"El número {numero} es especial.");
        }
        else
        {
            Console.WriteLine($"El número {numero} no es especial.");
        }
    }

    static bool EsNumeroEspecial(int numero)
    {
        // Verificar si el número es divisible entre 5
        if (numero % 5 != 0)
        {
            return false;
        }

        // Verificar si el número no es divisible ni por 2 ni por 3
        if (numero % 2 == 0 || numero % 3 == 0)
        {
            return false;
        }

        // Si el número cumple con ambos criterios, es especial
        return true;
    }
}*/

//3;

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cálculo de días y semanas desde el año actual");
        Console.WriteLine("---------------------------------------------");

        Console.WriteLine("Ingrese su edad:");
        int edad = int.Parse(Console.ReadLine());

        int diasTranscurridos = CalcularDiasTranscurridos(edad);
        int semanas = diasTranscurridos / 7;
        int diasExtras = diasTranscurridos % 7;

        Console.WriteLine($"Han transcurrido {semanas} semanas y {diasExtras} días desde el año actual.");
    }

    static int CalcularDiasTranscurridos(int edad)
    {
        int anioActual = DateTime.Now.Year;
        int anioNacimiento = anioActual - edad;
        DateTime fechaNacimiento = new DateTime(anioNacimiento, 1, 1);
        TimeSpan tiempoTranscurrido = DateTime.Now - fechaNacimiento;

        // Ajustar por años bisiestos
        int cantidadBisiestos = ContarAniosBisiestos(anioNacimiento, anioActual);
        return tiempoTranscurrido.Days + cantidadBisiestos;
    }

    static int ContarAniosBisiestos(int anioInicio, int anioFin)
    {
        int cantidadBisiestos = 0;
        for (int anio = anioInicio; anio <= anioFin; anio++)
        {
            if (DateTime.IsLeapYear(anio))
            {
                cantidadBisiestos++;
            }
        }
        return cantidadBisiestos;
    }
}*/

//4;

/*using System;

class Program
{
    static void Main(string[] args)
    {
        string usuarioPredeterminado = "admin";
        string contraseñaPredeterminada = "12345";

        int intentosRestantes = 3;

        while (intentosRestantes > 0)
        {
            Console.Write("Ingrese su nombre de usuario: ");
            string usuarioIngresado = Console.ReadLine();

            Console.Write("Ingrese su contraseña: ");
            string contraseñaIngresada = Console.ReadLine();

            if (usuarioIngresado == usuarioPredeterminado && contraseñaIngresada == contraseñaPredeterminada)
            {
                Console.WriteLine("Acceso concedido");
                return;
            }
            else
            {
                Console.WriteLine("Nombre de usuario o contraseña incorrectos. Intentos restantes: " + --intentosRestantes);
                Console.WriteLine();
            }
        }

        Console.WriteLine("Acceso denegado");
    }
}*/
