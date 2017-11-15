using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CompositePatern;

namespace LibTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void katalogand2file()
        {
            Component katalogFoto = new Katalog("katalogFoto_");
            Component foto1 = new File("Foto1", 10);
            Component foto2 = new File("Foto2", 20);
            
            katalogFoto.Add(foto1);
            katalogFoto.Add(foto2);
            Assert.AreEqual(katalogFoto.GetWeight(),30);
        }

        [Test]
        public void katalogand2katalogand4file()
        {
            Component katalogFoto = new Katalog("katalogFoto_");
            Component katalogFoto2016 = new Katalog("katalogFoto2016_");
            Component katalogFoto2017 = new Katalog("katalogFoto2017_");
            Component foto1 = new File("Foto1", 10);
            Component foto2 = new File("Foto2", 20);
            Component foto3 = new File("Foto1", 60);
            Component foto4 = new File("Foto2", 20);

            katalogFoto.Add(katalogFoto2016);
            katalogFoto.Add(katalogFoto2017);
            katalogFoto2016.Add(foto1);
            katalogFoto2016.Add(foto2);
            katalogFoto2017.Add(foto3);
            katalogFoto2017.Add(foto4);

            Assert.AreEqual(katalogFoto.GetWeight(), 110);
        }
        [Test]
        public void katalog0()
        {
            Component katalogFoto = new Katalog("katalogFoto_");
            Assert.AreEqual(katalogFoto.GetWeight(), 0);
        }
        [Test]
        public void kataloginkatalog0()
        {
            Component katalogFoto = new Katalog("katalogFoto_");
            Component katalogFoto2016 = new Katalog("katalogFoto_");
            Component katalogFoto2016sumer = new Katalog("katalogFoto_");
            katalogFoto.Add(katalogFoto2016);
            katalogFoto2016.Add(katalogFoto2016sumer);
            Assert.AreEqual(katalogFoto.GetWeight(), 0);
        }
        [Test]
        public void katalogwith2fileandwithkatalog()
        {
            Component katalogFoto = new Katalog("katalogFoto_");
            Component katalogFoto2016 = new Katalog("katalogFoto_");
            Component katalogFoto2016sumer = new Katalog("katalogFoto_");
            Component foto1 = new File("Foto1", 10);
            Component foto2 = new File("Foto1", 10);
            katalogFoto.Add(katalogFoto2016);
            katalogFoto.Add(foto1);
            katalogFoto.Add(foto2);
            katalogFoto2016.Add(katalogFoto2016sumer);
            Assert.AreEqual(katalogFoto.GetWeight(), 20);
        }

    }
}
