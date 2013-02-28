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
            select_pri_customer.IsChecked = true;
            this.textbox_bus_address.IsEnabled = false;
            this.textbox_bus_phone.IsEnabled = false;
            this.textbox_bus_seno.IsEnabled = false;
            this.textbox_bus_fax.IsEnabled = false;
            this.textbox_bus_contact.IsEnabled = false;
            this.textbox_bus_company.IsEnabled = false;

            this.textbox_pri_address.IsEnabled = true;
            this.textbox_pri_phone.IsEnabled = true;
            this.textbox_pri_name.IsEnabled = true;
            this.textbox_pri_age.IsEnabled = true;
            this.textbox_pri_sex.IsEnabled = true;
		}

        private void select_pri_customer_Checked(object sender, RoutedEventArgs e)
        {
            this.textbox_bus_address.IsEnabled = false;
            this.textbox_bus_phone.IsEnabled = false;
            this.textbox_bus_seno.IsEnabled = false;
            this.textbox_bus_fax.IsEnabled = false;
            this.textbox_bus_contact.IsEnabled = false;
            this.textbox_bus_company.IsEnabled = false;

            this.textbox_pri_address.IsEnabled = true;
            this.textbox_pri_phone.IsEnabled = true;
            this.textbox_pri_name.IsEnabled = true;
            this.textbox_pri_age.IsEnabled = true;
            this.textbox_pri_sex.IsEnabled = true;
        }
        private void select_bus_customer_Checked(object sender, RoutedEventArgs e)
        {
            this.textbox_bus_address.IsEnabled = true;
            this.textbox_bus_phone.IsEnabled = true;
            this.textbox_bus_seno.IsEnabled = true;
            this.textbox_bus_fax.IsEnabled = true;
            this.textbox_bus_contact.IsEnabled = true;
            this.textbox_bus_company.IsEnabled = true;

            this.textbox_pri_address.IsEnabled = false;
            this.textbox_pri_phone.IsEnabled = false;
            this.textbox_pri_name.IsEnabled = false;
            this.textbox_pri_age.IsEnabled = false;
            this.textbox_pri_sex.IsEnabled = false;
        }

        
        private void select_veh_car_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void select_veh_truck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void select_cont_sale_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void select_cont_lease_Checked(object sender, RoutedEventArgs e)
        {

        }

        
        
	}
}