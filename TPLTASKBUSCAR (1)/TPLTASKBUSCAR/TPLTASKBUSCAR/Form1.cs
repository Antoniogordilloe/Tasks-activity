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
        string results = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            txtResult.Text = "";
            results = "";
            if (!chkCountry.Checked && !chkEmail.Checked && !chkFirst.Checked && !chkid.Checked && !chkIP.Checked && !chkLast.Checked)
            {
                txtResult.Text = "ERROR: Selecciona un campo mínimo";
            }
            else {
                List<Task<string>> tasks = new List<Task<string>>();
                int contador = 0;
                bool encontrado = false;

                if (chkCountry.Checked)
                {
                    tasks.Add( new Task<string>(() => trolo.buscar(txtbuscar.Text, 4)));
                    tasks[tasks.Count-1].Start();
                    contador++;
                }
                if (chkEmail.Checked) {
                    tasks.Add( new Task<string>(() => trolo.buscar(txtbuscar.Text, 3)));
                    tasks[tasks.Count - 1].Start();
                    contador++;
                }
                if (chkFirst.Checked)
                {
                    tasks.Add( new Task<string>(() => trolo.buscar(txtbuscar.Text, 1)));
                    tasks[tasks.Count - 1].Start();
                    contador++;
                }
                if (chkid.Checked)
                {
                    tasks.Add( new Task<string>(() => trolo.buscar(txtbuscar.Text, 0)));
                    tasks[tasks.Count - 1].Start();
                    contador++;
                }
                if (chkIP.Checked)
                {
                   tasks.Add( new Task<string>(() => trolo.buscar(txtbuscar.Text, 5)));
                    tasks[tasks.Count - 1].Start();
                    contador++;
                }
                if (chkLast.Checked)
                {
         
                    tasks.Add( new Task<string>(() => trolo.buscar(txtbuscar.Text, 2)));
                    tasks[tasks.Count - 1].Start();
                    contador++;
                }

               
                do
                {
                    Task.WaitAll(tasks.ToArray());
                    results = results + tasks[contador - 1].Result + "\n"; 


                
                    contador--;
                } while (contador > 0 && !encontrado);

                if (results.Equals(""))
                {
                    txtResult.Text = "No Encontrado!";
                }
                else {
                    txtResult.Text = results;
                    
                }

                int[] countResults = new int[2];

                Task countEmailsEduTask = new Task(() => countEmailsEdu(results, countResults));
                Task countEmailsInfoTask = new Task(() => countEmailsInfo(results, countResults));
               
                countEmailsEduTask.Start();
                countEmailsInfoTask.Start();

                Task.WaitAll(countEmailsEduTask);
                Task.WaitAll(countEmailsInfoTask);

                eduCount.Text = "Emails check -> .edu Count: " +  countResults[0].ToString() + " .info Count: " + countResults[1].ToString();
            }

        }
        private bool check(string check) {
            if (!check.Equals(""))
            {
                results = check;
                return true;
            }
            else {

                return false;
            }
        }


        private void countEmailsEdu(string emails, int[] countResults)
        {
            for (int i = 0; i < emails.Length; i++)
            {
                if (emails[i] == '.')
                {
                    if (emails[i + 1] == 'e' && emails[i + 2] == 'd' && emails[i + 3] == 'u')
                    {
                        countResults[0]++;
                    }
                }
            }
          

        }

        private void countEmailsInfo(string emails, int[] countResults)
        {
          
            for (int i = 0; i < emails.Length; i++)
            {
                if (emails[i] == '.')
                {
                    if (emails[i + 1] == 'i' && emails[i + 2] == 'n' && emails[i + 3] == 'f' && emails[i + 4] == 'o')
                    {
                        countResults[1]++;
                    }
                }
            }

        }



    }
}
