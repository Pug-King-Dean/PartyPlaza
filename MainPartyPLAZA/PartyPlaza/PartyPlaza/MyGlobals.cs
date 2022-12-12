using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlaza
{
    internal class MyGlobals
    {
        public static bool frmClosing = false, frmEditForm = false, frmAddForm = false;
        public static int selectedCustNo, selectedSupplierNo;

        public static bool frmAddSupplier = false, frmEditSupplier = false, btnDisplayExit = false,
            frmSupplier = false, frmMain = false, frmOrder = false;
    }
}
