using Children.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace Children.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageAddGroup.xaml
    /// </summary>
    public partial class PageAddGroup : Page
    {
        public PageAddGroup()
        {
            InitializeComponent();

            CmbVG.SelectedValuePath = "ID";
            CmbVG.DisplayMemberPath = "Name";
            CmbVG.ItemsSource = App.context.ViewGroup.ToList();
        }

        private void AddGroup_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(TxtGroup.Text))
                mes += "Введите группу\n";

            if (string.IsNullOrWhiteSpace(CmbVG.Text))
                mes += "Выберите вид группы\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Group groupDS = new Group()
            {
                Name = TxtGroup.Text,
                ViewGroup = CmbVG.SelectedItem as ViewGroup
            };
            App.context.Group.Add(groupDS);
            App.context.SaveChanges();
            MessageBox.Show("Группа добавлена");

            TxtGroup.Text = "";
            CmbVG.Text = "";
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.GoBack();
        }
    }
}
