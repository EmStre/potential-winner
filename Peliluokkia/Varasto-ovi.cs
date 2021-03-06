﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Peliluokkia
{
    public class VarastoOvi : ILamppu
    {
        string vastaus;
        private bool lamppuPäällä = false;
        int kokeilu = 0;

        public bool LamppuPäällä
        {
            get
            {
                return lamppuPäällä;
            }
        }

        VarastoOvi lamppu;
        public void Avaa()
        {
            Console.WriteLine("Muistat Maisan kertoneen, että varastossa on sähkökaappi, joka käynnistää Academyn generaattorin tarjoten sähköä oleellisimmille toiminnoille.\n " +
                "Voisi olla hyödyllistä saada sähköt päälle.\n");
            Jatka();

        }
        public void Jatka()
        {
            lamppu = new VarastoOvi();
            if(Inventaario.esineet.Contains("CV") && Inventaario.esineet.Contains("vihko") && Inventaario.esineet.Contains("fläppitaulu"))
            {
                Console.WriteLine("Koodi on 7-numeroinen ja sinulla on kaikki esineet, joiden avulla voit saada oven auki...\nOn kuitenkin melko PIMÄÄ etkä näe näppäillä numeroita!\nVoit toki halutessasi palata " +
                    "tutkimaan käytävää (A).");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tarkastelet taas käytävää.\n");
                        Console.ResetColor();
                        Kaytava kaytava = new Kaytava();
                        kaytava.Avaa();
                        break;
                    case "TASKULAMPPU PÄÄLLE":
                    case "LAMPPU PÄÄLLE":
                    case "AVAA TASKULAMPPU":
                    case "AVAA LAMPPU":
                    case "LAMPPU":
                    case "LAITA LAMPPU PÄÄLLE":
                    case "KYTKE LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaOvi();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                       Jatka();
                        break;
                    case "HEIKKI":
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        Jatka();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta. Huomaathan, että koodilukko ei toimi pimeässä.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                }
            }

            else if ((!Inventaario.esineet.Contains("CV") && Inventaario.esineet.Contains("vihko") && Inventaario.esineet.Contains("fläppitaulu")) || (Inventaario.esineet.Contains("CV") && !Inventaario.esineet.Contains("vihko") && Inventaario.esineet.Contains("fläppitaulu")) || (Inventaario.esineet.Contains("CV") && Inventaario.esineet.Contains("vihko") && !Inventaario.esineet.Contains("fläppitaulu")))
            {
                Console.WriteLine("Sinulta puuttuu yksi oven avaamiseen tarvittava esine. Jatka etsimistä.\n" +
                    "Muistathan aina lisätä löytämäsi esineet kassiin!\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Tarkastelet taas käytävää.\n");
                Console.ResetColor();
                Kaytava kaytava = new Kaytava();
                kaytava.Avaa();
                
            }
            else if ((!Inventaario.esineet.Contains("CV") && !Inventaario.esineet.Contains("vihko") && Inventaario.esineet.Contains("fläppitaulu")) || (Inventaario.esineet.Contains("CV") && !Inventaario.esineet.Contains("vihko") && !Inventaario.esineet.Contains("fläppitaulu")) || (!Inventaario.esineet.Contains("CV") && Inventaario.esineet.Contains("vihko") && !Inventaario.esineet.Contains("fläppitaulu")))
            {
                Console.WriteLine("Sinulta puuttuu esineitä, joita ilman et voi saadaa ovea auki. Jatkahan etsimistä.\n" +
                    "Muistathan aina lisätä löytämäsi esineet kassiin!\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Tarkastelet taas käytävää.\n");
                Console.ResetColor();
                Kaytava kaytava = new Kaytava();
                kaytava.Avaa();
            }
            else if (!Inventaario.esineet.Contains("CV") && !Inventaario.esineet.Contains("vihko") && !Inventaario.esineet.Contains("fläppitaulu"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Sinulta puuttuu KAIKKI oven avaamiseen tarvittavat esineet. Yritäppäs löytää ne!\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Tarkastelet taas käytävää.\n");
                Console.ResetColor();
                Kaytava kaytava = new Kaytava();
                kaytava.Avaa();
            }
        }

        public void ValoisaOvi()
        {
            lamppu = new VarastoOvi();
            kokeilu++;

            if (kokeilu == 1)
            {
                Console.WriteLine("Otat kassistasi fläppitaulun, vihkon ja CV:n\n" +
                    "Niiden avulla yrität keksiä 7-numeroisen koodin, jonka näppäilet lukon numeronäppäimistöön.\nHUOM! Järjestyksellä on väliä!\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "6910542":
                        Console.WriteLine("Tosi hyvä!! Ovi on auki!\n");
                        Game.varastonOvi = true;
                        lamppu.PoisPäältä();
                        Varasto varasto = new Varasto();
                        varasto.Avaa();
                        break;
                    case "666":
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Beep(988, 300);
                        Console.WriteLine("Hyvä yritys...\n");
                        Console.Beep(784, 300);
                        Console.Beep(740, 300);
                        Console.Beep(698, 600);
                        Console.ResetColor();
                        Thread.Sleep(1500);
                        string pelastus = Console.ReadLine();
                        if (pelastus == "APUA")
                            ValoisaOvi();
                        break;
                    case "SAMMUTA VALO":
                    case "SAMMUTA TASKULAMPPU":
                    case "SAMMUTA LAMPPU":
                        lamppu.PoisPäältä();
                        Jatka();
                        break;
                    case "OTA VIHKO":
                    case "LUE VIHKO":
                    case "VIHKO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Selaat vihkoa:\n" +
                            "Vihkon yhdellä sivulla on lause: 'Varastoon pääsy kulminoituu osittain elämään, maailmankaikkeuteen ja kaikkeen muuhun sellaiseen liittyvän kysymyksen vastaukseen'\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "OTA FLÄPPITAULU":
                    case "LUE FLÄPPITAULU":
                    case "FLÄPPITAULU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tutkit punastellen fläppitaulua, jolloin kuvan aiemmin mieleesi tuoma kaskisnumeroinen luku palaa ajatuksiisi\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "OTA CV":
                    case "LUE CV":
                    case "CV":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Julius Caesar ja CV...\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "HEIKKI":
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                }
            }
            else if (kokeilu <10)
            {
                Console.WriteLine("Koodi oli väärin, yritä uudelleen! (7-numeroinen koodi)\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "6910542":
                        Console.WriteLine("Tosi hyvä!! Ovi on auki!\n");
                        Game.varastonOvi = true;
                        lamppu.PoisPäältä();
                        Varasto varasto = new Varasto();
                        varasto.Avaa();
                        break;
                    case "666":
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Beep(988, 300);
                        Console.WriteLine("Hyvä yritys...\n");
                        Console.Beep(784, 300);
                        Console.Beep(740, 300);
                        Console.Beep(698, 600);
                        Console.ResetColor();
                        Thread.Sleep(1500);
                        string pelastus = Console.ReadLine();
                        if (pelastus == "APUA")
                            ValoisaOvi();
                        break;
                    case "SAMMUTA VALO":
                    case "SAMMUTA TASKULAMPPU":
                    case "SAMMUTA LAMPPU":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
                    case "OTA VIHKO":
                    case "LUE VIHKO":
                    case "VIHKO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Selaat vihkoa:\n" +
                            "Vihkon yhdellä sivulla on lause: 'Varastoon pääsy kulminoituu osittain elämään, maailmankaikkeuteen ja kaikkeen muuhun sellaiseen liittyvän kysymyksen vastaukseen'.\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "OTA FLÄPPITAULU":
                    case "LUE FLÄPPITAULU":
                    case "FLÄPPITAULU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tutkit punastellen fläppitaulua, jolloin kuvan aiemmin mieleesi tuoma kaksinumeroinen luku palaa ajatuksiisi.\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "OTA CV":
                    case "LUE CV":
                    case "CV":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Julius Caesar ja CV...\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "HEIKKI":
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                }

            }
            else
            {
                Console.WriteLine("Koodi oli väärin, yritä uudelleen! Huomaa, että numeroiden oikea järjestys on fläppitaulu, CV ja vihko.\n Heikistä voisi kenties olla apua...\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "6910542":
                        Console.WriteLine("Tosi hyvä!! Ovi on auki!\n");
                        Game.varastonOvi = true;
                        lamppu.PoisPäältä();
                        Varasto varasto = new Varasto();
                        varasto.Avaa();
                        break;
                    case "666":
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Beep(988, 300);
                        Console.WriteLine("Hyvä yritys...\n");
                        Console.Beep(784, 300);
                        Console.Beep(740, 300);
                        Console.Beep(698, 600);
                        Console.ResetColor();
                        Thread.Sleep(1500);
                        string pelastus = Console.ReadLine();
                        if (pelastus == "APUA")
                            ValoisaOvi();
                        break;
                    case "SAMMUTA VALO":
                    case "SAMMUTA TASKULAMPPU":
                    case "SAMMUTA LAMPPU":
                        lamppu.PoisPäältä();
                        Jatka();
                        break;
                    case "OTA VIHKO":
                    case "LUE VIHKO":
                    case "VIHKO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Selaat vihkoa:\n" +
                            "Vihkon yhdellä sivulla on lause: 'Varastoon pääsy kulminoituu osittain elämään, maailmankaikkeuteen ja kaikkeen muuhun sellaiseen liittyvän kysymyksen vastaukseen'.\nHeikki voisi ehkä auttaa!\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "HEIKKI":
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("42");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "OTA FLÄPPITAULU":
                    case "LUE FLÄPPITAULU":
                    case "FLÄPPITAULU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tutkit punastellen fläppitaulua, jolloin kuvan mieleesi aiemmin tuoma kaskisnumeroinen luku palaa ajatuksiisi\nSama luku liittyy suomalaisen bändin nimeen __Eyes\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "OTA CV":
                    case "LUE CV":
                    case "CV":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Julius Caesar ja CV...\nCaesar oli muistaakseeni roomalainen ja CV taitaa olla luku...\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                }

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
    }
}
