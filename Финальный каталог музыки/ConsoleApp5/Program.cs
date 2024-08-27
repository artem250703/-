using System;
class Katalog
{
    public int[] viborGrupp = { 1, 2, 3, 4, 5 };
    public string[] Ispolnitel = { "Порнофильмы", "Исполнителей нету", "Skllet", "Исполнителей нету", "Скриптонит" };
    public string[] Alboms = { "Печаль", "Альбома нет", "Awake Deluxe", "Альбома нет", "Дом с нормальными явлениями" };
    public string[] JanrAlboms = { "Рок", "Жанра нету", "Rok", "Жанра нету", "хип-хоп" };
    public string[] Trek = { "Печаль, Это пройдёт", "Трек не добавлен", "Hero, Monster, Dont WAake, Me Awake and Alive, One Day Too Late, It's Not Me it's You, Should've ", "Трек не добавлен", "Интро, Дома, Вниз, Коньяк, Притон" };
    public int[] KolvoTrek = { 2, 0, 7, 0, 5 };
    public string[] prosl = { "Да", "Не прослушивалась", "Да", "Не прослушивалась", "Да" };

}
class progtam
{
    static void Main()
    {
        Katalog vi = new Katalog();
        string i = "да";
        while (i == "да")
        {
            Console.WriteLine("Приветсвуем в каталоге музыки!");
            Console.WriteLine("Выберите ниже представленые опции");





            Console.WriteLine("0. Изменить Каталог");
            Console.WriteLine("1. Показать Каталог");



            int vs = int.Parse(Console.ReadLine());
            if (vs == 0)
            {
                ispl(vi.Ispolnitel, vi.JanrAlboms, vi.Alboms, vi.Trek, vi.KolvoTrek, vi.prosl);

            }
            if (vs == 1)
            {
                vib(vi.viborGrupp, vi.Ispolnitel, vi.JanrAlboms, vi.Alboms, vi.Trek, vi.KolvoTrek, vi.prosl);
            }
            Console.WriteLine("Продолжим?");
            i = Console.ReadLine();
        }
        Console.WriteLine("Введите 2 чтобы вывести данные Исполнителей");
        int tr = int.Parse(Console.ReadLine());
        if (tr == 2)
        {
            musik(vi.viborGrupp, vi.Ispolnitel, vi.JanrAlboms, vi.Alboms, vi.Trek, vi.KolvoTrek, vi.prosl);
        }
    }
    public static void ispl(string[] massiv, string[] massiv_1, string[] massiv_2, string[] massiv_3, int[] massiv_4, string[] massiv_5)
    {
        Console.WriteLine("Введите номер Исполнителя");
        int o = int.Parse(Console.ReadLine());
        o = o - 1;
        Console.WriteLine("Введите Название Исполнителя");
        string isp = Console.ReadLine();
        massiv[o] = isp;
        Console.WriteLine("Введите Жанр альбома");
        string janr = Console.ReadLine();
        massiv_1[o] = janr;
        Console.WriteLine("Введите Название Альбома");
        string alb = Console.ReadLine();
        massiv_2[o] = alb;
        Console.WriteLine("Введите количество Треков в альбоме");
        int kolv = int.Parse(Console.ReadLine());
        massiv_4[o] = kolv;
        Console.WriteLine("Количество треков в альбоме" + " " + massiv_4[o]);
        Console.WriteLine("Введите Название Треков, Через пробел");
        string tre = Console.ReadLine();
        massiv_3[o] = tre;
        Console.WriteLine("Введите результат прослушивания (Да/Нет)");
        string prosl = Console.ReadLine();
        massiv_5[o] = prosl;
    }
    public static void vib(int[] massiv1, string[] massiv2, string[] massiv3, string[] massiv4, string[] massiv5, int[] massiv6, string[] massiv7)
    {
        Console.WriteLine("Введите номер Исполнителя");
        int l = int.Parse(Console.ReadLine());
        l = l - 1;
        Console.WriteLine("Номер Исполнителя - " + massiv1[l] + "\nИсполнитель " + massiv2[l] + "\nЖанрАльбома " + massiv3[l] + "\nАльбом " + massiv4[l] + "\nТрек/и - " + massiv5[l] + "\nКоличество треков в альбоме " + massiv6[l] + "\nРезультат прослушивания: " + massiv7[l]);
    }
    public static void musik(int[] massiv1, string[] massiv2, string[] massiv3, string[] massiv4, string[] massiv5, int[] massiv6, string[] massiv7)
    {
        int a = 0;
        int katal = 0;
        for (int i = 0; i < massiv1.Length; i++)
        {
            Console.WriteLine("Номер Исполнителя - " + massiv1[i] + "\nИсполнитель " + massiv2[i] + "\nЖанрАльбома " + massiv3[i] + "\nАльбом " + massiv4[i] + "\nТрек/и - " + massiv5[i] + "\nКоличество треков в альбоме " + massiv6[i] + "\nРезультат прослушивания: " + massiv7[i]);
            Console.WriteLine("<<<<><><><><><><><><><><><><><><><><><><><><><>>>>");
            if (massiv7[i] == "+")
            {
                a += 1;
            }
            katal += massiv6[i];
        }
        Console.WriteLine("Всего треков а альбоме  " + katal);


        Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><>");
        Console.WriteLine("Работу выполнили ☺ ☻ ");
        Console.WriteLine("Разрабочтик<><><><><><><><><> Гусельников Артём");
        Console.WriteLine("Разраб<><><><<> Овчинников");
    }
}

