using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Music_Book_Index_Search
{
    /*
 * Retrieved From: http://stackoverflow.com/questions/31153664/how-can-i-detect-when-window-10-enters-tablet-mode-in-a-windows-forms-applicatio
 */
    public static class TabletPcSupport
    {
        static TabletPcSupport()
        {
            _isTabletPC = false; //(GetSystemMetrics(SM_TABLETPC) != 0);
        }

        public static bool SupportsTabletMode
        {
            get { return _isTabletPC; }
        }

        public static bool IsTabletMode
        {
            get
            {
                return QueryTabletMode() && SupportsTabletMode;
            }
        }

        //private static readonly int SM_CONVERTIBLESLATEMODE = 0x2003;
        //private static readonly int SM_TABLETPC = 0x56;

        private static bool _isTabletPC = false;
        
        //[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto, EntryPoint = "GetSystemMetrics")]
        //private static extern int GetSystemMetrics(int nIndex);

        private static bool QueryTabletMode()
        {
            int state = 0;//GetSystemMetrics(SM_CONVERTIBLESLATEMODE);
            return (state == 0);
        }
    }
}
