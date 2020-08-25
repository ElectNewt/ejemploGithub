namespace ConsoleApp
{
    class Vehiculo
    {
        public decimal VelocidadMaxima { get; set; }
        public int NumeroPuertas { get; set; }
        public int Cv { get; set; }

        public Vehiculo(decimal velocidadMaxima, int numeroPuertas, int cv)
        {
            VelocidadMaxima = velocidadMaxima;
            NumeroPuertas = numeroPuertas;
            Cv = cv;
        }

    }
}
