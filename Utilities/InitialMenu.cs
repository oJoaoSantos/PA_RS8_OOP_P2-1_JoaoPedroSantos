﻿using System;

namespace Utilities
{
    public class InitialMenu
    {
        public static string Menu()
        {
            string[] menu =
            {
               " Entrar  > 1",
               "   Sair  > 2"
            };

            Basics.Header();
            Basics.Title01("Escolhe a opção");
            Console.WriteLine();

            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }
            string option = Basics.ValidateChoice(menu);
            return option;
        }
    }
}
