using IceCreamOrderForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace IceCreamOrderForm
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public MainWindowViewModel()
        {
            SelectedSize = 2;

            _flavorList = Flavors.LoadAllFlavorNames();
            _selectedFlavor = _flavorList[0];

            _mixinList = MixIns.LoadAllMixinNames();
            _selectedMixin = _mixinList[0];

            _toppingList = Toppings.LoadAllToppingNames();
            _selectedTopping = _toppingList[0];

            _servbowlsList = ServingBowls.LoadAllServingNames();
            _selectedBowls = _servbowlsList[0];
        }

        #region YUMMY PROPERTIES

        private List<Flavors> _flavorList;
        public List<Flavors> FlavorList
        {
            get { return _flavorList; }
            set { _flavorList = value; }
        }

        private Flavors _selectedFlavor;
        public Flavors SelectedFlavor
        {
            get { return _selectedFlavor; }
            set
            {
                if (_selectedFlavor != value)
                {
                    _selectedFlavor = value;
                    NotifyPropertyChanged("SelectedFlavor");
                }
            }
        }

        private List<MixIns> _mixinList;
        public List<MixIns> MixInList
        {
            get { return _mixinList; }
            set { _mixinList = value; }
        }

        private MixIns _selectedMixin;
        public MixIns SelectedMixIn
        {
            get { return _selectedMixin; }
            set
            {
                if (_selectedMixin != value)
                {
                    _selectedMixin = value;
                    NotifyPropertyChanged("SelectedMixIn");
                }
            }
        }

        private List<Toppings> _toppingList;
        public List<Toppings> ToppingsList
        {
            get { return _toppingList; }
            set { _toppingList = value; }
        }

        private Toppings _selectedTopping;
        public Toppings SelectedTopping
        {
            get { return _selectedTopping; }
            set
            {
                if (_selectedTopping != value)
                {
                    _selectedTopping = value;
                    NotifyPropertyChanged("SelectedTopping");
                }
            }
        }

        private List<ServingBowls> _servbowlsList;
        public List<ServingBowls> ServBowlList
        {
            get { return _servbowlsList; }
            set { _servbowlsList = value; }
        }

        private ServingBowls _selectedBowls;
        public ServingBowls SelectedBowls
        {
            get { return _selectedBowls; }
            set
            {
                if (_selectedBowls != value)
                {
                    _selectedBowls = value;
                    NotifyPropertyChanged("SelectedBowls");
                }
            }
        }

        private int _selectedSize;
        public int SelectedSize
        {
            get { return _selectedSize; }
            set
            {
                _selectedSize = value;
                NotifyPropertyChanged("SelectedSize");
                SizeName = value.ToString();
            }
        }

        private string _sizename;
        public string SizeName
        {
            get { return _sizename; }
            set
            {
                _sizename = "One " + GetSizeName(SelectedSize) + " size";
                NotifyPropertyChanged("SizeName");
            }
        }

        private bool _orderadded;
        public bool OrderAdded
        {
            get { return _orderadded; }
            set
            {
                _orderadded = value;
                NotifyPropertyChanged("OrderAdded");
            }
        }
        #endregion

        #region BUTTON COMMAND PROPERTIES

        public ICommand RBCommand { get; set; }
        private ICommand _clickCommand;
        public ICommand OrderCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new CommandHandler(() => OrderButton(), true));
            }
        }
        private ICommand _checkoutCommand;
        public ICommand CheckoutCommand
        {
            get
            {
                return _checkoutCommand ?? (_checkoutCommand = new CommandHandler(() => CheckoutButton(), true));
            }
        }

        #endregion

        public void OrderButton()
        {
            try
            {
                MessageBox.Show("Order added to Cart!", "Yay");
                OrderAdded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Try again", "Noooo");
            }
        }
        public void CheckoutButton()
        {
            try
            {
                MessageBox.Show("Pickup from somewhere", "$$$");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Try again", "Noooo");
            }
        }

        private string GetSizeName(int _size)
        {
            switch (_size)
            {
                case 1:
                    return "Small";

                case 2:
                    return "Medium";

                case 3:
                    return "Large";

                case 4:
                    return "Xtra Large";

                default:
                    return "oops! try again";
            }
        }
    }
}
