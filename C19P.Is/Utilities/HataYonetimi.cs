using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.Is.Utilities
{
    public static class HataYonetimi
    {
        public static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
