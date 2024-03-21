using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListDepa
{
    public partial class Form1 : Form
    {

        List<Departamento> departamentos = new List<Departamento>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Cargar_Departamento()
        {
            departamentos.Clear();
            string fileName = "Departamentos.txt";
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(stream))

                while (reader.Peek() > -1)
                {
                    Departamento departamento = new Departamento();
                    departamento.Id = Convert.ToInt32(reader.ReadLine());
                    departamento.Nombre = reader.ReadLine();
                    departamentos.Add(departamento);
                   
                }

        }

       /* private void Guardartemp(){
            FileStream 
            foreach (var item in collection){
            }
     }*/
    }
}
