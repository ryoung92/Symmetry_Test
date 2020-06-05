using System;
using System.Collections.Generic;
using System.Text;

namespace PartOne.Conditions
{
    ///<summary>
    ///Provides ability to add operators to calculations
    ///</summary>
    public interface ICondition
    {
        string Condition(int input);
    }
}
