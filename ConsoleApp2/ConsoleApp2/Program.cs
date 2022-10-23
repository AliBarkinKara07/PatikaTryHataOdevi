// See https://aka.ms/new-console-template for more information


//try
//{
//    Console.WriteLine("Bir sayı giriniz:");
//    int sayi = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Girmiş Olduğunuz Sayı" + sayi);
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Hata:" + ex.Message.ToString());

//}

try
{
    // int a = int.Parse(null);
    int a = int.Parse("test");
}
catch (ArgumentNullException exe)
{
    Console.WriteLine("Boş Değer Girdiniz");
    Console.WriteLine(exe);
}

catch(FormatException exe)
{
    Console.WriteLine("Veri Tipi Uygun Değil");
    Console.WriteLine(exe);
}
