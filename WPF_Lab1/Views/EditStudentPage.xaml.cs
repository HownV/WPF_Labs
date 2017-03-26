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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Lab1.ViewModels;

namespace WPF_Lab1.Views
{
    /// <summary>
    /// Interaction logic for EditStudentPage.xaml
    /// </summary>
    public partial class EditStudentPage : Page
    {
        private EditStudentViewModel _viewModel;

        public EditStudentPage()
        {
            InitializeComponent();
            _viewModel = (EditStudentViewModel) DataContext;
        }
        
        private void PhonesErrorText_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var personalPhoneError = PersonalPhoneErrorText.IsVisible;
            var parentPhoneError = ParentPhoneErrorText.IsVisible;

            if (!personalPhoneError && !parentPhoneError)
            {
                _viewModel.HasErrors = false;
            }
            else
            {
                _viewModel.HasErrors = true;
            }
        }
    }
}
