using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        int quoteIndex = 0;
        private string[] _quotes = new string[]
        {
            "Life is like riding a bicycle. To keep your balance, you must keep moving.",
            "You can't blame gravity for falling in love.",
            "Look deep into nature, and then you will understand everything better."
        };

        public QuotesPage()
        {
            InitializeComponent();
            quoteLabel.Text = _quotes[quoteIndex];
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            quoteIndex++;
            if (quoteIndex >= _quotes.Length)
                quoteIndex = 0;

            quoteLabel.Text = _quotes[quoteIndex];
        }
    }
}