﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class Varasto : ILamppu, ISahko
    {
        string vastaus;

        private bool lamppuPäällä = false;

        private bool sahkoPaalla = false;

        public bool LamppuPäällä
        {
            get
            {
                return lamppuPäällä;
            }
        }

        public bool Electricity
        {
            get
            {
                return sahkoPaalla;
            }
        }

        Varasto lamppu;
        Varasto sahkot;


        public void Avaa()
        {
            lamppu = new Varasto();
            sahkot = new Varasto();


            Console.WriteLine("Varasto on pilkkopimeä ja täynnä viinalaatikoita. Pimeässä on hankala lähteä etenemään.\n" +
            "Muistat, että sähkötaulu löytyy varaston perältä! Olisikohan siellä sellainen varavirtakytkin kuten leffoissa...?\n" +
            "Voit myös poistua takaisin käytävälle (A).");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            if (Inventaario.esineet.Contains("taskulamppu"))
            {

                switch (vastaus)
                {
                    case "TASKULAMPPU PÄÄLLE":
                    case "LAMPPU PÄÄLLE":
                    case "AVAA LAMPPU":
                    case "LAITA LAMPPU PÄÄLLE":
                    case "KYTKE LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaVarasto();
                        break;
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Astut takaisin käytävään.\n");
                        Console.ResetColor();
                        Kaytava kaytava = new Kaytava();
                        kaytava.Avaa();
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
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
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
                switch (vastaus)
                {
                    case "TASKULAMPPU PÄÄLLE":
                    case "LAMPPU PÄÄLLE":
                    case "AVAA LAMPPU":
                    case "LAITA LAMPPU PÄÄLLE":
                    case "KYTKE LAMPPU PÄÄLLE":
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Astut takaisin käytävään.\n");
                        Console.ResetColor();
                        Kaytava kaytava = new Kaytava();
                        kaytava.Avaa();
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
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
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

        public void ValoisaAcademy()
        {
            sahkoPaalla = true;
            Game.sahkoa = 1; // tämä asettaa sähköt päälle, jotta voi operoida keittiössä
            Console.WriteLine("On tämä saatana työmaa, mutta onneksi näkee jo eteensä. Tekee mieli kahvia ja sitten on pakko yrittää kyllä päästä viimein pois täältä.\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Astut takaisin käytävälle.\n");
            Console.ResetColor();
            lamppu.PoisPäältä();
            Kaytava kaytava = new Kaytava();
            kaytava.Avaa();

        }

        public void ValoisaVarasto()
        {
            lamppu = new Varasto();
            sahkot = new Varasto();

            Console.WriteLine("Noniin! Nyt pääset etenemään laatikoiden yli varaston perälle ja siellähän se sähkötaulu pilkottaa.\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "SÄHKÖT PÄÄLLE":
                case "LAITA SÄHKÖT PÄÄLLE":
                case "AVAA SÄHKÖT":
                case "AVAA SÄHKÖ":
                case "KYTKE SÄHKÖT":
                case "SÄHKÖT":
                    sahkot.SahkotPaalla();
                    ValoisaAcademy();
                    break;
                case "HALP":
                case "HELP":
                    Help help = new Help();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(help);
                    Console.ResetColor();
                    ValoisaVarasto();
                    break;
                case "KARTTA":
                    Kartta kartta = new Kartta();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    kartta.KutsuKartta();
                    Console.ResetColor();
                    ValoisaVarasto();
                    break;
                case "KASSI":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Inventaario inventaario = new Inventaario();
                    Console.WriteLine(inventaario);
                    Console.ResetColor();
                    ValoisaVarasto();
                    break;
                case "H-HELP":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Heikki heikki = new Heikki();
                    heikki.Help();
                    Console.ResetColor();
                   ValoisaVarasto();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Console.ResetColor();
                    ValoisaVarasto();
                    break;

            }
        }

        public void PoisPäältä()
        {
            lamppuPäällä = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Taskulamppu sammui.\n");
            Console.ResetColor();
        }

        public void Päällä()
        {
            lamppuPäällä = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Taskulamppu on päällä.\n");
            Console.ResetColor();
        }

        public void SahkotPaalla()
        {
            sahkoPaalla = true;
            Game.sahkoa = 1;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Varasähköt päällä! Näyttää siltä, että laitteet toimivat, mutta valot pysyvät himmeinä.\n");
            Console.ResetColor();

        }

        public void SahkotPois()
        {
            sahkoPaalla = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sähköt pois päältä.\n");
            Console.ResetColor();
        }
    }
}
