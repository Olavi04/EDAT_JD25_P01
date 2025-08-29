internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Complejidad de algoritmos");
        //Console.WriteLine("Complejidad Big O(1)");


        //var nombres = new List<string>() { "ileiny", "Alondra", "juan", "Alejandro", "Karla" };

        //var primero =(List<string> arreglo) => arreglo != null && arreglo.Count >0?

        //            arreglo[0] : "Lista vacia";

        //Console.WriteLine("El primer nombre es: " + primero(nombres));


        Console.WriteLine("Complejidad Big O(n)");
        var numeros = new List<int>() { 45, 2, 53, 500, 2000, 10000, 0, 1 };
        var numeroMayor = (List<int> arreglo) =>
        {
            if (arreglo == null || arreglo.Count == 0)
            {

                return 0;
            }
            
                int mayor = arreglo[0];
                for (int i = 0; i < arreglo.Count; i++)
                {
                    if (arreglo[i] > mayor)
                    {
                        mayor = arreglo[i];
                    }
                }

                return mayor;
            };

        int may = numeroMayor(numeros);
        Console.WriteLine("El numero mayor es: " + may);

        Console.ReadKey();
    }
}