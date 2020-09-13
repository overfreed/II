using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int numberOfColumns = 4;
        int numberOfRows = 4;
        int widthOfCells = 30;
        int heightOfCells = 30;
        
        public Form1()
        {
            InitializeComponent();
            initOfDataGridView();
        }


        private void initOfDataGridView()
        {
            dataGridView1.ColumnCount = numberOfColumns;
            dataGridView1.RowCount = numberOfRows;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;

            for (int i = 0; i < numberOfColumns; i++)
            {
                dataGridView1.Columns[i].Width = widthOfCells;
            }

            for (int i = 0; i < numberOfRows; i++)
            {
                dataGridView1.Rows[i].Height = heightOfCells;
            }
        }


        private void buttonInit_Click(object sender, EventArgs e)
        {
            double[][] VectorsForEducation = new double[][]
                                                            {
                                                                new double[]{0,0,0,1,
                                                                             0,0,1,1,
                                                                             0,0,0,1,
                                                                             0,0,0,1},
                                                                new double[]{0,1,1,1,
                                                                             0,0,0,1,
                                                                             0,0,1,0,
                                                                             0,1,1,1},
                                                                new double[]{0,1,0,1,
                                                                             0,1,0,1,
                                                                             0,1,1,1,
                                                                             0,0,0,1} 
                                                            };


                                             
            //1,2,4
            double[][] VectorsForEducationAnswers = new double[][]
                                                            {
                                                                new double[]{ 1, 0, 0 },
                                                                new double[]{ 0, 1, 0 },
                                                                new double[]{ 0, 0, 1 } 
                                                            };


        




            Perceptron P = new Perceptron(VectorsForEducation, VectorsForEducationAnswers);  
      
        }

   

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if  (dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor == System.Drawing.Color.Black)
            dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = System.Drawing.Color.White;
            else
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = System.Drawing.Color.Black;

        }
    }
}
