using System.Collections.Generic;
using GrandiProject;
using GuidazziProject;
using MagistriProject;

namespace TomideiProject
{
	public interface IWorld
	{
        ISet<IGenericEntity> GetLevelEntities();

        double GetMaxWorldWidth();

        double GetMaxWorldHeight();

        double GetMinWorldWidth();

        double GetMinWorldHeight();

        void startNextLevel();

		void restartLevel();

        int GetScore();

	}

}