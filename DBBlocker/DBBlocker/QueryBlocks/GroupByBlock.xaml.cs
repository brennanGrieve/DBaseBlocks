﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DBBlocker
{
    /// <summary>
    /// Interaction logic for GroupByBlock.xaml
    /// </summary>
    public partial class GroupByBlock : QueryBlockBase
    {
        public GroupByBlock()
        {
            InitializeComponent();
        }

        public override void EnableInput()
        {
            throw new NotImplementedException();
        }

        public override string ExtractSQL()
        {
            throw new NotImplementedException();
        }
    }
}