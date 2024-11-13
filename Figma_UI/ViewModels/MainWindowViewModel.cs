using Figma_UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Figma_UI.ViewModels
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Row> Rows { get; set; }
        public ObservableCollection<ImageItem> ImageItems { get; set; }
        public ObservableCollection<Order> OrderItems { get; set; }
        public MainWindowViewModel()
        {
            Rows = new ObservableCollection<Row>
            {
                new Row 
                {
                    Column1Text1 = "Curd Rice",
                    Column1Text2 = "10001",
                    Column2Text = "600.00",
                    Column3Text = "2",
                    Column4Text = "1,200.00"
                },
                new Row 
                {
                    Column1Text1 = "Curd Rice",
                    Column1Text2 = "10001",
                    Column2Text = "600.00",
                    Column3Text = "2",
                    Column4Text = "1,200.00"
                }
                // Add more rows as needed
            };

            ImageItems = new ObservableCollection<ImageItem>
            {
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem 
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                }
            };

            OrderItems = new ObservableCollection<Order>
            {
                new Order
                {
                    Customer1 = "Walk-in Customer",
                    Customer2 = "Customer",
                    Invoice1 = "002132",
                    Invoice2 = "Invoice No",
                    OrderType1 = "Dine in",
                    OrderType2 = "Type"
                },
                new Order
                {
                    Customer1 = "Walk-in Customer",
                    Customer2 = "Customer",
                    Invoice1 = "002132",
                    Invoice2 = "Invoice No",
                    OrderType1 = "Dine in",
                    OrderType2 = "Type"
                },
                new Order
                {
                    Customer1 = "Walk-in Customer",
                    Customer2 = "Customer",
                    Invoice1 = "002132",
                    Invoice2 = "Invoice No",
                    OrderType1 = "Dine in",
                    OrderType2 = "Type"
                },
                new Order
                {
                    Customer1 = "Walk-in Customer",
                    Customer2 = "Customer",
                    Invoice1 = "002132",
                    Invoice2 = "Invoice No",
                    OrderType1 = "Dine in",
                    OrderType2 = "Type"
                },
                new Order
                {
                    Customer1 = "Walk-in Customer",
                    Customer2 = "Customer",
                    Invoice1 = "002132",
                    Invoice2 = "Invoice No",
                    OrderType1 = "Dine in",
                    OrderType2 = "Type"
                },
                new Order
                {
                    Customer1 = "Walk-in Customer",
                    Customer2 = "Customer",
                    Invoice1 = "002132",
                    Invoice2 = "Invoice No",
                    OrderType1 = "Dine in",
                    OrderType2 = "Type"
                }
            };
        }
    }
}
