using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class AcmeCar
    {
        public LockState IsLocked { get; private set; }
        ILogger statusLogger = StatusLogger.GetStatusLogger();
        ILogger excLogger = ExceptionLogger.GetExceptionLogger();

        public void Lock()
        {
            try
            {
                //
                this.IsLocked = LockState.Locked;
                //log state change in computer
                statusLogger.Log("CarLocked");

            }
            catch (Exception)
            {
                excLogger.Log("There was an error locking the car!");
            }
        }

        public void Unlock()
        {
            try
            {
                //
                this.IsLocked = LockState.Unlocked;
                //
                statusLogger.Log("CarUnlocked");
            }
            catch (Exception)
            {
                excLogger.Log("There was an error unlocking the car!");
            }
        }
    }

    public enum LockState
    {
        Error = 0,
        Locked = 1,
        Unlocked = 2,

    }
}
