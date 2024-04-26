// See https://aka.ms/new-console-template for more information
using System;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");


public class Test
{
    public int MyProperty { get; set; }


    public Test()
    {
        MyProperty = MyProperty;

        // use nuget dependency
        var json = JsonConvert.SerializeObject(this);
    }
}