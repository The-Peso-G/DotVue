﻿using DotVue;
using System;

namespace WebApp.Pages
{
    public class Encoding : ViewModel
    {
        public string Text { get; set; }

        public void FromServer()
        {
            this.Text = "Hèllo Wôrld - Mãçâ";

            this.ClientScript.Alert(this.Text);
        }
    }
}
