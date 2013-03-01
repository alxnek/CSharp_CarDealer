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
using System.Windows.Controls.Primitives;
using CarDealerLibraries;

namespace CarDealer_GUI
{
    
    /// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        Contract data = new Contract();
		
        public MainWindow()
		{
            
			this.InitializeComponent();
			// Insert code required on object creation below this point.
            textbox_bus_address.IsEnabled = false;
            textbox_bus_phone.IsEnabled = false;
            textbox_bus_seno.IsEnabled = false;
            textbox_bus_fax.IsEnabled = false;
            textbox_bus_contact.IsEnabled = false;
            textbox_bus_company.IsEnabled = false;

            textbox_truck_model.IsEnabled = false;
            textbox_truck_colour.IsEnabled = false;
            textbox_truck_rent.IsEnabled = false;
            datepicker_truck_start.IsEnabled = false;
            datepicker_truck_end.IsEnabled = false;
		}

        private void select_pri_customer_clicked(object sender, RoutedEventArgs e)
        {
            textbox_bus_address.IsEnabled = false;
            textbox_bus_phone.IsEnabled = false;
            textbox_bus_seno.IsEnabled = false;
            textbox_bus_fax.IsEnabled = false;
            textbox_bus_contact.IsEnabled = false;
            textbox_bus_company.IsEnabled = false;

            textbox_pri_address.IsEnabled = true;
            textbox_pri_phone.IsEnabled = true;
            textbox_pri_name.IsEnabled = true;
            datepicker_pri_birth.IsEnabled = true;
            combo_pri_sex.IsEnabled = true;
        }
        private void select_bus_customer_clicked(object sender, RoutedEventArgs e)
        {
            textbox_bus_address.IsEnabled = true;
            textbox_bus_phone.IsEnabled = true;
            textbox_bus_seno.IsEnabled = true;
            textbox_bus_fax.IsEnabled = true;
            textbox_bus_contact.IsEnabled = true;
            textbox_bus_company.IsEnabled = true;

            textbox_pri_address.IsEnabled = false;
            textbox_pri_phone.IsEnabled = false;
            textbox_pri_name.IsEnabled = false;
            datepicker_pri_birth.IsEnabled = false;
            combo_pri_sex.IsEnabled = false;
        }

        private void select_veh_car_clicked(object sender, RoutedEventArgs e)
        {         
            textbox_truck_model.IsEnabled = false;
            textbox_truck_colour.IsEnabled = false;
            textbox_truck_rent.IsEnabled = false;
            datepicker_truck_start.IsEnabled = false;
            datepicker_truck_end.IsEnabled = false;

            textbox_car_model.IsEnabled = true;
            textbox_car_colour.IsEnabled = true;
            textbox_car_price.IsEnabled = true;
        }

        private void select_veh_truck_clicked(object sender, RoutedEventArgs e)
        {
            textbox_truck_model.IsEnabled = true;
            textbox_truck_colour.IsEnabled = true;
            textbox_truck_rent.IsEnabled = true;
            datepicker_truck_start.IsEnabled = true;
            datepicker_truck_end.IsEnabled = true;

            textbox_car_model.IsEnabled = false;
            textbox_car_colour.IsEnabled = false;
            textbox_car_price.IsEnabled = false;
        }

        private void button1_click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_click(object sender, RoutedEventArgs e)
        {
            if (select_pri_customer.IsChecked == true)
            {
                if (select_veh_car.IsChecked == true)
                {
                    //if (combo_veh_size = small)
                    //{

                    //}

                    //if (combo_veh_size = large)
                    //{

                    //}
                }

                if (select_veh_truck.IsChecked == true)
                {

                }

            }

            if (select_bus_customer.IsChecked == true)
            {
                if (select_veh_car.IsChecked == true)
                {

                }

                if (select_veh_truck.IsChecked == true)
                {

                }

            }

        }
        
	}
}