string[] nomes = new string[10];
int[] idades = new int[10];
double[] notas1 = new double[10];
double[] notas2 = new double[10];

int quantidadeAlunos = 0;


        // Integrante 2 - Listagem
        Console.WriteLine("\n=================================");
        Console.WriteLine("             LISTAGEM              ");
        Console.WriteLine("===================================");
        for (int i = 0; i < quantidadeAlunos; i++)
        {
            double media = (notas1[i] + notas2[i]) / 2.0;
            Console.WriteLine($"Nome: {nomes[i]}");
            Console.WriteLine($"Idade: git{idades[i]}");
            Console.WriteLine($"Média: {media:F1}\n");
        }
      


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