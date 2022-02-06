using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestesCSharp
{
    /// <summary>
    /// Comentários que aparecem no XML coments,
    /// * para pegar tem que colocar as tres barras
    /// * também temos a opçao de utilizar atalhos para comentar linhas
    /// * variaveis e constantes
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("                                                                               ");
            Console.WriteLine("************************ Sintaxe sobre váriaveis **********************   ");
            Console.WriteLine("                                                                               ");

            int a; //aqui é uma declaração de váriavel 
            a = 5; // aqui estou fazendo uma atribuição para variavel , aqui eu não preciso informar o tipo da variavel, porque ela foi informada acima
            Console.WriteLine(a);

            int b = 2; // aqui estou declarando uma váriavel e declarando ela com um valor inicial
            Console.WriteLine(b);










            

            Console.WriteLine("**************************   Tipos inteiros  **************************************");
            Console.WriteLine("                                                                               ");
            
            //constante e tipos de váriaves 

            int num = 15;
            const double pi = 3.14;
            Console.WriteLine(num);
            Console.WriteLine(pi);

            num = 50; //aqui não precisei colocar o tipo da variavel, pois já foi informada no inicio
            //pi = 4.5; // aqui deu pau, porque é uma constante que já foi informada no inicio com o valor de 3.14
 
            Console.WriteLine(num);
            Console.WriteLine(pi);

            //tipos de várives (internos)
            bool estaComFome=false;
            Console.WriteLine("Esta com fome? " + estaComFome);

            //tipos numericos  inteiros onde a diferença esta na capacidade armazenamento 
            //bytes com sinal e sem sinal
            byte idade = 10;
                Console.WriteLine(idade);
            
            sbyte temperatura = -20; //tem um range dividio em positivos e negativos 
            Console.WriteLine(temperatura);

            sbyte menorValordoByte = sbyte.MinValue;
            Console.WriteLine(menorValordoByte); //resultado -128

            sbyte maiorValordoByte = sbyte.MaxValue;
            Console.WriteLine(maiorValordoByte); //resultado 127;

            short menorValordoShort = short.MinValue;  //resultado -32768
            Console.WriteLine(menorValordoShort);

            short maiorValordoShort = short.MaxValue;  //resultado -32768
            Console.WriteLine(maiorValordoShort);

            int menorValorInt = int.MinValue;
            Console.WriteLine(menorValorInt);

            int maiorValorInt = int.MaxValue;
            Console.WriteLine(maiorValorInt);

            uint populacaobrasileira = 207_100_25;
            Console.WriteLine(populacaobrasileira);

            long menorValorLong = long.MinValue; // long com sinal
            Console.WriteLine(menorValorLong);

            long maiorValorLong = long.MaxValue; // long sem sinal
            Console.WriteLine(maiorValorLong);

            ulong menorValorULong = ulong.MinValue; // retorna 0
            Console.WriteLine(menorValorULong);

            ulong maiorValorULong = ulong.MaxValue;// retorna o valor sem o sinal
            Console.WriteLine(maiorValorULong);


            Console.WriteLine("                                                                               ");
            Console.WriteLine("************************ tipos reais(pontos flutuantes **********************   ");
            Console.WriteLine("                                                                               ");

            float precoVenda = 1299.99f; //o floate tem 4 bytes de armazenamento, enquanto o DOUBLE tem o dobro do float, ou seja, 8 bytes
            Console.WriteLine(precoVenda);
            
            double precoCompra = 1299.99;// fica a dica da quantidade de armazenamento
            Console.WriteLine(precoCompra);
            double precoCompraItem = 13_000_000_000_000;// fica a dica da quantidade de armazenamento
            Console.WriteLine(precoCompraItem);

            decimal precoVendaItem = 000_000_000_000_131_000_000_000_000; //aqui o armazenamento é maior ainda  
            Console.WriteLine(precoVendaItem);

            decimal menorValorDecimal = decimal.MinValue;
            Console.WriteLine(menorValorDecimal);


            decimal maiorValorDecimal = decimal.MaxValue;
            Console.WriteLine(maiorValorDecimal);


            Console.WriteLine("                                                                               ");
            Console.WriteLine("************************ Tipos para letras ou palavras **********************   ");
            Console.WriteLine("                                                                               ");

            char sexo = 'M'; //Em char é aspas simples, e recebe um valor
            Console.WriteLine(sexo);

            string nomeCompleto = "Emanuel Vieira de Souza e Souza Carvalho dos Santos";// aqui é uma cadeia de caracteres é usado aspas duplas    
            Console.WriteLine(nomeCompleto);

            Console.WriteLine("                                                                               ");
            Console.WriteLine("************************ Inferencia de tipos **********************   ");
            Console.WriteLine("                                                                               ");
            //é onde não preciso informar qual é o tipo da variavel, o C# vai descobrir na medida que é informado o conteudo

            var nome = "Bruno Ivo"; // aqui houve uma inferencia, ou seja, a variavel nome fica como string, outro detalhe é, quando uso 
                                    //inferencia eu devo sempre manter o padrão no código exemplo: var idade=17, var sexo='M', var valor=2.30
            Console.WriteLine(nome);


            Console.WriteLine("                                                                               ");
            Console.WriteLine("************************ Interpolação de Strings **********************   ");
            Console.WriteLine("                                                                               ");
            // É utilizaçaõ de simbolos no lugar dos nomes das varives quando eu quero mostrar em tela
            // interpolação é uma interpretação dos valores que estão entre chaves, onde são substituidos para gerar um resultado


            //Primeira maneira, colocando um identificador
            string nomeA = "Calça";
            string tamanhoA = "Tamanho P";
            double precoA = 15.25;
            Console.WriteLine("o produto {0}, do {1} custa no valor de {2}",nomeA,tamanhoA,precoA);

            //Segunda maneira, colocando o nome da variavel

            string nomeB = "Camisa";
            string tamanhoB = "Tamanho GG";
            double precoB = 30.65;
            Console.WriteLine($"o produto {nomeB}, do {tamanhoB} custa no valor de {precoB}");

            //Obs: podemos usar uma operação matematica
            Console.WriteLine($"1 + 3 é igual a: {1+3}");



            Console.WriteLine("                                                                               ");
            Console.WriteLine("************************ Notacação Ponto **********************   ");
            Console.WriteLine("                                                                               ");
            var saudacao = "oi".ToUpper().Insert(2, " tudo bem? como estamos?").Replace("tudo bem?", "eae blz?");
            Console.WriteLine(saudacao);

            string valorNulo = null;
            Console.WriteLine(valorNulo?.Length);/* quando o valor é nulo e vc usa somente o ponto da erro, tem que colocar o (?) 
                                                   para a nevageção ser mais segura , ou seja, não dê erro no console*/

            Console.WriteLine("                                                                               ");
            Console.WriteLine("************************ Lendo dados do console **********************   ");
            Console.WriteLine("                                                                               ");

            Console.WriteLine("Qual é o seu nome? ");
            string nomeC = Console.ReadLine();

            Console.WriteLine("Qual é sua idade? ");
            int idadeC = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é seu salario ");
            double salarioC = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture); //pega o . como separador de casas decimais 

            Console.WriteLine($"{nomeC} {idadeC} R$ {salarioC} ");



            
             Console.ReadLine();
        }
    }
}
