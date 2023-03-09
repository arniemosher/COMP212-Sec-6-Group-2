using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Question1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public string PriceTag 
        { 
            get
            {
                return $"{Price:C}";
            }
        }

    }
    
    public partial class MainWindow : Window
    {
        public ObservableCollection<MenuItem> Items;
        public MainWindow()
        {
            InitializeComponent();
            Items = new ObservableCollection<MenuItem>();
            //Items.Add(new MenuItem() { Name = "Spaghettig n' Meatballs", Price = 22.30 });
            lstItems.ItemsSource = Items;
            getTotals();
        }

        private void getTotals()
        {
            double result = 0;
            if (Items.Count>0)
            {
                foreach (MenuItem item in Items)
                {
                    result += item.Price;
                } 
            }
            lblTotals.Content = $"Bill\n\nSubtotal: {result:C}\nTax: {Math.Round(0.13*result,2):C}\nTotal: {Math.Round(1.13 * result, 2):C}";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string item = cmbMenuItems.Text;
            string category = item.Split(':')[0];
            string name = item.Split(':')[1].Trim().Split('$')[0].Trim();
            string price = item.Split(':')[1].Trim().Split('$')[1].Trim();

            Items.Add(new MenuItem() { Category = category, Name = name, Price=Double.Parse(price) });
            getTotals();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (Items.Count>0)
            {
                Items.RemoveAt(lstItems.SelectedIndex);
            }
            getTotals();
        }

    }
}
