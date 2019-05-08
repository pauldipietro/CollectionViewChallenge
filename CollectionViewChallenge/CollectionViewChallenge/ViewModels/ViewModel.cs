using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using NLipsum.Core;

namespace CollectionViewChallenge
{
	public class ViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public String Column1 { get; set; } = String.Empty;
		public String Column2 { get; set; } = String.Empty;

		LipsumGenerator lipsum = new LipsumGenerator();
		Random random = new Random(DateTime.Now.Millisecond);
		bool collapsed = false;

		public ViewModel()
		{
			CreateRandomText();
		}

		public void Toggle()
		{
			collapsed = !collapsed;
			CreateRandomText();
		}

		void CreateRandomText()
		{
			if (collapsed)
			{
				Column1 = "Tap to create random Text!";
				Column2 = String.Empty;
			}
			else
			{
				var words = lipsum.GenerateWords(random.Next(5, 50));
				var text = String.Join(" ", words.ToArray());

				Column1 = text;

				words = lipsum.GenerateWords(random.Next(2, 20));
				text = String.Join(" ", words.ToArray());

				Column2 = text;
			}
		}

	}
}