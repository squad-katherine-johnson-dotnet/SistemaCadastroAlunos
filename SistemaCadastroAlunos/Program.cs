string[] nomes = new string[10];
int[] idades = new int[10];
double[] notas1 = new double[10];
double[] notas2 = new double[10];

string nome = "";
int idade = 0;
double nota1 = 0, nota2 = 0;

Console.WriteLine("=================================");
Console.WriteLine("      CADASTRO DE ALUNOS");
Console.WriteLine("=================================");

Console.Write("\nDigite a quantidade de alunos a cadastrar: ");
int quantidadeAlunos = int.Parse(Console.ReadLine());

for (int i = 0; i < quantidadeAlunos; i++) {

    Console.WriteLine($"\nInsira os dados do aluno {i + 1}:");

    bool nomeValido = false;

    while (!nomeValido) {

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(nome)) {
            nomeValido = true;
        }
        else {
            Console.WriteLine("Nome informado é inválido! Digite novamente.");
        }
    }

    bool idadeValida = false;

    while (!idadeValida) {
        Console.Write("Idade: ");
        var idadeDigitada = Console.ReadLine();

        if (int.TryParse(idadeDigitada, out idade) && idade > 0) {
            idadeValida = true;
        }
        else {
            Console.WriteLine("Idade informada é inválida! Digite novamente.");
        }
    }

    bool Nota1Valida = false;

    while (!Nota1Valida) {

        Console.Write("Nota 1: ");
        var nota1Digitada = Console.ReadLine();

        if (double.TryParse(nota1Digitada, out nota1) && nota1 >= 0 && nota1 <= 10) {
            Nota1Valida = true;
        }
        else {
            Console.WriteLine("Nota informada é inválida! Digite novamente.");
        }
    }

    bool Nota2Valida = false;

    while (!Nota2Valida) {

        Console.Write("Nota 2: ");
        var nota2Digitada = Console.ReadLine();

        if (double.TryParse(nota2Digitada, out nota2) && nota2 >= 0 && nota2 <= 10) {
            Nota2Valida = true;
        }
        else {
            Console.WriteLine("Nota informada é inválida! Digite novamente.");
        }
    }

    nomes[i] = nome;
    idades[i] = idade;
    notas1[i] = nota1;
    notas2[i] = nota2;
}

int opcao = -1;
int tentativasErro = 0;

while (opcao != 0 && tentativasErro < 3) {

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

    if (opcao == 1) {

        Console.WriteLine("\n=================================");
        Console.WriteLine("             LISTAGEM              ");
        Console.WriteLine("===================================");

        for (int i = 0; i < quantidadeAlunos; i++) {

            double media = (notas1[i] + notas2[i]) / 2.0;

            Console.WriteLine($"Nome: {nomes[i]}");
            Console.WriteLine($"Idade: {idades[i]}");
            Console.WriteLine($"Média: {media:F1}\n");

            tentativasErro = 0;
        }
    }
    else if (opcao == 2) {

        Console.Write("Digite o nome do aluno que deseja buscar: ");
        string nomeBusca = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0; i < quantidadeAlunos; i++) {

            if (nomes[i].ToLower() == nomeBusca.ToLower()) {

                Console.WriteLine("\n=================================");
                Console.WriteLine("        ALUNO ENCONTRADO");
                Console.WriteLine("=================================");
                Console.WriteLine("Nome: " + nomes[i]);
                Console.WriteLine("Idade: " + idades[i]);
                Console.WriteLine("Nota 1: " + notas1[i]);
                Console.WriteLine("Nota 2: " + notas2[i]);

                double media = (notas1[i] + notas2[i]) / 2;
                Console.WriteLine("Média: " + media);

                encontrado = true;
                break;
            }
        }

        if (!encontrado) {
            Console.WriteLine("Aluno não encontrado.");
        }

        tentativasErro = 0;
    }
    else if (opcao == 3) {
        Console.WriteLine("\n=================================");
        Console.WriteLine("        ALUNOS APROVADOS");
        Console.WriteLine("=================================");

        int totalAprovados = 0;

        for (int i = 0; i < quantidadeAlunos; i++) {
            double media = (notas1[i] + notas2[i]) / 2.0;

            if (media >= 7) {
                Console.WriteLine($"{nomes[i]} - Média: {media:F1}");
                totalAprovados++;
            }
        }

        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Total de aprovados: {totalAprovados}");

        tentativasErro = 0;
    }
    else if (opcao == 4) {

        Console.WriteLine("\n=================================");
        Console.WriteLine("        MÉDIA DA TURMA");
        Console.WriteLine("=================================");

        if (quantidadeAlunos > 0) {

            double somaMedias = 0;

            for (int i = 0; i < quantidadeAlunos; i++) {

                double mediaAluno = (notas1[i] + notas2[i]) / 2;
                somaMedias = somaMedias + mediaAluno;
            }

            double mediaTurma = somaMedias / quantidadeAlunos;
            Console.WriteLine($"A média geral da turma é: " + mediaTurma);
        }

        tentativasErro = 0;
    }
    else if (opcao == 0) {
        Console.WriteLine("Programa encerrado.");
    }
    else {
        tentativasErro = tentativasErro + 1;

        if (tentativasErro >= 3) {
            Console.WriteLine("Número máximo de tentativas inválidas atingido!");
            Console.WriteLine();
            Console.WriteLine("*** Programa Encerrado! ***");
        }
        else {
            Console.WriteLine($"Opção inválida! Tentativa {tentativasErro} de 3. Tente novamente.");
        }
    }
}