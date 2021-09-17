using NUnit.Framework;
using Library;
namespace Test.Library
{
    public class MagoTests
    {
        /// <summary>
        /// test para crear mago
        /// </summary>
        [Test]
        public void TestCrearUnMago()
        {
            string vNombre = "Mago De Prueba";
            int vVida = 100;

            var elmago = new Mago(vNombre, vVida);

            Assert.AreEqual(vNombre, elmago.Nombre);
            Assert.AreEqual(vVida, elmago.Vida);
        }

        [Test]
        public void TestAgregarElemento()
        {
            var mago = new Mago("Mago Nuevo ", 100);
            var varita = new Elemento("varita", 1.5, 0, 0);
            int Contador = mago.Items.Count;

            mago.AgregarElemento(varita);

            Assert.AreEqual((Contador + 1), mago.Items.Count);
            Assert.Contains(varita, mago.Items);
        }
        [Test]
        public void TestAgregarHechizo()
        {
            var mago = new Mago("Mago Nuevo ", 100);
            var hechizo = new Hechizo("expeliarmus", 60);
            int Contador = mago.Items.Count;

            mago.AgregarHechizo(hechizo);

            Assert.AreEqual((Contador + 1), mago.Hechizos.Count);
            Assert.Contains(hechizo, mago.Hechizos);
        }
        [Test]
        public void TestQuitarElemento()
        {
            var mago = new Mago("Mago Nuevo ", 100);
            var elemento1 = new Elemento("VARITA1", 1.5, 0, 0);
            var elemento2 = new Elemento("VARITA2", 1.5, 0, 0);
            var elemento3 = new Elemento("VARITA3", 1.5, 0, 0);
            mago.AgregarElemento(elemento1);
            mago.AgregarElemento(elemento2);
            mago.AgregarElemento(elemento3);
            int contador = mago.Items.Count;

            mago.QuitarElemento(elemento2);

            Assert.AreEqual((contador - 1), mago.Items.Count);
            foreach (Elemento elemento in mago.Items)
            {
                Assert.AreNotSame(elemento2, elemento);
            }

        }
        [Test]
        public void TestQuitarHechizo()
        {
            var mago = new Mago("Mago Nuevo ", 100);
            var hechizo1 = new Hechizo("expeliarmus1", 60);
            var hechizo2 = new Hechizo("expeliarmus2", 60);
            var hechizo3 = new Hechizo("expeliarmus3", 60);
            mago.AgregarHechizo(hechizo1);
            mago.AgregarHechizo(hechizo2);
            mago.AgregarHechizo(hechizo3);
            int contador = mago.Hechizos.Count;

            mago.QuitarHechizo(hechizo2);

            Assert.AreEqual((contador - 1), mago.Hechizos.Count);
            foreach (Hechizo hechizo in mago.Hechizos)
            {
                Assert.AreNotSame(hechizo2, hechizo);
            }

        }
        [Test]
        public void TestAtacarArquero()
        {
            int vidaInicial = 100;
            int ataque = 50;
            int vidaRestante = 25;

            var mago = new Mago("Merlin", 78);
            var arquero = new Arquero("Arash", vidaInicial);
            var hechizo = new Hechizo("poder", ataque);
            var elemento = new Elemento("VARITA3", 1.5, 0, 0);
            mago.AgregarElemento(elemento);
            mago.AgregarHechizo(hechizo);


            mago.Ataque(hechizo, arquero);

            Assert.AreEqual(vidaRestante, arquero.Vida);
        }
        [Test]
        public void TestAtacarElfo()
        {
            int vidaInicial = 100;
            int ataque = 50;
            int vidaRestante = 25;


            var mago = new Mago("Merlin", 78);
            var elfo = new Elfo("elfo", vidaInicial);
            var hechizo = new Hechizo("poder", ataque);
            var elemento = new Elemento("VARITA3", 1.5, 0, 0);
            mago.AgregarElemento(elemento);
            mago.AgregarHechizo(hechizo);

            mago.Ataque(hechizo, elfo);

            Assert.AreEqual(vidaRestante, elfo.Vida);
        }
        [Test]
        public void TestAtacarEnano()
        {
            int vidaInicial = 100;
            int ataque = 50;
            int vidaRestante = 25;


            var mago = new Mago("Merlin", 78);
            var enano = new Enano("enano", vidaInicial);
            var hechizo = new Hechizo("poder", ataque);
            var elemento = new Elemento("VARITA3", 1.5, 0, 0);
            mago.AgregarElemento(elemento);
            mago.AgregarHechizo(hechizo);

            mago.Ataque(hechizo, enano);

            Assert.AreEqual(vidaRestante, enano.Vida);
        }
        [Test]
        public void TestAtacarMago()
        {
            int vidaInicial = 100;
            int ataque = 50;
            int vidaRestante = 25;


            var mago1 = new Mago("Merlin", 78);
            var mago2 = new Mago("mago", vidaInicial);
            var hechizo = new Hechizo("poder", ataque);
            var elemento = new Elemento("VARITA3", 1.5, 0, 0);
            mago1.AgregarElemento(elemento);
            mago1.AgregarHechizo(hechizo);

            mago1.Ataque(hechizo, mago2);

            Assert.AreEqual(vidaRestante, mago2.Vida);
        }
        [Test]
        public void TestCalcularDefensa()
        {
            int defensa1 = 20;
            int defensa2 = 45;
            int defensaTotalEsperada = defensa1 + defensa2;

            var mago = new Mago("mago1", 100);
            var elemento1 = new Elemento("el1", 0, 0, defensa1);
            var elemento2 = new Elemento("el2", 0, 0, defensa2);
            mago.AgregarElemento(elemento1);
            mago.AgregarElemento(elemento2);

            Assert.AreEqual(defensaTotalEsperada, mago.CalcularDefensa());
        }

        [Test]
        public void TestHeal()
        {
            var mago = new Mago("William Tell", 93);

            mago.Vida = 0;
            mago.Heal();

            Assert.AreEqual(mago.VidaInicial, mago.Vida);
        }

        [Test]
        public void TestDefensa()
        {
            int vidaInicial = 75;
            int defensa1 = 10;
            int defensa2 = 15;
            int defensaTotalEsperada = defensa1 + defensa2;
            int ataque = 45;
            int vidaRestante = vidaInicial - (ataque - defensaTotalEsperada);

            var mago1 = new Mago("nombre", vidaInicial);
            var elemento1 = new Elemento("el1", 0, 0, defensa1);
            var elemento2 = new Elemento("el2", 0, 0, defensa2);
            mago1.AgregarElemento(elemento1);
            mago1.AgregarElemento(elemento2);

            var mago2 = new Mago("mago3", 87);
            var hechizo = new Hechizo("el3",ataque);
            mago2.AgregarHechizo(hechizo);

            mago2.Ataque(hechizo, mago1);

            Assert.AreEqual(vidaRestante, mago1.Vida);
        }

        [Test]
        public void TestCalcularAtaque()
        {
            int vidaInicial = 100;
            double pot1 = 1.2;
            double pot2 = 1.05;
            double pot3 = 1.11;
            int dañoHechizo = 40;
            int dañoEsperado = (int)(dañoHechizo * (pot1 * pot2 * pot3));

            var mago1 = new Mago("mago1", vidaInicial);
            var elemento1 = new Elemento("el1", pot1, 0, 0);
            var elemento2 = new Elemento("el2", pot2, 0, 0);
            var elemento3 = new Elemento("el3", pot3, 0, 0);
            mago1.AgregarElemento(elemento1);
            mago1.AgregarElemento(elemento2);
            mago1.AgregarElemento(elemento3);
            var hechizo1 = new Hechizo("hec1", dañoHechizo);

            int dañoCalculado = this.CalcularAtaque(hechizo1);

            Assert.AreEqual(dañoEsperado, dañoCalculado);
        }
        
    }
}