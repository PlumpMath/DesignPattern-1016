﻿namespace TemplateMethodPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Program
    {
        public static void Main(string[] args)
        {
            Cricket c = new Cricket();
            c.Play();
            Game g = new Football();
            g.Play();
        }
    }
}
