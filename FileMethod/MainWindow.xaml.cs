using System.Windows;
using System.IO;

namespace FileMethod
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
         
        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            //File.Create(@"D:\Demo\Sathish.Txt"); ( Just create File )
            //File.WriteAllText(@"D:\Demo\Sathish.doc", "welcome"); (  With Store SomeDatas and next statement same and method used with bool true or false)
            FileClass fileClass =new FileClass();
            bool isSuccess = fileClass.StoreData(@"D:\Demo\Sathish.txt", "Hi");
            if(isSuccess)
            {
                MessageBox.Show("Data Saved");
            }
        }
    }
}
