using System;
using System.IO;

namespace applog
{
    public class LogSystem
    {
        public bool WriteNow(string path, string logs)
        {
			try
			{
				string last = path.Substring(path.Length - 1);
				if (last == "\\")
				{
					if (File.Exists(path+"Logs.log"))
					{
						string gelenlog = File.ReadAllText(path + "Logs.log");
						gelenlog = gelenlog + Environment.NewLine + logs;
						File.WriteAllText(path + "Logs.log", gelenlog);
						return true;
					}
					else
					{
						File.Create(path + "Logs.log");
						File.WriteAllText(path + "Logs.log", logs);
						return true;
					}
				}
				else
				{
					if (File.Exists(path +"\\"+ "Logs.log"))
					{
						string gelenlog = File.ReadAllText(path + "\\" + "Logs.log");
						gelenlog = gelenlog + Environment.NewLine + logs;
						File.WriteAllText(path + "\\" + "Logs.log", gelenlog);
						return true;
					}
					else
					{
						File.Create(path + "\\" + "Logs.log");
						File.WriteAllText(path + "\\" + "Logs.log", logs);
						return true;
					}
				}
			}
			catch (Exception excep)
			{
				throw excep;
			}
        }
    }
}
