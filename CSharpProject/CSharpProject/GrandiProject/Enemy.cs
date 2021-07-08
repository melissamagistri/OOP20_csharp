using System;
using System.Collections.Generic;
using System.Text;

namespace GrandiProject
{
    public abstract class Enemy : IMobileEntity
    {
        private Pair<double, double> pos;
        private double muX, muY;
        private int width, height, hit, maxHits;
        private IEntityMovement move;
        private EntityDirections direction;
        private SpecificEntityType entityType;

        protected internal virtual void Create(SpecificEntityType type,
            double x,
            double y,
            int width,
            int height,
            double muX,
            double muY,
            int maxHits,
            EntityDirections dir,
            IEntityMovement move)
        {
            this.width = width;
            this.height = height;
            pos = new Pair<double, double>(x, y);
            this.muX = muX;
            this.muY = muY;
            this.move = move;
            direction = dir;
            hit = 0;
            this.maxHits = maxHits;
            entityType = type;
        }

        public Pair<double, double> GetPos()
        {
            return pos;
        }

        public void SetPos(double x, double y)
        {
            pos.SetBoth(x, y);
        }

        public double GetX()
        {
            return pos.GetX();
        }

        public void SetX(double value)
        {
            pos.SetX(value);
        }

        public double GetY()
        {
            return pos.GetY();
        }

        public void SetY(double value)
        {
            pos.SetY(value);
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public double GetMuX()
        {
            return muX;
        }

        public void SetMuX(double value)
        {
            muX = value;
        }

        public double GetMuY()
        {
            return muY;
        }


        public void SetMuY(double value)
        {
            muY = value;
        }

        public virtual int GetHits()
        {
            return hit;
        }

        public virtual int GetMaxHits()
        {
            return maxHits;
        }

        public virtual void IncHits()
        {
            hit++;
        }

        public virtual IEntityMovement GetMovementMenager()
        {
            return move;
        }

        public virtual EntityDirections GetDirection()
        {
            return direction;
        }

        public virtual void SetDirection(EntityDirections value)
        {
            direction = value;
        }

        public bool IsAlive()
        {
            return hit < maxHits;
        }

        public abstract void UpdateEntityPosition();

        protected internal abstract void ChangeDirection();

        public SpecificEntityType GetEntityType()
        {
            return entityType;
        }
    }
}
