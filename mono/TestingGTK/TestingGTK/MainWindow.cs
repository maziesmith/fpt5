using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnHelloBtnClicked (object sender, EventArgs e)
	{
		new MessageDialog (this, 0, MessageType.Info, ButtonsType.Close, "Hello", "Message")
			.Show();
	}
}
