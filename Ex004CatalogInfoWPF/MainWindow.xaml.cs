using System;
using System.Collections.Generic;
using System.IO;
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

namespace Ex004CatalogInfoWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TreeViewItem CatalogInfo(string Path)
        {
            TreeViewItem t = new TreeViewItem();
            
            DirectoryInfo catalogs = new DirectoryInfo(Path);
            t.Header = catalogs.Name;
            t.Tag = catalogs.FullName;

            foreach (var currentCatalog in catalogs.GetDirectories())
            {
                t.Items.Add(CatalogInfo(currentCatalog.FullName));
            }

            foreach (var current in catalogs.GetFiles())
            {
                t.Items.Add(new TreeViewItem()
                {
                    Header = current.Name,
                    Tag = current.FullName
                });
            }

            return t;
        }


        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void treeView_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Right)
            {
                var path = (treeView.SelectedItem as TreeViewItem).Tag.ToString();
                if (Directory.Exists(path))
                {
                    System.Diagnostics.Process.Start("explorer", path);
                }
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             

            var r = CatalogInfo(tx.Text);

            treeView.Items.Add(r);
        }
    }
}
