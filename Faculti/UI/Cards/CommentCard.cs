﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculti.UI.Cards
{
    public partial class CommentCard : UserControl
    {
        public CommentCard(string commentBody)
        {
            InitializeComponent();
            CommentBodyLabel.Text = commentBody;
            CommentContainer.Height = CommentBodyLabel.Height + 40;
        }
    }
}