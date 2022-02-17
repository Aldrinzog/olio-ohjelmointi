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

namespace Autolaskuri
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int henkilöAutot = 0;
        private int kuormaAutot = 0; 

        public MainWindow()
        {
            InitializeComponent();

            tbHenkilauto.Text = henkilöAutot.ToString();
            tbKuormaauto.Text = kuormaAutot.ToString();
        }

        private void  btnhenkilöauto_click(object, Sender, RuotedEventargs e)
        {
            henkilöAutot++;
            tbHenkilauto.Text = henkilöAutot.ToString();
        }

        private void btnkuormaAutot_clic(object, sender, ruotedEventargs e)
        {
            kuormaAutot++;
            tbKuormaauto.Text = kuormaAutot.ToString();
        }

    }
}
