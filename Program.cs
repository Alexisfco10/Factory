namespace Factory 
{
    class Program 
    {
        static void Main(string[] args)
        {
            BebidaAlcoholica orden123 = Creador.OrdenBebida(Creador.Quiero_Cerveza);
            
            Console.WriteLine("Su bebida tiene el siguiente grado de alcohol:" + orden123.GradodeAlcohol());
            Console.ReadKey();
        }
    }
}