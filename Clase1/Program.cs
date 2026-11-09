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

Ejercicio1_2();


void Ejercicio1_2()
{
    Console.WriteLine("Ejercicio 1:");

    int num1, num2;

    Console.WriteLine("Ingrese el primer número:");
    string input1Str = Console.ReadLine();
    Console.WriteLine("Ingrese el segundo número:");
    string input2Str = Console.ReadLine();

    num1 = Convert.ToInt32(input1Str);
    num2 = Convert.ToInt32(input2Str);

    if (num1 > num2)
    {
        Console.WriteLine($"El número mayor es {num1}");
    }
    else if (num2 > num1)
    {
        Console.WriteLine($"El número mayor es {num2}");
    }
    else
    {
        Console.WriteLine("Los dos números son iguales");
    }
}

Ejercicio2_2();

void Ejercicio2_2()
{
    Console.WriteLine("Ejercicio 2:");

    double kilowatios;
    double precioKilowatio;

    Console.WriteLine("Ingrese los kilowatios consumidos:");
    string inputStr = Console.ReadLine();
    kilowatios = Convert.ToDouble(inputStr);

    if (kilowatios > 1800)
    {
        precioKilowatio = 0.8;
    }
    else if (kilowatios >= 1000)
    {
        precioKilowatio = 0.12;
    }
    else
    {
        precioKilowatio = 0.14;
    }

    double total = kilowatios * precioKilowatio;

    Console.WriteLine("El total de la factura es: " + total.ToString("C2"));
}

Ejercicio3_2();

void Ejercicio3_2()
{
    Console.WriteLine("Ejercicio 3:");

    char estadoCivil;

    Console.WriteLine("Introduzca su estado civil (C, S, V o D):");
    string inputStr = Console.ReadLine();
    estadoCivil = Convert.ToChar(inputStr.ToUpper());

    switch (estadoCivil)
    {
        case 'C':
            Console.WriteLine("Tu estado civil es Casad@");
            break;
        case 'S':
            Console.WriteLine("Tu estado civil es Solter@");
            break;
        case 'V':
            Console.WriteLine("Tu estado civil es Viud@");
            break;
        case 'D':
            Console.WriteLine("Tu estado civil es Divorciad@");
            break;
        default:
            Console.WriteLine("La opción introducida no es correcta");
            break;
    }
}

Ejercicio4_2();

void Ejercicio4_2()
{
    Console.WriteLine("Ejercicio 4:");

    int numero;

    do
    {
        Console.WriteLine("Introduzca un número del 1 al 9:");
        string inputStr = Console.ReadLine();
        numero = Convert.ToInt32(inputStr);

        if (numero < 1 || numero > 9)
        {
            Console.WriteLine("El número debe estar entre 1 y 9");
        }
    } while (numero < 1 || numero > 9);

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(numero + " x " + i + " = " + (numero * i));
    }
}

Ejercicio5_2();

void Ejercicio5_2()
{
    Console.WriteLine("Ejercicio 5:");

    Console.WriteLine("Introduzca una cadena de texto:");
    string texto = Console.ReadLine();

    Console.WriteLine("Longitud de la cadena: " + texto.Length);

    Console.WriteLine("Introduzca una subcadena para comprobar si está contenida:");
    string subcadena = Console.ReadLine();
    Console.WriteLine("¿La cadena contiene la subcadena? " + texto.Contains(subcadena));

    Console.WriteLine("Introduzca la letra que desea reemplazar:");
    char letraAnterior = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("Introduzca la nueva letra:");
    char letraNueva = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("Cadena con el reemplazo: " + texto.Replace(letraAnterior, letraNueva));

    Console.WriteLine("Cadena en mayúsculas: " + texto.ToUpper());
    Console.WriteLine("Cadena en minúsculas: " + texto.ToLower());

    if (texto.Length > 0)
    {
        Console.WriteLine("Introduzca la posición del carácter que desea eliminar (empezando por 0):");
        int posicion = Convert.ToInt32(Console.ReadLine());

        if (posicion >= 0 && posicion < texto.Length)
        {
            Console.WriteLine("Cadena sin ese carácter: " + texto.Remove(posicion, 1));
        }
        else
        {
            Console.WriteLine("La posición no es válida");
        }

        Console.WriteLine("Introduzca la posición inicial de la subcadena:");
        int inicio = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduzca la posición final de la subcadena:");
        int fin = Convert.ToInt32(Console.ReadLine());

        if (inicio >= 0 && fin >= inicio && fin <= texto.Length)
        {
            Console.WriteLine("Subcadena obtenida: " + texto.Substring(inicio, fin - inicio));
        }
        else
        {
            Console.WriteLine("La posición inicial o final no son válidas");
        }
    }
    else
    {
        Console.WriteLine("La cadena está vacía, no se pueden eliminar caracteres ni obtener subcadenas");
    }
}

Ejercicio6_2();

void Ejercicio6_2()
{
    Console.WriteLine("Ejercicio 6:");

    int numero;
    long factorial = 1;

    Console.WriteLine("Introduzca un número entero entre 0 y 20:");
    string inputStr = Console.ReadLine();
    numero = Convert.ToInt32(inputStr);

    if (numero >= 0 && numero <= 20)
    {
        for (int i = 1; i <= numero; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine("El factorial de " + numero + " es: " + factorial);
    }
    else
    {
        Console.WriteLine("El número debe estar entre 0 y 20");
    }
}

Ejercicio7_2();

void Ejercicio7_2()
{
    Console.WriteLine("Ejercicio 7:");

    for (int i = 90; i >= 65; i--)
    {
        Console.Write(Convert.ToString((char)i) + " ");
    }

    Console.WriteLine();
}

Ejercicio8_2();

void Ejercicio8_2()
{
    Console.WriteLine("Ejercicio 8:");

    Random aleatorio = new Random();
    int numero = aleatorio.Next(10, 31);

    Console.WriteLine("Número aleatorio: " + numero);
}

Ejercicio9_2();

void Ejercicio9_2()
{
    Console.WriteLine("Ejercicio 9:");

    int tamano;

    Console.WriteLine("Indique el tamaño del array:");
    string inputStr = Console.ReadLine();
    tamano = Convert.ToInt32(inputStr);

    if (tamano > 0)
    {
        int[] numeros = new int[tamano];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Introduzca el valor para la posición " + i + ":");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Números pares:");
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        Console.WriteLine("Números impares:");
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 != 0)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
    else
    {
        Console.WriteLine("El tamaño del array debe ser mayor que 0");
    }
}

Ejercicio10_2();

void Ejercicio10_2()
{
    Console.WriteLine("Ejercicio 10:");

    int[] numeros = { 8, 3, 15, 1, 10, 6, 20, 4, 12, 2 };

    Array.Sort(numeros);

    Console.WriteLine("Array ordenado:");
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine(numeros[i]);
    }
}

Ejercicio11_2();

void Ejercicio11_2()
{
    Console.WriteLine("Ejercicio 11:");

    System.Collections.Stack pila = new System.Collections.Stack();
    int cantidad;

    Console.WriteLine("¿Cuántos números desea introducir? (mínimo 2):");
    cantidad = Convert.ToInt32(Console.ReadLine());

    while (cantidad < 2)
    {
        Console.WriteLine("Debe introducir al menos 2 números. Indique la cantidad:");
        cantidad = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < cantidad; i++)
    {
        Console.WriteLine("Introduzca el número " + (i + 1) + ":");
        int numero = Convert.ToInt32(Console.ReadLine());
        pila.Push(numero);
    }

    Console.WriteLine("Elementos de la pila:");
    foreach (int numero in pila)
    {
        Console.WriteLine(numero);
    }

    pila.Pop();
    pila.Pop();

    Console.WriteLine("Elementos de la pila después de sacar dos valores:");
    foreach (int numero in pila)
    {
        Console.WriteLine(numero);
    }
}
