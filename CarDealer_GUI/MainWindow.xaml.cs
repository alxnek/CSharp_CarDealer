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
        CarDealer mycardealer = new CarDealer(new List<Vehicle>(), new List<Customer>());


        // Initial setup and grey-out logic.        
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
            this.mycardealer.CustomerList = mycardealer.LoadCustomers();
            this.mycardealer.VehicleList = mycardealer.LoadVehicles();

            this.comboBox_del_customer.ItemsSource = this.mycardealer.CustomerList;
            this.comboBox_Del_Vehicle.ItemsSource = this.mycardealer.VehicleList;
            this.select_combobox_customer.ItemsSource = this.mycardealer.CustomerList;


        }
        #region
        //grey-out logic for private customer type focus.
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
        //grey-out logic for business customer type focus.
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
        #endregion

        //button logic
        #region
        private void create_customer_click(object sender, RoutedEventArgs e)
        {
            bool pri_null_exception = false;
            bool bus_null_exception = false;
            bool pri_format_exception = false;
            bool bus_format_exception = false;

            string pri_boxes_empty_string = "";
            string bus_boxes_empty_string = "";
            string pri_wrong_format_string = "";
            string bus_wrong_format_string = "";

            if (select_pri_customer.IsChecked == true)
            {
                //Test if text boxes in the private section are empty.
                if (string.IsNullOrEmpty(textbox_pri_address.Text) == true ||
                    string.IsNullOrEmpty(textbox_pri_phone.Text) == true ||
                    string.IsNullOrEmpty(textbox_pri_name.Text) == true)
                {
                    pri_boxes_empty_string = "You have forgotten to fill in informationboxes in private customer \n";
                    pri_null_exception = true;
                }
                //Test if text boxes in the private section are in the right format.
                if (IsAllAlphabetic(textbox_pri_name.Text, false) == false ||
                    IsALLnumeric(textbox_pri_phone.Text, false) == false)
                {
                    pri_wrong_format_string = "Your have format errors in your private customer \n";
                    pri_format_exception = true;
                }
            }
            if (select_bus_customer.IsChecked == true)
            {
                //Test if text boxes in the business section are empty
                if (string.IsNullOrEmpty(textbox_bus_address.Text) == true ||
                    string.IsNullOrEmpty(textbox_bus_phone.Text) == true ||
                    string.IsNullOrEmpty(textbox_bus_seno.Text) == true ||
                    string.IsNullOrEmpty(textbox_bus_fax.Text) == true ||
                    string.IsNullOrEmpty(textbox_bus_contact.Text) == true ||
                    string.IsNullOrEmpty(textbox_bus_company.Text) == true)
                {
                    bus_boxes_empty_string = "You have forgotten to fill in informationboxes in business customer \n";
                    bus_null_exception = true;
                }
                //Test if text boxes in the business section are in the right format
                if (IsAllAlphabetic(textbox_bus_contact.Text, false) == false ||
                    IsALLnumeric(textbox_bus_phone.Text, false) == false ||
                    IsALLnumeric(textbox_bus_seno.Text, false) == false ||
                    IsALLnumeric(textbox_bus_fax.Text, false) == false
                    )
                {
                    bus_wrong_format_string = "Your have format errors in your private customer \n";
                    bus_format_exception = true;
                }
            }
            if ((pri_null_exception ||
               bus_null_exception ||
               pri_format_exception ||
               bus_format_exception) == true)
            {
                MessageBox.Show(pri_boxes_empty_string +
                                bus_boxes_empty_string +
                                pri_wrong_format_string +
                                bus_wrong_format_string);
            }

            else
            {
                //check if private customer.
                if (select_pri_customer.IsChecked == true)
                {
                    Private gui_pri_customer = new Private(textbox_pri_address.Text,
                                                            Convert.ToInt32(textbox_pri_phone.Text),
                                                            textbox_pri_name.Text,
                                                            datepicker_pri_birth.Text,
                                                            combo_pri_sex.Text);
                    mycardealer.AddCustomer(gui_pri_customer);

                }
                //check if business customer and create lease.
                if (select_bus_customer.IsChecked == true)
                {
                    Business gui_bus_customer = new Business(textbox_bus_address.Text,
                                                            Convert.ToInt32(textbox_bus_phone.Text),
                                                            Convert.ToInt32(textbox_bus_seno.Text),
                                                            Convert.ToInt32(textbox_bus_fax.Text),
                                                            textbox_bus_contact.Text, textbox_bus_company.Text);
                    mycardealer.AddCustomer(gui_bus_customer);
                }

                mycardealer.SaveCustomersToFile();
                this.comboBox_del_customer.ItemsSource = mycardealer.LoadCustomers();
                this.select_combobox_customer.ItemsSource = this.mycardealer.LoadCustomers();

                MessageBox.Show(mycardealer.ToString());

            }

        }

        private void create_vehicle_click(object sender, RoutedEventArgs e)
        {
            bool car_null_exception = false;
            bool truck_null_exception = false;
            bool car_format_exception = false;
            bool truck_format_exception = false;
            bool error_found_truck = false;
            bool error_found_car = false;

            string car_boxes_empty_string = "";
            string truck_boxes_empty_string = "";
            string car_wrong_format_string = "";
            string truck_wrong_format_string = "";

            //selected private
            #region
            if (select_combobox_customer.SelectedValue is Private || select_combobox_customer.SelectedValue == null)
            {

                //Test if text boxes in the car section are empty.
                if (string.IsNullOrEmpty(textbox_car_model.Text) == true ||
                    string.IsNullOrEmpty(textbox_car_license.Text) == true ||
                    string.IsNullOrEmpty(textbox_car_price.Text) == true ||
                    string.IsNullOrEmpty(textbox_car_colour.Text) == true)
                {
                    car_boxes_empty_string = "You have forgotten to fill in informationboxes in your car informations\n";
                    car_null_exception = true;
                }

                //Test if text boxes in the car section are in the right format
                if (IsALLnumeric(textbox_car_price.Text, false) == false)
                {
                    car_wrong_format_string = "Your have format errors in your car informations\n";
                    car_format_exception = true;
                }
                if ((car_null_exception ||
                car_format_exception) == true)
                {
                    MessageBox.Show(car_boxes_empty_string +
                                    car_wrong_format_string);
                    error_found_car = true;
                }
            }

            //selected business
            if (select_combobox_customer.SelectedValue is Business|| select_combobox_customer.SelectedValue== null)
            {
                //Test if text boxes in the truck section are empty
                if (string.IsNullOrEmpty(textbox_truck_model.Text) == true ||
                    string.IsNullOrEmpty(textbox_truck_license.Text) == true ||
                    string.IsNullOrEmpty(textbox_truck_rent.Text) == true ||
                    string.IsNullOrEmpty(textbox_truck_colour.Text) == true)
                {
                    truck_boxes_empty_string = "You have forgotten to fill in informationboxes in your truck informations \n";
                    truck_null_exception = true;
                }
                //Test if text boxes in the truck section are in the right format
                if (IsALLnumeric(textbox_truck_rent.Text, false) == false)
                {
                    truck_wrong_format_string = "Your have format errors in your truck informations\n";
                    truck_format_exception = true;
                }
            }
            //If any of the boxes were in the wrong format or empty,
            //then show the messagebox notifying the user and break the finalize action.
            if ((truck_null_exception ||
                truck_format_exception) == true)
            {
                MessageBox.Show(truck_boxes_empty_string +
                                truck_wrong_format_string);
                error_found_truck = true;

            }

            #endregion
            // if no errors found then complete the finalize action and bring up the finalize window.

            //check if private customer and create contract.
            if (error_found_car == false)
            {
                if (select_combobox_customer.SelectedValue == null)
                {
                    if (combo_veh_size_small_item.IsSelected) //Remember to add size parameter
                    {
                        Small myveh = new Small(textbox_car_colour.Text,
                                                textbox_car_model.Text,
                                                Convert.ToInt32(textbox_car_price.Text),
                                                "in stock",
                                                textbox_car_license.Text);

                        mycardealer.AddVehicle(myveh);
                    }
                    if (combo_veh_size_large_item.IsSelected)
                    {
                        Large myveh = new Large(textbox_car_colour.Text,
                                               textbox_car_model.Text,
                                               Convert.ToInt32(textbox_car_price.Text),
                                               "in stock",
                                               textbox_car_license.Text);

                        mycardealer.AddVehicle(myveh);                        
                    }
                }

                if (select_combobox_customer.SelectedValue is Private)
                {

                    if (combo_veh_size_small_item.IsSelected) //Remember to add size parameter
                    {
                        Small myveh = new Small(textbox_car_colour.Text,
                                                textbox_car_model.Text,
                                                Convert.ToInt32(textbox_car_price.Text),
                                                "sold",
                                                textbox_car_license.Text);

                        mycardealer.AddVehicle(myveh);
                        Private b = (Private)select_combobox_customer.SelectedValue;

                        Contract gui_contract = new Contract(myveh, "contract");

                        b.AddContract(gui_contract);

                        MessageBox.Show(mycardealer.ToString());

                    }

                    if (combo_veh_size_large_item.IsSelected)
                    {
                        Large myveh = new Large(textbox_car_colour.Text,
                                                textbox_car_model.Text,
                                                Convert.ToInt32(textbox_car_price.Text),
                                                "sold",
                                                textbox_car_license.Text);

                        mycardealer.AddVehicle(myveh);
                        Private b = (Private)select_combobox_customer.SelectedValue;

                        Contract gui_contract = new Contract(myveh, "contract");

                        b.AddContract(gui_contract);

                        MessageBox.Show(mycardealer.ToString());
                    }
                    
                    //this.comboBox_Del_Vehicle.ItemsSource = mycardealer.LoadVehicles();
                    //this.select_combobox_customer.ItemsSource = mycardealer.LoadVehicles();

                }
                mycardealer.SaveVehiclesToFile();
            }
            //check if business customer and create lease.
            else if(error_found_truck == false)
            {
                if (select_combobox_customer.SelectedValue == null)
                {
                    Truck myveh = new Truck(textbox_truck_colour.Text,
                                            textbox_truck_model.Text,
                                            Convert.ToInt32(textbox_truck_rent.Text),
                                            "in stock",
                                            textbox_truck_license.Text);

                    mycardealer.AddVehicle(myveh);                    
                }

                if (select_combobox_customer.SelectedValue is Business)
                {
                    Truck myveh = new Truck(textbox_truck_colour.Text,
                                            textbox_truck_model.Text,
                                            Convert.ToInt32(textbox_truck_rent.Text),
                                            "leased",
                                            textbox_truck_license.Text);

                    mycardealer.AddVehicle(myveh);
                    Business b = (Business)select_combobox_customer.SelectedValue;

                    Leasing gui_contract = new Leasing(myveh,
                                                        "truckContract",
                                                        Convert.ToInt32(textbox_truck_rent.Text),
                                                        datepicker_truck_start.SelectedDate,
                                                        datepicker_truck_end.SelectedDate);
                    b.AddLease(gui_contract);                    
                }
                MessageBox.Show(mycardealer.ToString());
                mycardealer.SaveVehiclesToFile();
                this.comboBox_Del_Vehicle.ItemsSource = mycardealer.LoadVehicles();
            } 
        }
        #endregion

        //grey-out logic for tab 2
        private void tab_2_GotFocus(object sender, RoutedEventArgs e)
        {
            if (select_combobox_customer.SelectedValue is Private)
            {
                textbox_truck_model.IsEnabled = false;
                textbox_truck_license.IsEnabled = false;
                textbox_truck_colour.IsEnabled = false;
                textbox_truck_rent.IsEnabled = false;
                datepicker_truck_start.IsEnabled = false;
                datepicker_truck_end.IsEnabled = false;

                textbox_car_model.IsEnabled = true;
                combo_veh_size.IsEnabled = true;
                textbox_car_license.IsEnabled = true;
                textbox_car_colour.IsEnabled = true;
                textbox_car_price.IsEnabled = true;
            }
            if (select_combobox_customer.SelectedValue is Business)
            {
                combo_veh_size.IsEnabled = false;
                textbox_car_model.IsEnabled = false;
                textbox_car_license.IsEnabled = false;
                textbox_car_colour.IsEnabled = false;
                textbox_car_price.IsEnabled = false;

                textbox_truck_model.IsEnabled = true;
                textbox_truck_license.IsEnabled = true;
                textbox_truck_colour.IsEnabled = true;
                textbox_truck_rent.IsEnabled = true;
                datepicker_truck_start.IsEnabled = true;
                datepicker_truck_end.IsEnabled = true;
            }

        }

        //Feedback on format sensitive textboxes to notify user of any errors when they shift focus away from a input box.
        #region
        private void textbox_pri_phone_LostFocus(object sender, RoutedEventArgs e)
        {
            IsALLnumeric(textbox_pri_phone.Text, true);
        }

        private void textbox_pri_name_LostFocus(object sender, RoutedEventArgs e)
        {
            IsAllAlphabetic(textbox_pri_name.Text, true);
        }

        private void textbox_bus_phone_LostFocus(object sender, RoutedEventArgs e)
        {
            IsALLnumeric(textbox_bus_phone.Text, true);
        }

        private void textbox_bus_seno_LostFocus(object sender, RoutedEventArgs e)
        {
            IsALLnumeric(textbox_bus_seno.Text, true);
        }

        private void textbox_bus_fax_LostFocus(object sender, RoutedEventArgs e)
        {
            IsALLnumeric(textbox_bus_fax.Text, true);
        }

        private void textbox_bus_contact_LostFocus(object sender, RoutedEventArgs e)
        {
            IsAllAlphabetic(textbox_bus_contact.Text, true);
        }

        private void textbox_car_price_LostFocus(object sender, RoutedEventArgs e)
        {
            IsALLnumeric(textbox_car_price.Text, true);
        }

        private void textbox_truck_rent_LostFocus(object sender, RoutedEventArgs e)
        {
            IsALLnumeric(textbox_truck_rent.Text, true);
        }
        #endregion

        // String methods to make sure inputs are correct and are handled by the user.
        #region
        private bool IsAllAlphabetic(string value, bool show)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    if (show == true)
                    {
                        MessageBox.Show("Your input has to be all alphabetic");
                    }
                    return false;
                }
            }
            return true;
        }

        private bool IsALLnumeric(string value, bool show)
        {
            int number;
            if (!(int.TryParse(value, out number)) && (string.IsNullOrEmpty(value) == false))
            {
                if (show == true)
                {
                    MessageBox.Show("Your input has to be only numbers");
                }
                return false;
            }
            return true;
        }
        #endregion



        private void button_del_customer_Click(object sender, RoutedEventArgs e)
        {
            Customer c = (Customer)this.comboBox_del_customer.SelectedItem;

            if (c != null)
                mycardealer.DeleteCustomer(c.Address);

            mycardealer.SaveCustomersToFile();
            this.comboBox_del_customer.ItemsSource = mycardealer.LoadCustomers();

            this.select_combobox_customer.ItemsSource = mycardealer.LoadCustomers();
            //MessageBox.Show(mycardealer.ToString());
        }

        private void button_del_vehicle_Click(object sender, RoutedEventArgs e)
        {
            Vehicle v = (Vehicle)this.comboBox_Del_Vehicle.SelectedItem;

            if (v != null)
                mycardealer.DeleteVehicle(v.LicensePlate);

            mycardealer.SaveVehiclesToFile();

            this.comboBox_Del_Vehicle.ItemsSource = mycardealer.LoadVehicles();

            //MessageBox.Show(mycardealer.ToString());
        }

        private void select_combobox_customer_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            this.select_combobox_customer.ItemsSource = this.mycardealer.CustomerList;
        }

        private void comboBox_del_customer_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            this.comboBox_del_customer.ItemsSource = this.mycardealer.CustomerList;
        }

        private void comboBox_Del_Vehicle_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            this.comboBox_Del_Vehicle.ItemsSource = this.mycardealer.VehicleList;
        }





    }
}