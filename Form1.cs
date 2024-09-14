using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cnv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(130, 197, 121);
            button1.BackColor = Color.FromArgb(182, 221, 177);
            button1.FlatAppearance.BorderSize = 0;
            textBox1.BackColor = Color.FromArgb(234, 245, 232);
            textBox2.BackColor = Color.FromArgb(234, 245, 232);
            textBox1.BorderStyle = BorderStyle.None;
            textBox2.BorderStyle = BorderStyle.None;
            unit.BackColor = Color.FromArgb(182, 221, 177);
            metru1.BackColor = Color.FromArgb(182, 221, 177);
            metru2.BackColor = Color.FromArgb(182, 221, 177);
            unit.FlatStyle = FlatStyle.Flat;
            metru1.FlatStyle = FlatStyle.Flat;
            metru2.FlatStyle = FlatStyle.Flat;
        }

       //-----------------GLOBALE-------------------//
        string[] len = { "Millimeter (mm)", 
                        "Centimeter (cm)", 
                        "Decimeter (dm)", 
                        "Meter (m)", 
                        "Decameter (dam)",
                        "Hectometer (hm)", 
                        "Kilometer (km)" };

        string[] wei = { "Milligram (mg)",
                        "Centigram (cg)", 
                        "Decigram (dg)",
                        "Gram (g)", 
                        "Decagram (dag)", 
                        "Hectogram (hg)", 
                        "Kilogram (kg)" };

        string[] vol= { "Milliliter (mL)",
                        "Centiliter (cL)", 
                        "Deciliter (dL)", 
                        "Liter (L)", 
                        "Decaliter (daL)", 
                        "Hectoliter (hL)",
                        "Kiloliter (kL)"};


        //-------------------------------------------//
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            int p = 1;
            if (unit.Text == "Length" || unit.Text == "Weight" || unit.Text == "Volume")
            {
                

                if (metru1.SelectedIndex < metru2.SelectedIndex)
                {
                    int z = metru1.SelectedIndex;
                    while (metru1.SelectedIndex < metru2.SelectedIndex) {
                        p *= 10;
                        metru1.SelectedIndex++;
                    }
                    metru1.Text = metru1.Items[z].ToString();
                    float a = float.Parse(textBox1.Text);
                    float b = a / p ;
                    textBox2.Text = b.ToString();
                }
                else
                {
                    while (metru1.SelectedIndex > metru2.SelectedIndex)
                    {
                        p *= 10;
                        metru1.SelectedIndex--;
                    }
                    float a = int.Parse(textBox1.Text);
                    float b = a / p;
                    textBox2.Text = b.ToString();
                }

            }

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void metru1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void metru2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unit.Text == "Length")
            {
                metru1.Items.Clear();
                metru2.Items.Clear();
                metru1.Text = null;
                metru2.Text = null;
                for (int i = 0; i< len.Length; i++)
                {
                    metru1.Items.Add(len[i]);
                    metru2.Items.Add(len[i]);
                }
            }
            if (unit.Text == "Weight")
            {
                metru1.Items.Clear();
                metru2.Items.Clear();
                metru1.Text = null;
                metru2.Text = null;
                for (int i = 0; i < wei.Length; i++)
                {
                    metru1.Items.Add(wei[i]);
                    metru2.Items.Add(wei[i]);
                }
            }
            if (unit.Text == "Volume")
            {
                metru1.Items.Clear();
                metru2.Items.Clear();
                metru1.Text = null;
                metru2.Text = null;
                for (int i = 0; i < vol.Length; i++)
                {
                    metru1.Items.Add(vol[i]);
                    metru2.Items.Add(vol[i]);
                }
            }
        }
    }
}
