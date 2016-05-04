using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TPSMetaTest.Properties;

namespace TPSMetaTest
{
    public partial class ProtocolViewForm : Form
    {
        public ProtocolViewForm()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            this.Icon = Resources.icon;
        }
    }
}
