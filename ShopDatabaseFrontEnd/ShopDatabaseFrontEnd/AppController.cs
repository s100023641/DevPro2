using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopDatabaseFrontEnd
{
   
    class AppController : ApplicationContext 
    {
        public static AppController Main;

        public AppController() {
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            StateHistory = new Stack<Form>();
            Form _new = new frmHome();
            StateHistory.Push(_new);
            _new.Show();
            _new.Activate();
            _new.Closed += new EventHandler(OnFormClosed);
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        public void Back()
        {
            Form _cur = StateHistory.Pop();
            _cur.Hide();
            _cur.Dispose();
            Form _new = StateHistory.Peek();
            _new.Show();
            _new.Activate();
            _new.Closed += new EventHandler(OnFormClosed);
        }

        public void ChangeState(string stateName)
        {
            Form _cur=StateHistory.Peek();
            _cur.Hide();
            Form _new;
            if (stateName == "AddSales") {
                _new = new frmAddSales();
            }else if (stateName == "Stock") {
                _new=new frmStock();
            }
            else if (stateName == "Sales")
            {
                _new = new frmSales();
            }
            else {
                throw new System.NotImplementedException();
            }
            
            _new.Show();
            _new.Activate();
           _new.Closed += new EventHandler(OnFormClosed);
           StateHistory.Push(_new);
        }

        private Stack<Form> StateHistory;

        public Form CurrentForm
        {
            get { return StateHistory.Peek(); }
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            // When a form is closed, decrement the count of open forms.

            // When the count gets to 0, exit the app by calling
            // ExitThread().

            Form _top = StateHistory.Peek();
            if (sender is Form)
            {
                Console.WriteLine("On form closed called");
            }
             if (sender == _top)
            {
                ExitThread();
            }
        }

        public void Run()
        {
            while (StateHistory.Count() > 0)
            {

            }
        }
    }
}
