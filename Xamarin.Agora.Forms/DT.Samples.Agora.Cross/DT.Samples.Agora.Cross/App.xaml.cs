﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DT.Samples.Agora.Cross.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DT.Samples.Agora.Cross
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }

    public static class Consts
    {
        public static string AgoraKey = "8ae3e71b00154c7c9271885c73adf9ac";
    }
}
