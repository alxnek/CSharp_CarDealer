﻿using System;
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
            textbox_bus_address.IsEnabled = false;
            textbox_bus_phone.IsEnabled = false;
            textbox_bus_seno.IsEnabled = false;
            textbox_bus_fax.IsEnabled = false;
            textbox_bus_contact.IsEnabled = false;
            textbox_bus_company.IsEnabled = false;

            textbox_truck_model.IsEnabled = false;
            textbox_truck_colour.IsEnabled = false;
            textbox_truck_rent.IsEnabled = false;
            textbox_truck_startdate.IsEnabled = false;
            textbox_truck_enddate.IsEnabled = false;
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
            textbox_pri_age.IsEnabled = true;
            textbox_pri_sex.IsEnabled = true;
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
            textbox_pri_age.IsEnabled = false;
            textbox_pri_sex.IsEnabled = false;
        }

        private void select_veh_car_clicked(object sender, RoutedEventArgs e)
        {         
            textbox_truck_model.IsEnabled = false;
            textbox_truck_colour.IsEnabled = false;
            textbox_truck_rent.IsEnabled = false;
            textbox_truck_startdate.IsEnabled = false;
            textbox_truck_enddate.IsEnabled = false;

            textbox_car_model.IsEnabled = true;
            textbox_car_colour.IsEnabled = true;
            textbox_car_price.IsEnabled = true;
        }

        private void select_veh_truck_clicked(object sender, RoutedEventArgs e)
        {
            textbox_truck_model.IsEnabled = true;
            textbox_truck_colour.IsEnabled = true;
            textbox_truck_rent.IsEnabled = true;
            textbox_truck_startdate.IsEnabled = true;
            textbox_truck_enddate.IsEnabled = true;

            textbox_car_model.IsEnabled = false;
            textbox_car_colour.IsEnabled = false;
            textbox_car_price.IsEnabled = false;
        }

	}
}