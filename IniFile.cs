using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

/*Клас використовує функції WritePrivateProfileString і GetPrivateProfileString з бібліотеки WIN32 KERNEL32.dll
 *Необхідні простори імен: System.Runtime.InteropServices та System.Text
 * 
 *Створення чи відкриття іні-файлу в каталозі де знаходиться ехе-файл з іменем таким як і ехе-файл:
 *IniFile MyIni = new IniFile();
 * 
 *Створення чи відкриття іні-файлу в каталозі де знаходиться ехе-файл:
 *IniFile MyIni = new IniFile("Settings.ini");
 *
 *Створення чи відкриття іні-файлу в заданому каталозі:
 *IniFile MyIni = new IniFile(@"C:\Settings.ini");
 *
 *Читання даних з іні-файлу (2 випадок коли використовуються секції):
 *var DefaultVolume = MyIni.Read("DefaultVolume");
 *var DefaultVolume = MyIni.Read("DefaultVolume", "Audio");
 *
 *Запис даних в іні-файл (2 випадок коли використовуються секції):
 *MyIni.Write("DefaultVolume", "100");
 *MyIni.Write("DefaultVolume", "100", "Audio");
 *
 *Перевірити наявність ключа:
 *if(!MyIni.KeyExists("DefaultVolume", "Audio")) MyIni.Write("DefaultVolume", "100", "Audio");
 *   
 *Видалити ключ: 
 *MyIni.DeleteKey("DefaultVolume", "Audio");     
 *    
 *Видалити секцію:     
 *MyIni.DeleteSection("Web");*/

namespace myPaint
{
    class IniFile
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}