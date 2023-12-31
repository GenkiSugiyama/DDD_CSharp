﻿using DDD.WinForm.ViewModels;
using System;
using System.Windows.Forms;

namespace DDD.WinForm
{
    public partial class WeatherLatestView : Form
    {
        private WeatherLatestViewModel _viewModel = new WeatherLatestViewModel();
        public WeatherLatestView()
        {
            InitializeComponent();

            this.AreaIdTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.AreaIdText));
            this.DataDateLabel.DataBindings.Add("Text", _viewModel, nameof(_viewModel.DataDateText));
            this.ConditionLabel.DataBindings.Add("Text", _viewModel, nameof(_viewModel.ConditionText));
            this.TemperatureLabel.DataBindings.Add("Text", _viewModel, nameof(_viewModel.TemperatureText));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LatestButton_Click(object sender, EventArgs e)
        {
            _viewModel.Search();
        }

        
    }
}
