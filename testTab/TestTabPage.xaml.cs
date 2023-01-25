using System;
using System.Drawing;
using Color = Microsoft.Maui.Graphics.Color;

namespace testTab;

public partial class TestTabPage : TabbedPage
{
	public TestTabPage()
	{
		InitializeComponent();
		SelectedTabColor = Colors.Red;
	}
}


//SelectedTabColor="DodgerBlue"