using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetMaxPitagoras
{
    //Método enum para espécies de cães
    //
    static class Program
    {
        /*
        enum Especies { CaesPastores, CaesPequenos, Terries, Dachshunds, Spitz, SabujosFarejadores, CaesApontadores, Retrievers, CaesCompanhia, LebreusEGalgos, Raca};
       */
        [STAThread]
        static void Main()
        {
            /*
            Especies myEspecie = Especies.Raca;

            Console.WriteLine("Especies.CaesPastores = {Cães pastores e Boeiros}", Especies.CaesPastores.ToString("A"));
            Console.WriteLine("Especies.CaesPequenos = {Pinscher e Schnauzer, Molossóides e Boieiros Suíços}", Especies.CaesPequenos.ToString("B"));
            Console.WriteLine("Especies.Terries = {Terries}", Especies.Terries.ToString("C"));
            Console.WriteLine("Especies.Dachshunds = {Dachshunds}", Especies.Dachshunds.ToString("D"));
            Console.WriteLine("Especies.Spitz = {Spitz}", Especies.Spitz.ToString("E"));
            Console.WriteLine("Especies.SabujosFarejadores = {Sabujos farejadores e raças semelhantes}", Especies.SabujosFarejadores.ToString("G"));
            Console.WriteLine("Especies.CaesApontadores = {Cães Apontadores e de Parar}", Especies.CaesApontadores.ToString("H"));
            Console.WriteLine("Especies.Retrievers = {Retrievers}", Especies.Retrievers.ToString("I"));
            Console.WriteLine("Especies.Caes de Companhia = {Cães de Companhia}", Especies.CaesCompanhia.ToString("J"));
            Console.WriteLine("Especies.Lebreus ou Galgos = {Lebréus ou Galgos}", Especies.LebreusEGalgos.ToString("L"));

            Console.WriteLine("myEspecie = Especies.Raca", Environment.NewLine);

            Console.WriteLine("myEspecie.ToString(\"a\") = Caes Pastores", myEspecie.ToString("a"));
            Console.WriteLine("myEspecie.ToString(\"A\") = Caes Pastores", myEspecie.ToString("A"));

            Console.WriteLine("myEspecie.ToString(\"b\") = Cães Pequenos", myEspecie.ToString("b"));
            Console.WriteLine("myEspecie.ToString(\"B\") = Cães Pequenos", myEspecie.ToString("B"));

            Console.WriteLine("myEspecie.ToString(\"c\") = Terries", myEspecie.ToString("c"));
            Console.WriteLine("myEspecie.ToString(\"C\") = Terries", myEspecie.ToString("C"));

            Console.WriteLine("myEspecie.ToString(\"e\") = Dachshunds", myEspecie.ToString("e"));
            Console.WriteLine("myEspecie.ToString(\"E\") = Dachshunds", myEspecie.ToString("E"));

            Console.WriteLine("myEspecie.ToString(\"f\") = Spitz", myEspecie.ToString("f"));
            Console.WriteLine("myEspecie.ToString(\"F\") = Spitz", myEspecie.ToString("F"));

            Console.WriteLine("myEspecie.ToString(\"f\") = Spitz", myEspecie.ToString("f"));
            Console.WriteLine("myEspecie.ToString(\"F\") = Spitz", myEspecie.ToString("F"));

            Console.WriteLine("myEspecie.ToString(\"g\") = Sabujos Farejadores", myEspecie.ToString("g"));
            Console.WriteLine("myEspecie.ToString(\"G\") = Sabujos Farejadores", myEspecie.ToString("G"));

            Console.WriteLine("myEspecie.ToString(\"h\") = Cães Apontadores", myEspecie.ToString("h"));
            Console.WriteLine("myEspecie.ToString(\"H\") = Cães Apontadores", myEspecie.ToString("H"));

            Console.WriteLine("myEspecie.ToString(\"i\") = Retrievers", myEspecie.ToString("i"));
            Console.WriteLine("myEspecie.ToString(\"I\") = Retrievers", myEspecie.ToString("I"));

            Console.WriteLine("myEspecie.ToString(\"j\") = Cães de Companhia", myEspecie.ToString("j"));
            Console.WriteLine("myEspecie.ToString(\"J\") = Cães de Companhia", myEspecie.ToString("J"));

            Console.WriteLine("myEspecie.ToString(\"l\") = Lebréus ou Galgos", myEspecie.ToString("l"));
            Console.WriteLine("myEspecie.ToString(\"L\") = Lebréus ou Galgos", myEspecie.ToString("L"));

    */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());

            
        }
    }
}
