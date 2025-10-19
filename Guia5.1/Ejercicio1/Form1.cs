using Ejercicio1.Models;
using System.Diagnostics;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            List<string> patentes = new List<string> 
            {
                "OXY333", "OYZ 013", "AAA 123", "BCD-456", "AB 123 CD", "YZ5432EF", "QW 3456 AB"
            };

            IProcesable procesable = null;

            if (rbString.Checked)
            {
                procesable = new StringProcesableImp();
            }
            else if (rbRegex.Checked)
            {
                procesable = new RegexProcesableImp();
            }
            else
            {
                MessageBox.Show("Seleccione alguna opción");
                return;
            }

            tbList.Clear();

            foreach (string patente in patentes)
            {
                string descripcion = procesable.Procesar(patente, out string patenteFormateada);

                tbList.Text += $"{patenteFormateada} {descripcion} \r\n";
            }
        }
    }
}
