using System.Windows.Forms;

namespace WinFormsAula
{
    class Carro
    {
        public string modelo { get; set; }
        public string fabricante { get; set; }
        public bool ar;
        public bool dh;
        public bool abs;
        public bool airbag;
        public bool ve;
        public int  portas;

        public Carro( string modelo, string fabricante, bool ar, bool dh, bool abs, bool airbag, bool ve, int portas)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.ar = ar;
            this.dh = dh;
            this.abs = abs;
            this.airbag = airbag;
            this.ve = ve;
            this.portas = portas;

        }

        public Carro( string modelo)
        {
            this.modelo = modelo;
        }


        public void MostrarDadosCarro()
        {
            MessageBox.Show("Carro " + this.modelo);
            MessageBox.Show("Fabricante " + this.fabricante);
            MessageBox.Show("DH " + this.dh);
            MessageBox.Show("Ar " + this.ar);
            MessageBox.Show("ABS " + this.abs);
            MessageBox.Show("Air bag " + this.airbag);
            MessageBox.Show("Vidros eletrico " + this.ve);
            MessageBox.Show("Portas " + this.portas);
        }
    }
}
