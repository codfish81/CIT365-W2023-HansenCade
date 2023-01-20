using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuotes deskQuote)
        {
            InitializeComponent();
            customerName.Text = deskQuote.CustomerName;
            deskWidth.Text = Convert.ToString(deskQuote.Width);
            deskDepth.Text = Convert.ToString(deskQuote.Depth);
            drawersNum.Text = Convert.ToString(deskQuote.Drawers);
            deskMaterial.Text = deskQuote.Material;
            //shippingTime.Text = shippingLabel;
        }
    }
}
