﻿using System;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var spy = new Spy();
            var result =spy.RevealPrivateMethods("Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}
