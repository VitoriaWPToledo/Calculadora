
menuCalculadora();

static void menuCalculadora()

{
    bool continuarMenu = true;
    while (continuarMenu)
    {

        Console.WriteLine("\n\n\n\n\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");   
        Console.WriteLine("Menu calculadora");
        Console.WriteLine("Digite ( + ) para fazer uma soma");
        Console.WriteLine("Digite ( - ) para fazer uma subtração");
        Console.WriteLine("Digite ( * ) para fazer uma multiplicação");
        Console.WriteLine("Digite ( / ) para fazer uma divisão");
        Console.WriteLine("Digite ( r ) para descubrir a raiz quadrada de um numero");
        Console.WriteLine("Para fechar o menu digite ( 0 )");
        Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
        Console.Write("Qual opção: ");
        

        string operacao = Console.ReadLine();
        Console.Clear();
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
        else if (operacao == "r")
        {
            raizQuadrada();
        }
        else if (operacao == "0")
        {
            continuarMenu = false;
        }
        else
        {
            Console.WriteLine("Valor Invalido, digite novamente: ");
        }
    }
}
static void raizQuadrada()
{
    double n1, resultado;
    Console.WriteLine("Digite um numero para descubrir a raiz quadrade dele: ");
    n1 = double.Parse(Console.ReadLine());
    resultado = Math.Sqrt(n1);
    Console.WriteLine($"O raiz de {n1} é {resultado}");
}
static void soma()
{
    double n1, n2;

    Console.WriteLine("Digite o primeiro número: ");
    n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    n2 = double.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado de {n1} + {n2} é: {n1+n2}");
}

static void subtracao()
{
    double n1, n2;

    Console.WriteLine("Digite o primeiro número: ");
    n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    n2 = double.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado de {n1} - {n2} é: {n1 - n2}");
}
static void multiplicacao()
{
    double n1, n2;

    Console.WriteLine("Digite o primeiro número: ");
    n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    n2 = double.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado de {n1} * {n2} é: {n1 * n2}");
}

static void divisao()
{
    double n1, n2;

    Console.WriteLine("Digite o primeiro número: ");
    n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    n2 = double.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado de {n1} / {n2} é: {n1 / n2}");
}