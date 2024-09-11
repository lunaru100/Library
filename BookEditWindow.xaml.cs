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
using System.Windows.Shapes;

namespace Wolska_BookManager
{
    /// <summary>
    /// Logika interakcji dla klasy BookEditWindow.xaml
    /// </summary>
    public partial class BookEditWindow : Window
    {
        public Book Book { get; set; }

        public BookEditWindow()
        {
            InitializeComponent();
            InitializeTypeComboBox();
            Book = new Book("", "", "", "", 0, 0);
            DataContext = Book;
        }

        public BookEditWindow(Book book)
        {
            InitializeComponent();
            InitializeTypeComboBox();
            Book = book;
            DataContext = Book;
            typeComboBox.SelectedItem = Book.Type;
        }

        private void InitializeTypeComboBox()
        {
            typeComboBox.Items.Add("Książka");
            typeComboBox.Items.Add("Manga");
            typeComboBox.Items.Add("Komiks");
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Book.Type = typeComboBox.SelectedItem.ToString();
            DialogResult = true;
        }
    }
}
