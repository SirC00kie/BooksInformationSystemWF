using BooksInformationSystem.Models;
using BooksInformationSystem.Services;
using BooksInformationSystem.Statics;
using System.ComponentModel;

namespace BooksInformationSystem.Views
{
    public partial class MainForm : Form
    {
        private readonly BookService _bookService;
        private readonly ApplicationDbContext _context;
        private readonly Configs _configs;
        public MainForm()
        {
            InitializeComponent();
            _bookService = new BookService();
            _context = new ApplicationDbContext();
            _configs = new Configs();

            comboType.DataSource = _configs.BookType.ToList();
            comboContent.DataSource = _configs.BookContent.ToList();
            openFile.Filter = _configs.DataType;
            saveFile.Filter = _configs.DataType;
            CompleteTitleGrid();

            dataGrid.DataSource = new BindingList<Book>(_context.Books.ToList());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var name = textName.Text;
            var type = comboType.Text;
            var content = comboContent.Text;
            var author = textAuthor.Text;
            var description = textDescription.Text;
            int.TryParse(textYear.Text, out var year);
            if (YearValidation(year))
            {
                Book book = new Book
                {
                    Name = name,
                    Type = type,
                    Content = content,
                    Author = author,
                    Description = description,
                    Year = year
                };
                _context.Books.Add(book);
                BookService.Books.Add(book);
                dataGrid.DataSource = new BindingList<Book>(BookService.Books.ToList());
                CompleteTitleGrid();
                Clear();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Информационная система учета электронных пособий. Разработал: Костомаров Илья, группа 496 ", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadMenu_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filename = openFile.FileName;
                bool IsOpen;
                IsOpen = _bookService.Load(filename);
                if (IsOpen)
                {
                    dataGrid.DataSource = BookService.Books.ToList();
                    dataGrid.DataSource = new BindingList<Book>(BookService.Books.ToList());
                    CompleteTitleGrid();
                }
                else
                {
                    MessageBox.Show("Не удалось прочитать файл", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveMenu_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFile.FileName;
                _bookService.Save(filename);
            }
        }

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            _context.SaveChanges();
        }

        private void clearGrid_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            BookService.Books.Clear();
            _context.Books.RemoveRange(_context.Books);
        }

        private void deleteGrid_Click(object sender, EventArgs e)
        {
            try
            {
                int delete = dataGrid.SelectedCells[0].RowIndex;
                dataGrid.Rows.RemoveAt(delete);
            }
            catch (Exception)
            {
                MessageBox.Show("Запись отсутсвует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butGetData_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textYearSearch.Text, out var year) || textNameSearch.Text != null || textAuthorSeacrh != null)
            {
                var searchYear = year;
                var seacrhName = textNameSearch.Text;
                var searchAuthor = textAuthorSeacrh.Text;

                BookService.Books = _context.Books.Where(b => b.Year == searchYear ||
                                                              b.Author == searchAuthor ||
                                                              b.Name == seacrhName).ToList();
                dataGrid.DataSource = new BindingList<Book>(BookService.Books.ToList());
            }
            else
            {
                MessageBox.Show("Нет данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompleteTitleGrid()
        {
            for (int i = 0; i < dataGrid.ColumnCount; i++)
            {
                dataGrid.Columns[i].HeaderText = _configs.GridTitles[i];
            }
        }

        private void Clear()
        {
            textName.Clear();
            textAuthor.Clear();
            textDescription.Clear();
            textYear.Clear();
        }

        private bool YearValidation(int year)
        {
            if (year < 1900 || year > 2022)
            {
                MessageBox.Show("Данные указаны неккоректно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textYear.Clear();
                return false;
            }
            return true;

        }


    }
}