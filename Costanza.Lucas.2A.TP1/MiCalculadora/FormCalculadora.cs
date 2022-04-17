using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {lblResultado.Text}\n");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            txtNumero1.Text = " ";
            txtNumero2.Text = " ";
            lblResultado.Text = "0";
            cmbOperador.Text = " ";
            lstOperaciones.Text = " ";
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes) e.Cancel = false;
            else e.Cancel = true;
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Limpiar()
        {
            txtNumero1.Text = " ";
            txtNumero2.Text = " ";
            lblResultado.Text = "0";
            cmbOperador.Text = " ";
            lstOperaciones.Text = " ";
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;

            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);

            resultado = Calculadora.Operar(operando1, operando2, char.Parse(operador));

            return resultado;
        }

        private void lstOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOperaciones.Text = $"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2} = {lblResultado}\n";
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando operandoDecimal = new Operando();
            lblResultado.Text = operandoDecimal.BinarioDecimal(lblResultado.Text);
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando operandoBinario = new Operando();
            lblResultado.Text = operandoBinario.BinarioDecimal(lblResultado.Text);
        }
    }
}
