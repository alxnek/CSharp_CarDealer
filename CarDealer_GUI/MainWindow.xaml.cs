using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CarDealer_GUI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			this.InitializeComponent();
            
			// Insert code required on object creation below this point.
		}

        private void select_pri_customer(object sender, RoutedEventArgs e)
        {
            /*use an if statement and visibility statement to control hiding of textboxes 
             * http://stackoverflow.com/questions/10340342/loading-different-user-control-based-on-radio-button-selection-using-xaml
             */ 
        }

        private void select_bus_customer(object sender, RoutedEventArgs e)
        {

        }

        private void select_veh_car(object sender, RoutedEventArgs e)
        {

        }

        private void select_veh_truck(object sender, RoutedEventArgs e)
        {

        }

        private void select_cont_sale(object sender, RoutedEventArgs e)
        {

        }

        private void select_cont_lease(object sender, RoutedEventArgs e)
        {

        }
             
	}
}