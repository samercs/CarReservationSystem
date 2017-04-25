using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReservationSystem.Code.Enum
{
    public enum Providers
    {
        SqlServer,
        OleDb,
        Oracle,
        ODBC,
        ConfigDefined,
        MySql
    }

    public enum ConnectionState
    {
        KeepOpen,
        CloseOnExit
    }

    public enum MovieType
    {
        Action = 1,
        Comday = 2,
        Horror = 3,
        Drama = 4
    }
}
