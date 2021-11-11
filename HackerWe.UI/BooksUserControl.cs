using CefSharp.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerWe.UI
{
    public partial class BooksUserControl : UserControl
    {
        private object dataGridView;

        public BooksUserControl()
        {
            InitializeComponent();
        }

        private void BooksUserControl_Load(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)JsonContent.DeserializeObject(JsonString, (typeof(DataTable)));
            dataGridView.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
