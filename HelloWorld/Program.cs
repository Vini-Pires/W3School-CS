using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ao usar o WriteLine o compilador automaticamente pula uma linha aplicando um \n
            Console.WriteLine("Ola mundo novo do c#!");
            Console.WriteLine("Estou aprendendo como funcionam os WriteLine");
            Console.WriteLine("Como é incrivel!!");
            // WriteLine consegue fazer contas para exibir seus resultados
            Console.WriteLine(3 + 3);
            // Exite outro metodo chamado Write porem esse não pula linha quando uma nova instancia é requisitada
            Console.Write("Ola mundo: ");
            Console.Write("Estou na mesma linha\n");

            /*
                Tipos de variaveis:
            - int : armazena numero inteiros
            - long : armazena mais numeros inteiros e deve terminar a declaração com L
            - float : armazena numeros reais e deve terminar a declaração com F
            - double : armazena com mais precisão numeros reais e deve terminar a declaração com D
            - char : armazena um unico caracter envolvida por aspas simples
            - string : armazena texto envolvidos por aspas duplas
            - bool : armazena true ou false (1 ou 0)
            */

            int myNum = 0; // atribuindo uma variavel
            Console.Write("Meu num atribuido: ");
            Console.WriteLine(myNum); // Output - 0
            myNum = 10; // reatribuindo uma variavel
            Console.Write("Meu num reatribuido: ");
            Console.WriteLine(myNum); // Output - 10

            double dble = 1.15d;
            Console.WriteLine(dble); // Output - 1.15

            char mychr = 'a';
            Console.WriteLine(mychr); // Output - a

            string str = "texto de teste";
            Console.WriteLine(str); // Output - texto de teste

            bool myboolean = false;
            Console.WriteLine(myboolean); // Output - False

            /*
                Constantes:
            Para tornar seu codigo aprova de erros com variaveis que não deveriam
            ser trocadas sendo trocadas se pode usar "const" para torna-las não
            reatribuives. Funciona em todos os tipos de variaveis.
            */

            const double PI = 3.14d;
            /* PI = 2.7; */ // error
            Console.WriteLine(PI);

            /*
               Exibindo variaveis
            O metodo WriteLine é usado normalmente para exibir variaveis no terminal/console.
            Para combinar texto e variaveis é possivel usar o sinal de +(adição).
            
            -------ATENÇÃO-------
            Não alteram o valor original da variavel.
            ---------------------
            
                Ex: 
            */
            string name = "John";
            char space = ' ';
            string surname = "Silva";
            string fullName = name + space + surname;

            Console.WriteLine("Nome: " + fullName); // Output - Nome: John Silva


            int numRand = 0;
            Console.WriteLine(fullName + numRand); // Output - John Silva0
            /*
            Quando um numero é usado na concatenação com um dos elementos sendo do tipo
            texto o numero é tratado para ser considerado do tipo texto tambem
            */  

            int x = 140;
            int y = 30;
            Console.WriteLine(x + y); // Output - 170
            /*
            Quando todos os valores da concatenação são do tipo numero o + é usado 
            para operações matematicas
            */

            /*
            É possivel declarar varias variaveis do mesmo tipo ao mesmo tempo
            Tambem é possivel declarar todas com o mesmo valor em uma linha
            */
            int q = 2, r = 3, p = 4;
            Console.WriteLine(q + r + p); // Output - 9

            q = r = p = 150;
            Console.WriteLine(q + r + p); // Output - 450

            /*
                Nomeando variaveis
            - Pode conter letras, digitos e underline [ _ ]
            - Deve começar com letras ou underline
            - De preferencia começar com minusculas e não pode ter espaços
            - São sensiveis a caps lock (myVar e myvar são variaveis diferentes)
            - Palavras reservadas do C#, como int e double, não podem ser usadas como variaveis
            */

            /*  Tipos mais comuns de variaveis, quanto ocupam e quanto armazenam:
            - int : 4 bytes [ 2 bilhões de numeros inteiros ]
            - long : 8 bytes [ 9 quintilhões de numeros inteiros ]
            - float : 4 bytes [ 6 a 7 digitos decimais ]
            - double : 8 bytes [ 15 digitos decimais ]
            - bool : 1 bit [ 0 ou 1 ]
            - char : 2 bytes [ 1 unico caracter ]
            - string : 2 bytes por caracter [ sem limite de quantos pode-se armazenar ]
            */

            /*
                Numeros cientificos
            */
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1); // Output - 35000
            Console.WriteLine(d1); // Output - 120000
            f1 = 35e-3f;
            Console.WriteLine(f1); // Output - 0.035

            /*
                Booleanos 
            */
            bool isCSharpFun = true;
            bool isTrashTasty = false;
            Console.WriteLine(isCSharpFun);   // True
            Console.WriteLine(isTrashTasty);   // False

            /*
                Conversão de tipos [ Casting Implicito e Explicito - Convert ]
            */

            int inteiro = 9;
            double real = inteiro; // Output - Casting Implicito - int para double
            Console.WriteLine(inteiro); // Output - 9
            Console.WriteLine(real); // Output - 9

            double outroDouble = 9.45;
            int meuInteiro = (int) outroDouble; // Output - Casting Explicito - double para int
            Console.WriteLine(outroDouble); // Output - 9.45
            Console.WriteLine(meuInteiro); // Output - 9

            /*
                Metodos de conversão
            - Convert.ToBoolean
            - Convert.ToDouble
            - Convert.ToString
            - Convert.ToInt32 [int]
            - Convert.ToInt64 [long]
            */

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt)); // Converte int para string
            Console.WriteLine(Convert.ToDouble(myInt)); // Converte int para double
            Console.WriteLine(Convert.ToInt32(myDouble)); // Converte double para int
            Console.WriteLine(Convert.ToString(myBool)); // Converte booleano para string


        }
    }
}