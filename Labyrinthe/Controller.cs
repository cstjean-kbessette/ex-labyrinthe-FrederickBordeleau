namespace Labyrinthe
{
    internal class Controller
    {
        private Labyrinthe labyrinthe;
        private View view;

        public Controller(Labyrinthe labyrinthe, View view)
        {
            this.labyrinthe = labyrinthe;
            this.view = view;
        }
        public void Run()
        {
            while (true)
            {


                view.AfficherEntete();
                view.AfficherLabyrinthe(labyrinthe);
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.W:
                        labyrinthe.MoveUp();
                        break;
                    case ConsoleKey.S:
                        labyrinthe.MoveDown();
                        break;
                    case ConsoleKey.D:
                        labyrinthe.MoveRight();
                        break;
                    case ConsoleKey.A:
                        labyrinthe.MoveLeft();
                        break;
                }
                if (labyrinthe.IsExit())
                {
                    view.AfficherVictoire();
                    return;
                }
            }
            
        }
    }
}
