﻿using System;

namespace Projekt
{
    public class Introduction
    {
        public static void Intro()
        {
//Wstęp
            Console.WriteLine(
                "Kurczę, nienawidzę moich studiów. Zaraz mam sesję, nic nie umiem, w pracy szef krzyczy, a najgorsze, że mamie będzie smutno jak nie zdam");

            Console.ReadKey();
            Console.WriteLine("Co mógłbym zrobić, żeby zdać? Ciekawe co teraz wpadnie mi do głowy");
            Console.ReadKey();
            Console.WriteLine("(teraz trzeba napisać myśl, która przyjdzie do głowy)");
            string input = Console.ReadLine();

            Console.WriteLine(input + "" + " Faktycznie fajna myśl.");
            Console.ReadKey();
            Console.WriteLine(
                "Szkoda że przez zniewolenie technologiczne spowodowane rewolucją przemysłową, jestem uzależniony od mediów społecznościowych co spowodowało, że mój mózg nie jest w stanie zapamiętać tej informacji, ponieważ jest przyzwyczajony do ciągłego czytania kompletnie nowych postów");

            Console.ReadKey();
            Console.Write("Hmm, najlepszą opcją będzie teraz zobaczenie czy nie ma czegoś nowego na facebooku");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("(konsumuje informacje przez następne 16 minut");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(
                "(krzyczy na głos) COOOOOO???? TO IZRAEL JEST ODPOWIEDZIALNY ZA ZNISZCZENIE USS LIBERTY??");

            Console.ReadKey();

            //Roboczo to co mówi tata będzie się zaczynać od ">"
            Console.WriteLine(">" + Program.postac.name +
                              " cholerny kryjanie i mnie obudziłeś tym krzykiem, a taki mecz oglądałem");
            Console.ReadKey();
            Console.WriteLine(">Jak już tu jestem to opowiedz mi o tej izraelskiej zbrodnii, bo mnie zaciekawiłeś.");
            Console.ReadKey();

            //
            //tutaj będzie wybór 
            //

            Console.WriteLine(">Cholerni żydzi. Niestety mój kochany " + Program.postac.name +
                              ", nie masz wpływu na to, czy izrael kiedyś odpowie za swoje zbrodnie.");
            Console.ReadKey();
            Console.WriteLine("Na szczęście masz wypływ na to czy będę pod wpływem.");
            Console.ReadKey();
            Console.WriteLine("Skocz tacie po piwko");
            Console.Clear();
        }
    }
}