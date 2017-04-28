using System;
using System.Collections.Generic;
using System.Globalization;
using ns14;

namespace ns15
{
	public class SectionInterpreter
	{
		public Track<int, List<string>> OtherList = new Track<int, List<string>>();

		public Track<int, string> SectionList = new Track<int, string>();

		public SectionInterpreter()
		{
		}

		public SectionInterpreter(string[] string0)
		{
			for (var i = 0; i < string0.Length; i++)
			{
				var text = string0[i];
				var array = text.Split(new[]
				{
					'=',
					'"'
				}, 3, StringSplitOptions.RemoveEmptyEntries);
				if (array.Length == 3 && !(array[1].Trim() != "E"))
				{
					array[2] = array[2].TrimEnd(' ', '\t');
					if (array[2].EndsWith("\""))
					{
						array[2] = array[2].Substring(0, array[2].Length - 1);
					}
					var num = ChartParser.GetNoteFromResolution(array[0].Trim());
					if (array[2].StartsWith("section "))
					{
						SectionList.Add(num, CultureInfo.CurrentCulture.TextInfo.ToTitleCase(array[2].Substring("section ".Length).Replace('_', ' ')));
					}
					else if (OtherList.ContainsKey(num))
					{
						OtherList[num].Add(array[2]);
					}
					else
					{
						OtherList.Add(num, new List<string>());
						OtherList[num].Add(array[2]);
					}
				}
			}
		}
	}
}
