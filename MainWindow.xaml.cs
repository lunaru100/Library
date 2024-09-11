using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Wolska_BookManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Book> books = new List<Book>();

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            books.Add(new Book("Cień i Kość","Leich Bardugo","fantasy","książka",2012,3));
            books.Add(new Book("Naruto","Masashi Kishimoto","shonen","Manga",1999,72));
            books.Add(new Book("Szóstka Wron","Leich Bardugo","fantasy","Książka",2015,2));
            books.Add(new Book("Zbrodnia i Kara", "Fiodor Dostojewski", "psychologiczny", "Książka", 1865, 1));
            books.Add(new Book("Akame ga Kill", "Takahiro", "fantasy", "Manga", 2014, 15));

            bookDataGrid.ItemsSource = books;
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            BookAddWindow addWindow = new BookAddWindow();
            addWindow.ShowDialog();
            if (addWindow.DialogResult == true)
            {
                books.Add(addWindow.Book);
                bookDataGrid.Items.Refresh();
            }
        }

        private void EditBook_Click(object sender, RoutedEventArgs e)
        {
            if (bookDataGrid.SelectedItem != null)
            {
                Book selectedBook = (Book)bookDataGrid.SelectedItem;
                BookEditWindow bookWindow = new BookEditWindow(selectedBook);
                bookWindow.ShowDialog();
                if (bookWindow.DialogResult == true)
                {
                    int index = books.IndexOf(selectedBook);
                    books[index] = bookWindow.Book;
                    bookDataGrid.Items.Refresh();
                }
            }
        }

        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {
            if (bookDataGrid.SelectedItem != null)
            {
                Book selectedBook = (Book)bookDataGrid.SelectedItem;
                books.Remove(selectedBook);
                bookDataGrid.Items.Refresh();
            }
        }
        private void ExportToTXT_Click(object sender, RoutedEventArgs e)
        {
            ExportToFile("TXT Files (*.txt)|*.txt", ExportToText);
        }

        private void ExportToCSV_Click(object sender, RoutedEventArgs e)
        {
            ExportToFile("CSV Files (*.csv)|*.csv", ExportToCSV);
        }

        private void ExportToFile(string filter, Action<string> exportMethod)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = filter;
            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    exportMethod(saveFileDialog.FileName);
                    MessageBox.Show("Lista książek została pomyślnie wyeksportowana.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas eksportowania listy książek: " + ex.Message, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ExportToText(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    writer.WriteLine($"Tytuł: {book.Title}, Autor: {book.Author}, Gatunek: {book.Genre}, Typ: {book.Type}, Rok wydania: {book.Year}, Liczba tomów: {book.Volume}");
                }
            }
        }
        private void ExportToCSV(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                writer.WriteLine("Tytuł,Autor,Gatunek,Typ,Rok wydania,Liczba tomów");
                foreach (var book in books)
                {
                    writer.WriteLine($"{book.Title},{book.Author},{book.Genre},{book.Type},{book.Year},{book.Volume}");
                }
            }
        }
    }
}