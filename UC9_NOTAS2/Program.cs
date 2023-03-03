string aluno1;
string aluno2;
string aluno3;
string aluno4;
string aluno5;
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


Console.WriteLine("Informe o nome do 1º aluno");
aluno1 = Console.ReadLine();

Console.WriteLine("Informe o nome do 2º aluno");
aluno2 = Console.ReadLine();

Console.WriteLine("Informe o nome do 3º aluno");
aluno3 = Console.ReadLine();

Console.WriteLine("Informe o nome do 4º aluno");
aluno4 = Console.ReadLine();

Console.WriteLine("Informe o nome do 5º aluno");
aluno5 = Console.ReadLine();

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

