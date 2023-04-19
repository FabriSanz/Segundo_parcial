//Codigo con error de datos

int datol = 16;
String dato2 = "25g";
int resultado = datol + Convert. ToInt32( dato2):

//Codigo reparado con la sintaxis “try…catch”

int datol = 16;
String dato2 = "25g";

try {
    int resultado = datol + Convert.ToInt32(dato2);
    Console.WriteLine("El resultado es: " + resultado);
} catch (FormatException e) {
    Console.WriteLine("Lo sentimos no se pudo realizar la operación requerida");
}
