
using Avalonia;
using Avalonia.Controls;
using SmartDesk.Context;
using System.Linq;

namespace SmartDesk.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            /*using (var context = new SmartDeskContext())
            {
                ///тест бд
                asd.Text = $"{context.Roles.Count()}"; 
            }*/
        }
    }
}