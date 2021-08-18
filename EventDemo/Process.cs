using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public class Process
    {
        //declaring an event
        public event EventHandler ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process started");
            //
            OnProcessCompleted(EventArgs.Empty);

        }

        protected virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }

}
