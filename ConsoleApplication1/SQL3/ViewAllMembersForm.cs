using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL3
{
    public partial class ViewAllMembersForm : Form
    {
        public ViewAllMembersForm()
        {
            InitializeComponent();
            this.Load += ViewAllMembersForm_Load;
        }

        void ViewAllMembersForm_Load(object sender, EventArgs e)
        {
            this.ViewAllMembers();
        }

        private void ViewAllMembers()
        {
            var db = new oopcsEntities1();
            var members = db.Members.ToArray();
            var memberViews = new MembersView[members.Length];
            for (int i = 0; i < members.Length; i++ )
            {
                memberViews[i] = new MembersView(members[i]);
            }
                this.grdMembers.DataSource = memberViews;
            //asdusadhsadfhsdfsdfsd
               
        }
    }
}
