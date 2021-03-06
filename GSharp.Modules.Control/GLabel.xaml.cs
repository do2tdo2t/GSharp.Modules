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
using GSharp.Extension.Abstracts;
using GSharp.Extension.Attributes;

namespace GSharp.Modules.Control
{
    /// <summary>
    /// GLabel.xaml에 대한 상호 작용 논리
    /// </summary>
    [GView("글자")]
    public partial class GLabel : GView
    {
        [GControl("내용")]
        public string Text
        {
            get
            {
                return LabelContent.Content.ToString();
            }
            set
            {
                LabelContent.Content = value;
            }
        }

        public GLabel()
        {
            InitializeComponent();
        }
    }
}
