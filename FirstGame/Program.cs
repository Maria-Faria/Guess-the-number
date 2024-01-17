Console.Write(@"
██████╗░███████╗░██████╗░█████╗░██╗░░░██╗██████╗░██████╗░░█████╗░  ░█████╗░
██╔══██╗██╔════╝██╔════╝██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗
██║░░██║█████╗░░╚█████╗░██║░░╚═╝██║░░░██║██████╦╝██████╔╝███████║  ██║░░██║
██║░░██║██╔══╝░░░╚═══██╗██║░░██╗██║░░░██║██╔══██╗██╔══██╗██╔══██║  ██║░░██║
██████╔╝███████╗██████╔╝╚█████╔╝╚██████╔╝██████╦╝██║░░██║██║░░██║  ╚█████╔╝
╚═════╝░╚══════╝╚═════╝░░╚════╝░░╚═════╝░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝  ░╚════╝░

███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░░█████╗░
████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██╔══██╗
██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║░░██║
██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║░░██║
██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║╚█████╔╝
╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░");

//Gerar um número aleatório entre 1 e 100
Random random = new Random();
int numRandom = random.Next(1, 101);

//Receber palpite do usuário
Console.WriteLine();
Console.Write("\nDigite um número: ");
int numUser = int.Parse(Console.ReadLine()!);
Console.WriteLine();

//Verificar se o valor digitado pelo usuário é menor ou maior ao escolhido
do
{
    if(numUser < numRandom)
    {
        Console.Write("Errado! O número que eu escolhi é maior que " + numUser + "... \nTente novamente: ");
        numUser = int.Parse(Console.ReadLine()!);
        Console.WriteLine();
    
    }else if(numUser > numRandom)
    {
        Console.Write("Errado! O número que eu escolhi é menor que " + numUser + "... \nTente novamente: ");
        numUser = int.Parse(Console.ReadLine()!);
        Console.WriteLine();
    
    }

} while (numUser != numRandom); //Repetir enquanto o usuário não acertar

Console.WriteLine("Parabéns, você acertou! O número que eu escolhi foi " + numRandom);
