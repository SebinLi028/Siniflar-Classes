//class

class ArrClass
{
    public ArrayList KarisikList = new ArrayList();

    public void ArrAdd(object data)
    {
        if (KarisikList.Contains(data) == false)
        {
            KarisikList.Add(data);
            Console.Write("Eleman Eklendi.\n\n\n");
        }
        else Console.Write("Eleman Eklenemedi.\n\n\n");
    }

    public void ArrRemove(object data)
    {
        if (KarisikList.Contains(data) == true)
        {
            KarisikList.Remove(data);
            Console.Write("Eleman Silindi.\n\n\n");
        }
        else Console.Write("Eleman Silinemedi.\n\n\n");
    }

    public object ArrFind_Var(object data) { return KarisikList.Contains(data); }

    public object ArrFind_Kac(object data) { return KarisikList.IndexOf(data); }

    public void ArrList()
    {
        if (KarisikList.Count == 0)
        {
            Console.Write("Dizide Eleman Yok.");
        }
        else foreach (object eleman in KarisikList) Console.WriteLine(eleman);
    }

    public void ArrSort(byte scm)
    {
        if (KarisikList.Count == 0)
        {
            Console.Write("Dizide Eleman Yok.\n\n\n");
        }
        else
        {
            if (scm == 0)
            {
                KarisikList.Sort();
                foreach (object eleman in KarisikList) Console.WriteLine(eleman);
                Console.Write("\n\n\n");
            }
            else if (scm == 1)
            {
                KarisikList.Sort();
                KarisikList.Reverse();
                foreach (object eleman in KarisikList) Console.WriteLine(eleman);
                Console.Write("\n\n\n");
            }
            else Console.Write("0 veya 1 gir.\n\n\n");
        }
    }
}

//main program

static void Main(string[] args)
{
    Console.Title = "Class ArrayList Uygulaması (========>>>> SebinLi028 <<<<========)";
    ArrClass arrclss = new ArrClass();
    object data;
    byte scm;
    do
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("******** ArrayList ********");
            Console.WriteLine("1.Eleman Ekle");
            Console.WriteLine("2.Eleman Sil");
            Console.WriteLine("3.Tüm Elemanları Sil");
            Console.WriteLine("4.Eleman Bul");
            Console.WriteLine("5.Elemanları Sırala");
            Console.WriteLine("6.Dizideki Elemanları Göster");
            Console.Write("\n\nSeçim Yapınız.."); int secenek = Convert.ToInt16(Console.ReadLine());
            switch (secenek)
            {
                case 1:
                    Console.Write("Eklenecek Elamanı Giriniz.."); data = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    arrclss.ArrAdd(data); break;
                case 2:
                    Console.Write("Silinecek Elemanı Giriniz.."); data = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    arrclss.ArrRemove(data); break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    arrclss.KarisikList.Clear(); Console.Write("Tüm Elemanlar Silindi.\n\n\n"); break;
                case 4:
                    Console.Write("Bulunacak Elemanı Giriniz.."); data = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(arrclss.ArrFind_Var(data) + " " + arrclss.ArrFind_Kac(data) + "\n\n\n"); break;
                case 5:
                    Console.Write("A-Z Sıralama İçin (0) Z-A Sıralama İçin (1).."); scm = Convert.ToByte(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green; arrclss.ArrSort(scm); break;
                case 6:
                    Console.WriteLine("\n\n*** Dizideki Elemanlar ***");
                    Console.ForegroundColor = ConsoleColor.Green; arrclss.ArrList(); Console.Write("\n\n\n"); break;
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\nHatalı Seçim Yaptınız.\n\n\n");
        }
    } while (true);
}
