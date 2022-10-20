using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exec_DeclareClass
{
//宣告 Address 類別 具備 City, ZipCode, Street 等屬性
//宣告 Telephone 類別 具備 CountryCode, AreaCode, Number, Ext 等屬性
//宣告 Member 類別:
//1.具備 Name, Account, Password, Email, Address, CellPhone,TelePhone 等屬性, 其中 Address, TelePhone的型別沿用上面二個類別
//2.具備 Register method, 用來註冊新會員, 參數包含 Name,Account, Password, ConfirmPassword, Email
//3.具備 ForgetPassword method, 用來處理忘記密碼, 參數包含Name, Email
//4.具備 Authenticate method, 用來判斷是否允許使用者登入, 參數包含 Account, PasswordlareClass\Exec_DeclareClass

	internal class Program
	{
		static void Main(string[] args)
		{
			var person=new Member();
			person.Register("tim", "tim880923", "password", "11034","tim@gmail.com");
			person.ForgetPassword("tim", "tim@gmail.com");
		}
	}

	class Address
	{
		public string City { get; set; }
		public string ZipCode { get; set; }
		public string Street { get; set; }
	}


	class TelePhone
	{
		public string CountryCode { get; set; }
		public string AreaCode { get; set; }
		public string Number { get; set; }
		public string Ext { get; set; }
	}

	class Member
	{
		public string Name { get; set; }
		public string Account { get; set; }
		public string PassWord { get; set; }
		public string Email { get; set; }
		public  Address Addr { get; set; }
		public string Cellphone { get; set; }
		public TelePhone Tel { get; set; }


		public void Register(string Name, string Account, string Password, string ConfirmPassword, string Email)
		{

		}

		public void ForgetPassword(string Name,string Email)
		{ 
			
		}

		public void Authenticate(string Account,string PassWord)
		{ 
			
		}
	}
}
