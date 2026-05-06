using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static MoviesForm.User;



namespace MoviesForm
{

    public partial class Form1 : Form
    {
        List<Movie> movies = new List<Movie>();
        User currentUser;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // التحقق من أن الحقول ليست فارغة
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtGenre.Text) ||
                string.IsNullOrWhiteSpace(txtRating.Text))
            {
                MessageBox.Show("Please fill in all fields before adding a movie.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // يوقف التنفيذ هنا
            }

            // التحقق من أن التقييم رقم صحيح بين 1 و 10
            if (!int.TryParse(txtRating.Text, out int rating) || rating < 1 || rating > 10)
            {
                MessageBox.Show("Rating must be a number between 1 and 10.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // إذا كل شيء صحيح، نضيف الفيلم
            Movie m = new Movie(txtTitle.Text, txtGenre.Text, rating);
            movies.Add(m);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = movies;

            // رسالة نجاح
            MessageBox.Show("Movie added successfully! 🎬",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // تنظيف الحقول بعد الإضافة
            txtTitle.Clear();
            txtGenre.Clear();
            txtRating.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // التحقق من أن اسم المستخدم مكتوب
            if (string.IsNullOrWhiteSpace(textUserName.Text))
            {
                MessageBox.Show("Please enter a user name before watching a movie.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // إنشاء المستخدم إذا لم يكن موجود
            if (currentUser == null)
                currentUser = new User(textUserName.Text);

            // التحقق من أن فيلم محدد من الجدول
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a movie from the list.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // إذا كل شيء صحيح → مشاهدة الفيلم
            Movie selectedMovie = (Movie)dataGridView1.CurrentRow.DataBoundItem;
            currentUser.WatchMovie(selectedMovie);

            listBox1.Items.Add($"{currentUser.Name} watched {selectedMovie.Title}");

            // رسالة نجاح
            MessageBox.Show($"Movie '{selectedMovie.Title}' watched successfully by {currentUser.Name}! 🎬",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // التحقق من أن اسم المستخدم مكتوب
            if (string.IsNullOrWhiteSpace(textUserName.Text))
            {
                MessageBox.Show("Please enter a user name before rating a movie.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // إنشاء المستخدم إذا لم يكن موجود
            if (currentUser == null)
                currentUser = new User(textUserName.Text);

            // التحقق من أن فيلم محدد من الجدول
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a movie from the list.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // التحقق من أن التقييم رقم صحيح بين 1 و 10
            if (!int.TryParse(txtRating.Text, out int rate) || rate < 1 || rate > 10)
            {
                MessageBox.Show("Rating must be a number between 1 and 10.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // إذا كل شيء صحيح → تقييم الفيلم
            Movie selectedMovie = (Movie)dataGridView1.CurrentRow.DataBoundItem;
            currentUser.RateMovie(selectedMovie, rate);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = movies;

            // رسالة نجاح
            MessageBox.Show($"Movie '{selectedMovie.Title}' rated successfully with {rate}/10 by {currentUser.Name}! ⭐",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

    }
}

