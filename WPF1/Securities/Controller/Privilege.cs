using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPF1.Securities.Controller
{
    public class Privilege
    {
        public Privilege(Decimal Pscreenno,Int16 Padd, Int16 Pedit, Int16 Pdelete,Int16 Pview)
        {
            vscreen_no = Pscreenno;
            vpriv_add = Padd;
            vpriv_edit = Pedit;
            vpriv_delete = Pdelete;
            vpriv_view = Pview;
        }
        public Decimal vscreen_no { get; set; }
        public int vpriv_add { get; set; }
        public int vpriv_edit { get; set; }
        public int vpriv_delete { get; set; }
        public int vpriv_view { get; set; }
    }
}
