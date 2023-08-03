using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public partial class model : Component
    {
        public model()
        {
            InitializeComponent();
        }

        public model(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
