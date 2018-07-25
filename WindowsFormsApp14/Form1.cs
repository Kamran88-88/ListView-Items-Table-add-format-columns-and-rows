using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        User user = new User();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Type us1 = user.GetType();
            listView1.Columns.Add("ID");
            foreach (var item in us1.GetProperties())
            {
                listView1.Columns.Add(item.Name);
               // listView1.Items.Add(item.GetValue(item));
            }
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            var list = new ListViewItem();

            ListViewItem viewItem = new ListViewItem("1");
            foreach (var item in Form2.user.GetType().GetProperties())
            {
                viewItem.SubItems.Add(item.GetValue(Form2.user).ToString());
            }

            listView1.Items.Add(viewItem);
        }
    }
}
