using System;
using System.Collections.Generic;
using System.Text;

namespace GrandiProject
{
    public interface IEntityMovement
    {
        void MoveLeft(IMobileEntity e);

        void MoveRight(IMobileEntity e);

        void MoveUp(IMobileEntity e);

        void MoveDown(IMobileEntity e);

        void MoveBottomLeft(IMobileEntity e);

        void MoveBottomRight(IMobileEntity e);
    }
}
