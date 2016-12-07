using System;
using System.Collections.Generic;
using System.Linq;
namespace LocaleEditor
{

	public class SingleLocale
	{
		public string Name { get; set; }
		public string Code { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}

	public class LocalizationProject
	{
		private SingleLocale defaultLocale = null;
		public string FileName { get; set; }
		public bool IsSaved { get; set; }

		public LocalizationProject()
		{
			IsSaved = true;
		}

		public SingleLocale DefaultLocale
		{
			get
			{
				return defaultLocale;
			}

			set
			{
				if (locales.Contains(value) || (value == null))
				{
					defaultLocale = value;
				}
				else
				{
					throw new Exception("Locale is not in locale list");
				}
			}
		}

		private List<SingleLocale> locales = new List<SingleLocale>();
		public List<SingleLocale> Locales { get { return locales; } }
	}

	public class LocaleSection
	{
		public LocaleSection(string name) { Name = name; }
		public string Name { get; set; }
	}

	public class LocaleValue
	{
		public string Name { get; set; }
		public LocaleValue(string name) { Name = name; }
		private Dictionary<SingleLocale, string> values = new Dictionary<SingleLocale, string>();
		public string this[SingleLocale index]
		{
			get
			{
				if (!values.ContainsKey(index))
					return "";
				else
					return values[index];
			}

			set
			{
				values[index] = value;
			}
		}
	}
}
