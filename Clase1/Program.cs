Console.WriteLine("Hello, DAM!");


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