﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamLogbook
{
	internal class Record
	{
		/*
		Класс для создания записи об учащемся
		*/
		string group; string name; string lesson;
		string date; int mark; int miss = 0;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Lesson
		{
			get { return lesson; }
			set { lesson = value; }
		}
		public string Date
		{
			get { return date; }
			set { date = value; }
		}
		public int Mark
		{
			get { return mark; }
			set { mark = value; }
		}
		public int Miss
		{
			get { return miss; }
			set { miss = value; }
		}

		public string Group
		{
			get { return group; }
			set { group = value; }
		}

		public void print()
		{
			MessageBox.Show(group + " " + name + " " + lesson + " " + date.ToString() + " " + mark.ToString() + " " + miss.ToString());
		}
	}
}
