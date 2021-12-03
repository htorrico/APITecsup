using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTecsup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Person> people = new List<Person>();
            people.Add(new Person { PersonID = 1, LastName = "Torrico",
                FirstName = "Hugo" });
            people.Add(new Person { PersonID = 2, LastName = "Torrico2",
                FirstName = "Hugo2" });
            dataGridView1.DataSource = people;
        }
    }
}
