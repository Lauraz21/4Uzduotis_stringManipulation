using System;
Console.WriteLine("SUBWAY");

float[] prices = {1.0f, 1.10f, 1.8f, 1.2f, 3.00f, 0f,
    0.8f, 0.8f, 0f, 0.5f, 0.5f, 0.5f, 0.5f, 0.5f, 0f,
0.2f, 0.2f, 0.2f, 0.2f, 0.2f, 0f,};

float sum = 0;

Console.WriteLine("PASIRINKITE DYDI: \n15cm - 1 arba 30cm - 2");
string size = Console.ReadLine();

if (size == "2")
{ 
    sum += 5;
    Console.WriteLine(sum);
}
Console.WriteLine("ISSIRINKITE DUONA: ");
Console.WriteLine("0) *Sviesi italiska: " + prices[0] + " Eur");
Console.WriteLine("1) *Surio ir raudonelio: " + prices[1] + " Eur");
int userInput = Convert.ToInt32(Console.ReadLine());

sum += prices[userInput];
Console.WriteLine(sum + "Eur");

Console.WriteLine("ISSIRINKITE MESA: ");
Console.WriteLine("2) *Vistiena: " + prices[2] + " Eur");
Console.WriteLine("3) *Kumpis: " + prices[3] + " Eur");
Console.WriteLine("4) *Jautiena: " + prices[4] + " Eur");
Console.WriteLine("5) *Be mesos: " + prices[5] + " Eur");
int userInput2 = Convert.ToInt32(Console.ReadLine());

sum += prices[userInput2];
Console.WriteLine(sum + "Eur");

Console.WriteLine("ISSIRINKITE SURI: ");
Console.WriteLine("6) *Mozzarella: " + prices[6] + " Eur");
Console.WriteLine("7) *Cederio: " + prices[7] + " Eur");
Console.WriteLine("8) *Be surio: " + prices[8] + " Eur");
int userInput3 = Convert.ToInt32(Console.ReadLine());

sum += prices[userInput3];
Console.WriteLine(sum + "Eur");

int[] vegetablesInput = new int [3]; 
Console.WriteLine("ISSIRINKITE 3 DARZOVES: ");
Console.WriteLine("9) *Salotos: " + prices[9] + " Eur");
Console.WriteLine("10) *Pomidorai: " + prices[10] + " Eur");
Console.WriteLine("11) *Agurkai: " + prices[11] + " Eur");
Console.WriteLine("12) *Paprika: " + prices[12] + " Eur");
Console.WriteLine("13) *Chalapos paprikos: " + prices[13] + " Eur");
Console.WriteLine("14) *Be darzoviu: " + prices[14] + " Eur");
vegetablesInput[0]= Convert.ToInt32(Console.ReadLine());
vegetablesInput[1] = Convert.ToInt32(Console.ReadLine());
vegetablesInput[2] = Convert.ToInt32(Console.ReadLine());

sum += prices[vegetablesInput[0]];
sum += prices[vegetablesInput[1]];
sum += prices[vegetablesInput[2]];
Console.WriteLine(sum + "Eur");

Console.WriteLine("ISSIRINKITE PADAZA: ");
Console.WriteLine("15) *Garlic (vegan): " + prices[15] + " Eur");
Console.WriteLine("16) *Chopotle: " + prices[16] + " Eur");
Console.WriteLine("17) *Cezario: " + prices[17] + " Eur");
Console.WriteLine("18) *Majonezo: " + prices[18] + " Eur");
Console.WriteLine("19) *BBQ: " + prices[19] + " Eur");
Console.WriteLine("20) *Be Padazo: " + prices[20] + " Eur");
int userInput7 = Convert.ToInt32(Console.ReadLine());

sum += prices[userInput7];
Console.WriteLine("Galutine kaina: " + sum + " Eur");

switch (userInput)
{
    case 0:
        Console.WriteLine("Sviesi italiska duona - " + prices[0] + " Eur");
        break;
    case 1:
        Console.WriteLine("Surio ir raudonelio duona - " + prices[1] + " Eur");
        break;
}
switch (userInput2)
{
    case 2:
        Console.WriteLine("Vistiena - " + prices[2] + " Eur");
        break;
    case 3:
        Console.WriteLine("Kumpis - " + prices[3] + " Eur");
        break;
    case 4:
        Console.WriteLine("Jautiena - " + prices[4] + " Eur");
        break;
    case 5:
        Console.WriteLine("Be mesos - " + prices[5] + " Eur");
        break;
}
switch (userInput3)
{
    case 6:
        Console.WriteLine("Mozzarella - " + prices[6] + " Eur");
        break;
    case 7:
        Console.WriteLine("Cederio - " + prices[7] + " Eur");
        break;
    case 8:
        Console.WriteLine("Be surio - " + prices[8] + " Eur");
        break;
}
int i = 0;
while (i < vegetablesInput.Length)
{
    switch (vegetablesInput[i])
    {
        case 9:
            Console.WriteLine("Salotos - " + prices[9] + " Eur");
            break;
        case 10:
            Console.WriteLine("Pomidorai -" + prices[10] + " Eur");
            break;
        case 11:
            Console.WriteLine("Agurkai -" + prices[11] + " Eur");
            break;
        case 12:
            Console.WriteLine("Paprika -" + prices[12] + " Eur");
            break;
        case 13:
            Console.WriteLine("Chalapos paprikos -" + prices[13] + " Eur");
            break;
        case 14:
            Console.WriteLine("Be darzoviu -" + prices[14] + " Eur");
            break;
    }
    i++;
}
switch (userInput7)
{
    case 15:
        Console.WriteLine("Garlic vegan -" + prices[15] + " Eur");
        break;
    case 16:
        Console.WriteLine("Chopotle -" + prices[16] + " Eur");
        break;
    case 17:
        Console.WriteLine("Cezario -" + prices[17] + " Eur");
        break;
    case 18:
        Console.WriteLine("Majonezo -" + prices[18] + " Eur");
        break;
    case 19:
        Console.WriteLine("BBQ -" + prices[19] + " Eur");
        break;
    case 20:
        Console.WriteLine("Be Padazo -" + prices[20] + " Eur");
        break;
}
