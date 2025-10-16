using guia82.Models;

namespace guia82
{
    public partial class Form1 : Form
    {

        List<IExportable> multas = new List<IExportable>();
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
    }
}
