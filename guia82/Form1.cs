using guia82.Models;
using guia82.Models.Exportadores;
using System.Windows.Forms;

namespace guia82
{
    public partial class Form1 : Form
    {

        List<IExportable> multas = new List<IExportable>();
        ExportadorFactory factory = new ExportadorFactory();
        OpenFileDialog ofd = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            IExportable nuevo = null;

            string patente = tbPatente.Text;
            DateOnly venc = new DateOnly(dtpVencimiento.Value.Year, dtpVencimiento.Value.Month, dtpVencimiento.Value.Day);
            double imp = Convert.ToDouble(tbImporte.Text);

            nuevo = new Multa(patente, venc, imp);

            multas.Sort();
            int idx = multas.BinarySearch(nuevo);

            if (idx >= 0)
            {
                Multa? multa = multas[idx] as Multa;

                multa.Importe += imp;

                if (multa.Vencimiento < ((Multa)nuevo).Vencimiento)
                {
                    multa.Vencimiento = ((Multa)nuevo).Vencimiento;
                }
            }
            else
            {
                multas.Add(nuevo);
            }
            button1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (IExportable m in multas)
            {
                listBox1.Items.Add(m.ToString());
            }
        }

        private void tbVencimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ofd.Filter = "(csv)|*.csv|(json)|*.json|(txt)|*.txt|(xml)|*.xml";

            if (ofd.ShowDialog()== DialogResult.OK)
            {
                string path = ofd.FileName;
                int tipo = ofd.FilterIndex;

                IExportador exportador = factory.GetInstance(tipo);
                FileStream fs = null;
                StreamReader sr = null;

                try
                {
                    fs = new FileStream(path,FileMode.Open,FileAccess.Read);
                    sr = new StreamReader(fs);

                    sr.ReadLine();

                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        IExportable nuevo = new Multa();
                        if (nuevo.Importar(linea, exportador) == true)
                        {
                            int idx = multas.BinarySearch(nuevo);
                            if (idx >= 0)
                            {
                                Multa multa = multas[idx] as Multa;
                                multa.Importe += ((Multa)nuevo).Importe;
                                if (multa.Vencimiento < ((Multa)nuevo).Vencimiento) ;
                                multa.Vencimiento = ((Multa)nuevo).Vencimiento;
                            }
                            else
                            {
                                multas.Add(nuevo);
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sr != null)
                        sr.Close();
                    if (fs != null)
                        fs.Close();
                }

            }

            button1.PerformClick();

        }
    }
}
