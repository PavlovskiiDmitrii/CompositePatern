using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatern
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Component StartKatalog = new Katalog("StartKatalog_");
            Component katalogFoto = new Katalog("katalogFoto_");
            Component katalogMusic = new Katalog("katalogMusic_");
            Component foto1 = new File("Foto1", 10);
            Component foto2 = new File("Foto2", 20);
            Component music1 = new File("Music1", 100);


            StartKatalog.Add(katalogFoto);
            StartKatalog.Add(katalogMusic);
            katalogMusic.Add(music1);
            katalogFoto.Add(foto1);
            katalogFoto.Add(foto2);


            Console.WriteLine("Start_katalog - " + StartKatalog.GetWeight());
            Console.WriteLine("Foto2 - " + foto2.GetWeight());
            Console.WriteLine("Каталог фото - " + katalogFoto.GetWeight());

            Console.ReadLine();
        }
    }
}
