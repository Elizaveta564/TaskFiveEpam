﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFive.Interfaces
{
	public interface IDao
	{
		public interface IDao<T> where T : class
		{
			/// <summary>
			/// Creates object in DB
			/// </summary>
			/// <param name="item"></param>
			/// <returns></returns>
			int Create(T item);
			/// <summary>
			/// Update object in DB
			/// </summary>
			/// <param name="item"></param>
			void Update(T item);
			/// <summary>
			/// Delete object from the DB according to index
			/// </summary>
			/// <param name="id"></param>
			void Delete(int id);
			/// <summary>
			/// Get entity from the DB according to index
			/// </summary>
			/// <param name="id"></param>
			/// <returns></returns>
			T Get(int id);
			/// <summary>
			/// Gets all entites of the table from the DB
			/// </summary>
			/// <returns></returns>
			List<T> GetAll();
		}
	}
}
