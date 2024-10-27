namespace MD2.CreatePages;
using MD1;
public partial class CreateStudent : ContentPage
{
	public CreateStudent()
	{
		InitializeComponent();
        
    }
	DataManager dm = GlobalVariables.dm;
	private void OnSaveStudentClicked(object sender, EventArgs e)
	{
		string name = StudentNameEntry.Text;
		string surname = StudentSurnameEntry.Text;

		// šī rinda ir no chatgpt,
		// konvertē ievadi no UI uz Gender vērtību
		Person.Gender gender = (Person.Gender)GenderPicker.SelectedIndex;

		dm.addStudent(name, surname, gender);

		
	}
}