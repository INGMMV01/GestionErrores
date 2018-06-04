using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public partial class Global: Component
    {    
        public Global()
        {
            InitializeComponent();
        }

        public Global(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


    }
}
