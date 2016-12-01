using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelloRegex
{
    class a7IFC
    {
        MatchCollection _IFCInstance;
        public a7IFC(string _inPath)
        {
            if (Regex.IsMatch(_inPath, "ifc$", RegexOptions.IgnoreCase))
            {
                StreamReader read = new StreamReader(_inPath);
                getIFCInstance(read.ReadToEnd());
                read.Close();
                a7Message.ShowMessage("Success, IFC instance Count : " + _IFCInstance.Count.ToString() + "\n");
            }
            else
                a7Message.ShowMessage("This path is wrong : \n\t" + _inPath + "\n");
        }
        public a7IFC(ref string _inIFCString)
        {
            getIFCInstance(_inIFCString);
        }

        void getIFCInstance(string _inIFCString)
        {
            _IFCInstance = Regex.Matches(_inIFCString, "#.*?;");
        }
    }
}
