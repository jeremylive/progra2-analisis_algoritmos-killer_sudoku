using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        //Constructor
        public Form1()
        {
            InitializeComponent();
        }

        //Variables
        private int contador = 0;
        private int filas = 0;
        private DataTable table2 = new DataTable();


        //Metodos///////////////////////////////////////////////////


        public DataTable getTable()
        {
            return this.table2;
        }

        public void setFilas(String pFilas)
        {
            filas = Convert.ToInt32(pFilas);
        }

        public int getFilas()
        {
            return this.filas;
        }

        public void obtengoDatos()
        {
            setFilas(filaColum.Text);
        }

        public void setColumTable(int param)
        {
            table.ColumnCount = param;
        }

        public void llenarColumName()
        {
            //
            int largo = getFilas();
            //
            for (int i=0;i<largo;i++)
            {
                //table.Columns.Add("/", typeof(int));
                table.Columns[i].Name = "/";
            }
            
        }

        public void llenarConCeros()
        {
            obtengoDatos();
            int largo = getFilas();
            setColumTable(largo);
            llenarColumName();
            //
            for (int i = 0; i < largo; i++)
            {
                if (largo == 2)
                {
                    table.Rows.Add("0", "0");
                }
                else if (largo == 3)
                {
                    table.Rows.Add("0", "0", "0");
                }else if (largo == 4)
                {
                    table.Rows.Add("0", "0", "0", "0");
                }
                else if (largo == 5)
                {
                    table.Rows.Add("0", "0", "0", "0", "0");
                }
                else if (largo == 6)
                {
                    table.Rows.Add("0", "0", "0", "0", "0", "0");
                }
                else if (largo == 7)
                {
                    table.Rows.Add("0", "0", "0", "0", "0", "0", "0");
                }
                else if (largo == 8)
                {
                    table.Rows.Add("0", "0", "0", "0", "0", "0", "0", "0");
                }
                else if (largo == 9)
                {
                    table.Rows.Add("0", "0", "0", "0", "0", "0", "0", "0", "0");
                }
                else if (largo == 10)
                {
                    table.Rows.Add("0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
                }
                else if (largo == 11)
                {
                    table.Rows.Add("0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
                }
                else if (largo == 12)
                {
                    table.Rows.Add("0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
                }
                else if (largo == 13)
                {
                    table.Rows.Add("0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
                }
                else if (largo == 14)
                {
                    table.Rows.Add("0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
                }
                else if (largo == 15)
                {
                    table.Rows.Add("0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
                }
                else if (largo == 16)
                {
                    table.Rows.Add("0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
                }
                else if (largo == 17)
                {
                    table.Rows.Add("0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
                }
                else if (largo == 18)
                {
                    table.Rows.Add("0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
                }
                else if (largo == 19)
                {
                    table.Rows.Add("0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
                }

            }
            
        }

        public void vaciarTabla()
        {
            table.Rows.Clear();
            table.Refresh();
        }

        /**
         * 
         * 
         * 
         * 
         **/

        private int[,,] biblioteca_tetris = new int[100,5,2];
        
        //obtiene coordenadas(vectores) de la figura tetris 
        public int[] getBibliotecaTetris(int tipo_figura, int pos_figura)
        {
            int[] pReturn = new int[5];

            return pReturn;
        }

        //Meto tetris a la matriz
        public void setTetris()
        {
            int largo = getFilas();

            //


        }

        public void generoBibliotecaTetris()
        {
            setTetris();
        }

        public void generoSudoku()
        {
            //Generar gridDataView con ceros
            llenarConCeros();

            //tetris


        }

        /**
         * 
         * 
         * 
         * 
         **/

        public int[][] sudoku_matriz;
        private int[] randomPosibleFilas;
        private int[] randomPosibleColumns;

        public int getRadomPosible()
        {
            int largo = getFilas();
            int largo_filaRand = getRanFilas().Length;
            int largo_columRand = getRanColumns().Length;
            int result = 0;
            Random rand = new Random();
            int pfila = 0;
            int pcolumna = 0;
            Boolean repetido = true;

            for (int i = 0; i < largo; i++)
            {
                //Obtengo numero
                do
                {
                    pfila = getRandFilas(rand.Next(0, largo_filaRand));

                    if (pfila == getRandColumns(rand.Next(0, largo_columRand)))
                    {
                        repetido = false;
                    }
                } while (repetido);

                //Coloco numero
                //setSudokuMatriz();

                //Borro numero


            }

            return result;
        }

        //......................................................................loading....................
        public void deleteRandFila(int celda)
        {

        }

        public void deleteRandColumn(int celda)
        {
            
        }

        public int getRandFilas(int i)
        {
            return this.randomPosibleFilas[i];
        }

        public int getRandColumns(int i)
        {
            return this.randomPosibleColumns[i];
        }

        public int[] getRanFilas()
        {
            return this.randomPosibleFilas;
        }

        public int[] getRanColumns()
        {
            return this.randomPosibleColumns;
        }

        public void setRandomsPosibleFilasColumns()
        {
            this.randomPosibleFilas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            this.randomPosibleColumns = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        public void setSudokuMatriz(int largo)
        {
            this.sudoku_matriz = new int[largo][];
        }

        public void setSudokuCelda (int num, int i, int j)
        {
            this.sudoku_matriz[i][j] = num;
        }



        //Lleno de sudoku con numeros siguiendo las dos reglas
        public void fullSudoku()
        {
            //Inicializo y lleno de ceros la matriz
            int largo = getFilas();
            setSudokuMatriz(largo);
            setRandomsPosibleFilasColumns();

            for (int i=0;i<largo;i++)
            {
                for (int j = 0; i < largo; i++)
                {
                    sudoku_matriz[i][j] = 0;
                }
            }

            //Lleno de # la matriz
            for (int i = 0; i < largo; i++)
            {
                for (int j = 0; i < largo; i++)
                {
                    //random posibles


                    if (true)
                    {

                    }

                    sudoku_matriz[i][j] = 0;
                }
            }


        }




        /**
         * 
         * 
         * 
         * 
         **/



        public void generoTabla()
        {
            int f = getFilas();
            for (int i = 0; i < f; i++)
            {
                table.ColumnCount = f;
                table.Columns[contador].Name = "/";
                contador++;

            }
        }

        public void puncheoDatos()
        {
            DataTable table = new DataTable();

            for (int i = 0; i < filas; i++)
            {
                table.Columns.Add("0", typeof(int));
            }

            for (int i = 0; i < filas; i++)
            {

                table.Rows.Add("0", "0", "0", "0", "0", "0");
            }


            this.table.DataSource = table;

            //colorearhttps://www.youtube.com/watch?v=blx4DL9j39U&list=PLFDH5bKmoNqyDKntkVv-NURTAlPIhMPqA&index=25

        }

        /**
         * 
         * 
         * 
         * 
         **/

        //CodigoDeInterface///////////////////////////////////////////

        private void button1_Click(object sender, EventArgs e)
        {
            //Genero sudoku
            generoSudoku();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            //puncheoDatos();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            vaciarTabla();
        }
    }
}
