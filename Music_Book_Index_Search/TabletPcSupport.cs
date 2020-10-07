using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            inspectTabletSupport();
        }

        public static bool SupportsTabletMode { get; private set; }

        public static bool IsTabletMode
        {
            get
            {
                if (SupportsTabletMode)
                {
                    inspectTabletMode();
                }
                return SupportsTabletMode && _isInTabletMode;
            }
        }
        
        private static bool _isInTabletMode = false;

        [Conditional("DEBUG"), Conditional("RELEASE")]
        private static void inspectTabletSupport()
        {
            SupportsTabletMode = (GetSystemMetrics(SM_TABLETPC) != 0);
        }

        [Conditional("DEBUG"), Conditional("RELEASE")]
        private static void inspectTabletMode()
        {
            int state = GetSystemMetrics(SM_CONVERTIBLESLATEMODE);
            _isInTabletMode = (state == 0);
        }

        private static readonly int SM_CONVERTIBLESLATEMODE = 0x2003;
        private static readonly int SM_TABLETPC = 0x56;

#if (!Linux)
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto, EntryPoint = "GetSystemMetrics")]
        private static extern int GetSystemMetrics(int nIndex);
#endif
    }
}
