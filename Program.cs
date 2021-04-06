using System;

namespace Zoologico
{
    public abstract class Animal{
        protected string especie;
        protected string nombre;
        protected double peso;
        protected int jaula;

        public Animal(string especie, string nombre, double peso, int jaula){
            this.especie = especie;
            this.nombre = nombre;
            this.peso = peso;
            this.jaula = jaula;
        }
        public virtual void queClaseDeAnimalEres(){
        }
    }
    public class Mamifero : Animal{
        protected string colorPlumaje;
        protected double alturaMaximaVuelo;
        public Mamifero(string especie, string nombre, double peso,int jaula):base(especie, nombre, peso, jaula){}
        public override void queClaseDeAnimalEres(){
            Console.WriteLine("\nSoy un mamifero llamado: {0}", nombre);
            Console.WriteLine("De la Especie: {0}", especie);
            Console.WriteLine("Peso en Kg: {0}",peso);
            Console.WriteLine("Estoy en la Jaula: {0}\n", jaula);
        }
    }
    public class Ave : Animal{
        protected string colorPlumaje;
        protected double alturaMaximaVuelo;
        public Ave(string especie, string nombre, double peso,int jaula, string colorPlumaje, double alturaMaximaVuelo):base(especie, nombre, peso, jaula){
            this.colorPlumaje = colorPlumaje;
            this.alturaMaximaVuelo = alturaMaximaVuelo;
        }
        public override void queClaseDeAnimalEres(){
            Console.WriteLine("Soy un Ave llamado: {0}", nombre);
            Console.WriteLine("De la Especie: {0}", especie);
            Console.WriteLine("Peso en Kg: {0}",peso);
            Console.WriteLine("Estoy en la Jaula: {0}", jaula);
            Console.WriteLine("Mis plumas son de color: {0}", colorPlumaje);
            Console.WriteLine("Mi altura Maxima de  Vuelo es de: {0}\n", alturaMaximaVuelo);
        }
    }
    public class Insecto : Animal{
        protected bool vuela;
        public Insecto(string especie, string nombre, double peso,int jaula, bool vuela):base(especie, nombre, peso, jaula){
            this.vuela = vuela;
        }
        public override void queClaseDeAnimalEres(){
            Console.WriteLine("Soy un Insecto llamado: {0}", nombre);
            Console.WriteLine("De la Especie: {0}", especie);
            Console.WriteLine("Peso en Kg: {0}",peso);
            Console.WriteLine("¿Sera que puedo volar?: {0}\n", vuela);
        }
    }
    public class Zoologico{
        public void Mostrar(){
            Mamifero m = new Mamifero("Leon", "Katiusko", 180, 01);
            m.queClaseDeAnimalEres();
            Ave a = new Ave("Aguila", "Yirusleidy", 4, 02, "Blanco y Marron", 9.100);
            a.queClaseDeAnimalEres();
            Insecto i = new Insecto("Abeja", "Yuderka", 0.00014, 03, true);
            i.queClaseDeAnimalEres();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zoologico z = new Zoologico();
            z.Mostrar();
        }
    }
}
