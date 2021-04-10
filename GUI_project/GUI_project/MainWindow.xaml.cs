using System;
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

namespace GUI_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double income = double.Parse(Income.Text);
            double expend = double.Parse(Expend.Text);
            double price = double.Parse(Price.Text);

            if (price <= 0)
            {
                MessageBox.Show("คำเตือน!! : ราคาสินค้าไม่สามารถเป็น 0 หรือ ติดลบ ได้" + "\n" + "คำแนะนำ : โปรดใส่ราคาสินค้าใหม่");
            } else if (income < 0)
            {
                MessageBox.Show("คำเตือน!! : รายได้ไม่สามารถ ติดลบ ได้" + "\n" + "คำแนะนำ : โปรดใส่รายได้ใหม่");
            }
            else if (expend < 0)
            {
                MessageBox.Show("คำเตือน!! : รายจ่ายไม่สามารถ ติดลบ ได้" + "\n" + "คำแนะนำ : โปรดใส่รายได้ใหม่");
            }
            else
            {
                if (income < expend)
                {
                    MessageBox.Show("คำเตือน!! : รายได้คุณน้อยกว่ารายจ่าย" + "\n" + "คำแนะนำ : คุณควรหารายได้เสริมอีก");
                    Day.Text = "เงินไม่พอ!!!";
                }
                else if (income == expend)
                {
                    MessageBox.Show("คำเตือน!! : รายได้คุณเท่ากับรายจ่าย" + "\n" + "คำแนะนำ : คุณควรหารายได้เสริมอีก");
                    Day.Text = "เงินไม่พอ!!!";

                }
                else
                {

                    double net = income - expend;

                    int day = int.Parse((Math.Ceiling(price / net).ToString()));

                    Day.Text = day.ToString();
                }
            }
        }

    }
}
 