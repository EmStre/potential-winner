 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class Hejlsberg : ILamppu
    { 
        string vastaus;
        string esine;
        private bool lamppuPäällä = false;

        public bool LamppuPäällä
        {
            get
            {
                return lamppuPäällä;
            }
        }

        Hejlsberg lamppu;

        public void Avaa()
        {

            if (Game.kassilaskuri > 0)
            {
                Game.kassilaskuri--;
                Console.WriteLine("C#-ryhmän luokka on tyhjä ja hämärä, lähes täysin pimeä.\n\n" +
                "Kätesi ulottuvilla on Academyn kangaskassi. Päätät pitää sen, jotta voit säilyttää siellä tavaroitasi.\n" +
                "Joten kuten erotat valonkatkaisijan (A), kaksi ovea käytävään (B) ja oven Java-ryhmän Hawking-luokkaan (C).\n" +
                "Tunnet niskassasi tuulenvireen takanasi auki olevata ikkunasta (D).\n" +
                "Tuuli saa pöydällä olevan vihkon sivut lepattamaan äänekkäästi.");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Painat valonkatkaisijaa, mutta mitään ei tapahdu. Sähköt tosiaan taitavat olla poikki.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Avaat oven käytävään.\n");
                        Console.ResetColor();
                        Kaytava kaytava = new Kaytava();
                        kaytava.Avaa();
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Väännät Java-ryhmän huoneen oven kahvasta, mutta toteat oven olevan lukossa.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "D":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Astut ikkunan luo ja vilkaiset alas.\n");
                        Console.ResetColor();
                        Ikkuna ikkuna = new Ikkuna();
                        ikkuna.Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        Avaa();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                }
            }
            else//vihko, lamppu, 
            {
                if (Inventaario.esineet.Contains("taskulamppu") && !Inventaario.esineet.Contains("vihko"))
                {
                    lamppu = new Hejlsberg();
                    Console.WriteLine("C#-ryhmän luokka on tyhjä ja hämärä, lähes täysin pimeä.\n" +
                    "Jotenkuten erotat valonkatkaisijan (A), kaksi ovea käytävään (B) ja oven Java-ryhmän Hawking-luokkaan (C).\n" +
                    "Tunnet niskassasi tuulenvireen takanasi auki olevata ikkunasta (D).\n" +
                    "Tuuli saa pöydällä olevan vihkon sivut lepattamaan äänekkäästi.");
                    vastaus = Console.ReadLine();
                    vastaus = vastaus.ToUpper();
                    switch (vastaus)
                    {
                        case "A":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Painat valonkatkaisijaa, mutta mitään ei tapahdu. Sähköt ovat edelleen poikki.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        case "B":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Avaat oven käytävään.\n");
                            Console.ResetColor();
                            Kaytava kaytava = new Kaytava();
                            kaytava.Avaa();
                            break;
                        case "C":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Väännät Java-ryhmän huoneen oven kahvasta, mutta toteat oven olevan lukossa.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        case "D":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Astut ikkunan luo ja vilkaiset alas.\n");
                            Console.ResetColor();
                            Ikkuna ikkuna = new Ikkuna();
                            ikkuna.Avaa();
                            break;
                        case "KASSI":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Inventaario inventaario = new Inventaario();
                            Console.WriteLine(inventaario);
                            Console.ResetColor();
                            Avaa();
                            break;
                        case "TASKULAMPPU PÄÄLLE":
                            lamppu.Päällä();
                            ValoisaHejsberg();
                            break;
                        case "LAMPPU PÄÄLLE":
                            lamppu.Päällä();
                            ValoisaHejsberg();
                            break;
                        case "AVAA LAMPPU":
                            lamppu.Päällä();
                            ValoisaHejsberg();
                            break;
                        case "LAITA LAMPPU PÄÄLLE":
                            lamppu.Päällä();
                            ValoisaHejsberg();
                            break;
                        case "KYTKE LAMPPU PÄÄLLE":
                            lamppu.Päällä();
                            ValoisaHejsberg();
                            break;
                        case "VIHKO":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Mitä haluat tehdä vihkolle?\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        case "LUE VIHKO":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("On pimeää etkä saa mitään selvää vihkon sisällöstä.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        case "HALP":
                        case "HELP":
                            Help help = new Help();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(help);
                            Console.ResetColor();
                            Avaa();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Epäkelpo valinta.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                    }
                }

                else if (Inventaario.esineet.Contains("taskulamppu") && Inventaario.esineet.Contains("vihko"))
                {
                    lamppu = new Hejlsberg();
                   
                    Console.WriteLine("C#-ryhmän luokka on tyhjä ja hämärä, lähes täysin pimeä.\n" +
                   "Jotenkuten erotat valonkatkaisijan (A), kaksi ovea käytävään (B) ja oven Java-ryhmän Hawking-luokkaan (C).\n" +
                   "Tunnet niskassasi tuulenvireen takanasi auki olevata ikkunasta (D).\n");
                    vastaus = Console.ReadLine();
                    vastaus = vastaus.ToUpper();
                    switch (vastaus)
                    {
                        case "A":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Painat valonkatkaisijaa, mutta mitään ei tapahdu. Sähköt ovat edelleen poikki.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        case "B":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Avaat oven käytävään.\n");
                            Console.ResetColor();
                            Kaytava kaytava = new Kaytava();
                            kaytava.Avaa();
                            break;
                        case "C":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Väännät Java-ryhmän huoneen oven kahvasta, mutta toteat oven olevan lukossa.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        case "D":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Astut ikkunan luo ja vilkaiset alas.\n");
                            Console.ResetColor();
                            Ikkuna ikkuna = new Ikkuna();
                            ikkuna.Avaa();
                            break;
                        case "KASSI":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Inventaario inventaario = new Inventaario();
                            Console.WriteLine(inventaario);
                            Console.ResetColor();
                            Avaa();
                            break;
                        case "TASKULAMPPU PÄÄLLE":
                            lamppu.Päällä();
                            ValoisaHejsberg();
                            break;
                        case "LAMPPU PÄÄLLE":
                            lamppu.Päällä();
                            ValoisaHejsberg();
                            break;
                        case "AVAA LAMPPU":
                            lamppu.Päällä();
                            ValoisaHejsberg();
                            break;
                        case "LAITA LAMPPU PÄÄLLE":
                            lamppu.Päällä();
                            ValoisaHejsberg();
                            break;
                        case "KYTKE LAMPPU PÄÄLLE":
                            lamppu.Päällä();
                            ValoisaHejsberg();
                            break;
                        case "HALP":
                        case "HELP":
                            Help help = new Help();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(help);
                            Console.ResetColor();
                            Avaa();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Epäkelpo valinta.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                    }
                }
            else
            {
                    Console.WriteLine("C#-ryhmän luokka on tyhjä ja hämärä, lähes täysin pimeä.\n" +
                    "Jotenkuten erotat valonkatkaisijan (A), kaksi ovea käytävään (B) ja oven Java-ryhmän Hawking-luokkaan (C).\n" +
                    "Tunnet niskassasi tuulenvireen takanasi auki olevata ikkunasta (D).\n");
                    vastaus = Console.ReadLine();
                    vastaus = vastaus.ToUpper();
                    switch (vastaus)
                    {
                        case "A":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Painat valonkatkaisijaa, mutta mitään ei tapahdu. Sähköt ovat poikki.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        case "B":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Avaat oven käytävään.\n");
                            Console.ResetColor();
                            Kaytava kaytava = new Kaytava();
                            kaytava.Avaa();
                            break;
                        case "C":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Väännät Java-ryhmän huoneen oven kahvasta, mutta toteat oven olevan lukossa.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        case "D":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Astut ikkunan luo ja vilkaiset alas.\n");
                            Console.ResetColor();
                            Ikkuna ikkuna = new Ikkuna();
                            ikkuna.Avaa();
                            break;
                        case "KASSI":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Inventaario inventaario = new Inventaario();
                            Console.WriteLine(inventaario);
                            Console.ResetColor();
                            Avaa();
                            break;
                        case "LUE VIHKO":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("On pimeää etkä saa mitään selvää vihkon sisällöstä.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        case "VIHKO":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Mitä haluat tehdä vihkolle?\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        case "LAMPPU PÄÄLLE":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Sinulla ei ole lamppua.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        case "TASKULAMPPU PÄÄLLE":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Sinulla ei ole lamppua.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        case "HALP":
                        case "HELP":
                            Help help = new Help();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(help);
                            Console.ResetColor();
                            Avaa();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Epäkelpo valinta.\n");
                            Console.ResetColor();
                            Avaa();
                            break;

                    }
                }
            }
        }
        
        public void ValoisaHejsberg()
        {
            lamppuPäällä = true;
            lamppu = new Hejlsberg();

            if(!Inventaario.esineet.Contains("vihko"))
            { 
            Console.WriteLine("Taskulampun valossa katselet ympärillessi C#-luokkaa ja näet, että tussitaulut ovat täynnä mitä erikoisimpia for-looppeja ja if-lauseita,\n" +
                " joiden syvällisempää tarkoitusta et jää miettimään." + " Huomiosi kiinnittyy pöydällä olevaan vihkoon.\n" + " Nyt erotat selvästi valonkatkaisijan (A), kaksi ovea käytävään (B) ja oven Java-ryhmän Hawking-luokkaan (C).\n" +
                "Tunnet edelleen niskassasi tuulenvireen takanasi auki olevata ikkunasta (D).\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
              

                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Painat valonkatkaisijaa, mutta mitään ei tapahdu. Sähköt ovat poikki.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Avaat oven käytävään.\n");
                        Console.ResetColor();
                        Kaytava kaytava = new Kaytava();
                        kaytava.Avaa();
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Väännät Java-ryhmän huoneen oven kahvasta, mutta toteat oven olevan lukossa.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "D":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Astut ikkunan luo ja vilkaiset alas.\n");
                        Console.ResetColor();
                        lamppu.PoisPäältä();
                        Ikkuna ikkuna = new Ikkuna();
                        ikkuna.Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "SAMMUTA VALO":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
                    case "SAMMUTA TASKULAMPPU":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
                    case "SAMMUTA LAMPPU":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
                    case "VIHKO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Mitä haluat tehdä vihkolle?\n");
                        Console.ResetColor();
                        ValoisaHejsberg();
                        break;
                    case "LUE VIHKO":
                        Vihko();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        Avaa();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                }

            }
            else
            {
                Console.WriteLine("Taskulampun valossa katselet ympärillessi C#-luokkaa ja näet, että tussitaulut ovat edelleen täynnä mitä erikoisimpia for-looppeja ja if-lauseita,\n" +
                "joiden syvällisempää tarkoitusta et jää miettimään." + " Nyt erotat selvästi valonkatkaisijan (A), kaksi ovea käytävään (B) ja oven Java-ryhmän Hawking-luokkaan (C).\n" +
                "Tunnet edelleen niskassasi tuulenvireen takanasi auki olevata ikkunasta (D).\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Painat valonkatkaisijaa, mutta mitään ei tapahdu. Sähköt ovat poikki.\n");
                        Console.ResetColor();
                        ValoisaHejsberg();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Avaat oven käytävään.\n");
                        Console.ResetColor();
                        Kaytava kaytava = new Kaytava();
                        lamppu.PoisPäältä();
                        kaytava.Avaa();
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Väännät Java-ryhmän huoneen oven kahvasta, mutta toteat oven olevan lukossa.\n");
                        Console.ResetColor();
                        ValoisaHejsberg();
                        break;
                    case "D":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Astut ikkunan luo ja vilkaiset alas.\n");
                        Console.ResetColor();
                        Ikkuna ikkuna = new Ikkuna();
                        lamppu.PoisPäältä();
                        ikkuna.Avaa();
                        break;
                    case "SAMMUTA VALO":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
                    case "SAMMUTA TASKULAMPPU":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
                    case "SAMMUTA LAMPPU":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        Avaa();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        ValoisaHejsberg();
                        break;
                }
            }
        }


        public void PoisPäältä()
        {
            lamppuPäällä = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Taskulamppu sammui");
        }

        public void Päällä()
        {
            lamppuPäällä = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Taskulamppu on päällä\n");
            Console.ResetColor();
        }


        public void Vihko()
        {
            Console.WriteLine("Selatessasi vihkoa ymmärrät, ettei sen omistaja ole kovin ahkera muistiinpanojen kirjoittaja.\n Toisaalta koodaamaan oppii koodaamaalla, eikä muistiinpanoja tekemällä...\n" +
                "Yhdelle sivulle on kirjoitettu isoilla kirjaimilla sana 'VIREYTYMINEN'\nja mieleesi palaa eräs huippuhyödyllinen vuorovaikutuskoulutus ja huomaat olevasi erityisen vireytynyt juuri nyt, yrittäessäsi löytää ulospääsyä tästä rakennuksesta. \n" + "Vihkon yhdellä sivulla on lause: 'Varastoon pääsy kulminoituu osittain elämään, maailmankaikkeuteen ja kaikkeen muuhun sellaiseen liittyvän kysymyksen vastaukseen'\n" +
                "Onpa merkillistä! Mietit, että vihkosta saattaisi olla hyötyöä myöhemmin.\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "OTA VIHKO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Vihko lisätty Academy-kassiin.\n");
                        Inventaario inventaario = new Inventaario();
                        inventaario.LisaaEsine(esine);
                        Console.ResetColor();
                        ValoisaHejsberg();
                        break;
                    case "LISÄÄ VIHKO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Vihko lisätty Academy-kassiin.\n");
                        Inventaario inventaario2 = new Inventaario();
                        inventaario2.LisaaEsine(esine);
                        Console.ResetColor();
                        ValoisaHejsberg();
                        break;
                    case "SAMMUTA VALO":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
                    case "SAMMUTA TASKULAMPPU":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
                    case "SAMMUTA LAMPPU":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
                case "HALP":
                case "HELP":
                    Help help = new Help();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(help);
                    Console.ResetColor();
                    Avaa();
                    break;
                default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Vihko();
                        break;
                }
                
            

        }
    }
}

