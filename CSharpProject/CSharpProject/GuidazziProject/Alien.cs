using System;
using System.Collections.Generic;
using System.Text;
using GrandiProject;

namespace GuidazziProject
{
	public class Alien : Enemy
	{
		private readonly int INITIAL_WIDTH = 5;
		private readonly int INITIAL_HEIGHT = 5;
		private readonly double INITIAL_MU_X = 5;
		private readonly double INITIAL_MU_Y = 5;
		private readonly int MAX_HITS = 3;

		public Alien(int x, int y, SpecificEntityType type)
		{
			this.Create(type, x, y, this.INITIAL_WIDTH, this.INITIAL_HEIGHT, this.INITIAL_MU_X, this.INITIAL_MU_Y, this.MAX_HITS, EntityDirections.LEFT, new EntityMovementImpl());
			
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
			this.GetMovementMenager().MoveDown(this);
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
	}
}
