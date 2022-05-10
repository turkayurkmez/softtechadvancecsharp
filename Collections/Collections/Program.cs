// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.ObjectModel;

Console.WriteLine("Hello, World!");
List<string> countries = new List<string>();
countries.Add("USA");
countries.Add("Canada");
//countries.
//ArrayList ulkeler = new ArrayList();
//ulkeler.Add("Türkiye");
//ulkeler.Add(9);
//ulkeler.Add(new Random());
/*
 * 1. Tükenen koleksiyonlar
 * 2. key-value pair koleksiyonlar
 * 3. ObservableCollection
 */
Queue<string> mailList = new Queue<string>();
mailList.Enqueue("turkay.urkmez@dinamikzihin.com");
mailList.Enqueue("furkan.baskan@softtech.com.tr");
mailList.Enqueue("faruk.boyacioglu@softtech.com.tr");
mailList.Enqueue("elif.yilmaz@softtech.com.tr");

while (mailList.Count > 0)
{
    var mailAddress = mailList.Dequeue();
    Console.WriteLine($"{mailAddress} adresine gönderiliyor...");
}

Stack<string> stackItems = new Stack<string>();
stackItems.Push("A");
stackItems.Push("B");
stackItems.Push("C");

while (stackItems.Count > 0)
{
    var value = stackItems.Pop();
    Console.WriteLine($"{value} çıkartıldı...");
}

Dictionary<string, string> plates = new Dictionary<string, string>();
string plate = string.Empty;
do
{
    Console.WriteLine("Plaka giriniz (Çıkmak için q):");
    plate = Console.ReadLine();
    if (plate=="q")
    {
        break;
    }
    else
    {
        Console.WriteLine("İl adı giriniz:");
        var city = Console.ReadLine();
        if (plates.ContainsKey(plate))
        {
            Console.WriteLine("Bu plaka zaten var.");
        }
        else
        {
            plates.Add(plate, city);
        }

    }

} while (plate != "q");

foreach (var entry in plates)
{
    Console.WriteLine($"{entry.Key} : {entry.Value}");
}

Console.WriteLine("Aradığınız kodu giriniz:" );
var code = Console.ReadLine();
var cityName = code == string.Empty ? "nope": plates[code];
Console.WriteLine($"{code} kodlu plakanın il adı {cityName}");

ObservableCollection<string> participants = new ObservableCollection<string>();
participants.CollectionChanged += Participants_CollectionChanged;

participants.Add("Uğurcan Yüksel");
participants.Add("Emre Çevik");
participants.Add("Ahmet Yıldırım");
participants.Add("Ebru Yıldırım");


participants[0] = "Türkay Ürkmez";
participants[3] = participants[2];
participants.Remove("Ebru Yıldırım");



void Participants_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
{
    switch (e.Action)
    {
        case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
            Console.WriteLine($"{e.NewItems[0]} katılımcısı eklendi.");
            break;
        case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
            Console.WriteLine($"{e.OldItems[0]} katılımcısı çıkarıldı.");
            break;
        case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
            Console.WriteLine($"{e.OldItems[0]} katılımcısı {e.NewItems[0]} ile değiştirildi.");
            break;
        case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
            Console.WriteLine($"{e.OldStartingIndex} nolu katılımcı {e.NewStartingIndex} nolu katılımcıya taşındı.");
            break;
        case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
            break;
        default:
            break;
    }
}






