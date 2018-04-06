using System.Windows;

namespace WhatAChamp
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Loading loadingWindow = new Loading();
            var app = new Application();
            app.Run(loadingWindow);
        }
    }
}
