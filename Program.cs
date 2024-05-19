//Console.WriteLine("zehmet olmasa balansinizi daxil edin");
//int balance = int.Parse(Console.ReadLine());
//bool flag = (balance > 0);
//int operationCount = 0;
//while (flag)
//{

//    operationCount++;
//    Console.WriteLine("ceke bileceyiniz en boyuk pul vahidini daxil edin");
//    int unitValue = int.Parse(Console.ReadLine());
//    Console.WriteLine("sayini daxil edin");
//    int unitCount = int.Parse(Console.ReadLine());
//    int currentAmount = unitCount * unitValue;

//    if (balance >= currentAmount)
//    {
//        balance = balance - currentAmount;
//        Console.WriteLine($"Siz {operationCount} islem sonunda hesabinizdan {currentAmount} manat pul cekdiniz");
//        Console.WriteLine($"Sizin cari balansiniz {balance}");
//        if (balance == 0)
//        {
//            flag = false;
//        }
//    }
//    else
//    {
//        Console.WriteLine("yanlis islem");
//    }


//}
//Console.ReadLine();

//Console.WriteLine("telebe sayini daxil edin");
//int studentCount = int.Parse(Console.ReadLine());

//float sum = 0;
//float average = 0;
//int count = 0;
//while (count < studentCount)
//{

//    Console.WriteLine($"{count + 1}-ci telebenin balini daxil edin");
//    int score = int.Parse(Console.ReadLine());
//    if (score > 0 && score <= 100)
//    {
//        sum = sum + score;
//        count++;
//    }


//}
//average = sum / studentCount;
//Console.WriteLine($"Telebelerin ortalama bali {average}");
//Console.ReadLine();


// birinci studentCountda telebelerin sayin aliriq.Sonra sum telebelerin ballarinin cemidi.Average ortalamasidi.countda sayi gosterir.
// Sonra whileda eger count telebelerin sayindan kicikdise onda while islesin deyirik ve count basda 0di ve studentCountda 5di deye dovre daxil olur.
// sonra count+1 var orda countdan 1 vahid olsun deye yazmisiq cunki countumuz 0dan baslayir 0ci telebe olmaz 1 den baslamalidi.Sonra score ile telebenin balini aliriq.
// telebe bali 0 ve 100 olmalidi deye if ile onu yoxlayiriq
// sonra sum umumi butun telebelerin balin ozunde saxlayacaq deyerdi onun ustune o an daxil etdiyimiz bali gelirik.ve countuda 1 vahid artiririq.
// 1 vahid ona gore artiriqki yeni 1 telebe balin daxil etdi
// count studentCounta catana kimi bu davam edir.Sonra average ortalama demekdi ortalama bali tapmaq ucun umumi bali yeni sum yaziriq
// ve telebe sayina studentCounta boluruk
//orda da biz ortalamani tapmis oluruq.
// float kesr ededdi
// ortalamani tapmaq ucun cemini topluyub sayina boluruk


//Console.WriteLine("telebelerin sayini daxil edin");
//int telebesayi =int.Parse( Console.ReadLine());


//int telebesirasi = 1;

//float umumibal = 0;


//while (telebesirasi<=telebesayi)
//{


//    Console.WriteLine(telebesirasi+"-ci telebenin balini daxil edin");
//    float bal = float.Parse(Console.ReadLine());






//    if (bal<=100&& bal>=0)
//    {
//        umumibal += bal;

//        telebesirasi++;
//    }



//}
//float ortalama = umumibal / telebesayi;

//Console.WriteLine("ortalama: "+ortalama);
//Console.Read();

int a = 1;
int i = 1;

for (a = 1; a <=5; a++)
{
    Console.WriteLine("a="+a);


    for ( i = 1; i <=3; i++)
    {
        Console.WriteLine("i="+i);
    }
    Console.WriteLine();
}
Console.Read();


