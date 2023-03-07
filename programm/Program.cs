//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//var nimi = Console.ReadLine();
//if (nimi.ToUpper() == "JUKU")
//{
//    Console.WriteLine("Lahme kinno");
//    int vanus = Convert.ToInt32(Console.ReadLine());
//    if (vanus < 0 || vanus > 120) //&&-and ||-or
//    {
//        Console.WriteLine("Vanus ei saa {0} olla", vanus);
//    }
//    else if (vanus < 6)
//    {
//        Console.WriteLine("Pilet on tasuta kui vanus on {0}", vanus);

//    }
//    else if (vanus >= 6 && vanus <= 14)
//    {
//        Console.WriteLine("Sinu vanus on {0} teil on vaja lastepileti osta", vanus);

//    }
//    else if (vanus >= 15 && vanus <= 65)
//    {
//        Console.WriteLine("Sinu vanus on {0} teil on vaja täispileti osta", vanus);

//    }
//    else if (vanus > 65)
//    {
//        Console.WriteLine("Sinu vanus on {0} teil on vaja sooduspileti osta", vanus);

//    }
//}
//else
//{
//    Console.WriteLine("Mind kodus pole");
//}
//Console.Clear();
//Console.BackgroundColor = ConsoleColor.Magenta;
//Console.ForegroundColor = ConsoleColor.Yellow;
using System.Windows.Markup;

Random rnd = new Random();
//int hinne = rnd.Next(1, 5);
//Console.WriteLine("Täna sai hinne {0}", hinne);
//string reaktsion = "";
//switch (hinne)
//{
//    case 1: reaktsion = "Opi veel!"; break;
//    case 2: reaktsion = "Opi natuke veel!"; break;
//    case 3: reaktsion = "Rahuldav"; break;
//    case 4: reaktsion = "Hea tulemus!"; break;
//    case 5: reaktsion = "Vaga hea"; break;
//    default:
//        Console.WriteLine("viga!");
//        break;
//}
//Console.WriteLine("for abil");
//for (int i = 0; i < hinne; i++)
//{
//    Console.WriteLine(reaktsion);
//}
//Console.WriteLine("while abil");
//int hinne_test = hinne;
//while (hinne > 0)
//{
//    hinne--;//hinne=hinne-1
//    Console.WriteLine(reaktsion);
//}

//Console.WriteLine("do while abil");
//do
//{
//    Console.WriteLine(reaktsion);
//    hinne_test--;
//} while (hinne_test != 0);
//var vas = "";
//do
//{
//    Console.Clear();
//    Console.WriteLine("Tahan kommi");
//    vas = Console.ReadLine();
//} while (vas != "komm");

//while (vas != "komm")
//{
//    Console.Beep();
//    Console.Clear();
//    Console.WriteLine("Tahan kommi");
//    vas = Console.ReadLine();
//}

//Console.WriteLine("Tere, " + nimi);
//Console.WriteLine("Arv 1: ");
//int arv1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Arv 2: ");
//int arv2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Tehe: ");
//char tehe = Convert.ToChar(Console.ReadLine()[0]);
//double vastus=0;
//if (tehe=='+')
//{
//    vastus = arv1 + arv2;
//}
//else if (tehe == '-')
//{
//    vastus = arv1 - arv2;

//}
//else if (tehe=='/')
//{
//    vastus = arv1 / arv2;
//}
//else
//{
//    Console.WriteLine("{0} - tundmatu tehe", tehe);
//}

//Console.WriteLine("{0}ja{1} = {2}", arv1, arv2, vastus);


//int kogus = rnd.Next(1, 10);
//string[] Nimed = new string[kogus];
//for (int i = 0; i < kogus; i++)
//{
//    Console.WriteLine("Sisesta {0} nimi: ", i+1);
//    Nimed[i] = Console.ReadLine();
//}

//for (int i = 0; i < Nimed.Length; i++)
//{
//    Console.WriteLine("Tere {0}", Nimed[i]);
//}


//int arv = rnd.Next(1, 15);
//int vas = 0;
//int pop = 0;
//do
//{
//    Console.WriteLine(arv);
//    Console.WriteLine("Sisesta arv");
//    vas = Convert.ToInt32(Console.ReadLine());
//    pop=pop+1;

//} while (vas != arv && pop!=5);

//for (int i = 1; i < 11; i++)
//{
//	for (int j = 1; j < 11; j++)
//	{
//		Console.Write("{0,4}", i * j);
//	}
//	Console.WriteLine();
//}
int inimene;
int[] Arvud = new int[5];
for (int i = 0; i < 5; i++)
{
    Arvud[i]= Convert.ToInt32(Console.ReadLine());
}
int summa=0,korrutis=1;
double keskmine;
foreach (int arv in Arvud)
{
    Console.Write("{0,5}", arv);
    summa = summa + arv;
    korrutis = korrutis * arv;

}
Console.WriteLine();
keskmine = summa / Arvud.Length;
Console.WriteLine("Summa={0},\nKorrutis={1},\nKeskmine={2}", summa, korrutis, keskmine);