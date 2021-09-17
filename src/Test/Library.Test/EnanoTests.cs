using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class EnanoTests
    {
        /// <summary>
        /// Test de creacion de Enano. Revisa si los valores
        /// en las propiedades de la instancia creada son los 
        /// provistos al constructor.
        /// </summary>
        [Test]
        public void TestCrearEnano()
        {
            string nombre = "Nicolas";
            int vidaInicial = 120;

            Enano xEnano = new Enano(nombre, vidaInicial);

            Assert.AreEqual(nombre, xEnano.Nombre);
            Assert.AreEqual(vidaInicial, xEnano.Vida);
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
            Elemento xElemento = new Elemento("Botas", 0, 0, 20);
            Enano xEnano = new Enano("Carlos", 90);
            int itemCount = xEnano.Items.Count;

            xEnano.AgregarElemento(xElemento);

            Assert.AreEqual((itemCount + 1), xEnano.Items.Count);
            Assert.Contains(xElemento, xEnano.Items);
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
            Enano xEnano = new Enano("Pedro", 45);
            Elemento xElemento1 = new Elemento("Espada 1", 0, 25, 0);
            Elemento xElemento2 = new Elemento("Espada 2", 0, 25, 0);
            Elemento xElemento3 = new Elemento("Espada 3", 0, 25, 0);
            xEnano.AgregarElemento(xElemento1);
            xEnano.AgregarElemento(xElemento2);
            xEnano.AgregarElemento(xElemento3);
            int itemCount = xEnano.Items.Count;

            xEnano.QuitarElemento(xElemento2);

            Assert.AreEqual((itemCount - 1), xEnano.Items.Count);
            foreach (Elemento elemento in xEnano.Items)
            {
                Assert.AreNotSame(xElemento2, elemento);
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

            Enano xEnano = new Enano("Pepe", 78);
            Arquero xArquero = new Arquero("Jose", vidaInicial);
            Elemento elemento = new Elemento("Piedra", 0, ataque, 0);
            xEnano.AgregarElemento(elemento);

            xEnano.Ataque(elemento, xArquero);

            Assert.AreEqual(vidaRestante, xArquero.Vida);
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

            Enano xEnano = new Enano("Pepe", 78);
            Elfo xElfo = new Elfo("Circe", vidaInicial);
            Elemento xElemento = new Elemento("Enuma Elish", 0, ataque, 0);
            xEnano.AgregarElemento(xElemento);

            xEnano.Ataque(xElemento, xElfo);

            Assert.AreEqual(vidaRestante, xElfo.Vida);
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

            Enano xEnano1 = new Enano("Juan", 83);
            Enano xEnano2 = new Enano("Ernesto", vidaInicial);
            Elemento xElemento = new Elemento("Secace", 0, ataque, 0);
            xEnano1.AgregarElemento(xElemento);

            xEnano1.Ataque(xElemento, xEnano2);

            Assert.AreEqual(vidaRestante, xEnano2.Vida);
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

            Enano xEnano = new Enano("Jose", 76);
            Mago xMago = new Mago("Helena Blavatsky", vidaInicial);
            Elemento xElemento = new Elemento("Thunderer", 0, ataque, 0);
            xEnano.AgregarElemento(xElemento);

            xEnano.Ataque(xElemento, xMago);

            Assert.AreEqual(vidaRestante, xMago.Vida);
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

            Enano xEnano = new Enano("Andres", 91);
            Elemento xElemento1 = new Elemento("Holy Shroud", 0, 0, defensa1);
            Elemento xElemento2 = new Elemento("Rho Aias", 0, 0, defensa2);
            xEnano.AgregarElemento(xElemento1);
            xEnano.AgregarElemento(xElemento2);

            Assert.AreEqual(defensaTotalEsperada, xEnano.CalcularDefensa());
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

            Enano xEnano1 = new Enano("Luis", vidaInicial);
            Elemento xElemento1 = new Elemento("Holy Shroud", 0, 0, defensa1);
            Elemento xElemento2 = new Elemento("Rho Aias", 0, 0, defensa2);
            xEnano1.AgregarElemento(xElemento1);
            xEnano1.AgregarElemento(xElemento2);

            Enano xEnano2 = new Enano("Ivan", 87);
            Elemento xElemento3 = new Elemento("Yew Bow", 0, ataque, 0);
            xEnano2.AgregarElemento(xElemento3);

            xEnano2.Ataque(xElemento3, xEnano1);

            Assert.AreEqual(vidaRestante, xEnano1.Vida);
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
            Enano xEnano = new Enano("Timy", 93);

            xEnano.Vida = 0;
            xEnano.Heal();

            Assert.AreEqual(xEnano.VidaInicial, xEnano.Vida);
        }
    }
}