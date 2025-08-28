using FuncionesLambda;
using System;
internal class Program

{
    private static void Main(string[] args)
    {
        Console.WriteLine("Expresion Lambda como funcion");

        //Func<int, int> b = (a) => a * 2;

        //int resultado = b(4);

        //Console.WriteLine("El resultado es: " + resultado);



        //Func<int, int, int> suma = (a, b) => a + b;
        //int resultado = suma(4, 5);
        //Console.WriteLine("El resultado de la suma es: " + resultado);


        //Func<int, int, int> mayor = (a, b) =>
        //{
        //    if(a>b) {
        //        return a;
        //    }
        //    else
        //    {
        //        return b;
        //    }

        //};

        //int resultado = mayor(45,30);

        //Console.WriteLine("El resultado de la suma es: " + resultado);




        var numeros = new List<int> { 8, 5, 9, 34, 2, 26, 8 };
        Func<int, bool> esPar = num => num % 2 == 0;

        //var numerosPares = numeros.Where(esPar);
        var numerosPares = numeros.Where((num) => num % 2 == 0);

        Console.WriteLine("Numeros pares: ");



        //Persona pers = new Persona();

        //int edad=18;
        //edad++;
        //edad++;



        //Console.WriteLine("El valo de la variables es :"+edad);
        //Console.WriteLine("La direccion de memoria es: ");



        Console.ReadKey();
    }


}