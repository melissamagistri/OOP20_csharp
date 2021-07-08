using GrandiProject;
namespace MagistriProject
{
	

	public class Player1 : Player
	{
		private readonly int INITIAL_WIDTH = 5;
		private readonly int INITIAL_HEIGHT = 5;
		private readonly double INITIAL_MU_X = 5;
		private readonly double INITIAL_MU_Y = 5;
		private readonly int MAX_HITS = 3;
		private bool shoot_Conflict;

		public Player1(SpecificEntityType type, double x, double y)
		{
			double speedX = 10;
			this.create(type, x, y, INITIAL_WIDTH, INITIAL_HEIGHT, speedX, 0, MAX_HITS);

			this.shoot_Conflict = false;
		}
		public override void UpdateEntityPosition(GameEvent @event, int cycles)
		{
				if (@event.Equals(GameEvent.LEFT))
				{
					this.SetMuX(-INITIAL_MU_X);
					this.SetX(this.GetX() + this.GetMuX());
				}
		
				if (@event.Equals(GameEvent.RIGHT))
				{
					this.SetMuX(INITIAL_MU_X);
					this.SetX(this.GetX() + this.GetMuX());
				}

		}

	}

}