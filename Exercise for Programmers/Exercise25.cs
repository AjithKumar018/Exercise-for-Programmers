using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
	class Exercise25
	{
		int nNumber = 0;
		public void Solution()
		{
			string strPassword;
			Console.Write("Enter the Password: ");
			strPassword = Console.ReadLine();

			passwordValidator(strPassword);
		}

		public void passwordValidator(string pass)
		{
			string password = pass;
			int nLen = password.Length;

			for (int i = 0; i < nLen; i++)
			{
				if (char.IsDigit(password[i]) && nLen < 8)
				{
					nNumber = 1;
				}
				else if (char.IsLetter(password[i]) && nLen < 8)
				{
					nNumber = 2;
				}
				else if (nLen >= 8)
				{
					if (char.IsLetterOrDigit(password[i]))
					{
						nNumber = 3;
					}
					else
					{
						nNumber = 4;
					}
				}
			}

			switch (nNumber)
			{
				case 1:
					Console.WriteLine("Very Weak Password.\n");
					break;
				case 2:
					Console.WriteLine("Weak Password.\n");
					break;
				case 3:
					Console.WriteLine("Strong Password.\n");
					break;
				case 4:
					Console.WriteLine("Very Strong Password. \n");
					break;
				default:
					break;
			}
		}
	}
}
