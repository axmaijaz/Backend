﻿// See https://aka.ms/new-console-template for more information
using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            Console.WriteLine("Hello ASMA! This is a test app for Deployment");
        }
       
    }
}
 
   