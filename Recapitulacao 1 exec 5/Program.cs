/* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago. */

using System.Globalization;

int codigo, numeroPeca, codigo2, numeroPeca2;
double valorUnitario, valorUnitario2, valor;

Console.WriteLine("Informe o código da peça 1, o número de peças , o valor unitário de cada peça ");
string[] valores = Console.ReadLine().Split(' ');
codigo = int.Parse(valores[0]);
numeroPeca = int.Parse(valores[1]);
valorUnitario = double.Parse(valores[2], CultureInfo.InvariantCulture);

Console.WriteLine("Informe o código da peça 2, o número de peças , o valor unitário de cada peça ");
valores = Console.ReadLine().Split(' ');
codigo2 = int.Parse(valores[0]);
numeroPeca2 = int.Parse(valores[1]);
valorUnitario2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

valor = valorUnitario * numeroPeca + valorUnitario2 * numeroPeca2;

Console.WriteLine("VALOR A PAGAR: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));