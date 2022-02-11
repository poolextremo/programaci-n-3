using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace practica_numero_1_progra_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        nombres misnombres = new nombres();
        class nombres
        {
            public string nombre { get; set; }
            public string edad { get; set; }

            public List<nombres> listanombres1 = new List<nombres>();

            public List<nombres> listanombres2 = new List<nombres>();

            public List<nombres> listanombres3 = new List<nombres>();
            public void limpiar()
            {
                listanombres1.Clear();
                listanombres2.Clear();
                listanombres3.Clear();
            }

            public void crearoriginal(string lol1, string lol2)
            {
                listanombres1.Add(new nombres { nombre = lol1, edad = lol2});
            }

            public void crearnombres2(string lol1, string lol2)
            {
                listanombres2.Add(new nombres { nombre = lol1, edad = lol2});
            }
            public void crearnombres3(string lol1, string lol2)
            {
                listanombres3.Add(new nombres { nombre = lol1, edad = lol2 });
            }
        }
        string[] edadxd = new string[1];
        string[] nombresxd = new string[1];
        string[] nombresxd1;
        string[] edadxd1;
        int contro = 1;
        int contro2 = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            misnombres.limpiar();
            original.ItemsSource = null;
            ordennombres.ItemsSource = null;
            ordenedades.ItemsSource = null;
            nombresxd[contro2] = nombre.Text;
            edadxd[contro2] = edad.Text;
            contro2++;
            contro++;
            nombresxd1 = new string[contro];
            edadxd1 = new string[contro];
            int x = 0;
            while (x < contro-1)
            {
                nombresxd1[x] = nombresxd[x];
                edadxd1[x] = edadxd[x];
                x++;
            }
            nombresxd = new string[contro];
            edadxd = new string[contro];
            x = 0;
            while (x < contro)
            {
                nombresxd[x] = nombresxd1[x];
                edadxd[x] = edadxd1[x];
                x++;
            }
            crealistas();
            nombre.Text = "";
            edad.Text = "";
        }
        void crealistas()
        {
            int x = 0;
            while (x < contro)
            {
                misnombres.crearoriginal(nombresxd[x], edadxd[x]);
                x++;
            }
            original.ItemsSource = misnombres.listanombres1;
            x = 0;
            if (contro > 2)
            {
                while (x < contro)
                {
                    int x2 = 0;
                    while (x2 < contro - 2)
                    {
                        //MessageBox.Show("" + nombresxd[x2][0]);
                        //MessageBox.Show("" + nombresxd[x2+1][0]);
                        if (nombresxd[x2][0] > nombresxd[x2+1][0])
                        {
                            string cambio = nombresxd[x2];
                            string cambio2 = edadxd[x2];
                            nombresxd[x2] = nombresxd[x2 + 1];
                            edadxd[x2] = edadxd[x2 + 1];
                            nombresxd[x2 + 1] = cambio;
                            edadxd[x2 + 1] = cambio2;
                        }
                        x2++;
                    }
                    x++;
                }
                x = 0;
                while (x < contro)
                {
                    misnombres.crearnombres2(nombresxd[x], edadxd[x]);
                    x++;
                }
            }                        
            ordennombres.ItemsSource = misnombres.listanombres2;
            x = 0;
            if (contro > 2)
            {
                while (x < contro)
                {
                    int x2 = 0;
                    while (x2 < contro - 2)
                    {
                        //MessageBox.Show("" + nombresxd[x2][0]);
                        //MessageBox.Show("" + nombresxd[x2+1][0]);
                        int num1 = int.Parse(edadxd[x2]);
                        int num2 = int.Parse(edadxd[x2+1]);
                        if (num1 > num2)
                        {
                            string cambio = nombresxd[x2];
                            string cambio2 = edadxd[x2];
                            nombresxd[x2] = nombresxd[x2 + 1];
                            edadxd[x2] = edadxd[x2 + 1];
                            nombresxd[x2 + 1] = cambio;
                            edadxd[x2 + 1] = cambio2;
                        }
                        x2++;
                    }
                    x++;
                }
                x = 0;
                while (x < contro)
                {
                    misnombres.crearnombres3(nombresxd[x], edadxd[x]);
                    x++;
                }
                ordenedades.ItemsSource = misnombres.listanombres3;
            }
        }
    }
}
