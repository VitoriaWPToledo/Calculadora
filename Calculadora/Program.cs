Console.WriteLine("calculadora");
Console.WriteLine("Qual operação você deseja executar? ");
Console.WriteLine("Digite as opções: +, -, *, / ");
string operacao = Console.ReadLine();
if (operacao == "+")
{
    soma();
}
else if (operacao == "-")
{
    subtracao();
}
else if (operacao == "*")
{
    multiplicacao();
}
else if (operacao == "/")
{
    divisao();
}



static void soma()
{
    double n1, n2;

    Console.WriteLine("Digite o primeiro número: ");
    n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    n2 = double.Parse(Console.ReadLine());

    Console.WriteLine(n1 + n2);
}

static void subtracao()
{
    double n1, n2;

    Console.WriteLine("Digite o primeiro número: ");
    n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    n2 = double.Parse(Console.ReadLine());

    Console.WriteLine(n1 - n2);
}
static void multiplicacao()
{
    double n1, n2;

    Console.WriteLine("Digite o primeiro número: ");
    n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    n2 = double.Parse(Console.ReadLine());

    Console.WriteLine(n1 * n2);
}

static void divisao()
{
    double n1, n2;

    Console.WriteLine("Digite o primeiro número: ");
    n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    n2 = double.Parse(Console.ReadLine());

    Console.WriteLine(n1 / n2);
}