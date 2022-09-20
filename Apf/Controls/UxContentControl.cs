using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Pchp.Core;

namespace Apf.Controls;

    /// <summary>
    /// Displays <see cref="UxContentControl.Content"/> according to a <see cref="FuncDataTemplate"/>.
    /// </summary>
    public class UxContentControl : ContentControl
{
        
        /// <summary>
        /// 
        /// </summary>
        private readonly IDictionary<string, PhpValue> _dataContent;

        /// <summary>
        /// События  <see cref="UxContentControl.Listener"/>
        /// </summary>
        public UxEvents Listener;
            
        public UxContentControl()
        {
            _dataContent = new Dictionary<string, PhpValue>();
            
            Listener = new UxEvents(this);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
         public PhpValue this[string key]
         {
             get {
                 return _dataContent[key];
             }
             set
             {
                 _dataContent[key] = value;
             }
         }

}

