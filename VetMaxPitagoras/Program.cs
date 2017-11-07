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
        enum Especies { CaesPastores, CaesPequenos, Terries, Dachshunds, Spitz, SabujosFarejadores, CaesApontadores, Retrievers, CaesCompanhia, LebreusEGalgos, Raca};
        enum Racas    { AfegaoHound, Affenpinscher, AriedaleTerrier, Akita, AmericanStaffordshire, Basenji, BassetHound, Beagle, BeardedCollie, Bedlinton, BichoFrise, BloodHound, Bobtail, BoiadeiroAustraliano, BoiadeiroBernes, BorderCollie, BorderTerrier, Borzoi, BostonTerrier, Boxer, BuldogueFrances, BuldogeIngles, BullTerrier, Bulmastife, CairnTerrier, CaneCorso, CaoDeAguaPortugues, CaoDeCristaChines, CavalierKingCharlesSpaniel, ChesapeakeBayRetriever, Chihuahua, ChowChow, Collie, CotonDeTulear, Tipo };
        

        [STAThread]
        static void Main()
        {
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

            //Método enum para raça de cães
            //

            Racas myRaca = Racas.Tipo;

            Console.WriteLine("Racas.AfegaoHound = {AfegaoHound}", Racas.AfegaoHound.ToString());
            Console.WriteLine("Racas.Affenpinscher = {Affenpinscher}", Racas.Affenpinscher.ToString());
            Console.WriteLine("Racas.AriedaleTerrier = {AriedaleTerrier}", Racas.AriedaleTerrier.ToString());
            Console.WriteLine("Racas.Akita = {Akita}", Racas.Akita.ToString("D"));
            Console.WriteLine("Racas.AmericanStaffordshire = {AmericanStaffordshire}", Racas.AmericanStaffordshire.ToString());
            Console.WriteLine("Racas.Basenji = {Basenji}", Racas.Basenji.ToString());
            Console.WriteLine("Racas.BassetHound = {BassetHound}", Racas.BassetHound.ToString());
            Console.WriteLine("Racas.Beagle = {Beagle}", Racas.Beagle.ToString());
            Console.WriteLine("Racas.BeardedCollie = {BeardedCollie}", Racas.BeardedCollie.ToString());
            Console.WriteLine("Racas.Bedlinton = {Bedlinton}", Racas.Bedlinton.ToString());
            Console.WriteLine("Racas.BichoFrise = {BichoFrise}", Racas.BichoFrise.ToString());
            Console.WriteLine("Racas.BloodHound = {BloodHound}", Racas.BloodHound.ToString());
            Console.WriteLine("Racas.Bobtail = {Bobtail}", Racas.Bobtail.ToString());
            Console.WriteLine("Racas.BoiadeiroAustraliano = {BoiadeiroAustraliano}", Racas.BoiadeiroAustraliano.ToString());
            Console.WriteLine("Racas.BoiadeiroBernes = {BoiadeiroBernes}", Racas.BoiadeiroBernes.ToString());
            Console.WriteLine("Racas.BorderCollie = {BorderCollie}", Racas.BorderCollie.ToString());
            Console.WriteLine("Racas.BorderTerrier = {BorderTerrier}", Racas.BorderTerrier.ToString());
            Console.WriteLine("Racas.Borzoi = {Borzoi}", Racas.Borzoi.ToString());
            Console.WriteLine("Racas.BostonTerrier = {BostonTerrier}", Racas.BostonTerrier.ToString());
            Console.WriteLine("Racas.BuldogueFrances = {BuldogueFrances}", Racas.BuldogueFrances.ToString());
            Console.WriteLine("Racas.BuldogeIngles = {BuldogeIngles}", Racas.BuldogeIngles.ToString());
            Console.WriteLine("Racas.BullTerrier = {BullTerrier}", Racas.BullTerrier.ToString());
            Console.WriteLine("Racas.Bulmastife = {Bulmastife}", Racas.Bulmastife.ToString());

            Console.WriteLine("myRaca = Racas.Tipo", Environment.NewLine);

            Console.WriteLine("myRaca.ToString() = AfegaoHound", myRaca.ToString("AfegaoHound"));
            Console.WriteLine("myRaca.ToString() = Affenpinscher", myRaca.ToString("Affenpinscher"));
            Console.WriteLine("myRaca.ToString() = AriedaleTerrier", myRaca.ToString("AriedaleTerrier"));
            Console.WriteLine("myRaca.ToString() = Akita", myRaca.ToString("Akita"));
            Console.WriteLine("myRaca.ToString() = AmericanStaffordshire", myRaca.ToString("AmericanStaffordshire"));
            Console.WriteLine("myRaca.ToString() = Basenji", myRaca.ToString("Basenji"));
            Console.WriteLine("myRaca.ToString() = BassetHound", myRaca.ToString("BassetHound"));
            Console.WriteLine("myRaca.ToString() = Beagle", myRaca.ToString("Beagle"));
            Console.WriteLine("myRaca.ToString() = BeardedCollie", myRaca.ToString("BeardedCollie"));
            Console.WriteLine("myRaca.ToString() = Bedlinton", myRaca.ToString("Bedlinton"));
            Console.WriteLine("myRaca.ToString() = BichoFrise", myRaca.ToString("BichoFrise"));
            Console.WriteLine("myRaca.ToString() = BloodHound", myRaca.ToString("BloodHound"));
            Console.WriteLine("myRaca.ToString() = Bobtail", myRaca.ToString("Bobtail"));
            Console.WriteLine("myRaca.ToString() = BoiadeiroAustraliano", myRaca.ToString("BoiadeiroAustraliano"));
            Console.WriteLine("myRaca.ToString() = BoiadeiroBernes", myRaca.ToString("BoiadeiroBernes"));
            Console.WriteLine("myRaca.ToString() = BorderCollie", myRaca.ToString("BorderCollie"));
            Console.WriteLine("myRaca.ToString() = BorderTerrier", myRaca.ToString("BorderTerrier"));
            Console.WriteLine("myRaca.ToString() = Borzoi", myRaca.ToString("Borzoi"));
            Console.WriteLine("myRaca.ToString() = BostonTerrier", myRaca.ToString("BostonTerrier"));
            Console.WriteLine("myRaca.ToString() = BuldogueFrances", myRaca.ToString("BuldogueFrances"));
            Console.WriteLine("myRaca.ToString() = BuldogueFrances", myRaca.ToString("BuldogeIngles"));
            Console.WriteLine("myRaca.ToString() = BullTerrier", myRaca.ToString("BullTerrier"));
            Console.WriteLine("myRaca.ToString() = Bulmastife", myRaca.ToString("Bulmastife"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());

            //Ainda faltam muitas raças para enumerar abaixo :)
            //portaldodog.com.br/cachorros/racas-de-cachorros


        }
    }
}
