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

namespace TreeView_Test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private class Data
        {
            public object Content { get; set; }

            public List<Data> Items { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
            var listi = treeView.Items;
            var nels = listi.Count;

            Test(null, null);
        }

        public void Test(object sender, EventArgs e)
        {

            List<Data> x = new List<Data>()
            {
                new Data()
                {
                    Content = "123",
                    Items = new List<Data>()
                    {
                        new Data()
                        {
                            Content = "wwww"
                        }
                    }

                },

                new Data()
                {
                    Content = "123456"
                },

                new Data()
                {
                    Content = "qqqq"
                },

                new Data()
                {
                    Content = "qqqq2qq"
                },

                new Data()
                {
                    Content = "qq"
                },

            };

            List<Data> y = new List<Data>();

            for (int i = 0; i < 5; i++)
            {
                var sdfsd = x[i].Content.ToString().Length;
                if(sdfsd > 5)
                {
                    x.Add(x[i]);
                }

            }

            treeView.ItemsSource = x;
        }
    }
}
