
using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class HechizosTest
    {
        [Test]
        public void TestCrearHechizo()
        {
            string nombre = "Hechizo";
            int ataque = 40;
            

            var hechizo = new Hechizo(nombre, ataque);

            Assert.AreEqual(nombre, hechizo.Nombre);
          
            Assert.AreEqual(ataque, hechizo.Ataque);
        }

        [Test]
        public void TestGetElemento()
        {
            string nombre = "expeliarmus";
            var hechizo1 = new Hechizo(nombre, 0);

            var hechizo2 = Hechizo.GetHechizo(nombre);

            Assert.AreSame(hechizo1, hechizo2);
        }
    }
}