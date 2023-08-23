using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Cache;
using System.Runtime.Intrinsics.X86;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Astrologer_App
{
    /// <summary>
    /// Interaction logic for Astrologer.xaml
    /// </summary>
    public partial class Astrologer : Window
    {
        
        public Astrologer()
        {
            InitializeComponent();
        }

        private void btngen_Click(object sender, RoutedEventArgs e)
        {
            int Age = 2023 - Convert.ToInt32(txtyear.Text);

            Result Oresult = new Result();
            Oresult.Show();


            string result = "Dear {name}_{age},";
            string data = result.Replace("{name}", txtname.Text);
            data = data.Replace("{age}", Age.ToString());
            Oresult.tblockhead.Text = data;

            string gre = "{Greetings}";


            if (Age < 20)
            {
                
                string value = gre.Replace(gre, "You're a fantastic listener & You follow directions perfectly.");
                Oresult.tblockresult.Text = value;
            }
            else
            {
                if (Age > 20 && Age < 24)
                {
                    string value = gre.Replace(gre, "Your passion to read, write and learn is infectious in College.");
                    Oresult.tblockresult.Text = value;
                }
                else if (Age > 24 && Age < 28)
                {
                    string value = gre.Replace(gre, "You've done a great job on this assignment.");
                    Oresult.tblockresult.Text = value;
                }

                else if (Age > 28 && Age < 32)
                {
                   
                    string value = gre.Replace(gre, "You make work your passion, and that’s why you succeed.");
                    Oresult.tblockresult.Text = value;
                }

                else if (Age > 32 && Age < 36)
                {
                    
                    string value = gre.Replace(gre, "You've faced many challenges and it'll be Win.");
                    Oresult.tblockresult.Text = value;
                }

                else if (Age > 36 && Age < 40)
                {
                    
                    string value = gre.Replace(gre, "Your handle and execute your work is a masterclass in and of itself. ");
                    Oresult.tblockresult.Text = value;
                }

                else if (Age > 40 && Age < 44)
                {
                    
                    string value = gre.Replace(gre, "Your leadership is an asset to this team and an inspiration to others.");
                    Oresult.tblockresult.Text = value;
                }

                else if (Age > 44 && Age < 48)
                {
                   
                    string value = gre.Replace(gre, "There is no doubt that you will rise.. Keep going!");
                    Oresult.tblockresult.Text = value;
                }

                else if (Age > 48 && Age < 55)
                {
                   
                    string value = gre.Replace(gre, "As you worked toward this victory <3");
                    Oresult.tblockresult.Text = value;
                }

                else if (Age > 55 && Age < 80)
                {
                    
                    string value = gre.Replace(gre, "Freedom is another name of retirement <3");
                    Oresult.tblockresult.Text = value;
                }
                
            }
        }

        
    }
}
