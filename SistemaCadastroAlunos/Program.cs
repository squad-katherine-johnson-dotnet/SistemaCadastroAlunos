string[] nomes = new string[10];
int[] idades = new int[10];
double[] notas1 = new double[10];
double[] notas2 = new double[10];

int quantidadeAlunos = 0;
int tentativasErro = 0;

int opcao = -1;

while (opcao != 0 && tentativasErro < 3)
{
    Console.WriteLine("");
    Console.WriteLine("=================================");
    Console.WriteLine("          MENU PRINCIPAL         ");
    Console.WriteLine("=================================");
    Console.WriteLine("1 - Lista de alunos");
    Console.WriteLine("2 - Buscar aluno");
    Console.WriteLine("3 - Exibir aprovados");
    Console.WriteLine("4 - Exibir média da turma");
    Console.WriteLine("0 - Encerrar");
    Console.WriteLine("=================================");
    Console.WriteLine();
    Console.Write("Digite a opção desejada: ");

    opcao = int.Parse(Console.ReadLine()!);

    if (opcao == 1)
    {
        Console.WriteLine("Lista de Alunos...");
        tentativasErro = 0;
    }
    else if (opcao == 2)
    {
        Console.WriteLine("Buscar Aluno...");
        tentativasErro = 0;
    }
    else if (opcao == 3)
    {
        Console.WriteLine("====== ALUNOS APROVADOS ======");
        int totalAprovados = 0;
        tentativasErro = 0;

        for (int i = 0; i < quantidadeAlunos; i++)
        {
            double media = (notas1[i] + notas2[i]) / 2;
            if (media >= 7.0)
            {
                Console.WriteLine(nomes[i] + " - Média: " + media);
                totalAprovados = totalAprovados + 1;
            }
        }
        Console.WriteLine($"Total: " + totalAprovados + " alunos");
    }
    else if (opcao == 4)
    {
        Console.WriteLine("====== MÉDIA DA TURMA ======");
        tentativasErro = 0;

        if (quantidadeAlunos > 0)
        {
            double somaMedias = 0;
            for (int i = 0; i < quantidadeAlunos; i++)
            {
                double mediaAluno = (notas1[i] + notas2[i]) / 2;
                somaMedias = somaMedias + mediaAluno;
            }
            double mediaTurma = somaMedias / quantidadeAlunos;
            Console.WriteLine($"A média geral da turma é: " + mediaTurma);
        }
    }
    else if (opcao == 0)
    {
        Console.WriteLine("Programa encerrado.");
    }
    else
    {
        tentativasErro = tentativasErro + 1;

        if (tentativasErro >= 3)
        {
            Console.WriteLine("Número máximo de tentativas inválidas atingido!");
            Console.WriteLine();
            Console.WriteLine("*** Programa Encerrado! ***");
        }
        else
        {
            Console.WriteLine($"Opção inválida! Tentativa {tentativasErro} de 3. Tente novamente.");
        }
    }
}