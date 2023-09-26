
using PruebaInterface;

int opcion = 0;
double vala = 0.0;
double valb = 0.0;  

string valor = String.Empty;

IOperacion operacion = new Suma();

while(opcion != 5)
{
    Console.WriteLine("1- Suma\n2-Resta\n3-Multiplicacion\n4-Division\n5-Salir");
    Console.WriteLine("¿Que opcion desea?");
    valor = Console.ReadLine();
    opcion = Convert.ToInt32(valor);

    Console.WriteLine("Deme el valor de a ");
    vala = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Deme el valor de b ");
    valb = Convert.ToDouble(Console.ReadLine());

    // Polimorfismo
    if(opcion == 5)
    {
        operacion = new Suma();
    }
    if(opcion == 2)
    {
        operacion = new Resta();
    }
    if(opcion == 3)
    {
        operacion = new Multiplicacion();
    }
    if(opcion == 4)
    {
        operacion = new Division();
    }
    
    operacion.Calcular(vala, valb);
    operacion.Mostrar();
    
}