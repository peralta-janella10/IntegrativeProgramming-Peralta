namespace LibraryCatalog
{
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();
        }
        public class Book
        {
            public string ISBN { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }
            public int Copies { get; set; }

            public override string ToString()
            {
                return $"{Title} - {ISBN}";
            }
        }

        private void RefreshList()
        {
            lstBooks.Items.Clear();
            foreach (var book in books)
            {
                lstBooks.Items.Add(book);
            }
        }

        private void ShowDetails(Book book)
        {
            if (book == null) return;

            txtDetails.Text =
                $"ISBN: {book.ISBN}\r\n" +
                $"Title: {book.Title}\r\n" +
                $"Author: {book.Author}\r\n" +
                $"Year: {book.Year}\r\n" +
                $"Copies Available: {book.Copies}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtISBN.Text) ||
       string.IsNullOrWhiteSpace(txtTitle.Text) ||
       string.IsNullOrWhiteSpace(txtAuthor.Text) ||
       string.IsNullOrWhiteSpace(txtYear.Text) ||
       string.IsNullOrWhiteSpace(txtCopies.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            if (!int.TryParse(txtYear.Text, out int year) ||
                !int.TryParse(txtCopies.Text, out int copies))
            {
                MessageBox.Show("Year and Copies must be numbers.");
                return;
            }

            if (txtTitle.Text.Any(char.IsDigit) || txtAuthor.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Title and Author should not contain numbers.");
                return;
            }

            string isbn = txtISBN.Text.Trim();
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();

            bool isbnExists = books.Any(b =>
                b.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase));

            if (isbnExists)
            {
                MessageBox.Show("ISBN already exists.");
                return;
            }
            bool bookExists = books.Any(b =>
                b.Title.Equals(title, StringComparison.OrdinalIgnoreCase) &&
                b.Author.Equals(author, StringComparison.OrdinalIgnoreCase) &&
                b.Year == year);

            if (bookExists)
            {
                MessageBox.Show("This book already exists.");
                return;
            }
            Book book = new Book
            {
                ISBN = isbn,
                Title = title,
                Author = author,
                Year = year,
                Copies = copies
            };

            books.Add(book);
            RefreshList();
            ClearFields();

        }
        private void lstbook_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstBooks.SelectedItem == null) return;
            ShowDetails((Book)lstBooks.SelectedItem);
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            txtCopies.Clear();

        }

        private void bntRemove_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem == null)
            {
                MessageBox.Show("Please select a book to remove.");
                return;
            }

            books.Remove((Book)lstBooks.SelectedItem);
            RefreshList();
            txtDetails.Clear();

        }

        private void bntborrow_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem == null)
            {
                MessageBox.Show("Select a book to borrow.");
                return;
            }

            Book book = (Book)lstBooks.SelectedItem;

            if (book.Copies <= 0)
            {
                MessageBox.Show("No copies available.");
                return;
            }
            book.Copies--;

            MessageBox.Show("Book borrowed.");

            RefreshList();
            ShowDetails(book);

        }
        private void bntReturn_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem == null)
            {
                MessageBox.Show("Select a book.");
                return;
            }

            Book book = (Book)lstBooks.SelectedItem;
            book.Copies++;

            MessageBox.Show("Book returned.");

            RefreshList();
            ShowDetails(book);

        }
    }
}

