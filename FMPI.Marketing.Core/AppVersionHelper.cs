using System;

namespace FMPI.Marketing.Core
{
    public class AppVersionHelper
    {
        public const string Version = "1.0.0.0";

        public static DateTime ReleaseDate
        {
            get { return new DateTime(2019, 08, 01);}
        }
    }
}
