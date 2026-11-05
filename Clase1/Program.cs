/*
 * Console.WriteLine("Hello, DAM!");


int number1 = 10;
int number2 = 20;

int sum = number1 + number2;
Console.WriteLine("La suma de " + number1 + " y " + number2 + " es: " + sum);

// Leer valores desde la consola

int input1, input2;

string input1Str = Console.ReadLine();
string input2Str = Console.ReadLine();

input1 = Convert.ToInt32(input1Str);
input2 = Convert.ToInt32(input2Str);

Console.WriteLine("La suma de " + input1 + " y " + input2 + " es: " + (input1 + input2));
*/

Ejercicio1();
void Ejercicio1()
{
    Console.WriteLine("Ejercicio 1:");

    int input1, input2;

    Console.WriteLine("Ingrese el primer número:");
    string input1Str = Console.ReadLine();
    Console.WriteLine("Ingrese el segundo número:");
    string input2Str = Console.ReadLine();

    input1 = Convert.ToInt32(input1Str);
    input2 = Convert.ToInt32(input2Str);

    Console.WriteLine("La suma de " + input1 + " y " + input2 + " es: " + (input1 + input2));
    Console.WriteLine("La resta de " + input1 + " y " + input2 + " es: " + (input1 - input2));
    Console.WriteLine("La multiplicación de " + input1 + " y " + input2 + " es: " + (input1 * input2));
    Console.WriteLine("La división de " + input1 + " y " + input2 + " es: " + (input1 / input2));
    Console.WriteLine("El módulo de " + input1 + " y " + input2 + " es: " + (input1 % input2));
}

Ejercicio2();
void Ejercicio2()
{
    Console.WriteLine("Ejercicio 2:");
    const int priceHamburger = 5;
    const int priceFries = 3;
    const int priceDrink = 2;

    int itemCountHamburger, itemCountFries, itemCountDrink;

    Console.WriteLine("Cantidad de hamburguesas:");
    string input1Str = Console.ReadLine();
    Console.WriteLine("Cantidad de papas fritas:");
    string input2Str = Console.ReadLine();
    Console.WriteLine("Cantidad de bebidas:");
    string input3Str = Console.ReadLine();

    itemCountHamburger = Convert.ToInt32(input1Str);
    itemCountFries = Convert.ToInt32(input2Str);
    itemCountDrink = Convert.ToInt32(input3Str);

    int totalPrice = (itemCountHamburger * priceHamburger) + (itemCountFries * priceFries) + (itemCountDrink * priceDrink);

    Console.WriteLine("El precio total de la orden es: " + totalPrice);

}

Ejercicio3();
void Ejercicio3()
{
    Console.WriteLine("Ejercicio 3:");

    int num1;

    Console.WriteLine("Ingrese un numero: ");
    string input1Str = Console.ReadLine();

    num1 = Convert.ToInt32(input1Str);

    Console.WriteLine("Valor absoluto de " + num1 + " es: " + Math.Abs(num1));
    Console.WriteLine("Potencia al cubo de " + num1 + " es: " + Math.Pow(num1, 3));
    Console.WriteLine("Raíz cuadrada de " + num1 + " es: " + Math.Sqrt(num1));
    Console.WriteLine("Seno de " + num1 + " es: " + Math.Sin(num1));
    Console.WriteLine("Coseno de " + num1 + " es: " + Math.Cos(num1));

    int num2;

    Console.WriteLine("Ingrese otro numero: ");
    string input2Str = Console.ReadLine();

    num2 = Convert.ToInt32(input2Str);

    Console.WriteLine("El mayor entre " + num1 + " y " + num2 + " es: " + Math.Max(num1, num2));
    Console.WriteLine("El menor entre " + num1 + " y " + num2 + " es: " + Math.Min(num1, num2));

}

Ejercicio4();
void Ejercicio4()
{
    Console.WriteLine("Ejercicio 4: ");

    int ladoCuadrado;

    Console.WriteLine("Ingrese el lado del cuadrado: ");
    string input1Str = Console.ReadLine();

    ladoCuadrado = Convert.ToInt32(input1Str);

    Console.WriteLine("El perímetro del cuadrado es: " + (ladoCuadrado * 4));
}

Ejercicio5();
void Ejercicio5()
{
    Console.WriteLine("Ejercicio 5: ");
    int num1, num2, num3, num4;
    Console.WriteLine("Ingrese 4 números dandole enter después de cada uno: ");
    string input1Str = Console.ReadLine();
    string input2Str = Console.ReadLine();
    string input3Str = Console.ReadLine();
    string input4Str = Console.ReadLine();

    num1 = Convert.ToInt32(input1Str);
    num2 = Convert.ToInt32(input2Str);
    num3 = Convert.ToInt32(input3Str);
    num4 = Convert.ToInt32(input4Str);

    Console.WriteLine("Suma de los dos primeros números: " + (num1 + num2));
    Console.WriteLine("Producto de los dos últimos números: " + (num3 * num4));
}

Ejercicio6();
void Ejercicio6()
{
    Console.WriteLine("Ejercicio 6: ");
    int num1, num2, num3, num4;
    Console.WriteLine("Ingrese 4 números dandole enter después de cada uno: ");
    string input1Str = Console.ReadLine();
    string input2Str = Console.ReadLine();
    string input3Str = Console.ReadLine();
    string input4Str = Console.ReadLine();

    num1 = Convert.ToInt32(input1Str);
    num2 = Convert.ToInt32(input2Str);
    num3 = Convert.ToInt32(input3Str);
    num4 = Convert.ToInt32(input4Str);

    Console.WriteLine("Suma de los números: " + (num1 + num2 + num3 + num4));
    Console.WriteLine("Promedio de los números: " + ((num1 + num2 + num3 + num4) / 4.0));
}

Ejercicio7();
void Ejercicio7()
{
    Console.WriteLine("Ejercicio 7: ");

    int price;
    int cantity;

    Console.WriteLine("Ingrese el precio del producto: ");
    string input1Str = Console.ReadLine();
    price = Convert.ToInt32(input1Str);

    Console.WriteLine("Ingrese la cantidad de productos: ");
    string input2Str = Console.ReadLine();
    cantity = Convert.ToInt32(input2Str);

    Console.WriteLine("El precio total es: " + (price * cantity));
}

Ejercicio8();
void Ejercicio8()
{
    Console.WriteLine("Ejercicio 8: ");

    int parcial1, parcial2, examen, trabajoFinal;

    Console.WriteLine("Ingrese la calificación del primer parcial: ");
    string input1Str = Console.ReadLine();
    parcial1 = Convert.ToInt32(input1Str);

    Console.WriteLine("Ingrese la calificación del segundo parcial: ");
    string input2Str = Console.ReadLine();
    parcial2 = Convert.ToInt32(input2Str);

    Console.WriteLine("Ingrese la calificación del examen: ");
    string input3Str = Console.ReadLine();
    examen = Convert.ToInt32(input3Str);

    Console.WriteLine("Ingrese la calificación del trabajo final: ");
    string input4Str = Console.ReadLine();
    trabajoFinal = Convert.ToInt32(input4Str);

    double notaFinal = (parcial1 + parcial2) / 2.0 * 0.5 + examen * 0.3 + trabajoFinal * 0.2;

    Console.WriteLine("La nota final es: " + notaFinal);

}

Ejercicio9();
void Ejercicio9()
{
    Console.WriteLine("Ejercicio 9: ");

    int socio1, socio2, socio3;

    Console.WriteLine("Ingrese la cantidad aportada por el socio 1: ");
    string input1Str = Console.ReadLine();
    socio1 = Convert.ToInt32(input1Str);

    Console.WriteLine("Ingrese la cantidad aportada por el socio 2: ");
    string input2Str = Console.ReadLine();
    socio2 = Convert.ToInt32(input2Str);

    Console.WriteLine("Ingrese la cantidad aportada por el socio 3: ");
    string input3Str = Console.ReadLine();
    socio3 = Convert.ToInt32(input3Str);

    Console.WriteLine("El porcentaje del socio 1 es {0}%, del socio 2 es {1}% y del socio 3 es {2}%", 
        (socio1 * 100) / (socio1 + socio2 + socio3), 
        (socio2 * 100) / (socio1 + socio2 + socio3), 
        (socio3 * 100) / (socio1 + socio2 + socio3));
}

Ejercicio10();
void Ejercicio10()
{
    Console.WriteLine("Ejercicio 10: ");

    string input;
    Console.WriteLine("Ingrese un string: ");
    input = Console.ReadLine();

    if (input.StartsWith("www"))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }

}