using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Threading;
using System.Globalization;
using System.ComponentModel;



namespace SearchForm
{
    public class RegistryHelper
    {
        public RegistryKey regHiveKey = Registry.LocalMachine;
        public List<RegistryData> results = new List<RegistryData>();

        private void CheckKeyAndValues(RegistryKey Key, bool isKey, string term)
        { //Check if there are values for a given key and add data to the results list
            string[] valueNames = Key.GetValueNames();
            if (valueNames == null || valueNames.Length <= 0) //has no values
            {
                if (isKey && term.Equals(Key.Name.Substring(Key.Name.LastIndexOf(@"\") + 1)))  //Search by key
                {
                    RegistryData rd = new RegistryData(Key.Name, "no values");
                    results.Add(rd);
                }
                else  //Search by value
                    return;
            }
            else
            {
                foreach (string valueName in valueNames)
                {
                    object obj = Key.GetValue(valueName);
                    if (obj != null)
                    {
                        if ((isKey && term.Equals(Key.Name.Substring(Key.Name.LastIndexOf(@"\") + 1))) || (!isKey && term.Equals(valueName)))
                        {
                            RegistryData rd = new RegistryData(Key.Name, valueName);
                            results.Add(rd);
                        }
                    }

                }
            }
        }

        private void RecursiveSearchKeysTree(RegistryKey Key, bool isKey, string term, System.ComponentModel.BackgroundWorker bw, DoWorkEventArgs e)
        {
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
                    string[] subKeyNames = Key.GetSubKeyNames();
                    if (subKeyNames == null || subKeyNames.Length <= 0)
                    {
                        CheckKeyAndValues(Key, isKey, term);
                        return;
                    }
                    foreach (string keyName in subKeyNames)
                    {
                        using (RegistryKey key2 = Key.OpenSubKey(keyName))
                            RecursiveSearchKeysTree(key2, isKey, term, bw, e);
                    }
                    CheckKeyAndValues(Key, isKey, term);
                }
                catch (Exception exp)
                {
                    Console.WriteLine("Exception:  " + exp);
                }
            }
        }

        public void RecursiveSearchKeysTreeWrapper(bool isKey, string term, System.ComponentModel.BackgroundWorker bw, DoWorkEventArgs e)
        {
            RecursiveSearchKeysTree(regHiveKey, isKey, term, bw, e);
            e.Result = results;
        }
    }
}
