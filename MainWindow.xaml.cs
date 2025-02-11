

namespace FirstModuleProject
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtemail.Text = "";
            ccname.Text = "";
        }
        List<StudentInfo> students = new List<StudentInfo>();

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            students.Add(new StudentInfo { ID = int.Parse(txtid.Text), Name = txtname.Text,
                                          Email=txtemail.Text,CourseName =ccname.Text  });
            MessageBox.Show("Data has been Save Successfully");
            
            clear();
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            int found = students.FindIndex(c => c.ID == int.Parse(txtid.Text));
            students.RemoveAt(found);

            MessageBox.Show("Data has been Delete Successfully");
            
            clear();
        }
        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            int found = students.FindIndex(c => c.ID == int.Parse(txtid.Text));
            students.RemoveAt(found);
            students.Add(new StudentInfo { ID = int.Parse(txtid.Text), Name = txtname.Text, CourseName = ccname.Text, Email = txtemail.Text });

            MessageBox.Show("Data has been Update Successfully");
            
            clear();
        }

        private void btnfind_Click(object sender, RoutedEventArgs e)
        {
            var find = students.Find(c => c.ID== int.Parse(txtid.Text));
            txtname.Text = find.Name;
            txtemail.Text = find.Email;
            ccname.Text = find.CourseName;
        }

        private void btncler_Click(object sender, RoutedEventArgs e)
        {
            clear();
        }
        }
    }
