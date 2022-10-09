using System.Collections.Generic;

namespace AMS.Profile._2
{
	/// <summary>
	/// Provides functionality for reading ini files into objects without having to constantly read the files for information.
	/// </summary>
	public static class IniReader
	{
		/// <summary>
		/// Reads a specified ini file into a <see cref="Dictionary{TKey, TValue}"/> with the specified values stored.
		/// </summary>
		/// <param name="IniFile">The ini-config file to be read.</param>
		/// <returns>The information in the ini-config file structurized.</returns>
		public static Dictionary<string, Dictionary<string, string>> ReadConfig(string IniFile)
		{
			Ini reader = new Ini(IniFile);
			Dictionary<string, Dictionary<string, string>> configInfo = new Dictionary<string, Dictionary<string, string>>();

			string[] sections = reader.GetSectionNames();
			foreach (string section in sections)
			{
				Dictionary<string, string> secEntries = new Dictionary<string, string>();

				string[] entries = reader.GetEntryNames(section);
				foreach (string entry in entries)
					secEntries.Add(entry, reader.GetValue(section, entry).ToString());

				configInfo.Add(section, secEntries);
			}

			return configInfo;
		}
	}
}
