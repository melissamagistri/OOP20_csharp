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
            this.pos = new Pair<double, double>(x, y);
            this.muX = muX;
            this.muY = muY;
            this.move = move;
            this.direction = dir;
            this.hit = 0;
            this.maxHits = maxHits;
            this.entityType = type;
        }

        public Pair<double, double> GetPos()
        {
            return pos;
        }

        public void SetPos(double x, double y)
        {
            this.pos.SetBoth(x, y);
        }

        public double GetX()
        {
            return this.pos.GetX();
        }

        public void SetX(double value)
        {
            this.pos.SetX(value);
        }

        public double GetY()
        {
            return this.pos.GetY();
        }

        public void SetY(double value)
        {
            this.pos.SetY(value);
        }

        public int GetWidth()
        {
            return this.width;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public double GetMuX()
        {
            return muX;
        }

        public void SetMuX(double value)
        {
            this.muX = value;
        }

        public double GetMuY()
        {
            return muY;
        }


        public void SetMuY(double value)
        {
            this.muY = value;
        }

        public virtual int GetHits()
        {
            return this.hit;
        }

        public virtual int GetMaxHits()
        {
            return this.maxHits;
        }

        public virtual void IncHits()
        {
            this.hit++;
        }

        public virtual IEntityMovement GetMovementMenager()
        {
            return this.move;
        }

        public virtual EntityDirections GetDirection()
        {
            return this.direction;
        }

        public virtual void SetDirection(EntityDirections value)
        {
            this.direction = value;
        }

        public bool IsAlive()
        {
            return this.hit < this.maxHits;
        }

        public abstract void UpdateEntityPosition();

        protected internal abstract void ChangeDirection();

        public SpecificEntityType GetEntityType()
        {
            return this.entityType;
        }
    }
}
