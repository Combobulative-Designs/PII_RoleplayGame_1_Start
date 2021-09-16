using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class ArqueroTests
    {
        /// <summary>
        /// Test de creacion de arquero. Revisa si los valores
        /// en las propiedades de la instancia creada son los 
        /// provistos al constructor.
        /// </summary>
        [Test]
        public void TestCrearArquero()
        {
            string nombre = "Artemis";
            int vidaInicial = 80;

            var arquero = new Arquero(nombre, vidaInicial);

            Assert.AreEqual(nombre, arquero.Nombre);
            Assert.AreEqual(vidaInicial, arquero.Vida);
        }

        /// <summary>
        /// Test de agregar elementos. Crea un elemento
        /// y prueba agregarlo al personaje. Luego testea
        /// si la cuenta de items incremento en 1, y si 
        /// el item se encuentra en la lista de items del 
        /// personaje.
        /// </summary>
        [Test]
        public void TestAgregarElemento()
        {
            var elemento = new Elemento("Maana", 0, 55, 0);
            var arquero = new Arquero("Ishtar", 80);
            int itemCount = arquero.Items.Count;

            arquero.AgregarElemento(elemento);

            Assert.AreEqual((itemCount + 1), arquero.Items.Count);
            Assert.Contains(elemento, arquero.Items);
        }

        /// <summary>
        /// Test de quitar elementos. Crea un elemento, lo añade
        /// al personaje e intenta removerlo finalmente. Prueba si
        /// la cantidad de elementos decrecio en 1 luego de remover
        /// el item, y si ninguno de los items restantes es identico
        /// al removido.
        /// </summary>
        [Test]
        public void TestQuitarElemento()
        {
            var arquero = new Arquero("Oda Nobunaga", 75);
            var elemento1 = new Elemento("Rifle 1", 0, 25, 0);
            var elemento2 = new Elemento("Rifle 2", 0, 25, 0);
            var elemento3 = new Elemento("Rifle 3", 0, 25, 0);
            arquero.AgregarElemento(elemento1);
            arquero.AgregarElemento(elemento2);
            arquero.AgregarElemento(elemento3);
            int itemCount = arquero.Items.Count;

            arquero.QuitarElemento(elemento2);

            Assert.AreEqual((itemCount - 1), arquero.Items.Count);
            foreach (Elemento elemento in arquero.Items)
            {
                Assert.AreNotSame(elemento2, elemento);
            }
        }

        /// <summary>
        /// Test de atacar a un arquero. Crea 2 personajes y 
        /// un elemento con ataque, añade el elemento a uno de
        /// los personajes, y ataca con ese personaje al otro.
        /// Prueba que la vida restante del personaje atacado
        /// sea igual a la vida inicial menos el daño del ataque.
        /// </summary>
        [Test]
        public void TestAtacarArquero()
        {
            int vidaInicial = 97;
            int ataque = 32;
            int vidaRestante = 65;

            var arquero1 = new Arquero("Atalante", 78);
            var arquero2 = new Arquero("Arash", vidaInicial);
            var elemento = new Elemento("Tauropolos", 0, ataque, 0);
            arquero1.AgregarElemento(elemento);

            arquero1.Ataque(elemento, arquero2);

            Assert.AreEqual(vidaRestante, arquero2.Vida);
        }

        /// <summary>
        /// Test de atacar a un elfo. Crea 2 personajes y 
        /// un elemento con ataque, añade el elemento a uno de
        /// los personajes, y ataca con ese personaje al otro.
        /// Prueba que la vida restante del personaje atacado
        /// sea igual a la vida inicial menos el daño del ataque.
        /// </summary>
        [Test]
        public void TestAtacarElfo()
        {
            int vidaInicial = 63;
            int ataque = 57;
            int vidaRestante = 6;

            var arquero1 = new Arquero("Gilgamesh", 121);
            var elfo1 = new Elfo("Circe", vidaInicial);
            var elemento = new Elemento("Enuma Elish", 0, ataque, 0);
            arquero1.AgregarElemento(elemento);

            arquero1.Ataque(elemento, elfo1);

            Assert.AreEqual(vidaRestante, elfo1.Vida);
        }

        /// <summary>
        /// Test de atacar a un enano. Crea 2 personajes y 
        /// un elemento con ataque, añade el elemento a uno de
        /// los personajes, y ataca con ese personaje al otro.
        /// Prueba que la vida restante del personaje atacado
        /// sea igual a la vida inicial menos el daño del ataque.
        /// </summary>
        [Test]
        public void TestAtacarEnano()
        {
            int vidaInicial = 52;
            int ataque = 43;
            int vidaRestante = 9;

            var arquero1 = new Arquero("Maid Alter", 83);
            var enano1 = new Enano("Hans Christian Andersen", vidaInicial);
            var elemento = new Elemento("Secace", 0, ataque, 0);
            arquero1.AgregarElemento(elemento);

            arquero1.Ataque(elemento, enano1);

            Assert.AreEqual(vidaRestante, enano1.Vida);
        }

        /// <summary>
        /// Test de atacar a un mago. Crea 2 personajes y 
        /// un elemento con ataque, añade el elemento a uno de
        /// los personajes, y ataca con ese personaje al otro.
        /// Prueba que la vida restante del personaje atacado
        /// sea igual a la vida inicial menos el daño del ataque.
        /// </summary>
        [Test]
        public void TestAtacarMago()
        {
            int vidaInicial = 62;
            int ataque = 25;
            int vidaRestante = 37;

            var arquero1 = new Arquero("Billy the Kid", 76);
            var mago1 = new Mago("Helena Blavatsky", vidaInicial);
            var elemento = new Elemento("Thunderer", 0, ataque, 0);
            arquero1.AgregarElemento(elemento);

            arquero1.Ataque(elemento, mago1);

            Assert.AreEqual(vidaRestante, mago1.Vida);
        }

        /// <summary>
        /// Test del calculo de defensa. Crea un personaje y
        /// varios items con puntos de defensa para añadir a 
        /// este. Prueba si el resultado del metodo CalcularDefensa()
        /// es equivalente a la suma de la defensa de los items.
        /// </summary>
        [Test]
        public void TestCalcularDefensa()
        {
            int defensa1 = 20;
            int defensa2 = 45;
            int defensaTotalEsperada = defensa1 + defensa2;

            var arquero1 = new Arquero("Emiya Shirou", 91);
            var elemento1 = new Elemento("Holy Shroud", 0, 0, defensa1);
            var elemento2 = new Elemento("Rho Aias", 0, 0, defensa2);
            arquero1.AgregarElemento(elemento1);
            arquero1.AgregarElemento(elemento2);

            Assert.AreEqual(defensaTotalEsperada, arquero1.CalcularDefensa());
        }

        /// <summary>
        /// Test de defender un ataque. Crea dos personajes, uno
        /// con items de defensa y otro con items de ataque. Luego
        /// ataca con el segundo al primero. Prueba si la vida restante
        /// del primer personaje es equivalente a su vida inicial menos
        /// resta de su defensa al ataque del segundo personaje.
        /// </summary>
        [Test]
        public void TestDefender()
        {
            int vidaInicial = 75;
            int defensa1 = 10;
            int defensa2 = 15;
            int defensaTotalEsperada = defensa1 + defensa2;
            int ataque = 45;
            int vidaRestante = vidaInicial - (ataque - defensaTotalEsperada);

            var arquero1 = new Arquero("Chloe von Einzbern", vidaInicial);
            var elemento1 = new Elemento("Holy Shroud", 0, 0, defensa1);
            var elemento2 = new Elemento("Rho Aias", 0, 0, defensa2);
            arquero1.AgregarElemento(elemento1);
            arquero1.AgregarElemento(elemento2);

            var arquero2 = new Arquero("Robin Hood", 87);
            var elemento3 = new Elemento("Yew Bow", 0, ataque, 0);
            arquero2.AgregarElemento(elemento3);

            arquero2.Ataque(elemento3, arquero1);

            Assert.AreEqual(vidaRestante, arquero1.Vida);
        }

        /// <summary>
        /// Prueba de la accion Heal. Crea un personaje con su
        /// vida inicial, disminuye su vida, y luego ejecuta el 
        /// metodo Heal(). Prueba si la vida final luego del Heal
        /// es igual a su vida inicial.
        /// </summary>
        [Test]
        public void TestHeal()
        {
            var arquero1 = new Arquero("William Tell", 93);

            arquero1.Vida = 0;
            arquero1.Heal();

            Assert.AreEqual(arquero1.VidaInicial, arquero1.Vida);
        }
    }
}