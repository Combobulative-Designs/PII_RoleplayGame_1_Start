using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class Test_Elfo
    {
        [Test]
        public void crear_Elfo()
        {
            string nombre = "Poderoso";
            int vida = 100;
            Elfo Elfo_Prueba = new Elfo(nombre,vida);

            Assert.AreEqual(nombre, Elfo_Prueba.Nombre);
            Assert.AreEqual(vida, Elfo_Prueba.Vida);

        }

        [Test]
        public void Agregar_elemento()
        {
            Elfo Elfo_prueba2 = new Elfo("Malisii",90);
            
            Elemento Hacha = new Elemento("Hacha",0,100,0);
            int itemCount = Elfo_prueba2.Items.Count;
            Elfo_prueba2.AgregarElemento(Hacha);

            Assert.AreEqual((itemCount + 1), Elfo_prueba2.Items.Count);
            Assert.Contains(Hacha, Elfo_prueba2.Items);




        }


        [Test]
        public void Quitar_elemento()
        {
            Elfo Elfo_prueba3 = new Elfo("Malisii",90);
            Elemento Hacha2 = new Elemento("Hacha2",0,100,0);
            Elfo_prueba3.AgregarElemento(Hacha2);

            Elfo_prueba3.QuitarElemento(Hacha2);

            
        }

        [Test]
        public void Atacar_arquero()
        {

            int vida_arquero_restante = 70;
            Arquero prueba_arquero = new Arquero("Flechas",80);
            Elfo Elfo_prueba0 = new Elfo("Soldi",150);
            Elemento Hacha3 = new Elemento("Hacha3",0,10,0);
            Elfo_prueba0.AgregarElemento(Hacha3);
            Elfo_prueba0.Ataque(Hacha3,prueba_arquero);


            Assert.AreEqual(vida_arquero_restante,prueba_arquero.Vida);


            
        }

        public void Atacar_enano()
        {
            int vida_enano = 100;

            Enano prueba_enano = new Enano("Pickas",130);
            Elfo Elfo_prueba4 = new Elfo("Soldi",150);
            Elemento Hacha4 = new Elemento("Hacha4",0,30,0);
            Elfo_prueba4.AgregarElemento(Hacha4);
            Elfo_prueba4.Ataque(Hacha4,prueba_enano);

            Assert.AreEqual(vida_enano,prueba_enano.Vida);

        }


        [Test]
        public void atacar_mago()
        {
            int vida_mago = 40;

            Mago prueba_mago = new Mago("Magin",80);
            Elfo Elfo_prueba5 = new Elfo("Lofio",100);
            Elemento Hacha5 = new Elemento("Hacha5",0,40,0);
            Elfo_prueba5.AgregarElemento(Hacha5);
            Elfo_prueba5.Ataque(Hacha5,prueba_mago);

            Assert.AreEqual(vida_mago,prueba_mago.Vida);

        }

        [Test]
        public void atacar_elfo()
        {
            int vida_elfo = 40;

            Elfo prueba_elfo_atacado = new Elfo("Dolos",100);
            Elfo Elfo_prueba6 = new Elfo("Kay",120);
            Elemento Hacha6 = new Elemento("Hacha6",0,50,0);
            Elfo_prueba6.AgregarElemento(Hacha6);
            Elfo_prueba6.Ataque(Hacha6,prueba_elfo_atacado);

            Assert.AreEqual(vida_elfo,prueba_elfo_atacado.Vida);


        }
        [Test]
        public void Testheal()
        {
            Elfo prueba_elfo7 = new Elfo("Malto",200);
            prueba_elfo7.Vida = 0;
            prueba_elfo7.Heal();

            Assert.AreEqual(prueba_elfo7.VidaInicial, prueba_elfo7.Vida);
        }




    }


}