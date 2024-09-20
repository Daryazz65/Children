using Children.ClassPr;
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
        private static ZininaMatveevaChildrenEntities context = App.GetContext();
        public PageAddGroup()
        {

            InitializeComponent();

            CmbVG.ItemsSource = context.ViewGroup.ToList();
            CmbVG.DisplayMemberPath = "Name";
            CmbVG.SelectedIndex = 0;

        }

        private void AddGroup_Click(object sender, RoutedEventArgs e)
        {
            string groupNumber = TxtGroup.Text;
            if(string.IsNullOrEmpty(groupNumber) == false) 
            {
                Group newGroup = new Group()
                {
                    Name = groupNumber,
                    ViewGroup = CmbVG.SelectedItem as ViewGroup
                };
                context.Group.Add(newGroup);
                context.SaveChanges();
                MessageBox.Show("Добавлена группа.");
                ClassFrame.selectedFrame.Navigate(new MenuPage());
            }
            else
            {
                MessageBox.Show("Введите название группы");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.selectedFrame.Navigate(new MenuPage());
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
