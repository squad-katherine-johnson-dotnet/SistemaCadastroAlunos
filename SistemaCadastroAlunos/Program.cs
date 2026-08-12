string[] nomes = new string[10];
int[] idades = new int[10];
double[] notas1 = new double[10];
double[] notas2 = new double[10];

int quantidadeAlunos = 0;
int tentativasErro = 0;

string nome;
int idade;
double nota1, nota2;

Console.WriteLine("==== CADASTRO DE ALUNOS ====");

for (int i = 0; i < 10; i++) {

    Console.WriteLine($"Insira os dados do aluno {i + 1}:");


    while (true) {
        Console.Write("Nome: ");
        nome = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(nome)) {
            break;
        }
        Console.WriteLine("Nome informado é inválido! Digite novamente.");
    }

    while (true) {
        Console.Write("Idade: ");
        var idadeDigitada = Console.ReadLine();

        if (int.TryParse(idadeDigitada, out idade) && idade > 0) {
            break;
        }

        Console.WriteLine("Idade informada é inválida! Digite novamente.");
    }

    while (true) {

        Console.Write("Nota 1: ");
        var nota1Digitada = Console.ReadLine();

        if (double.TryParse(nota1Digitada, out nota1) && nota1 >= 0 && nota1 <= 10) {
            break;
        }

        Console.WriteLine("Nota informada é inválida! Digite novamente.");
    }

    while (true) {

        Console.Write("Nota 2: ");
        var nota2Digitada = Console.ReadLine();

        if (double.TryParse(nota2Digitada, out nota2) && nota2 >= 0 && nota2 <= 10) {
            break;
        }

        Console.WriteLine("Nota informada é inválida! Digite novamente.");
    }

    nomes[i] = nome;
    idades[i] = idade;
    notas1[i] = nota1;
    notas2[i] = nota2;
}

quantidadeAlunos = nomes.Length;

int opcao = -1;

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
            Console.WriteLine($"Idade: git{idades[i]}");
            Console.WriteLine($"Média: {media:F1}\n");
            tentativasErro = 0;
        }
    }
    else if (opcao == 2) {
        Console.WriteLine("Buscar Aluno...");
        tentativasErro = 0;
    }
    else if (opcao == 3) {
        Console.WriteLine("====== ALUNOS APROVADOS ======");
        int totalAprovados = 0;
        tentativasErro = 0;
    }
}
        // Integrante 2 - Listagem

      


// ==========================
// CADASTRO
// ==========================


// ==========================
// MENU
// ==========================


// ==========================
// LISTAGEM
// ==========================


// ==========================
// BUSCA
// ==========================


// ==========================
// APROVADOS
// ==========================


// ==========================
// MÉDIA DA TURMA
// ==========================