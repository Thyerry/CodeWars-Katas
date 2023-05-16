// See https://aka.ms/new-console-template for more information
using CodeWarsKatas.Codity;
using CodeWarsKatas.Kata;
int bi = 36;
int ci = 7;
while (bi != ci)
{
    if (bi > ci) bi -= ci;
    else ci -= bi;
    Console.WriteLine(bi);
    Console.WriteLine(ci);
}

Console.WriteLine("######################################");
Console.WriteLine(bi);
