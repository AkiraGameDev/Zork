using System;
using System.Diagnostics;

namespace Zork
{
    public static class Assert
    {
        [Conditional("DEBUG")]
        public static void IsTrue(bool expresison, string message = null)
        {
            if(!expresison)
            {
                throw new Exception(message);
            }
        }
    }
}