using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StyleExamples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocalDesignPage : ContentPage
    {
        const string placeHolderText = "Type your message here";

        void HandleFeedback(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            var text = Feedback.Text;

            if (Feedback.Text == placeHolderText)
            {
                Feedback.Text = string.Empty;
                Feedback.TextColor = Color.Navy;
                return;
            }

            if (Feedback.Text == string.Empty)
            {
                Feedback.Text = placeHolderText;
                Feedback.TextColor = Color.Silver;
                return;
            }
        }

        public LocalDesignPage()
        {
            InitializeComponent();
            Feedback.Text = placeHolderText;
            Feedback.TextColor = Color.Silver;
        }
    }
}