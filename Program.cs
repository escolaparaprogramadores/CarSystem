﻿using System;
using CarSystem.Dominio;

namespace CarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto 1
           new ServicoLocacao1
           (
            200,
            30
           );

           //Objeto 2
           new ServicoLocacao1
           (
            200,
            2
           );
          

            Console.WriteLine(25*5/2+298);
        }
    }
}
