// Módulos gerais que estão sendo utilizados no projeto. Cada um deles adiciona novas ferramentas e funcionalidades possíveis.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {

        // Nos Enum é possível definir o índice que você quer que os itens tenham.
        // Se isso for feito para um dos itens, os itens seguintes seguirão o índice a partir daí.
        // Enums servem para criarmos um novo "tipo" de dado, que poderá ter os valores indicados.
        enum Cor { Azul = 30, Verde, Amarelo, Vermelho }
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }

        // Variáveis criadas dentro de uma função possuem escopo local. Ou seja, só existem naquela função.
        // Variáveis criadas no "program" tem escopo global e podem ser utilizadas em qualquer função.
        // Variáveis do escopo global só podem ser usadas em funções "static" se elas também forem static.
        // Pode possuir modificadores como "private" ou "readonly" para restringir sua usabilidade.
        static string variavelGlobal = "EscopoGlobal";

        static void Main(string[] args)
        {

            // Tipos de dados
            // Int: Número inteiros.
            // Float: Números flutuantes (15.5)
            // Bool: True ou False
            // String: "" Texto definido com aspas duplas.
            // Char: '' um único caracter definido com aspas simples.

            Console.WriteLine("Hello World!");
            Console.WriteLine("Meu nome é Marlon James.");

            GerarPreco(50, 0.1f);

            Enum();

            Console.WriteLine(variavelGlobal);

            Console.ReadLine();

        }

        static void Variáveis()
        {

            /* Nome de variável só pode contar letras e números,
            o único caracter especial permitido é o _
            e não pode começar com número.
            Não podemos usar palavras que são reservadas da linguagem. */

            int soma = Somar(1, 2, 3);
            Console.WriteLine(soma);

            int segundaGuerraMundial = 1939;
            string corFavorita = "lilás";
            float velocidadeF1 = 294.48f; // Para usar decimal tem que colocar o f no final.
            bool segundaGuerraAconteceu = true;

            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraAconteceu);

            velocidadeF1 = 348.29f;

            Console.WriteLine(velocidadeF1);

            // var cor_favorita = "lilás"; 

            // Declarando variáveis com dynamic permite mudar o tipo dela.
            dynamic cor_favorita = "Vermelho";
            Console.WriteLine(cor_favorita);
            // Não é muito recomendada por sair do padrão do C# que é uma linguagem muito tipada, além de possuir menos performance.
            cor_favorita = 987;
            Console.WriteLine(cor_favorita);

            // Constantes são iguais variáveis mas seu valor não pode ser alterado posteriormente.
            const float PI = 3.1415f;
            Console.WriteLine(PI);

            Console.WriteLine("Escreva seu nome");
            string nome = Console.ReadLine();
            Console.Write("Seu nome é: ");
            Console.WriteLine(nome);

        }

        static void GerarPreco(int preco, float desconto)
        {
            int precoAbs = Math.Abs(preco);
            float valorFinal = precoAbs - (precoAbs * desconto);
            Console.WriteLine(valorFinal);
        }

        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
        }

        static void Arrays()
        {

            // Forma base para criar Arrays.
            string[] Produtos = new string[6]
            {
                "Hogwarts Legacy",
                "Red Dead Redemption 2",
                "Elden Ring",
                "Ghost of Tsushima",
                "Assassins Creed Valhalla",
                "The Last of Us Part I"
            };

            Produtos[5] = "The Last of Us Part II";
            Console.WriteLine(Produtos[5]);

            // Forma simplificada para criar arrays.
            int[] precos = { 40, 50, 60, 70, 80 };

        }

        static void Condicionais()
        {

            // Divisão entre dois inteiros é igual a um inteiro.
            // Divisão que contenha ao menos 1 número float será igual a float.
            int numeroQualquer = 20 + 20 - 10 * 2 / 5;
            Console.WriteLine(numeroQualquer);

            // > < >= <= == !=
            if (numeroQualquer == 10)
            {
                Console.WriteLine("É 10!");
            }
            else if (numeroQualquer == 20)
            {
                Console.WriteLine("É 20!");
            }
            else
            {
                Console.WriteLine("É outro número");
            }

            // && (and) || (or)

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é criança!");
            }
            else if (idade >= 12 && idade <= 17)
            {
                Console.WriteLine("Você é adolescente!");
            }
            else if (idade >= 18 && idade <= 59)
            {
                Console.WriteLine("Você é adulto!");
            }
            else
            {
                Console.WriteLine("Você é idoso!");
            }

        }

        static void Switch()
        {

            // Uma alternativa ao uso do If e Else if. Muito útil quando temos muitas condições.
            // Ele só funciona para comparativo de igualdade.
            string cor = "Lilás";

            switch (cor)
            {

                case "Lilás":
                    Console.WriteLine("Sua cor favorita é lilás");
                    break;
                case "Verde":
                    Console.WriteLine("Você não gosta de verde.");
                    break;
                case "Preto":
                    Console.WriteLine("Preto é uma cor muito flexível");
                    break;
                default:
                    Console.WriteLine("Não sei qual é sua cor favorita");
                    break;
            }

        }

        static void Enum()
        {

            Cor corFavorita = Cor.Vermelho;
            Console.WriteLine(corFavorita);
            Cor verIndice = Cor.Vermelho;
            Console.WriteLine((int)verIndice);
            // Foi feito Cast para transformar o dado do tipo "Cor" para "int".
            Console.WriteLine((Cor)30);
            // Processo reverso. Buscar um valor usando um número de índice.

            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1 - Criar\n2 - Deletar\n3 - Editar\n4 - Listar\n5 - Atualizar");

            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você está criando algo.");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Você está deletando algo.");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Você está editando algo.");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Você está listando algo.");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Você está atualizando algo.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        }

        static void While()
        {

            int contador = 0;
            while (contador < 10)
            {
                Console.WriteLine("Executando o while.");
                contador++;
                // contador = contador +1 / contador += 1 / contador++
            }

            // A diferença do doWhile pro While é que ele sempre será executado ao menos 1 vez.
            // Mesmo que a condição seja falsa.
            int contador2 = 0;
            do
            {
                Console.WriteLine("Executando o Do While.");
                contador2++;
            } while (contador2 < 10);

        }

        static void For()
        {
            string[] palavras = { "Marlon", "James", "Rezende", "Castro" };

            for (int contador = 0; contador < palavras.Length; contador++)
            {
                Console.WriteLine(contador);
                Console.WriteLine(palavras[contador]);
            };

            // Fazer o For percorrer o Array em ordem reversa (decrescente).
            for (int contador2 = palavras.Length - 1; contador2 >= 0; contador2--)
            {
                Console.WriteLine(contador2);
                Console.WriteLine(palavras[contador2]);
            }
        }

        static void ForEach()
        {

            string[] palavras = { "Marlon", "James", "Rezende", "Castro" };

            // Percorre os elementos de um array.
            // deve-se colocar uma variável do mesmo tipo do array e nomeá-lo, logo indicar o nome do array.
            foreach (string palavra in palavras)
            {
                Console.WriteLine(palavra);
            }

        }

    }
}