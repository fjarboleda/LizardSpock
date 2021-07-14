
namespace Game.HowWin
{

    public interface IHowToWin 
    {
        GameResult itWinsTo( GameCircle one, GameCircle other );
        string explain(GameCircle one, GameCircle other);
    }
}