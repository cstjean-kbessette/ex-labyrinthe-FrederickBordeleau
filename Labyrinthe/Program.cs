namespace Labyrinthe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Labyrinthe labyrinthe = new Labyrinthe();

            View view = new View();

            Controller controller = new Controller(labyrinthe, view);
            controller.Run();
        }
    }
}
