// See https://aka.ms/new-console-template for more information
using Calendar.Entitities;

Console.WriteLine("Calendar App");


Meets meeting1 = new Meets()
{
    Title = "YetGen Jump & Akbank Backend Planlama Toplantısı",
    Details = new List<string>()
    {
        "Katılımcıların alım süreçleri konuşulacak",
        "Akbank'tan gelen mail konuşulacak",
        "Bütçe planlaması konuşulacak"
    },
    StartTime = new DateTime(2023, 09, 18, 19, 00, 00),
    FinishTime = new DateTime(2023, 09, 18, 20, 00, 00),
    Guests = new List<string>()
     { "hakan@deneme.com", "mehmet@deneme.com", "ugur@deneme.com" }
};




Todo todo1 = new Todo()
{
    Title = "Katılımcı Geri Bildirimlerini Teslim Et",
    Details = new List<string>()
    {
        "Değerlendirme sonuçlarının anonimleştirilmesi",
        "Grafik oluşturulması"
    },
    StartTime = new DateTime(2023, 09, 20, 21, 00, 00),
    FinishTime = new DateTime(2023, 09, 20, 22, 00, 00),
    Importance = "High Priority"
};


meeting1.GetNotification();
todo1.GetNotification();

Console.ReadLine();