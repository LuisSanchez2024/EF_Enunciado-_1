using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Enunciado_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtingresararray_Click(object sender, EventArgs e)
        {
            
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            // Verifica que el TextBox no esté vacío
            if (!string.IsNullOrWhiteSpace(txtarray.Text))
            {
                // Limpia el ListBox antes de agregar nuevos elementos
                listBox1.Items.Clear();

                // Recorre cada carácter del texto y agrégalo al ListBox
                foreach (char c in txtarray.Text)
                {
                    listBox1.Items.Add(c.ToString());
                }

                // Limpia el TextBox después de agregar el texto al ListBox
                txtarray.Clear();
            }
            else
            {
                // Opcional: Muestra un mensaje si el TextBox está vacío
                MessageBox.Show("Por favor, ingrese un texto antes de agregarlo a la lista.");
            }

        }

        private void btndesordenar_Click(object sender, EventArgs e)
        {
            // Verifica que el ListBox no esté vacío
            if (listBox1.Items.Count > 0)
            {
                // Copia los elementos del ListBox a una lista
                List<object> items = listBox1.Items.Cast<object>().ToList();

                // Desordena la lista usando el método OrderBy con un número aleatorio
                Random rng = new Random();
                var shuffledItems = items.OrderBy(x => rng.Next()).ToList();

                // Limpia el ListBox y agrega los elementos desordenados
                listBox1.Items.Clear();
                foreach (var item in shuffledItems)
                {
                    listBox1.Items.Add(item);
                }
            }
            else
            {
                // Opcional: Muestra un mensaje si el ListBox está vacío
                MessageBox.Show("La lista está vacía. Agregue elementos antes de desordenar.");
            }
        }

        private void btnordenar_Click(object sender, EventArgs e)
        {
            // Verifica que el ListBox no esté vacío
            if (listBox1.Items.Count > 0)
            {
                // Ordena los elementos del ListBox en orden ascendente
                var sortedItems = listBox1.Items.Cast<string>().OrderBy(item => item).ToList();

                // Limpia el ListBox y agrega los elementos ordenados
                listBox1.Items.Clear();
                foreach (var item in sortedItems)
                {
                    listBox1.Items.Add(item);
                }
            }
            else
            {
                // Opcional: Muestra un mensaje si el ListBox está vacío
                MessageBox.Show("La lista está vacía. Agregue elementos antes de ordenar.");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtarray.Clear();
            listBox1.Items.Clear();
        }
    }
}
