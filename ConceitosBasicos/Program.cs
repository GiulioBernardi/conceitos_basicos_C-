//1. Fazer um programa que leia três valores com ponto flutuante: A, B e C. Em seguida, calcule e mostre:
//a) a área do triângulo retângulo que tem A por base e C por altura. Fórmula: área = (base * altura) / 2
//b) a área do círculo de raio C. Fórmula: área = pi * raio²
//c) a área do trapézio que tem A e B por bases e C por altura. Fórmula: área = ((base1 + base2) * altura) / 2
//d) a área do quadrado que tem lado B. Fórmula: área = base²
//e) a área do retângulo que tem lados A e B. Fórmula: área = base * altura



//Console.WriteLine("Digite o valor de A: ");
//double a = double.Parse(Console.ReadLine());
//Console.WriteLine("Digite o valor de B: ");
//double b = double.Parse(Console.ReadLine());
//Console.WriteLine("Digite o valor de C: ");
//double c = double.Parse(Console.ReadLine());

//Console.WriteLine("A)");
//double areaDoTrianguloRetangulo;
//areaDoTrianguloRetangulo = (a * c) / 2;
//Console.WriteLine($"O valor A={a} e C={c} são, respectivamente, a base e altura de um triângulo retângulo.Sua área é: {areaDoTrianguloRetangulo}");

//Console.WriteLine("B)");
//double areaDoCirculo = 3.14 * (Math.Pow(c, 2));
//Console.WriteLine($"O valor C={c} é o raio de um círculo, sendo assim,sua área é: {areaDoCirculo}");

//Console.WriteLine("C)");
//double areaDoTrapezio = ((a + b) * c) / 2;
//Console.WriteLine($"O valor A={a} e B={b} são as bases de um trapézio, e C={c} é a sua altura, sua área é: {areaDoTrapezio}");

//Console.WriteLine("D)");
//double areaDoQuadrado = Math.Pow(c, 2);
//Console.WriteLine($"O valor de B={b} é o lado do quadrado, sua área é: {areaDoQuadrado}");

//Console.WriteLine("E)");
//double areaDoRetangulo = a * b;
//Console.WriteLine($"O de A={a} e B={b} são, respectivamente a altura e base de um retângulo, sua área é: {areaDoRetangulo}");



//--------------------------FIM DO EXERCÍCIO 1 ----------------------------------

//2. Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "São Múltiplos" ou "Não são
//Multiplos ", indicando se os valores lidos são múltiplos entre si.



//Console.WriteLine("Saiba se um número A é múltiplo de um número B\nDigite o valor de A: ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Digite o valor de B: ");
//int b = int.Parse(Console.ReadLine());

//Boolean saoMultiplos = false;
//for(int i = 1; i <= 10; i++)
//{
//    if (a > b)
//    {
//        if (a == (b * i))
//        {
//            saoMultiplos = true;
//            Console.WriteLine($"São múltiplos. Pois {i} * {b} = {a}");
//        }
//    }
//    else
//    {
//        if (b == (a * i))
//        {
//            saoMultiplos = true;
//            Console.WriteLine($"São múltiplos. Pois {i} * {a} = {b}");
//        }
//    }
//}
//if(saoMultiplos == false)
//{
//    Console.WriteLine("Não são múltiplos.");
//}



//--------------------------FIM DO EXERCÍCIO 2 ----------------------------------


//3. A estimativa de três pontos (PERT) é uma técnica utilizada para calcular a duração de uma atividade baseada em
//três valores:
//  • A estimativa mais otimista;
//  • A estimativa mais pessimista; e
//  • A estimativa mais provável.
//Para se calcular o tempo esperado para uma atividade, utiliza-se a seguinte fórmula:
//[Otimista + Pessimista + (4 x Mais Provável)] / 6

//Crie um programa que leia a estimativa (em horas) otimista, a pessimista e a mais provável e exiba na tela o tempo
//esperado, conforme a fórmula acima. Ex.: 10 + 30 + (15*4) / 6
//Otimista: 10
//Pessimista: 30
//Provavel: 15
//PERT = 16.66


//Console.WriteLine("Estimativa de três pontos");

//Console.WriteLine("Duração (horas) estimativa otimista: ");
//int horasEstimativaOtimista = int.Parse(Console.ReadLine());

//Console.WriteLine("Duração (horas) estimativa pessimista: ");
//int horasEstimativaPessimista = int.Parse(Console.ReadLine());

//Console.WriteLine("Duração (horas) estimativa mais provável: ");
//int horasEstimativaProvavel = int.Parse(Console.ReadLine());

//double pert = (horasEstimativaOtimista + horasEstimativaPessimista + (4 * horasEstimativaProvavel)) / 6;
//Console.WriteLine($"Estimativa \nOtimista: {horasEstimativaOtimista}\nPessimista: {horasEstimativaPessimista}\nProvável: {horasEstimativaProvavel}\nPERT(arredondado): {pert}");



//--------------------------FIM DO EXERCÍCIO 3 ----------------------------------

//4. Escreva um programa que leia a nota de um aluno e imprima sua situação com base nas seguintes condições:
//a) Caso a nota seja >= 7: “Aprovado”
//b) Caso a nota seja < 7 e >= 4: “Em recuperação”
//c) Caso a nota seja < 4: “Reprovado”



//Console.WriteLine("Programa de notas");
//Console.WriteLine("Digite a nota: ");
//double nota = double.Parse(Console.ReadLine());

//if (nota >= 7)
//{
//    Console.WriteLine("Aprovado");
//}
//if (nota >= 4 && nota < 7)
//{
//    Console.WriteLine("Em recuperação");
//}
//if (nota < 4)
//{
//    Console.WriteLine("Reprovado");
//}
//else
//{
//    Console.WriteLine("Opção inválida");
//}



//--------------------------FIM DO EXERCÍCIO 4 ----------------------------------

//5. Escreva um programa, utilizando a estrutura de decisão switch/case, que receba do usuário um número inteiro de 1
//a 3 e imprima a mensagem na tela com base na resposta:
//1-> “Bom dia”
//2 -> “Boa tarde”
//3 -> “Boa noite”


//Console.WriteLine("Digite um número de 1 a 3: ");
//int entrada = int.Parse(Console.ReadLine());

//switch (entrada)
//{
//    case 1:
//        Console.WriteLine("Bom dia");
//        break;
//    case 2:
//        Console.WriteLine("Boa tarde");
//        break;
//    case 3:
//        Console.WriteLine("Boa noite");
//        break;
//    case > 3:
//        Console.WriteLine("Opção inválida");
//        break;
//    case < 1:
//        Console.WriteLine("Opção inválida");
//        break;
//}



//--------------------------FIM DO EXERCÍCIO 5 ----------------------------------
//6. Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) *(N - 2) * (N - 3) * ... *1.
//Lembrando que, por definição, fatorial de 0 é 1.



//Console.WriteLine("Digite um número: ");
//int numero = int.Parse(Console.ReadLine());
//int fatorial = numero;
//for (int i = 1; i < numero; i++)
//{
//    fatorial *= numero - i;
//}
//Console.WriteLine($"{numero}! = {fatorial}");



//--------------------------FIM DO EXERCÍCIO 6 ----------------------------------
//7. Escreva um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
//começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor. Ex.:
//Entrada: 2
//Saída:
//1 1 1
//2 4 8

//Console.WriteLine("Digite um número: ");
//int n = int.Parse(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine($"{i} {i*i} {i*i*i}");
//}


//--------------------------FIM DO EXERCÍCIO 7 ----------------------------------


//8. Escreva um programa que simule a urna eletrônica. A tela a ser apresentada deverá ser da seguinte forma:
//As opções são:
//1.Candidato Chaves
//2.Candidata Chiquinha
//3.Candidato Quico
//4.Nulo / Branco
//5.Encerrar a votação
//Entre com o seu voto:
//O programa deverá ler os votos dos eleitores e, quando for entrado o número 5, apresentar as seguintes
//informações:
//a) O número de votos de cada candidato;
//b) A porcentagem de votos nulos;
//c) A porcentagem de votos brancos;
//d) O candidato vencedor


//Console.WriteLine("Urna eletrônica");

//Boolean encerrou = false;
//int chaves = 0;
//int chiquinha = 0;
//int quico = 0;
//int nulo = 0;
//int total = 0;
//String vencedor = null;
//while (!encerrou)
//{
//    Console.WriteLine("Selecione uma opção:\n1 - Candidato Chaves\n2 - Candidata Chiquinha\n3 - Candidato Quico\n4 - Nulo / Branco\n5 - Encerrar a votação");
//    int voto = int.Parse(Console.ReadLine());
//    switch (voto)
//    {
//        case 1:
//            chaves++;
//            total++;
//            break;
//        case 2:
//            chiquinha++;
//            total++;
//            break;
//        case 3:
//            quico++;
//            total++;
//            break;
//        case 4:
//            nulo++;
//            total++;
//            break;
//        case 5:
//            Console.WriteLine("Votação encerrada");
//            encerrou = true;
//            break;
//    }

//    int porcentagemNulo = (nulo * 100) / total;
    
//    if(chaves > chiquinha && chaves > quico)
//    {
//        vencedor = "Chaves";
//    }if (quico > chiquinha && quico > chaves)
//    {
//        vencedor = "Quico";
//    }if(chiquinha > chaves && chiquinha > quico)
//    {
//        vencedor = "Chiquinha";
//    }

//        Console.WriteLine($"Votos para Chaves: {chaves}" +
//        $"\nVotos para Chiquinha: {chiquinha}" +
//        $"\nVotos para Quico: {quico}" +
//        $"\nPorcentagem de votos nulo/branco: {porcentagemNulo}%" +
//        $"\n Vencedor: {vencedor}");
//}



//--------------------------FIM DO EXERCÍCIO 8 ----------------------------------
