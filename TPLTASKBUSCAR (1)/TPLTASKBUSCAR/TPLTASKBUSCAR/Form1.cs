using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPLTASKBUSCAR
{
    public partial class Form1 : Form
    {
        string hola = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!chkCountry.Checked && !chkEmail.Checked && !chkFirst.Checked && !chkid.Checked && !chkIP.Checked && !chkLast.Checked)
            {
                txtResult.Text = "ERROR: Selecciona un campo mínimo";
            }
            else {
                List<Task<string>> tasks = new List<Task<string>>();
                List<string> results = new List<string>();
  

                if (chkCountry.Checked)
                {
                    tasks.Add( new Task<string>(() => trolo.buscar(txtbuscar.Text, 4)));
                    tasks[tasks.Count-1].Start();
                }
                if (chkEmail.Checked) {
                    tasks.Add( new Task<string>(() => trolo.buscar(txtbuscar.Text, 3)));
                    tasks[tasks.Count - 1].Start();
                }
                if (chkFirst.Checked)
                {
                    tasks.Add( new Task<string>(() => trolo.buscar(txtbuscar.Text, 1)));
                    tasks[tasks.Count - 1].Start();
                }
                if (chkid.Checked)
                {
                    tasks.Add( new Task<string>(() => trolo.buscar(txtbuscar.Text, 0)));
                    tasks[tasks.Count - 1].Start();
               
                }
                if (chkIP.Checked)
                {
                   tasks.Add( new Task<string>(() => trolo.buscar(txtbuscar.Text, 5)));
                    tasks[tasks.Count - 1].Start();
                }
                if (chkLast.Checked)
                {
                    tasks.Add( new Task<string>(() => trolo.buscar(txtbuscar.Text, 2)));
                    tasks[tasks.Count - 1].Start();
                }
                
                results.AddRange(tasks.Select(task => task.Result));

                if (results.Any(result => check(result))) { 

                    txtResult.Text = string.Join(Environment.NewLine, results.Where(result => !string.IsNullOrEmpty(result))) ;
                }
                else
                {
                    txtResult.Text = "No Encontrado!";
                }
            }

        }
        private bool check(string check) {
            if (!check.Equals(""))
            {
                hola = check;
                return true;
            }
            else {

                return false;
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
