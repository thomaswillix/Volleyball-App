using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form1 : Form
    {
        int[] numericos = { 12, 11, 25, 26, 23, 6, 24, 2, 423, 123, 1, 43, 14, 3434, 232, 4, 34, 34, 62, 9 };
        public Form1()
        {
            InitializeComponent();
        }

        private int[] rellenarArray()
        {
            int i;
            for (i = 0; i < numericos.Length; i++)
            {
                var random = new Random();
                numericos[i] = random.Next();
            }
            return numericos;
        }
        private int[] rellenarArrayManual()
        {
            int[] numericos = {12,11,25,26,23,6,24,2,423,123,1,43,14,3434,232,4,34,34,62,9};
            return numericos;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cadena = textBox1.Text;
            if (comprobar(cadena))
            {
                MessageBox.Show("El número sí está");
            }
            else
            {
                MessageBox.Show("El número no está");
            }
        }
        private bool comprobar(String numero)
        {
            int num = Int32.Parse(numero);
            for (int i = 0; i < rellenarArrayManual().Length; i++)
            {
                if (num == rellenarArrayManual()[i])
                {
                    return true;
                }        
            }
            return false;
        }

        private void suma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El resultado de la suma es: " + sumaNumeros(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
        }
        
        private int sumaNumeros(String s)
        {
            int cont = 0;
            String[] numeros = s.Split(' ');
            int[] nums = new int [2];
            int result = 0;
            try
            {
                foreach (String num in numeros)
                {
                    nums[cont] = Int32.Parse(num);
                    cont++;
                }
            } catch (Exception e)
            {
                MessageBox.Show(" Solo se admiten hasta "+ cont +" números en la suma");
                return result;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i];
            }
            return result;
        }

        private void lista_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La lista de números mayores que 20 del Array es: " +mostrarLista());
        }
        private String mostrarLista()
        {
            String s = "";
            for (int i = 0; i < numericos.Length; i++)
            {
                if (numericos[i]>=20)
                {
                    s += numericos[i] + " ";
                }
            }
            return s;
        }

        private void ordenar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La lista ordenada de los números es: ", ordenarLista());
        }
        private String ordenarLista()
        {
            Array.Sort(numericos);
            String s = "";
            for (int i = 0; i < numericos.Length; i++)
            {
                s += numericos[i] + " ";
            }
            return s;
        }
    }
}
