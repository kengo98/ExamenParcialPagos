using Parcial2.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial2.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }

    }
}
