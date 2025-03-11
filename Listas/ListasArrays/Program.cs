namespace ListasArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[5];
            double[] notas = new double[8];
            //double[] notas = { };
            string[] arraysFrutas = { "bananas", "Maça", "Pera" };//new string[3];

            string nome = "João";
            string nome1 = "JOAO";
            string nome2 = "reyna";
            string nome3 = "jkjkj.@gmail.com";
            string nome4 = "902.555.123-21";


            notas[0] = 7.5;
            notas[1] = 8.4;
            notas[2] = 7.6;



            Console.WriteLine(nome.Replace("ã", "a"));//muda
            Console.WriteLine(nome1.ToLower());//mnuscula
            Console.WriteLine(nome2.ToUpper());//maiuscula
            Console.WriteLine(nome1.Contains("@"));//recorre si tem un @ na palavra
            Console.WriteLine(nome3.Contains("@"));//recorre si tem un @ na palavra
            Console.WriteLine(nome4.Replace(".","").Replace("-", ""));
         




            Console.WriteLine(nome4);

            Console.WriteLine(arraysFrutas.Length);//cantidad dentro do array---toString
        


            List<string> fruitList = new List<string>();//nova lista

            List<double> ListaNotas = new List<double>();//nova lista



            fruitList.Add("morango");
            fruitList.Add("mango");
            fruitList.Add("uva");


            Console.WriteLine("***********************************************");
            //  fruitList.Remove("morango");//remove
           // Console.WriteLine(string.Join(", ", fruitList));


          /*  foreach (string fruta in fruitList) 
            { 
                Console.WriteLine(fruta);                 
            }
          */

            //otro de fazer foreach
            fruitList.ForEach(fruta=>Console.WriteLine(fruta));


            //  arraysFrutas[0] = "bananas";
            // arraysFrutas[1] = "Maça";
            // arraysFrutas[2] = "Pera";

            //Console.WriteLine(arraysFrutas[0]);
            Console.WriteLine(arraysFrutas);


            Console.WriteLine("***********************************************");

            
            Aluno aluno1 = new Aluno("reyna",1212,"Transformesse","reyna@gmail.com","11956232114");
            Aluno aluno2 = new Aluno("vero", 5656, "Transformesse", "vero@gmail.com", "119565232134");
            Aluno aluno3 = new Aluno("vicky", 1235, "Transformesse", "vicky@gmail.com", "1191313132114");

            List<Aluno>listaAlunos=new  List<Aluno>();
            listaAlunos.Add(aluno1);
            listaAlunos.Add(aluno2);
            listaAlunos.Add(aluno3);


            foreach (Aluno aluno in listaAlunos) {
                Console.WriteLine(aluno.Nome);
                Console.WriteLine(aluno.Matricula);
                Console.WriteLine(aluno.Telefono);
                Console.WriteLine("**********");
                Console.WriteLine($"Nome:{aluno.Nome}");
                Console.WriteLine($"Matricula:{aluno.Matricula}");
                Console.WriteLine($"Telefono:{aluno.Telefono}");
                Console.WriteLine();

            }















        }
    }
}
