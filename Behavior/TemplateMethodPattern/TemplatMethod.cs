namespace DesignPattern
{
    public abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        //template method
        public void Play()
        {

            //initialize the game
            Initialize();

            //start game
            StartPlay();

            //end game
            EndPlay();
        }
    }

    public class Football : Game
    {
        public override void EndPlay()
        {

        }

        public override void Initialize()
        {

        }

        public override void StartPlay()
        {

        }
    }

}