using System;
using System.Collections.Generic;
using System.Text;

namespace GrandiProject
{
    public class Pair<X, Y>
    {
		private X x;
		private Y y;

		public Pair(in X x, in Y y)
		{
			this.x = x;
			this.y = y;

		}

		public virtual X GetX()
		{
			return this.x;
		}

		public virtual Y GetY()
		{
			return this.y;
		}

		public virtual X SetX(in X x)
		{
			X prev = this.x;
			this.x = x;
			return prev;
		}

		public virtual Y SetY(in Y y)
		{
			Y prev = this.y;
			this.y = y;
			return prev;
		}

		public virtual Pair<X, Y> SetBoth(in X x, in Y y)
		{
			Pair<X, Y> prev = new Pair<X, Y>(this.x, this.y);
			this.x = x;
			this.y = y;
			return prev;
		}

		public virtual Pair<X, Y> SetByPair(in Pair<X, Y> other)
		{
			Pair<X, Y> prev = new Pair<X, Y>(this.x, this.y);
			this.x = other.GetX();
			this.y = other.GetY();
			return prev;
		}

		public virtual Pair<X, Y> Clone()
		{
			return new Pair<X, Y>(this.x, this.y);
		}

		public virtual Pair<Y, X> Swapped
		{
			get
			{
				return new Pair<Y, X>(this.y, this.x);
			}
		}

		public override string ToString()
		{
			return "Pair [x = " + this.x + ", y = " + this.y + "]";
		}

		public override int GetHashCode()
		{
			const int prime = 31;
			int result = 1;
			result = prime * result + ((this.x == null) ? 0 : this.x.GetHashCode());
			result = prime * result + ((this.y == null) ? 0 : this.y.GetHashCode());
			return result;
		}

		public bool Equals(in object obj)
		{
			if (this == obj)
			{
				return true;
			}
			if (obj == null)
			{
				return false;
			}
			if (this.GetType() != obj.GetType())
			{
				return false;
			}
			Pair<object, object> other = (Pair<object, object>)obj;
			if (this.x == null)
			{
				if (other.x != null)
				{
					return false;
				}
			}
			else if (!this.x.Equals(other.x))
			{
				return false;
			}
			if (this.y == null)
			{
				if (other.y != null)
				{
					return false;
				}
			}
			else if (!this.y.Equals(other.y))
			{
				return false;
			}
			return true;
		}
	}
}
