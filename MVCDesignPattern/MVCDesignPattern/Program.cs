namespace MVCDesignPattern;

class Program
{
    public static void Main()
    {
        UserModel model = new UserModel("John Doe", 30);

        // Create the view
        UserView view = new UserView();

        // Create the controller
        UserController controller = new UserController(model, view);

        // Display initial data
        controller.UpdateView();

        // Update model from user input and display updated data
        controller.UpdateModelFromInput();
        controller.UpdateView();
    }
}
