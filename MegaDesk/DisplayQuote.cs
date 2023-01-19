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
        public DisplayQuote(string nameLabel, string widthLabel, string depthLabel, string drawersLabel, string materialLabel, string shippingLabel)
        {
            InitializeComponent();
            customerName.Text = nameLabel;
            deskWidth.Text = widthLabel;
            deskDepth.Text = depthLabel;
            drawersNum.Text = drawersLabel;
            deskMaterial.Text = materialLabel;
            shippingTime.Text = shippingLabel;
        }
    }
}
