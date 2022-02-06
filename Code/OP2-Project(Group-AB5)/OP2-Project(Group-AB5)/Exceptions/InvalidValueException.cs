using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 2020-10-26
/// Group AB5 -
/// André Normann
/// Viktor Klang
/// Denise Peterson
/// David Ahlström
/// </summary>
namespace OP2_Project_Group_AB5_
{
    /// <summary>
    /// Handles the invalid value exception
    /// </summary>
    class InvalidValueException :Exception
    {
        public InvalidValueException(string message) :base (message)
        {

        }
    }
}
