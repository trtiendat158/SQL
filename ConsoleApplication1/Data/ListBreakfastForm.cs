using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public partial class ListBreakfastForm : Form
    {
        public ListBreakfastForm()
        {
            InitializeComponent();
            this.Load += ListBreakfastForm_Load;
        }

        void ListBreakfastForm_Load(object sender, EventArgs e)
        {
            this.ShowBreakfastDishes();
        }
        private void ShowBreakfastDishes()
        {
            var db = new restaurantEntities();
            var list = db.Breakfasts.ToArray();
            this.grdBreakfast.DataSource = list;
        }
    }
}
