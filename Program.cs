namespace papier_kamien
{
    internal class Program
    {
        /*const int papier = 1;
        const int kamien = 2;
        const int nozyce = 3;*/

        public static Random rnd = new Random();
        
        static void Main(string[] args)
        {
           bool kontynuuj = true;
            while (kontynuuj)
            {
                Console.WriteLine("PAPIER/KAMIEN/NOŻYCE!");
                Console.WriteLine("Wybierz jedną z trzech opcji");
                Console.WriteLine("Papier = 1");
                Console.WriteLine("Kamień = 2");
                Console.WriteLine("Nożyce = 3");
                try
                {
                    int wyborGracza = int.Parse(Console.ReadLine());
                    int wylosowanaWartosc = rnd.Next(1, 4);

                    logikaGry.kamienPapier(wylosowanaWartosc, wyborGracza);

                }
                catch (Exception)
                {
                    
                    Console.WriteLine("Nieprawidłowy znak.Wybór jest z zakresu liczb 1-3");
                }
                
            }
        }
    }
}