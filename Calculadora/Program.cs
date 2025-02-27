
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
        Console.WriteLine("Digite ( % ) para algumas opções envolvendo porcentagem");
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
        else if (operacao == "%")
        {
            porcentagem(); ;
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

static void porcentagem()
{
    double n1, n2,resultado;
    Console.WriteLine("Opção (1): digite 2 numeros e descubra a porcentagem do segundo referente ao primeiro ");
    Console.WriteLine("Opção (2): digite um numero em seguida digite a porcetagem dele, será exibido o valor referente a porcentagem ");
    Console.WriteLine("Opção: ");
    int opcao;
    opcao = int.Parse(Console.ReadLine());
    if (opcao == 1)
    {
        Console.WriteLine("Digite o número numero base: ");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o numero que você quer descobrir a porcentagem sobre o numero base: ");
        n2 = double.Parse(Console.ReadLine());
        resultado = (n2 / n1) * 100;
        Console.WriteLine($"{n2} é {resultado:F2}% de {n1}");
    }
    if (opcao == 2)
    {
        Console.WriteLine("Digite o número numero base: ");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Digite a porcentagem que você deseja descubir de {n1} ");
        n2 = double.Parse(Console.ReadLine());
        resultado = (n1 / 100) * n2;
        Console.WriteLine($"{n2}% de {n1} é: {resultado}");
    }


}