using managingadentalclinic.DataBase;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace managingadentalclinic
{
    /// <summary>
    /// Interaction logic for FormHome.xaml
    /// </summary>
    public partial class FormHome : Window
    {

        public class CompositeViewModel
        {
            public TeethStatus status { get; set; }
            public SetTeethStatus setting { get; set; }
            public SetCrownType crownType { get; set; }
            public CompositeViewModel()
            {
                status = new TeethStatus();
                setting = new SetTeethStatus();
                crownType = new SetCrownType();
            }
        }
        bool iset = true;
        CompositeViewModel viewModel = new CompositeViewModel();
        public FormHome()
        {
            InitializeComponent();
            //this.DataContext = status;

            this.DataContext = viewModel;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //UpdateLabel();
        }
        void setteethstate()
        {
            viewModel.setting.setToothType();
        }
        private void UpdateLabel()
        {
            this.DataContext = null;
            setteethstate();
            this.DataContext = viewModel;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(post.IsChecked.ToString());
            viewModel.status.post = false;
            UpdateLabel();
        }

        private void post_Checked(object sender, RoutedEventArgs e)
        {
            if (post.IsChecked == true)
            {
                viewModel.status.post = true;
                //MessageBox.Show("true");
            }
            else
            {
                //MessageBox.Show("false");
                viewModel.status.post = false;

            }
            UpdateLabel();
        }

        private void metalpost_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.status.post_type = TeethStatus.PostType.Metal;
        }

        private void galspost_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.status.post_type = TeethStatus.PostType.GlassFiber;
        }

        private void screowpost_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.status.post_type = TeethStatus.PostType.Screw;
            MessageBox.Show(viewModel.status.post_type.ToString());
        }
        private void Permanent_Checked(object sender, RoutedEventArgs e)
        {
            viewModel = new CompositeViewModel();
            if (Permanent.IsChecked == true)
            {
                viewModel.setting.isPermanent = true;
                viewModel.status.crown = true;
                viewModel.status.rct = true;
                viewModel.status.ortho = true;
                viewModel.status.mobility = true;
                viewModel.status.vitality = true;
                imagebig.Source = new BitmapImage(new Uri(@"/Assets/finding_typs/closed right.PNG", UriKind.Relative));
                labelhd.Visibility = Visibility.Hidden;
                crown_panel.Visibility = Visibility.Visible;
                rct_panel.Visibility = Visibility.Visible;
                ortho_panel.Visibility = Visibility.Visible;
                mobility_panel.Visibility = Visibility.Visible;
                vitality_panel.Visibility = Visibility.Visible;
            }
            UpdateLabel();
        }
        private void Deciduous_Checked(object sender, RoutedEventArgs e)
        {
            viewModel = new CompositeViewModel();
            if (Deciduous.IsChecked == true)
            {
                //MessageBox.Show("HI");
                viewModel.setting.isDeciduous = true;
                viewModel.status.crown = true;
                viewModel.status.rct = false;
                viewModel.status.ortho = false;
                viewModel.status.mobility = true;
                viewModel.status.vitality = true;

                labelhd.Visibility = Visibility.Hidden;
                crown_panel.Visibility = Visibility.Visible;
                rct_panel.Visibility = Visibility.Hidden;
                ortho_panel.Visibility = Visibility.Hidden;
                mobility_panel.Visibility = Visibility.Visible;
                vitality_panel.Visibility = Visibility.Visible;
            }
            UpdateLabel();
        }
        private void Imolant_Checked(object sender, RoutedEventArgs e)
        {
            viewModel = new CompositeViewModel();
            if (Imolant.IsChecked == true)
            {
                //MessageBox.Show("HI");
                viewModel.setting.isImolant = true;
                viewModel.status.crown = true;
                viewModel.status.rct = false;
                viewModel.status.ortho = false;
                viewModel.status.mobility = true;
                viewModel.status.vitality = false;

                labelhd.Visibility = Visibility.Hidden;
                crown_panel.Visibility = Visibility.Visible;
                rct_panel.Visibility = Visibility.Hidden;
                ortho_panel.Visibility = Visibility.Hidden;
                mobility_panel.Visibility = Visibility.Visible;
                vitality_panel.Visibility = Visibility.Hidden;
            }
            UpdateLabel();
        }
        private void Pontic_Checked(object sender, RoutedEventArgs e)
        {
            viewModel = new CompositeViewModel();
            if (Pontic.IsChecked == true)
            {
                //MessageBox.Show("HI");
                viewModel.setting.isPontic = true;
                viewModel.status.crown = true;
                viewModel.status.rct = false;
                viewModel.status.ortho = false;
                viewModel.status.mobility = false;
                viewModel.status.vitality = false;

                imagebig.Source = new BitmapImage(new Uri(@"/Assets/finding_typs/pontic.PNG", UriKind.Relative));
                labelhd.Visibility = Visibility.Visible;

                crown_panel.Visibility = Visibility.Hidden;
                rct_panel.Visibility = Visibility.Hidden;
                ortho_panel.Visibility = Visibility.Hidden;
                mobility_panel.Visibility = Visibility.Hidden;
                vitality_panel.Visibility = Visibility.Hidden;
            }
            UpdateLabel();
            //viewModel.status.crown = true;
            //crown_panelel.Visibility = Visibility.Visible;
            //MessageBox.Show(viewModel.status.crown.ToString());
        }
        private void Saddle_Checked(object sender, RoutedEventArgs e)
        {
            viewModel = new CompositeViewModel();
            if (Saddle.IsChecked == true)
            {
                //MessageBox.Show("HI");
                viewModel.setting.isSaddle = true;
                viewModel.status.crown = false;
                viewModel.status.rct = false;
                viewModel.status.ortho = false;
                viewModel.status.mobility = false;
                viewModel.status.vitality = false;

                imagebig.Source = new BitmapImage(new Uri(@"/Assets/finding_typs/suddle.PNG", UriKind.Relative));
                labelhd.Visibility = Visibility.Hidden;

                crown_panel.Visibility = Visibility.Hidden;
                rct_panel.Visibility = Visibility.Hidden;
                ortho_panel.Visibility = Visibility.Hidden;
                mobility_panel.Visibility = Visibility.Hidden;
                vitality_panel.Visibility = Visibility.Hidden;
            }
            UpdateLabel();
        }
        private void Missing_Checked(object sender, RoutedEventArgs e)
        {
            viewModel = new CompositeViewModel();
            if (Missing.IsChecked == true)
            {
                //MessageBox.Show("HI");
                viewModel.setting.isMissing = true;
                viewModel.status.crown = false;
                viewModel.status.rct = false;
                viewModel.status.ortho = false;
                viewModel.status.mobility = false;
                viewModel.status.vitality = false;

                imagebig.Source = new BitmapImage(new Uri(@"/Assets/finding_typs/32.PNG", UriKind.Relative));
                labelhd.Visibility = Visibility.Hidden;

                crown_panel.Visibility = Visibility.Hidden;
                rct_panel.Visibility = Visibility.Hidden;
                ortho_panel.Visibility = Visibility.Hidden;
                mobility_panel.Visibility = Visibility.Hidden;
                vitality_panel.Visibility = Visibility.Hidden;
            }
            UpdateLabel();
        }

        private void spdl_Checked(object sender, RoutedEventArgs e)
        {
            viewModel = new CompositeViewModel();
            if (spdl.IsChecked == true)
            {
                //MessageBox.Show("HI");
                viewModel.setting.isSpaceClosed = true;
                viewModel.status.crown = false;
                viewModel.status.rct = false;
                viewModel.status.ortho = false;
                viewModel.status.mobility = false;
                viewModel.status.vitality = false;

                imagebig.Source = new BitmapImage(new Uri(@"/Assets/finding_typs/space closed.PNG", UriKind.Relative));
                labelhd.Visibility = Visibility.Hidden;

                crown_panel.Visibility = Visibility.Hidden;
                rct_panel.Visibility = Visibility.Hidden;
                ortho_panel.Visibility = Visibility.Hidden;
                mobility_panel.Visibility = Visibility.Hidden;
                vitality_panel.Visibility = Visibility.Hidden;
            }
            UpdateLabel();
        }

        private void closedright_Checked(object sender, RoutedEventArgs e)
        {
            viewModel = new CompositeViewModel();
            if (closedright.IsChecked == true)
            {
                //MessageBox.Show("HI");
                viewModel.setting.isClosedRight = true;
                viewModel.status.crown = false;
                viewModel.status.rct = false;
                viewModel.status.ortho = false;
                viewModel.status.mobility = false;
                viewModel.status.vitality = false;

                imagebig.Source = new BitmapImage(new Uri(@"/Assets/finding_typs/closed right.PNG", UriKind.Relative));
                labelhd.Visibility = Visibility.Hidden;

                crown_panel.Visibility = Visibility.Hidden;
                rct_panel.Visibility = Visibility.Hidden;
                ortho_panel.Visibility = Visibility.Hidden;
                mobility_panel.Visibility = Visibility.Hidden;
                vitality_panel.Visibility = Visibility.Hidden;
            }
            UpdateLabel();
        }

        private void closedleft_Checked(object sender, RoutedEventArgs e)
        {
            viewModel = new CompositeViewModel();
            if (closedleft.IsChecked == true)
            {
                //MessageBox.Show("HI");
                viewModel.setting.isClosedLeft = true;
                viewModel.status.crown = false;
                viewModel.status.rct = false;
                viewModel.status.ortho = false;
                viewModel.status.mobility = false;
                viewModel.status.vitality = false;

                imagebig.Source = new BitmapImage(new Uri(@"/Assets/finding_typs/closed left.PNG", UriKind.Relative));
                labelhd.Visibility = Visibility.Hidden;

                crown_panel.Visibility = Visibility.Hidden;
                rct_panel.Visibility = Visibility.Hidden;
                ortho_panel.Visibility = Visibility.Hidden;
                mobility_panel.Visibility = Visibility.Hidden;
                vitality_panel.Visibility = Visibility.Hidden;
            }
            UpdateLabel();
        }

        private void cell1_Click(object sender, RoutedEventArgs e)
        {
            cell1border.Background = new SolidColorBrush(Colors.Green);
        }
    }
}