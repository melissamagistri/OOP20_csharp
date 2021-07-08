using System;
using System.Collections.Generic;
using System.Text;

namespace GrandiProject
{
    public interface IGenericEntity
    {
        Pair<double, double> GetPos();

        void SetPos(double x, double y);

        double GetX();

        void SetX(double value);

        double GetY();

        void SetY(double value);

        int GetWidth();

        int GetHeight();

        bool IsAlive();

        SpecificEntityType GetEntityType();
    }
}
