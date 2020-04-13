using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;using Entity;using BLL;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmPrincipal : Form
    {
        
        public FrmPrincipal()
        {
            InitializeComponent();
            TxtID.Focus();
            label6.Text = "0.0";
            GrillaConsultar.DataSource = PersonaService.Consutar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            Persona persona = MapearPersona();
            string mensaje = PersonaService.Guardar(persona);
            MessageBox.Show(mensaje, "Mensaje de Guardado");
            Limpiar();
            
            Muestra();
        }
        void Muestra()
        {
            GrillaConsultar.DataSource = null;
            GrillaConsultar.DataSource = PersonaService.Consutar();
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            if (TxtID.Text != "")
            {
                Persona persona = PersonaService.Buscar(TxtID.Text);

                if (persona != null)
                {
                    TxtID.Text = persona.Identificacon;
                    TxtNombre.Text = persona.Nombre;
                    TxtEdad.Text = persona.Edad.ToString();
                    label6.Text = persona.Pulsacion.ToString();
                    comboBox1.Text = persona.Sexo;
                }
                else
                {
                    MessageBox.Show($"La persona con la identificación {TxtID.Text} no se encuentra registrada");
                }

            }
            else
            {
                MessageBox.Show("Por favor digite una identificación");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Muestra();
        }

        private void bttCalcular_Click(object sender, EventArgs e)
        {
            Persona persona = MapearPersona();
            label6.Text = persona.Pulsacion.ToString();

        }
        private void Limpiar()
        {
            TxtID.Text = "";
            TxtNombre.Text = "";
            TxtEdad.Text = "";
            label6.Text = "";
            comboBox1.Text = "";
        }
        private Persona MapearPersona()
        {
            Persona persona = new Persona();
            persona.Identificacon = TxtID.Text;
            persona.Nombre = TxtNombre.Text;
            persona.Edad = int.Parse(TxtEdad.Text);
            persona.Sexo = comboBox1.Text;
            return persona;

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = TxtID.Text;
            
            string mensaje = PersonaService.Eliminar(id);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Limpiar();
            Muestra();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }
    }
}
