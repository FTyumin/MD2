using MD1;

namespace MD2.EditPages;

public partial class EditAssignment : ContentPage
{
	private Assignment assignment;
	public EditAssignment(Assignment assignment)
	{
		InitializeComponent();
		this.assignment = assignment;

	}
}