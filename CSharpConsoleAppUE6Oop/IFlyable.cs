using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal interface IFlyable
    {
        int Altitude { get; set; }

        void Fly();
        void FlyTo(string destination);
        void TakeOff();
        void Land();
        void avoidCollision();
    }
}
