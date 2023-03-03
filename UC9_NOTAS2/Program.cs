string aluno;
int i;
int faltas;
int aulas;
double prova1 = 0;
double prova2 = 0;
double prova3 = 0;
double trabalho = 0;
double peso1 = 0;
double peso2 = 0;
double peso3 = 0;
double md = 0;
double presenca = 0;
string resultado = "";

for (i = 1; i <= 5; i++)
{

    Console.WriteLine("Informe o nome do " + (i + 1) + "º aluno");
    aluno = Console.ReadLine();

    Console.WriteLine("Informe a quantidade de aulas");
    aulas = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe a quantidade de faltas");
    faltas = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe a nota da prova 1");
    prova1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o peso para a nota da prova 1");
    peso1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a nota da prova 2");
    prova2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o peso para a nota da prova 2");
    peso2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a nota da prova 3");
    prova3 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o peso para a nota da prova 3");
    peso3 = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a nota do trabalho");
    trabalho = double.Parse(Console.ReadLine());

    md = (prova1 * peso1) + (prova2 * peso2) + (prova3 * peso3);
    presenca = (faltas / aulas) * 100;



    if (md >= 6 && presenca > 25)
    {
        resultado = "Aprovado";
    }
    if (md < 6 && presenca >= 25)
    {
        resultado = "Reprovado por Menção";
    }
    if (md > 6 && presenca < 25)
    {
        resultado = "Reprovado por Faltas";
    }
    if (md < 6 && presenca < 25)
    {
        resultado = "Reprovado por Menção e Faltas";
    }

    Console.WriteLine(aluno + ", sua nota foi de: " + md + " sua presença foi de: " + presenca + ", o Aluno foi ");

}