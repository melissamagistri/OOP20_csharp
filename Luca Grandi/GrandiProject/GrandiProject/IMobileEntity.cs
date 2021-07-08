using System;
using System.Collections.Generic;
using System.Text;

namespace GrandiProject
{
    public interface IMobileEntity : IGenericEntity
    {
        double GetMuX();

        void SetMuX(double value);

        double GetMuY();

        void SetMuY(double value);
    }
}
