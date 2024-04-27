
namespace CalcularSumaProducto.Class
{
    public class Calcular
    {
        public void CalcularSumaProducto() 
        {
            int num1 = 0;
            int num2 = 0;
            decimal suma = 0;
            decimal producto = 0;

            Console.WriteLine("Digite el primer numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            suma = (num1 + num2);

            producto = (num1 * num2);

            Console.WriteLine($"La suma de los dos numeros es: { suma }");

            Console.WriteLine($"El producto de los dos numeros es: { producto }");

        }
    }
}
