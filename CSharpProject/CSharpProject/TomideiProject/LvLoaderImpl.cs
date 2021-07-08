namespace TomideiProject
{

	public class LvLoaderImpl : ILvLoader
	{
		public virtual ILevel loadLevel(int levelNumber)
		{
			return new LvImpl(levelNumber);
		}
	}
}