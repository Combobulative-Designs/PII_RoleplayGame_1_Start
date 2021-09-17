// Justificacion de decisiones para la ubicacion de metodos segun principios/patrones.

// La mayoria de las decisiones fueron tomadas de acuerdo al patron Expert, decidiendo
// implementar las metodos requeridos en las clases que tienen la informacion necesaria
// para realizar su funcion.

// El metodo de calcular el ataque de un personaje no fue añadido en ningun lado
// pues no es necesario. Es una propiedad de los elementos asignada en su creacion
// por el constructor. Luego es utilizada de forma directa al atacar por los 
// personajes, sin ninguna manipulacion que requiera un metodo para calcular.

// La unica excepcion es el ataque del mago ya que este se realiza con hechizos los 
// cuales se pueden potenciar de acuerdo a los items del Mago. En este caso, el metodo
// de calculo del daño se implemento en la clase Mago, debido a que este calculo requiere
// conocer todos los potenciadores de los items equipados y el daño base del hechizo.

// El metodo CalcularDefensa() fue añadido a la clase de cada personaje (Elfo, Enano,
// Mago, y Arquero). Se implemento en esas clases debido a que su calculo requiere
// sumar las defensas de todos los items equipados por el personaje, y cada item tiene
// su valor de defensa directo como propiedad sin necesidad de calculo individual.

// El metodo de Atacar() fue implementado de nuevo en las clases de los personajes,
// debido a que estas clases son las que pueden seleccionar el item equipado con el
// cual realizar el ataque. La clase Elemento por ejemplo no tiene el listado de items
// del personaje para saber si puede atacar con el mismo.

// El metodo Heal(), encargado de restaurar la vida de un personaje a su cantidad inicial
// fue implementado en las clases de los personajes debido a que estas tienen tanto el
// acceso a la vida actual del personaje para modificarla, como el dato de su vida inicial
// para saber a que cantidad restaurar la vida actual.


using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            PopulateItems();
            PopulateHechizos();

            var arquero1 = new Arquero("Chloe von Einzbern", 75);
            arquero1.AgregarElemento(Elemento.GetElemento("Kanshou y Bakuya"));
            arquero1.AgregarElemento(Elemento.GetElemento("Caladbolg II"));
            arquero1.AgregarElemento(Elemento.GetElemento("Holy Shroud"));
            //Console.WriteLine(((Elemento)arquero1.Items[2]).Nombre);

            Enano xEnano = new Enano("Carlitos", 120);
            xEnano.AgregarElemento(Elemento.GetElemento("Espada"));
            xEnano.AgregarElemento(Elemento.GetElemento("Dagas"));
            xEnano.AgregarElemento(Elemento.GetElemento("Escudo"));

            Elfo Elfo1 = new Elfo("Mantoldor", 100);
            Elfo1.AgregarElemento(Elemento.GetElemento("Pico"));
            Elfo1.AgregarElemento(Elemento.GetElemento("Merryline"));
            Elfo1.AgregarElemento(Elemento.GetElemento("Excuman"));
            //Console.WriteLine(((Elemento)Elfo1.Items[1]).Nombre);

            Mago Harry = new Mago("Harry Potter", 150);
            Harry.AgregarElemento(Elemento.GetElemento("Varita De Acebo"));
            Harry.AgregarElemento(Elemento.GetElemento("Capa"));
            Harry.AgregarHechizo(Hechizo.GetHechizo("wingardium leviosa"));
            
            
        }

        static void PopulateItems()
        {

            new Elemento("Caladbolg II", 0, 60, 0);
            new Elemento("Kanshou y Bakuya", 0, 35, 10);
            new Elemento("Holy Shroud", 0, 0, 40);
            new Elemento("Espada", 0, 80, 0);
            new Elemento("Dagas", 0, 30, 0);
            new Elemento("Escudo", 0, 0, 45);
            new Elemento("Pico", 0, 30, 0);
            new Elemento("Merryline", 0, 50, 0);
            new Elemento("Excuman", 0, 0, 30);
            new Elemento("Varita De Acebo", 1.5, 0, 0);
            new Elemento("Capa", 0, 0, 50);
        }

        static void PopulateHechizos()
        {
            new Hechizo("wingardium leviosa",60);

        }
    }
}
