using GrandiProject;
namespace MagistriProject
{
    public enum GameEvent{ PAUSE, RIGHT, LEFT, FIRE }

	public interface IUserEntity : IMobileEntity
	{
		void UpdateEntityPosition(GameEvent @event, int cycles);
	}

}