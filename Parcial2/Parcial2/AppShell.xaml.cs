﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : TabbedPage
    {
        public AppShell()
        {
            InitializeComponent();
        }
    }
}