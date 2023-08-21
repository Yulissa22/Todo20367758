using Todo20367758.Views;

namespace Todo20367758;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));
	}
}
