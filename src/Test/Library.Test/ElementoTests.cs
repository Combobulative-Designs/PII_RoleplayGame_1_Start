using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class ElementoTests
    {
        [Test]
        public void TestCrearElemento()
        {
            string nombre = "Gae Bolg";
            double potenciador = 1.2;
            int ataque = 40;
            int defensa = 25;

            var elemento = new Elemento(nombre, potenciador, ataque, defensa);

            Assert.AreEqual(nombre, elemento.Nombre);
            Assert.AreEqual(potenciador, elemento.Potenciador);
            Assert.AreEqual(ataque, elemento.Ataque);
            Assert.AreEqual(defensa, elemento.Defensa);
        }

        [Test]
        public void TestGetElemento()
        {
            string nombre = "Balmung";
            var elemento1 = new Elemento(nombre, 0, 35, 5);

            var elemento2 = Elemento.GetElemento(nombre);

            Assert.AreSame(elemento1, elemento2);
        }
    }
}