using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter3_ContentView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubContentView : ContentView
    {
        public SubContentView()
        {
            InitializeComponent();
        }
    }
}