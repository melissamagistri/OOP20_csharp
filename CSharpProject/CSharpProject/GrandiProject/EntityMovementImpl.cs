using System;
using System.Collections.Generic;
using System.Text;

namespace GrandiProject
{
    public class EntityMovementImpl : IEntityMovement
    {
        public void MoveLeft(IMobileEntity e)
        {
            e.SetX(e.GetX() - e.GetMuX());
        }

        public void MoveRight(IMobileEntity e)
        {
            e.SetX(e.GetX() + e.GetMuX());
        }

        public void MoveUp(IMobileEntity e)
        {
            e.SetY(e.GetY() - e.GetMuY());
        }

        public void MoveDown(IMobileEntity e)
        {
            e.SetY(e.GetY() + e.GetMuY());
        }

        public void MoveBottomLeft(IMobileEntity e)
        {
            e.SetY(e.GetY() + e.GetMuY());
            e.SetX(e.GetX() - e.GetMuX());
        }

        public void MoveBottomRight(IMobileEntity e)
        {
            e.SetY(e.GetY() + e.GetMuY());
            e.SetX(e.GetX() + e.GetMuX());
        }
    }
}
