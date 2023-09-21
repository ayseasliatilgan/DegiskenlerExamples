internal class Program
{
    static void Main(string[] args)
    {
        // ogrenci giris sistemi icin ornek
        var studentName = ("Susan");
        var studentSurname = ("Olsen");
        var nameSurname = studentName + studentSurname;
        var studentNo = "1013";
        var studentBirthDate = 1997;
        var studentAge = 2023 - studentBirthDate;
        var studentAdress = "London UK";

        Console.WriteLine(studentName);
        Console.WriteLine(studentSurname);
        Console.WriteLine(nameSurname);
        Console.WriteLine(studentNo);
        Console.WriteLine(studentBirthDate);
        Console.WriteLine(studentAge);
        Console.WriteLine(studentAdress);


    }
}