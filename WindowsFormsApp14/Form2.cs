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
    public partial class Form2 : Form
    {
      public static User user = new User();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
           
            user.Name = textBox1.Text;
            user.Surname = textBox2.Text;
            user.Age =textBox3.Text;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            Close();
        }
    }
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
    }

}
