using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace lab2_Test_Calc
{
    class Finder
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern uint FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern uint FindWindowEx(uint hwndParent, uint hwndChildAfter, string className, string windowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(uint hWnd, int msg, int wParam, int lParam);

        [DllImport("User32.Dll")]
        public static extern int GetClassName(int hwnd, StringBuilder lpClassName, int nMaxCount);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public static extern int RegisterWindowMessage(string lpString);

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = System.Runtime.InteropServices.CharSet.Auto)] //
        public static extern bool SendMessage(IntPtr hWnd, uint Msg, int wParam, StringBuilder lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SendMessage(int hWnd, int Msg, int wparam, int lparam);

        const int WM_LBUTTONDOWN = 0x0201;
        const int WM_LBUTTONUP = 0x0202;
        const int WM_KEYDOWN = 0x0100;
        const int WM_KEYUP = 0x0101;
        const int WM_CHAR = 0x0102;
        const int BM_CLICK = 0x00F5;
        const int WM_SETTEXT = 0x000C;
        const int WM_GETTEXT = 0x000D;
        const int WM_GETTEXTLENGTH = 0x000E;

        // Нажать кнопку с текстом «1» на стандартном калькуляторе 
        public void pressbtn_standartcalc(string winName)
        {
            // находим окно калькулятора, зная window class ("SciCalc"-XP   "CalcFrame"-Win7  )
            uint calcWnd = FindWindowEx(0, 0, "CalcFrame", null);
            // находим кнопку по имени окна ("1") и имени класса ("TButton")
            uint button1 = FindWindowEx(calcWnd, 0, "TButton", winName);
            // если нашли
            if (button1 != 0)
            {
                // посылаем нажатие кнопки мыши
                SendMessage(button1, WM_LBUTTONDOWN, 0, 0);
                SendMessage(button1, WM_LBUTTONUP, 0, 0);
            }
        }

        // Нажать кнопку по хэндлу, заданному в окне ввода в шестнадцатеричном формате 
        public void pressbtn_handle(string HNDL_TEXT)
        {
            string s = HNDL_TEXT;//.Lines[0];
            uint hnd = uint.Parse(s, System.Globalization.NumberStyles.HexNumber);
            SendMessage(hnd, BM_CLICK, 0, 0);
        }


        string WindowFormName = "", WindowFormClassName = "", WindowElementClassName = "",editClassName = "", strBM_CLICKS ="";
        int BM_CLICKS;

        public string start()
        {
            dict.Clear();
            return detected_FormName();
        }
        // Нажать кнопку с текстом «1» на калькуляторе CALC 
        public void pressbtn_CALC(string winName)
        {
            dict.TryGetValue("WindowFormName", out WindowFormName);
            dict.TryGetValue("WindowElementClassName", out WindowElementClassName);
            dict.TryGetValue("WindowFormClassName", out WindowFormClassName);
            dict.TryGetValue("editClassName", out editClassName);

            //dict.TryGetValue("BM_CLICKS", out strBM_CLICKS);
            // BM_CLICKS = Convert.ToInt32(strBM_CLICKS);

            // находим кнопку по имени окна ("1") и имени класса ("Button")
            uint calcWnd = FindWindowEx(0, 0, WindowFormClassName, WindowFormName);
            uint button1 = FindWindowEx(calcWnd, 0, WindowElementClassName, winName);

            // если нашли
            if (button1 != 0)
            {
                // посылаем нажатие кнопки мыши
                SendMessage(button1, BM_CLICK, 0, 0);
            }

        }

        public void RegisterControlforMessages()
        {
          RegisterWindowMessage("WM_GETTEXT");
        }
        public string GetControlText()
        {
            uint calcWnd = FindWindowEx(0, 0, WindowFormClassName, WindowFormName);
            uint hWnd  = FindWindowEx(calcWnd, 0, editClassName, "");
          StringBuilder title = new StringBuilder();
          Int32 size = SendMessage((int)hWnd, WM_GETTEXTLENGTH, 0, 0).ToInt32();
          if (size > 0)
          {
              title = new StringBuilder(size + 1);
              SendMessage((IntPtr)hWnd,(int)WM_GETTEXT, title.Capacity, title);
          }
          return title.ToString();
        }
       

        public SortedDictionary<string, string> dict = new SortedDictionary<string, string>();
        private string detected_FormName()
        {
            string text = "";
            string answer = "";
            using (StreamReader fs = new StreamReader("script.txt", Encoding.Default))
            {
                while (true)
                {
                    string temp = fs.ReadLine();
                    if (temp == null) break;
                    text += temp + "\n";
                }
            }
            string[] textline = text.Trim().Split('\n');
            for (int i = 0; i < textline.Length; i++)
            {
                if (new Regex("detect").Matches(textline[i].Trim()).Count == 1)
                    //textline[i].Trim() == "detect") 
                {
                    i++;
                    while (new Regex("enddetect").Matches(textline[i].Trim()).Count != 1)
                       // textline[i + 1].Trim() != "enddetect;")
                    {
                        string [] temp = textline[i].Trim().Split(':');
                        dict.Add(temp[0], temp[1]);
                        i++;
                    }
                }

                if (new Regex("expressions").Matches(textline[i].Trim()).Count == 1)
                //textline[i].Trim() == "detect") 
                {
                    i++;
                    while (new Regex("endexpressions").Matches(textline[i].Trim()).Count != 1)
                    // textline[i + 1].Trim() != "enddetect;")
                    {
                        answer += textline[i].Trim();
                        answer += "C";
                        i++;
                    }
                }

                if (new Regex("pressbtn").Matches(textline[i].Trim()).Count == 1)
                {
                    i++;
                    while (new Regex("endpressbtn").Matches(textline[i].Trim()).Count != 1)
                    {
                        answer += textline[i].Trim();
                        i++;
                    }
                    answer += "C";
                }
            }
            return answer;
        }

       
    }
}
