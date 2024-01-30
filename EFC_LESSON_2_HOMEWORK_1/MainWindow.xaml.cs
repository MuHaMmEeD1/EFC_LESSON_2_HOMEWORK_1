using EFC_LESSON_2_HOMEWORK_1.DbContexts;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using EFC_LESSON_2_HOMEWORK_1.Entitis;
using System.Data;


namespace EFC_LESSON_2_HOMEWORK_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {

        public L3DBContext DbContext { get; set; }
        public List<string> TableNames { get; set; } = new List<string>();

        public MainWindow()
        {
            DbContext = new L3DBContext();


            TableNames = DbContext.Model.GetEntityTypes()
            .Select(t => t.GetTableName())
            .ToList();

            InitializeComponent();
            DbContext.Authors.Add(new Author() { FirstName = "DF", LastName = "DF" });
            DbContext.SaveChanges();

            ComboBoxTableSelected.ItemsSource = TableNames;
            ComboBoxTableSelected.Text = TableNames[0];


            
            
        }

        private void ComboBoxTableSelected_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            GetTable(ComboBoxTableSelected.SelectedItem.ToString());

        }

        void GetTable(string tableName)
        {
            if (tableName == nameof(DbContext.Authors))
            {
                DataGridTable.ItemsSource = DbContext.Authors.Select(a=>a).ToList();
            }
            else if (tableName == nameof(DbContext.Books))
            {
                DataGridTable.ItemsSource = DbContext.Books.Select(a => a).ToList();
            }
            else if (tableName == nameof(DbContext.Categorlees))
            {
                DataGridTable.ItemsSource = DbContext.Categorlees.Select(a => a).ToList();
            }
            else if (tableName == nameof(DbContext.Departments))
            {
                DataGridTable.ItemsSource = DbContext.Departments.Select(a => a).ToList();
            }
            else if (tableName == nameof(DbContext.Faculties))
            {
                DataGridTable.ItemsSource = DbContext.Faculties.Select(a => a).ToList();
            }
            else if (tableName == nameof(DbContext.Groups))
            {
                DataGridTable.ItemsSource = DbContext.Groups.Select(a => a).ToList();
            }
            else if (tableName == nameof(DbContext.Libs))
            {
                DataGridTable.ItemsSource = DbContext.Libs.Select(a => a).ToList();
            }
            else if (tableName == nameof(DbContext.Presss))
            {
                DataGridTable.ItemsSource = DbContext.Presss.Select(a => a).ToList();
            }
            else if (tableName == nameof(DbContext.S_Cards))
            {
                DataGridTable.ItemsSource = DbContext.S_Cards.Select(a => a).ToList();
            }
            else if (tableName == nameof(DbContext.Students))
            {
                DataGridTable.ItemsSource = DbContext.Students.Select(a => a).ToList();
            }
            else if (tableName == nameof(DbContext.T_Cards))
            {
                DataGridTable.ItemsSource = DbContext.T_Cards.Select(a => a).ToList();
            }
            else if (tableName == nameof(DbContext.Teachers))
            {
                DataGridTable.ItemsSource = DbContext.Teachers.Select(a => a).ToList();
            }
            else if (tableName == nameof(DbContext.Themes))
            {
                DataGridTable.ItemsSource = DbContext.Themes.Select(a => a).ToList();
            }


        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = int.Parse(DeleteTextBox.Text.ToString());
                DelecteRow(ComboBoxTableSelected.SelectedItem.ToString(), id);
                DbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DelecteRow(string tableName, int Id)
        {
            if (tableName == nameof(DbContext.Authors))
            {
                if(DbContext.Authors.Where(e=>e.Id == Id).Select(e=>e.Id).ToList().Count == 1) { DbContext.Authors.Remove(DbContext.Authors.FirstOrDefault(a => a.Id == Id)); }
            }
            else if (tableName == nameof(DbContext.Books))
            {
                if (DbContext.Books.Where(e => e.Id == Id).Select(e => e.Id).ToList().Count == 1) { DbContext.Books.Remove(DbContext.Books.FirstOrDefault(a => a.Id == Id)); }
            }
            else if (tableName == nameof(DbContext.Categorlees))
            {
                if (DbContext.Categorlees.Where(e => e.Id == Id).Select(e => e.Id).ToList().Count == 1) { DbContext.Categorlees.Remove(DbContext.Categorlees.FirstOrDefault(a => a.Id == Id)); }
            }
            else if (tableName == nameof(DbContext.Departments))
            {
                if (DbContext.Departments.Where(e => e.Id == Id).Select(e => e.Id).ToList().Count == 1) { DbContext.Departments.Remove(DbContext.Departments.FirstOrDefault(a => a.Id == Id)); }
            }
            else if (tableName == nameof(DbContext.Faculties))
            {
                if (DbContext.Faculties.Where(e => e.Id == Id).Select(e => e.Id).ToList().Count == 1) { DbContext.Faculties.Remove(DbContext.Faculties.FirstOrDefault(a => a.Id == Id)); }
            }
            else if (tableName == nameof(DbContext.Groups))
            {
                if (DbContext.Groups.Where(e => e.Id == Id).Select(e => e.Id).ToList().Count == 1) { DbContext.Groups.Remove(DbContext.Groups.FirstOrDefault(a => a.Id == Id)); }
            }
            else if (tableName == nameof(DbContext.Libs))
            {
                if (DbContext.Libs.Where(e => e.Id == Id).Select(e => e.Id).ToList().Count == 1) { DbContext.Libs.Remove(DbContext.Libs.FirstOrDefault(a => a.Id == Id)); }
            }
            else if (tableName == nameof(DbContext.Presss))
            {
                if (DbContext.Presss.Where(e => e.Id == Id).Select(e => e.Id).ToList().Count == 1) { DbContext.Presss.Remove(DbContext.Presss.FirstOrDefault(a => a.Id == Id)); }
            }
            else if (tableName == nameof(DbContext.S_Cards))
            {
                if (DbContext.S_Cards.Where(e => e.Id == Id).Select(e => e.Id).ToList().Count == 1) { DbContext.S_Cards.Remove(DbContext.S_Cards.FirstOrDefault(a => a.Id == Id)); }
            }
            else if (tableName == nameof(DbContext.Students))
            {
                if (DbContext.Students.Where(e => e.Id == Id).Select(e => e.Id).ToList().Count == 1) { DbContext.Students.Remove(DbContext.Students.FirstOrDefault(a => a.Id == Id)); }
            }
            else if (tableName == nameof(DbContext.T_Cards))
            {
                if (DbContext.T_Cards.Where(e => e.Id == Id).Select(e => e.Id).ToList().Count == 1) { DbContext.T_Cards.Remove(DbContext.T_Cards.FirstOrDefault(a => a.Id == Id)); }
            }
            else if (tableName == nameof(DbContext.Teachers))
            {
                if (DbContext.Teachers.Where(e => e.Id == Id).Select(e => e.Id).ToList().Count == 1) { DbContext.Teachers.Remove(DbContext.Teachers.FirstOrDefault(a => a.Id == Id)); }
            }
            else if (tableName == nameof(DbContext.Themes))
            {
                if (DbContext.Themes.Where(e => e.Id == Id).Select(e => e.Id).ToList().Count == 1) { DbContext.Themes.Remove(DbContext.Themes.FirstOrDefault(a => a.Id == Id)); }
            }


        }

        private void DataGridTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            
        }

    }
}