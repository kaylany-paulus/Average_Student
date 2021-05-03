using System;

namespace Average_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4;

            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine("\n\nOLÁ! BEM VINDO(A) AO PROGRAMA.");
            Console.WriteLine(
                "NÓS CALCULAMOS AS NOTAS DO ALUNO E RETORNAMOS A MÉDIA.");
            Console.ResetColor();
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("\nRESPONDA CORRETAMENTE:");
            Console.ResetColor();

            n1 = RequestNote("primeira");
            n2 = RequestNote("segunda");
            n3 = RequestNote("terceira");
            n4 = RequestNote("quarta");
        
            if (
                !ValidNote(n1)
             || !ValidNote(n2) 
             || !ValidNote(n3) 
             || !ValidNote(n4)
            )
            {
                Console.Clear();
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("\nDIgite apenas notas entre 0 e 10.");
                Console.ResetColor();
                Environment.Exit(-1);
            }

            Console.WriteLine(Result (n1, n2, n3, n4));

            Console.ResetColor();
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("\n\nMUITO OBRIGADA POR UTILIZAR NOSSO PROGRAMA!");
            Console.ResetColor();
            Environment.Exit(-1);
        }


        static double RequestNote (string order)
        {
            double conversion;

            Console.Write($"Digite a {order} nota..:");
            conversion = Convert.ToDouble(Console.ReadLine());

            return conversion;
        }
        static bool ValidNote (double note)
        {
            return (note >=0 && note <= 10);
        }
     
        static  string Result (double note1, double note2, 
                               double note3, double note4)
     {
        double average= Calculatesverage (note1, note2, 
                                          note3, note4);
        
        string result = "";

        if (average < 5)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            result = "Reprovado";
        }  
        else if (average >= 5 && average < 6)
        {
            Console.ForegroundColor=ConsoleColor.Yellow;
            result = "Recuperação";
        }
        else 
        {
            Console.ForegroundColor=ConsoleColor.Green;
            result = "Aprovado";
        }

        return $"\nVocê ficou com média {average:N2}. Resultado: {result}";
        
        }
        static double Calculatesverage (double N1, double N2, 
                                        double N3, double N4)
        {
            return (N1 + N2 + N3 + N4) / 4;
        }

    }
}
