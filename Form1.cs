namespace BasitNotDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                MessageBox.Show("Dosya baþarýyla kaydedildi.");
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string icerik = System.IO.File.ReadAllText(openFileDialog1.FileName);
                textBox1.Text = icerik;
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void çýkýþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
