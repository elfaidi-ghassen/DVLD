using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_UI.Debug
{
    public class CustomAssert
    {
        public static void That(bool condition, string message)
        {
            if (!condition)
            {
                throw new Exception("Assert failed: " + message);
            }
        }

        public static void ShowUserInputForm(Exception e, int userId)
        {
            new AssertUserInputForm(e, userId).ShowDialog();
        }
    }


}
