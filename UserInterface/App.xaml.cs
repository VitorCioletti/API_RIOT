namespace WhatAChamp
{
	using System.Windows;
	
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var app = new Application();
            app.Run();
        }
    }
}
