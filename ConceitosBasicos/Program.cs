using ConceitosBasicos;

int num1 = 20;
int num2 = 11, result;

Somador Soma; 
Soma = new Somador();

result = Soma.Soma(num1, num2);

Console.WriteLine($" A soma dos numeros {num1} + {num2} é {result}" );

//Conversor MetrosMilimetros;
//MetrosMilimetros = new Conversor();
Console.WriteLine(Conversor.MetrosMilimetros(1.76));
double metros = 1.76;
Console.WriteLine("A medida {0} metros correspondente a {1}", metros, Conversor.MetrosMilimetros(1.76));