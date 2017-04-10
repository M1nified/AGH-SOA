using System;

namespace Cave
{
    public partial class Cave : ICave
    {
        class LocationBusyException : Exception
        {
            public string PlayerName;
        }
    }
}
