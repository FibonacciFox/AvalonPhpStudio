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
        
        public UxContentControl()
        {
            _dataContent = new Dictionary<string, PhpValue>();

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

