namespace ConsoleApp
{
    class Vehiculo
    {
        public decimal VelocidadMaxima { get; set; }
        public int NumeroPuertas { get; set; }

        public Vehiculo(decimal velocidadMaxima, int numeroPuertas)
        {
            VelocidadMaxima = velocidadMaxima;
            NumeroPuertas = numeroPuertas;
        }

    }
}
