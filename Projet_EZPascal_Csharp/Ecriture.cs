using System;
namespace Projet_EZPascal_Csharp
{
	public class Ecriture
	{
		private Ecriture()
		{
		}

		private static Singleton _instance;

		public static Singleton GetInstance()
		{
			if (_instance == null)
			{
				_instance = new Singleton();
			}
			return _instance;
		}
	}
}