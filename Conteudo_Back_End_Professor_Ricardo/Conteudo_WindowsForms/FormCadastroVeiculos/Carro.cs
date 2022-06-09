using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCadastroVeiculos
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
        public int portas;

        public Carro(string modelo, string fabricante, bool ar, bool dh, bool abs, bool airbag, bool ve, int portas)
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

        public void MostrarDadosCarro()
        {
            MessageBox.Show("Carro: " + this.modelo + "\nFabricante: " + this.fabricante + "\nDH: " + this.dh + "\nAr: " + this.ar + "\nABS: " + this.abs + "\nAir bag: " + this.airbag + "\nVidros eletrico: " + this.ve + "\nPortas: " + this.portas);
        }
    }
}
