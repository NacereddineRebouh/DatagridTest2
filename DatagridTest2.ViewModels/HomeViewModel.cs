

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DatagridTest2.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        //public DatabaseAccess Dba { get; set; }
        //private List<Users> _UsersList = null;
        //private List<Users> _UsersListDummy = null;
        //private Thread thread;
        //bool keepthreading = true;
        //public List<Users> UsersList
        //{
        //    get { return _UsersList; }
        //    set { _UsersList = value; OnPropertyChanged("UsersList"); }
        //}

        //public HomeViewModel()
        //{ }
        //public HomeViewModel(bool LoopUpdate)
        //{
        //    keepthreading = LoopUpdate;
        //    loopUpdate();
        //}

        //public void loopUpdate()
        //{
        //    thread = new Thread(() =>
        //    {
        //        Thread.CurrentThread.IsBackground = true;
        //        threading();
        //    });
        //    thread.Start();
        //    Debug.WriteLine("Threading has been Called Successfully! :" + Thread.CurrentThread.ManagedThreadId);

        //}
        //private void threading()
        //{
        //    Debug.WriteLine("----------Welcome to HomeViewModel threading Method------------");
        //    //Dba = new DatabaseAccess();
        //    //Dba.OpenConnection();
        //    //while (keepthreading == true)
        //    //{
        //    //    _UsersListDummy = Dba.Get_Users();
        //    //    UsersList = _UsersListDummy;
        //    //    if (_UsersListDummy.Count != UsersList.Count)
        //    //    {
        //    //        UsersList = _UsersListDummy;
        //    //    }

        //    //    //OperationsList 
        //    //    Debug.WriteLine("Updated!" + UsersList.Count + "  " + Thread.CurrentThread.ManagedThreadId);

        //    //    Thread.Sleep(5000);
        //    //}

        //}

        public void dispose()
        {
            //thread.Join();
            //    keepthreading = false;
        }


        //public void Quick_Update()
        //{
        //    new Thread(() =>
        //    {
        //        Thread.CurrentThread.IsBackground = true;
        //        continueUpdate();
        //    }).Start();
        //}

        //public void continueUpdate()
        //{
        //    //Debug.WriteLine("inside continueUpdate!");
        //    //Dba = new DatabaseAccess();
        //    //Dba.OpenConnection();
        //    //_UsersListDummy = Dba.Get_Users();
        //    //UsersList = _UsersListDummy;
        //    //if (_UsersListDummy.Count != UsersList.Count)
        //    //{
        //    //    Debug.WriteLine("update done!");
        //    //    UsersList = _UsersListDummy;
        //    //}
        //}

    }
}
