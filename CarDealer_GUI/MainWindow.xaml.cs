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
        CarDealer mycardealer = new CarDealer();
        #region
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

        private void tab_1_next_click(object sender, RoutedEventArgs e)
        {
            tab_2.IsSelected = true;
        }

        private void tab_2_last_click(object sender, RoutedEventArgs e)
        {
            tab_1.IsSelected = true;
        }

        private void tab_2_finalize_click(object sender, RoutedEventArgs e)
        {
            string output = "hello there";
            MessageBox.Show(output);
        }
        #endregion

        private void button2_click(object sender, RoutedEventArgs e)
        {
            if (select_pri_customer.IsChecked == true)
            {
                Private gui_pri_customer = new Private(textbox_pri_address.Text, Convert.ToInt16(textbox_pri_phone.Text), textbox_pri_name.Text, datepicker_pri_birth.Text ,combo_pri_sex.Text);
                //mycardealer.AddCustomer(gui_pri_customer);
                if (select_veh_car.IsChecked == true)
                {
                    if (combo_veh_size_small_item.IsSelected) //Remember to add size parameter
                    {
                        //Contructor takes 5 parameters now :P
                        //Small gui_veh = new Small(textbox_car_colour.Text,textbox_car_model.Text,Convert.ToInt16(textbox_car_price.Text),"in stock");
                        //mycardealer.AddVehicle(gui_veh);  
                    }
                    if (combo_veh_size_large_item.IsSelected)
                    {
                        //Large myveh = new Large(textbox_car_colour.Text,textbox_car_model.Text,Convert.ToInt16(textbox_car_price.Text),"in stock");
                        //mycardealer.AddVehicle(myveh); 
                    }

                }
                if (select_veh_truck.IsChecked == true)
                {
                    //Truck myveh = new Truck(textbox_truck_colour.Text,textbox_truck_model.Text,Convert.ToInt16(textbox_truck_rent.Text),"in stock");
                    //mycardealer.AddVehicle(myveh); 
                }
            }

            if (select_bus_customer.IsChecked == true)
            {
                Business gui_bus_customer = new Business(textbox_bus_address.Text, Convert.ToInt16(textbox_bus_phone.Text), Convert.ToInt16(textbox_bus_seno.Text), Convert.ToInt16(textbox_bus_fax.Text), textbox_bus_contact.Text, textbox_bus_company.Text);
                mycardealer.AddCustomer(gui_bus_customer);
                if (select_veh_car.IsChecked == true)
                {
                    if (combo_veh_size_small_item.IsSelected)
                    {
                        //Small gui_veh = new Small(textbox_car_colour.Text, textbox_car_model.Text, Convert.ToInt16(textbox_car_price.Text), "in stock");
                        //mycardealer.AddVehicle(gui_veh); 
                    }
                    if (combo_veh_size_large_item.IsSelected)
                    {
                        //Large gui_veh = new Large(textbox_car_colour.Text, textbox_car_model.Text, Convert.ToInt16(textbox_car_price.Text), "in stock");
                        //mycardealer.AddVehicle(gui_veh); 
                    }
                }
                if (select_veh_truck.IsChecked == true)
                {
                    //Truck gui_veh = new Truck(textbox_truck_colour.Text,textbox_truck_model.Text,Convert.ToInt16(textbox_truck_rent.Text),"in stock");
                    //mycardealer.AddVehicle(gui_veh);
                    Contract gui_contract = new Contract();
                }
            }
        }   
	}
}