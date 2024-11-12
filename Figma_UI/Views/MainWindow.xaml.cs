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

namespace Figma_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ImageItem> ImageItems { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            ImageItems = new ObservableCollection<ImageItem>
            {
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/2.png")),
                    Text1 = "Noodles",
                    Text2 = "600.00"
                },
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/3.png")),
                    Text1 = "Chicken Kottu",
                    Text2 = "600.00"
                },
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/4.png")),
                    Text1 = "Fried Rice",
                    Text2 = "600.00"
                },
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/5.jpg")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/6.jpg")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/7.jpg")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/8.jpg")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/9.jpg")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/10.jpg")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                },
                new ImageItem { 
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png")),
                    Text1 = "Curd Rice",
                    Text2 = "600.00"
                }
                //new ImageItem { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/2.png"))},
                //new ImageItem { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/3.png"))},
                //new ImageItem { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/4.png"))},
                //new ImageItem { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/5.jpg"))},
                //new ImageItem { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png"))},
                //new ImageItem { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/6.jpg"))},
                //new ImageItem { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png"))},
                //new ImageItem { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png"))},
                //new ImageItem { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/7.jpg"))},
                //new ImageItem { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png"))},
                //new ImageItem { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/8.jpg"))},
                //new ImageItem { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/9.jpg"))},
                //new ImageItem { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png"))},
                //new ImageItem { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/10.jpg"))},
                //new ImageItem { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png"))}
                
            };

            DataContext = this;
        }

    }
}
