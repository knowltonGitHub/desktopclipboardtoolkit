using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClipboardToolkit
{
    public enum EventType
    {
        clipboarditemcontrol_listboxselectedindexchanged,
        clipboarditemcontrol_deleteclipboarditembuttonclick,
        clipboarditemcontrol_clearlistbox,
        clipboarditemcontrol_neworupdateclipboarditem,
        tagcontrol_listboxselectedindexchanged,
        tagcontrol_processselectedfiltertags,        
        tagcontrol_deleteexistingtagbuttonclick,
        tagcontrol_clearlistbox,
        tagcontrol_taglistwasjustreturned,
        tagcontrol_addnewtag,
        tagcontrol_fillclipboarditemsbasedonselectedfilters,
        clipboarditemcontrol_updatecount,
        clipboarditemcontrol_clearclipboardmemorybuttonclick,
        addlogitemtext,
        clear_value_textbox,
        new_clipboarditem,
        update_clipboarditem
    }
       
    public class CustomEvents
    {
        public event EventHandler<CustomEventArgs> ApplicationEvent;
        
        public void AppEvent(object sender, CustomEventArgs e)
        {
            EventHandler<CustomEventArgs> handler = ApplicationEvent;

            if(handler != null)
            {
                handler(sender, e);
            }
        }      
    }

    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(String tempmessage, EventType tempeventtype)
        {            
            message = tempmessage;
            et = tempeventtype;
        }

        public string message = Helper.EMPTY_STRING;
        public EventType et;
    }

  
}
