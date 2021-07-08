using GrandiProject;

namespace TomideiProject

{

	public class LvImpl : ILevel
	{

		private string bossType;
		private int aliens;

		public LvImpl(string boss, int aliens)
		{
			this.bossType = boss; 
			this.aliens = aliens;
		}

		public LvImpl(int levelNum)
		{
			switch (levelNum)
			{
				case 1:
					this.bossType = "";
					this.aliens = 25;
					break;
				case 2:
					this.bossType = SpecificEntityType.BOSS_1.ToString();
					break;
				case 3:
					this.bossType = "";
					this.aliens = 30;
					break;
				case 4:
					this.bossType = SpecificEntityType.BOSS_2.ToString();
					break;
				case 5:
					this.bossType = "";
					this.aliens = 35;
					break;
				case 6:
					this.bossType = SpecificEntityType.BOSS_3.ToString();
					break;
			}
		}

        public virtual int GetAliens()
        {
            return this.aliens;
        }

        public virtual string GetBoss()
        {
            return this.bossType;
        }

    }
}