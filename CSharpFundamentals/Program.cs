﻿namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            System.Console.WriteLine((int)method);
        }
    }
}
