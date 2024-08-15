class Program
{
    class Film// film adında bir class açtım çükü iki tane değişken tanımlamak için 
    {
        public double _imbd {  get; set; }
        public string _isim {  get; set; }

        public Film(double imbd,string isim)// iki değişkeni bir metot içinde çağırarak tanımlayabilmek için 
        {
            _imbd = imbd;
            _isim = isim;

        }
    }
    static void Main()
    {
        List<Film>filmliste= new List<Film>();

        while (true)//sonzu bir döngü oluşturmak için 
        {
            Console.WriteLine("Lütfen film adını giriniz");
            string film=Console.ReadLine();

            Console.WriteLine("Lütfen ımbd puanı giriniz");
            double imbd=Convert.ToDouble(Console.ReadLine());
           
            Film yenifilm = new Film(imbd, film);
            filmliste.Add(yenifilm);

            Console.WriteLine("Programdan çıkmak için evet yazınız(evet/hayır");
            string cevap = Console.ReadLine().ToLower();
            if (cevap == "evet")//evet yazıldığında döngüden çıkmak için 
            {
                break;
            }
          

        }
        Console.WriteLine("Filmlerin tam listesi:");
        foreach (Film item in filmliste)//filmleri sıralamak için foreach döngüsü
        {
            Console.WriteLine($"Film adı:{item._isim} film imbd: {item._imbd}");
        }
        Console.WriteLine("İmdb ouanu 4 ile 9 arasında olanlar");
        foreach(Film film in filmliste.Where(f => f._imbd >= 4 && f._imbd <= 9))//4 ile 9 imdb arası puanları listelemek 
        {
            Console.WriteLine($"Film Adı: {film._isim} Imbd Puanı: {film._imbd}");
        }
        Console.WriteLine("Film adı A ile başlayanlar");
        foreach (Film film in filmliste.Where(f => f._isim.StartsWith("A", StringComparison.OrdinalIgnoreCase)))// A ile başlayanları listelemek
        {
            Console.WriteLine($"Film Adı: {film._isim}, IMDB Puanı: {film._imbd}");
        }

    }

}