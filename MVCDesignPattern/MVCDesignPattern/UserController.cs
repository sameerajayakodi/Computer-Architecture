using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDesignPattern
{
    public class UserController
    {
        private UserModel _model;
        private UserView _view;

        public UserController(UserModel model, UserView view)
        {
            _model = model;
            _view = view;
        }

        public void UpdateView()
        {
            _view.DisplayUserDetails(_model.Name, _model.Age);
        }

        public void UpdateModelFromInput()
        {
            _model.Name = _view.GetUserInput("Enter Name: ");
            _model.Age = int.Parse(_view.GetUserInput("Enter Age: "));
        }
    }
}
