using System;
using System.Collections.Generic;
using System.Text;

namespace GrandiProject
{
	public class Boss1 : Enemy
	{
		private readonly int INITIAL_WIDTH = 0;
		private readonly int INITIAL_HEIGHT = 0;
		private readonly double INITIAL_MU_X = 0;
		private readonly double INITIAL_MU_Y = 0;
		private readonly int MAX_HITS = 0;

		public Boss1(double x, double y)
		{
			this.Create(
				SpecificEntityType.BOSS_1,
				x,
				y,
				INITIAL_WIDTH,
				INITIAL_HEIGHT,
				INITIAL_MU_X,
				INITIAL_MU_Y,
				MAX_HITS,
				EntityDirections.RIGHT,
				new EntityMovementImpl());
		}

		public override void UpdateEntityPosition()
		{
			if (this.GetDirection().Equals(EntityDirections.LEFT))
			{
				this.GetMovementMenager().MoveLeft(this);
			}
			else
			{
				this.GetMovementMenager().MoveRight(this);
			}
		}

		protected internal override void ChangeDirection()
		{
			if (this.GetDirection().Equals(EntityDirections.LEFT))
			{
				this.SetDirection(EntityDirections.RIGHT);
			}
			else
			{
				this.SetDirection(EntityDirections.LEFT);
			}
		}
	}
}
