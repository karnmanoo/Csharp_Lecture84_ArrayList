using System;
using System.Collections;
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

namespace Csharp_Lecture84_ArrayList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Add Data
            //arrayList.Add(13);
            //arrayList.Add(10);
            //arrayList.Add(11);
            //arrayList.Add(14);
            //arrayList.Add(10);
            //arrayList.Add(12);

            //Remove ลบข้อมูลตาม object ที่ระบุ เฉพาะข้อมูลแรก
            //arrayList.Remove(10);

            //RemoveAt ลบข้อมูลตาม Index ที่ระบุ
            //arrayList.RemoveAt(3);

            //Sort เรียงลำดับข้อมูลน้อยไปมาก
            //arrayList.Sort();

            //Clear ลบข้อมูลทั้งหมดใน Array
            //arrayList.Clear();

            //Show Data
            foreach (double data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }

            //Count
            MessageBox.Show("Count "+arrayList.Count.ToString());

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double addData = double.Parse(txtData.Text);
            arrayList.Add(addData);
            txtData.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double removeData = double.Parse(txtData.Text);
            arrayList.Remove(removeData);
            txtData.Clear();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            txtData.Clear();
            arrayList.Clear();
        }
    }
}
