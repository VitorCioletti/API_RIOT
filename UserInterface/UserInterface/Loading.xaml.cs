namespace WhatAChamp
{
	using System.Windows;

	public partial class Loading : Window
	{
		public Loading()
		{
			InitializeComponent();

			Show();

			new WhatAChampUI().Show();

			Close();
		}
	}
}
