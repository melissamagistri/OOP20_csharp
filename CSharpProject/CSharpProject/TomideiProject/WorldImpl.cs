using System.Collections.Generic;
using GuidazziProject;
using GrandiProject;
using MagistriProject;
using System.Linq;

namespace TomideiProject
{
	public class WorldImpl : IWorld
	{

		private readonly int INITIAL_MAX_WIDTH = 800;
		private readonly int INITIAL_MAX_HEIGHT = 600;
		private readonly int INITIAL_MIN_WIDTH = 0;
		private readonly int INITIAL_MIN_HEIGHT = 0;

		private readonly int LAST_LEVEL = 6;
		private readonly int FIRST_LEVEL = 1;

		private double MAX_WIDTH;
		private double MAX_HEIGHT;
		private double MIN_WIDTH;
		private double MIN_HEIGHT;

		private ISet<IGenericEntity> entities;

		private readonly ILvLoader loaderManager;
		private int score;
		private int lvlNum;

		public WorldImpl()
		{
			this.entities = new HashSet<IGenericEntity>();
			this.score = 0;
			this.lvlNum = this.FIRST_LEVEL;
			this.loaderManager = new LvLoaderImpl();

			MAX_WIDTH = (this.INITIAL_MAX_WIDTH == 0) ? 100 + this.INITIAL_MIN_WIDTH : this.INITIAL_MAX_WIDTH;
			MAX_HEIGHT = (this.INITIAL_MAX_HEIGHT == 0) ? 100 + this.INITIAL_MIN_HEIGHT : this.INITIAL_MAX_HEIGHT;
			MIN_WIDTH = this.INITIAL_MIN_WIDTH;
			MIN_HEIGHT = this.INITIAL_MIN_HEIGHT;

		}

		private void nextLevel()
		{
			ILevel lv = this.loaderManager.loadLevel(lvlNum);

			int numAliens = lv.GetAliens();

			string bossType = lv.GetBoss();

			this.entities.Add(new Player1(SpecificEntityType.PLAYER_1, (this.MAX_WIDTH + this.MIN_WIDTH) / 2, (this.MAX_HEIGHT - 20)));

			this.entities.UnionWith(this.placeEnemy(bossType, numAliens, this.MAX_WIDTH, this.MIN_WIDTH, this.MAX_HEIGHT, this.MIN_HEIGHT));

			foreach (var e in this.entities)
			{
				if (e.GetX() + e.GetWidth() / 2 > this.MAX_WIDTH)
				{
					e.SetX(this.INITIAL_MAX_WIDTH);
				}
				if (e.GetX() - e.GetWidth() / 2 < this.MIN_WIDTH)
				{
					e.SetX(this.INITIAL_MIN_WIDTH);
				}
				if (e.GetY() + e.GetHeight() / 2 > this.MAX_HEIGHT)
				{
					e.SetY(this.INITIAL_MAX_HEIGHT);
				}
				if (e.GetY() - e.GetHeight() / 2 < this.MIN_HEIGHT)
				{
					e.SetY(this.INITIAL_MIN_HEIGHT);
				}
			}
		}

		private ISet<IGenericEntity> placeEnemy(string bossType, int numAliens, double maxWidth, double minWidth, double maxHeight, double minHeight)
		{

			ISet<IGenericEntity> set = new HashSet<IGenericEntity>();

			if (numAliens != 0)
			{
				set.Add(new Alien(0, 0, SpecificEntityType.ALIEN_1));
			}

			if (!(bossType.Length != 0))
			{
				if (bossType.ToUpper() == "BOSS_1")
				{
					set.Add(new Boss1((int)((maxWidth + minWidth) / 2), (int)(minHeight + 20)));
				}
			}
			return set;
		}

		public ISet<IGenericEntity> LevelEntities()
		{
			return this.entities;
		}

		public ISet<IGenericEntity> GetLevelEntities()
		{
			return this.entities;
		}

		public double GetMaxWorldWidth()
		{
			return this.MAX_WIDTH;
		}

		public double GetMaxWorldHeight()
		{
			return this.MAX_HEIGHT;
		}

		public double GetMinWorldWidth()
		{
			return this.MIN_WIDTH;
		}

		public double GetMinWorldHeight()
		{
			return this.MIN_HEIGHT;
		}

		public void startNextLevel()
		{
			this.entities.Clear();
			if (!(this.lvlNum > this.LAST_LEVEL))
			{
				this.nextLevel();
				this.lvlNum++;
			}
		}

		public void restartLevel()
		{
			this.score = 0;
			this.lvlNum = this.FIRST_LEVEL;
			this.startNextLevel();
		}

		public int GetScore()
		{
			return this.score;
		}
	} 
}
