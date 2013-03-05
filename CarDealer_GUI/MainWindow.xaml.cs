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

        // Initial setup and grey-out logic.
        #region
        public MainWindow()
        {
            this.InitializeComponent();
			// Insert code required on object creation below this point.
            // Insert Grey out logic here and afterwards.
            textbox_bus_address.IsEnabled = false;
            textbox_bus_phone.IsEnabled = false;
            textbox_bus_seno.IsEnabled = false;
            textbox_bus_fax.IsEnabled = false;
            textbox_bus_contact.IsEnabled = false;
            textbox_bus_company.IsEnabled = false;

            textbox_truck_model.IsEnabled = false;
            textbox_truck_license.IsEnabled = false;
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
            textbox_truck_model.IsEnabled = false;
            textbox_truck_license.IsEnabled = false;
            textbox_truck_colour.IsEnabled = false;
            textbox_truck_rent.IsEnabled = false;
            datepicker_truck_start.IsEnabled = false;
            datepicker_truck_end.IsEnabled = false;

            textbox_pri_address.IsEnabled = true;
            textbox_pri_phone.IsEnabled = true;
            textbox_pri_name.IsEnabled = true;
            datepicker_pri_birth.IsEnabled = true;
            combo_pri_sex.IsEnabled = true;
            textbox_car_model.IsEnabled = true;
            textbox_car_license.IsEnabled = true;
            textbox_car_colour.IsEnabled = true;
            textbox_car_price.IsEnabled = true;
        }
        private void select_bus_customer_clicked(object sender, RoutedEventArgs e)
        {
            textbox_bus_address.IsEnabled = true;
            textbox_bus_phone.IsEnabled = true;
            textbox_bus_seno.IsEnabled = true;
            textbox_bus_fax.IsEnabled = true;
            textbox_bus_contact.IsEnabled = true;
            textbox_bus_company.IsEnabled = true;
            textbox_truck_model.IsEnabled = true;
            textbox_truck_license.IsEnabled = true;
            textbox_truck_colour.IsEnabled = true;
            textbox_truck_rent.IsEnabled = true;
            datepicker_truck_start.IsEnabled = true;
            datepicker_truck_end.IsEnabled = true;

            textbox_pri_address.IsEnabled = false;
            textbox_pri_phone.IsEnabled = false;
            textbox_pri_name.IsEnabled = false;
            datepicker_pri_birth.IsEnabled = false;
            combo_pri_sex.IsEnabled = false;
            textbox_car_model.IsEnabled = false;
            textbox_car_license.IsEnabled = false;
            textbox_car_colour.IsEnabled = false;
            textbox_car_price.IsEnabled = false;
        }

        #endregion
        
        //button logic
        #region
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
            bool pri_null_exception = false;
            bool bus_null_exception = false;
            bool car_null_exception = false;
            bool truck_null_exception = false;

            string pri_boxes_empty_string = "";
            string car_boxes_empty_string = "";
            string bus_boxes_empty_string = "";
            string truck_boxes_empty_string = "";

            if (select_pri_customer.IsChecked == true)
            {
                if ((string.IsNullOrEmpty(textbox_pri_address.Text) == true) ||
                    (string.IsNullOrEmpty(textbox_pri_phone.Text) == true) ||
                    (string.IsNullOrEmpty(textbox_pri_name.Text) == true))
                {
                    pri_boxes_empty_string = "You have forgotten to fill in informationboxes in private customer \n";
                    pri_null_exception = true;
                }

                if ((string.IsNullOrEmpty(textbox_car_model.Text) == true) ||
                    (string.IsNullOrEmpty(textbox_car_license.Text) == true) ||
                    (string.IsNullOrEmpty(textbox_car_price.Text) == true) ||
                    (string.IsNullOrEmpty(textbox_car_colour.Text) == true))
                {
                    car_boxes_empty_string = "You have forgotten to fill in informationboxes in vehicles \n";
                    car_null_exception = true;
                }
            }

            if (select_bus_customer.IsChecked == true)
            {
                if ((string.IsNullOrEmpty(textbox_bus_address.Text) == true) ||
                    (string.IsNullOrEmpty(textbox_bus_phone.Text) == true) ||
                    (string.IsNullOrEmpty(textbox_bus_seno.Text) == true) ||
                    (string.IsNullOrEmpty(textbox_bus_fax.Text) == true) ||
                    (string.IsNullOrEmpty(textbox_bus_contact.Text) == true) ||
                    (string.IsNullOrEmpty(textbox_bus_company.Text) == true))
                {
                    bus_boxes_empty_string = "You have forgotten to fill in informationboxes in business customer \n";
                    bus_null_exception = true;
                }

                if ((string.IsNullOrEmpty(textbox_truck_model.Text) == true) ||
                    (string.IsNullOrEmpty(textbox_truck_license.Text) == true) ||
                    (string.IsNullOrEmpty(textbox_truck_rent.Text) == true) ||
                    (string.IsNullOrEmpty(textbox_truck_colour.Text) == true))
                {
                    truck_boxes_empty_string = "You have forgotten to fill in informationboxes in vehicles \n";
                    truck_null_exception = true;
                }
            }
            if((pri_null_exception || car_null_exception || bus_null_exception || truck_null_exception) == true)
            {
                MessageBox.Show(pri_boxes_empty_string + car_boxes_empty_string + bus_boxes_empty_string + truck_boxes_empty_string);
            }
                    
        }
    
        #endregion

        // Create customer logic on button push.
        #region       

        private void button2_click(object sender, RoutedEventArgs e)
        {
            //check if the customer type is a business
            if (select_pri_customer.IsChecked == true)
            {
                Private gui_pri_customer = new Private(textbox_pri_address.Text, Convert.ToInt16(textbox_pri_phone.Text), textbox_pri_name.Text, datepicker_pri_birth.Text ,combo_pri_sex.Text);
                
                if (combo_veh_size_small_item.IsSelected) //Remember to add size parameter
                {
                    Small myveh = new Small(textbox_car_colour.Text,textbox_car_model.Text,Convert.ToInt16(textbox_car_price.Text),"in stock", textbox_car_license.Text);
                    mycardealer.AddVehicle(myveh);  
                }

                if (combo_veh_size_large_item.IsSelected)
                {
                    Large myveh = new Large(textbox_car_colour.Text,textbox_car_model.Text,Convert.ToInt16(textbox_car_price.Text),"in stock", textbox_car_license.Text);
                    mycardealer.AddVehicle(myveh);
                }                             
                Contract gui_contract = new Contract(); 
            }
          
            //check if the customer type is a business
            if (select_bus_customer.IsChecked == true)
            {
                Business gui_bus_customer = new Business(textbox_bus_address.Text, Convert.ToInt16(textbox_bus_phone.Text), Convert.ToInt16(textbox_bus_seno.Text), Convert.ToInt16(textbox_bus_fax.Text), textbox_bus_contact.Text, textbox_bus_company.Text);
               
                Truck myveh = new Truck(textbox_truck_colour.Text,textbox_truck_model.Text,Convert.ToInt16(textbox_truck_rent.Text),"in stock", textbox_truck_license.Text);
                mycardealer.AddVehicle(myveh);            
            
                Contract gui_contract = new Contract();                
            }
        }
        #endregion

        // Exception methods to make sure inputs are correct and are handled without a program crash.
        #region
        private void IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Your input has to be all alphabetic");
                    break;
                }
            }
        }

        private void IsALLnumeric(string value)
        {
            int number;
            if (!(int.TryParse(value, out number)) && (string.IsNullOrEmpty(value)==false))
            {
                MessageBox.Show("Your input has to be only numbers");                
            }
        }

        #endregion
        //User feedback to make use easier
        #region 
        private void textbox_pri_phone_LostFocus(object sender, RoutedEventArgs e)
        {
            IsALLnumeric(textbox_pri_phone.Text);
        }

        private void textbox_pri_name_LostFocus(object sender, RoutedEventArgs e)
        {
            IsAllAlphabetic(textbox_pri_name.Text);
        }

        private void textbox_bus_phone_LostFocus(object sender, RoutedEventArgs e)
        {
            IsALLnumeric(textbox_bus_phone.Text);
        }

        private void textbox_bus_seno_LostFocus(object sender, RoutedEventArgs e)
        {
            IsALLnumeric(textbox_bus_seno.Text);
        }

        private void textbox_bus_fax_LostFocus(object sender, RoutedEventArgs e)
        {
            IsALLnumeric(textbox_bus_fax.Text);
        }

        private void textbox_bus_contact_LostFocus(object sender, RoutedEventArgs e)
        {
            IsAllAlphabetic(textbox_bus_contact.Text);
        }

        private void textbox_car_price_LostFocus(object sender, RoutedEventArgs e)
        {
            IsALLnumeric(textbox_car_price.Text);
        }

        private void textbox_truck_rent_LostFocus(object sender, RoutedEventArgs e)
        {
            IsALLnumeric(textbox_truck_rent.Text);
        }
        #endregion 
    }     
    
}