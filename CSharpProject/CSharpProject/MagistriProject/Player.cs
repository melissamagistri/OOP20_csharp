using GrandiProject;
namespace MagistriProject
{

    public abstract class Player : IUserEntity
    {

        private SpecificEntityType entityType;
        private Pair<double, double> position;
        private double movimentUnitX;
        private double movimentUnitY;
        private int height;
        private int width;
        private int hit;
        private int maxHits;

        protected internal virtual void create(SpecificEntityType type, double x, double y, int width, int height, double muX, double muY, int maxHits)
        {
            this.width = width;
            this.height = height;
            this.position = new Pair<double, double>(x, y);
            this.movimentUnitX = muX;
            this.movimentUnitY = muY;
            this.hit = 0;
            this.maxHits = maxHits;
            this.entityType = type;
        }

        public Pair<double, double> GetPos()
        {
            return this.position;
        }

        public void SetPos(double x, double y)
        {
            this.position.SetBoth(x, y);
        }

        public double GetX()
        {
            return this.position.GetX();
        }

        public void SetX(double value)
        {
            this.position.SetX(value);
        }

        public double GetY()
        {
            return this.position.GetY();
        }

        public void SetY(double value)
        {
            this.position.SetY(value);
        }

        public int GetWidth()
        {
            return this.width;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public bool IsAlive()
        {
            return this.hit < this.maxHits;
        }

        public virtual void IncHits()
        {
            this.hit++;
        }

        public virtual int GetHits()
        {
            return this.hit;
        }

        public double GetMuX()
        {
            return this.movimentUnitX;
        }

        public void SetMuX(double value)
        {
            this.movimentUnitX = value;
        }

        public double GetMuY()
        {
            return this.movimentUnitY;
        }


        public void SetMuY(double value)
        {
            this.movimentUnitY = value;
        }

        public SpecificEntityType GetEntityType()
        {
            return this.entityType;
        }

        public int GetMaxHits()
        {
            return this.maxHits;
        }

        public abstract void UpdateEntityPosition(GameEvent @event, int cycles);
    }
}