using Microsoft.EntityFrameworkCore;
using System;

namespace Test_Entity_Framework
{
	public class MyDbContex : DbContext
	{
		protected MyDbContex() : base("DbConnectionString")
		{ 
		
		}
	}
}
