using DatagridTest2.EFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatagridTest2.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        DatagridTest2Context db;
        private List<User> _UsersList = null;
        //private List<Users> _UsersListDummy = null;
        //private Thread thread;
        //bool keepthreading = true;
        public List<User> UsersList
        {
            get { return _UsersList; }
            set { _UsersList = value; OnPropertyChanged("UsersList"); }
        }
        public HomeViewModel()
        {
            db = new DatagridTest2Context();
            UsersList = db.Users.ToList();
        }
        public void dispose()
        { }
    }
}
