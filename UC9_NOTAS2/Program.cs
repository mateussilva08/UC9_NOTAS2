string aluno;
int i;
int faltas = 0;
int faltastotal = 0;
int aulas = 0;
double prova1 = 0;
double prova2 = 0;
double prova3 = 0;
double trabalho = 0;
double peso1 = 0.3;
double peso2 = 0.25;
double peso3 = 0.35;
double md = 0;
double presenca = 0;
string resultado = "";

for (i = 1; i <= 5; i++)
{
    Console.Clear();

    Console.WriteLine("Informe o nome do " + i + "º aluno");
    aluno = Console.ReadLine();

    Console.WriteLine("Informe a quantidade de aulas");
    aulas = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe a quantidade de faltas");
    faltas = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe a nota da prova 1");
    prova1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a nota da prova 2");
    prova2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a nota da prova 3");
    prova3 = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a nota do trabalho");
    trabalho = double.Parse(Console.ReadLine());

    md = (prova1 * peso1 + prova2 * peso2 + prova3 * peso3) / (peso1 + peso2 + peso3) + trabalho;
    faltastotal = (faltas * 100) / aulas;
    presenca = 100 - faltastotal;



    if (md >= 6 && presenca >= 75)
    {
        Console.WriteLine(aluno + ", Aprovado com " + md.ToString("F") + " de media e " + presenca + "% presença");
    }
    if (md < 6 && presenca >= 75)
    {
        Console.WriteLine(aluno + ", Reprovado por notas com " + md.ToString("F") + " de media");
    }
    if (md > 6 && presenca < 75)
    {
        Console.WriteLine(aluno + ", Reprovado por faltas com " + presenca + "% de presença");
    }
    if (md < 6 && presenca < 75)
    {
        Console.WriteLine(aluno + ", Reprovado por menção e faltas com " + md.ToString("F") + " de media e " + presenca + "% de presença");
    }

    Console.WriteLine("Pressione ENTER para continuar");
    Console.ReadLine();

}
