using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door
{
    public class Door
    {
        private bool Open;
        private bool Close;
        private bool Locked;
        private bool unLocked;

        private const string Key = "JoseKey";

        public Door(bool open, bool close, bool locked, bool unlocked)
        {
            this.Open = open;
            this.Close = close;
            this.Locked = locked;
            this.unLocked = unlocked;
        }

        public void OpenAndUnlocked(string key)
        {
            if(Key == key)
            {
                Open = true;
                unLocked = true;
                
            }
        }
        public void OpenAndLocked(string key)
        {
            if(Key == key)
            {
                Open = true;
                Locked = true;
            }
        }
        public void ClosedAndUnlocked(string key)
        {
            if (Key == key)
            {
                Close = true;
                unLocked = true;
            }        }
        public void ClosedAndLocked(string key)
        {
            if(Key == key)
            {
                Close = true;
                Locked = true;
            }
        }

        public bool OpenDoor()
        {
            if(Open == false && unLocked == true && Close == true && Locked == false)
            {
                Close = false;
                Open = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CloseDoor()
        {
            if(Close == false && Open == true && Locked == false && unLocked == true)
            {
                Open = false;
                Close = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LockedDoor()
        {
            if(Close == true && unLocked == true && Open == false && Locked == false)
            {
                unLocked = false;
                Locked = true;
                return Locked;
            }
            else
            {
                return false;
            }
        }

        public bool unLockedDoor(string key)
        {
            if(Open == false && Close == true && Locked == true && unLocked == false && Key == key)
            {
                Locked = false;
                unLocked = true;
                return unLocked;
            }
            else
            {
                return false;
            }
        }

        public bool isOpen()
        {
            return Open;
        }

        public bool isClose()
        {
            return Close;
        }

        public bool isLocked()
        {
            return Locked;
        }

        public bool isUnLocked()
        {
            return unLocked;
        }


    }
}
