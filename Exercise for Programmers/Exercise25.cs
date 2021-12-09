using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
	class Exercise25
	{
		int nNumb = 0;

		public void Solution()
		{
			string strPass;

			Console.Write("Enter the Password: ");
			strPass = Console.ReadLine();

			passwordValidator(strPass);

		}
		public void passwordValidator(string password)
		{
			string pass = password;
			int nLen = pass.Length;

			for (int i = 0; i < nLen; i++)
			{
				if (char.IsDigit(pass[i]) && nLen < 8)
				{
					nNumb = 1;
				}
				else if (char.IsLetter(pass[i]) && nLen > 8)
				{
					nNumb = 2;
				}
				else if (nLen >= 8)
				{
					if (char.IsLetterOrDigit(pass[i]))
					{
						nNumb = 3;
					}
					else
					{
						nNumb = 4;
					}
				}
			}

			switch (nNumb)
            {
				case 1:
					Console.Write("Very Weak Password.\n");
					break;
				case 2:
					Console.Write("Weak Password.\n");
					break;
				case 3:
					Console.Write("Strong Password.\n");
					break;
				case 4:
					Console.Write("Very Strong Password.\n");
					break;
				default:
					break;
            }
		}
	}
}