﻿using System;
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

namespace NavrhSingleton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, People> dbPeople = new Dictionary<string, People>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text != null && prijmeni.Text != null && datumNarozeni.SelectedDate != null && rodneCislo.Text != null)
            {
                People people = People.Instance;
                people.Jmeno = name.Text;
                people.Prijmeni = prijmeni.Text;
                people.DatumNarozeni = Convert.ToDateTime(datumNarozeni.SelectedDate);
                people.RodneCislo = rodneCislo.Text;
                dbPeople.Add(rodneCislo.Text, people);
                allPeople.Items.Add(people.Jmeno + " " + people.Prijmeni);
            }
        }
    }
}
