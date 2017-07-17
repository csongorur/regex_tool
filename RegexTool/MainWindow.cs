using System;
using Gtk;
using System.Text.RegularExpressions;

public partial class MainWindow: Gtk.Window
{
	private String backRegex;
	private String backReplace;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnOkClicked (object sender, EventArgs e)
	{
		String result;
		String text;
		backRegex = txtRegex.Text;
		backReplace = txtReplace.Text;
		text = txtText.Buffer.Text;
		Regex regex = new Regex (backRegex);
		result = regex.Replace (text,backReplace);
		display.Buffer.Text = result;
	}

	protected void OnBtnBackClicked (object sender, EventArgs e)
	{
		txtRegex.Text = "";
		txtReplace.Text = "";
		txtText.Buffer.Text = "";
		display.Buffer.Text = "";
	}
}
